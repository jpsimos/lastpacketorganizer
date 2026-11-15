// Author Jacob A. Psimos

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace LastPacketOrganizer
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		const string defaultWindowTitle = "Last Packet Organizer - ";
		const string fileFilterBoth = "CAN log unique set|*.cus|CAN log linear list|*.cll";
		const string fileFilterHashSet = "CAN log unique set|*.cus";
		const string fileFilterList = "CAN log linear list|*.cll";

		private bool exitPending = false;
		private CANMessageContainer messageContainer = new CANMessageContainer();

		private void MainForm_Load(object sender, EventArgs e)
		{
			messageContainer = new CANMessageList();
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(DialogResult.OK == saveFileDialog.ShowDialog()){
				if (messageContainer.ExtendedType == typeof(CANMessageList))
				{
					messageContainer.Save(saveFileDialog.FileName);
				}
				else if (messageContainer.ExtendedType == typeof(CANMessageHashSet))
				{
					((CANMessageHashSet)messageContainer).Save(saveFileDialog.FileName);
				}
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(DialogResult.OK == openFileDialog.ShowDialog()){
				CANMessageContainer container = new CANMessageContainer();
				if (openFileDialog.FileName.EndsWith(".cll")){
					container = new CANMessageList(openFileDialog.FileName);
				}
				else if(openFileDialog.FileName.EndsWith(".cus")){
					container = new CANMessageHashSet(openFileDialog.FileName);
				}
				LoadMessageContainer(container);
				messageContainer = container;
				saveFileDialog.Filter = fileFilterBoth;
				this.Text = defaultWindowTitle + (new FileInfo(openFileDialog.FileName)).Name;
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CANMessageContainer container = new CANMessageContainer();
			LoadMessageContainer(container);
			messageContainer = container;
			saveFileDialog.Filter = fileFilterBoth;
			this.Text = defaultWindowTitle;
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveToolStripMenuItem_Click(sender, e);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(serialPortWorker.IsBusy){
				serialPortWorker.CancelAsync();
				exitPending = true;
			}else{
				if(serialPort.IsOpen){
					serialPort.Close();
				}
				this.Close();
			}
		}

		private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			canTable.DeselectAll();
		}

		private void clearHighlightsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			canTable.ClearHighlights();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void highlightMatchingCellsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == colorDialog.ShowDialog())
			{
				canTable.HighlightMatchingColValue(colorDialog.Color);
			}
		}

		private void complementToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == openFileDialog.ShowDialog())
			{
				uint numRemoved = 0;
				CANMessageContainer container = new CANMessageContainer();
				if (openFileDialog.FileName.EndsWith(".cll"))
				{
					container = new CANMessageList(openFileDialog.FileName);
				}
				else if (openFileDialog.FileName.EndsWith(".cus"))
				{
					container = new CANMessageHashSet(openFileDialog.FileName);
				}

				if (messageContainer.ExtendedType == typeof(CANMessageList))
				{
					numRemoved = ((CANMessageList)messageContainer).Complement((CANMessageList)container);
				}
				else if (messageContainer.ExtendedType == typeof(CANMessageHashSet))
				{
					numRemoved = ((CANMessageHashSet)messageContainer).Complement((CANMessageHashSet)container);
				}
				LoadMessageContainer(messageContainer);
				MessageBox.Show(string.Format("Removed {0} messages.", numRemoved));
			}
		}

		private void intersectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == openFileDialog.ShowDialog())
			{
				uint numRemoved = 0;
				CANMessageContainer container = new CANMessageContainer();
				if (openFileDialog.FileName.EndsWith(".cll"))
				{
					container = new CANMessageList(openFileDialog.FileName);
				}
				else if (openFileDialog.FileName.EndsWith(".cus"))
				{
					container = new CANMessageHashSet(openFileDialog.FileName);
				}

				if (messageContainer.ExtendedType == typeof(CANMessageList))
				{
					numRemoved = ((CANMessageList)messageContainer).Intersect((CANMessageList)container);
				}
				else if (messageContainer.ExtendedType == typeof(CANMessageHashSet))
				{
					numRemoved = ((CANMessageHashSet)messageContainer).Intersect((CANMessageHashSet)container);
				}
				LoadMessageContainer(messageContainer);
				MessageBox.Show(string.Format("Removed {0} messages.", numRemoved));
			}
		}

		private void lstIDs_SelectedValueChanged(object sender, EventArgs e)
		{
			if (!serialPortWorker.IsBusy)
			{
				canTable.Clear();
				List<CANMessage> allSelectedMsgs = new List<CANMessage>();
				foreach (string strMsgID in lstIDs.SelectedItems)
				{
					allSelectedMsgs.AddRange(messageContainer.GetList(strMsgID));
				}
				allSelectedMsgs.Sort();
				foreach (CANMessage msg in allSelectedMsgs)
				{
					canTable.Add(msg);
				}
			}
		}

		private void lstSerialPorts_Click(object sender, EventArgs e)
		{
			lstSerialPorts.Items.Clear();
			lstSerialPorts.Items.AddRange(SerialPort.GetPortNames());
		}

		private void btnOpenSerialPort_Click(object sender, EventArgs e)
		{
			if (lstSerialPorts.SelectedIndex > -1)
			{
				if (serialPort.IsOpen)
				{
					serialPort.Close();
				}
				serialPort.PortName = lstSerialPorts.SelectedItem.ToString();
				serialPort.Open();
				if (serialPort.IsOpen)
				{
					btnCloseSerialPort.Enabled = true;
					btnOpenSerialPort.Enabled = false;
					panelLogging.Enabled = true;
					btnStartLogging.Enabled = true;
					btnStopLogging.Enabled = false;
				}
			}
		}

		private void btnCloseSerialPort_Click(object sender, EventArgs e)
		{
			if(serialPort.IsOpen){
				serialPort.Close();
				if (!serialPort.IsOpen){
					btnOpenSerialPort.Enabled = true;
					btnCloseSerialPort.Enabled = false;
					panelLogging.Enabled = false;
					btnStartLogging.Enabled = true;
					btnStopLogging.Enabled = false;
				}
			}
		}

		private void btnStartLogging_Click(object sender, EventArgs e)
		{
			CANMessageContainer container;
			if (serialPort.IsOpen && !serialPortWorker.IsBusy){
				if (chkLinearList.Checked)
				{
					container = new CANMessageList();
					saveFileDialog.Filter = fileFilterList;
				}
				else
				{
					container = new CANMessageHashSet();
					saveFileDialog.Filter = fileFilterHashSet;
				}
				btnStartLogging.Enabled = false;
				btnStopLogging.Enabled = true;
				canTable.Clear();
				lstIDs.Items.Clear();
				serialPortWorker.RunWorkerAsync(container);
			}else if(!serialPort.IsOpen){
				btnOpenSerialPort.Enabled = true;
				btnCloseSerialPort.Enabled = false;
				btnStartLogging.Enabled = true;
				btnStopLogging.Enabled = false;
				panelLogging.Enabled = false;
			}
		}

		private void btnStopLogging_Click(object sender, EventArgs e)
		{
			serialPortWorker.CancelAsync();
		}

		private void serialPortWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			CANMessageContainer container = (CANMessageContainer)e.Argument;
			bool rowUpdateMethod = chkRowUpdates.Checked;
			bool hadError = false;
			if(serialPort.IsOpen){
				serialPort.WriteLine("l11");
			}
			while(!serialPortWorker.CancellationPending && serialPort.IsOpen){
				try
				{
					string line = serialPort.ReadLine();
					CANMessage receivedMsg = new CANMessage(line);
					if (container.ExtendedType == typeof(CANMessageList))
					{
						((CANMessageList)container).Add(receivedMsg);
					}
					else if (container.ExtendedType == typeof(CANMessageHashSet))
					{
						((CANMessageHashSet)container).Add(receivedMsg);
					}

					if (rowUpdateMethod)
					{
						this.Invoke((MethodInvoker)delegate
						{
							canTable.Update(receivedMsg);
						});
					}
				}catch(Exception serialException)
				{
					if(serialException is InvalidOperationException){
						//Reset GUI with a closed serial port.
						hadError = true;
					}
				}
				
			}
			if(serialPort.IsOpen){
				serialPort.WriteLine("l00");
			}
			e.Result = new object[] { hadError, container };
		}

		private void serialPortWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			bool hadError = (bool)((object[])e.Result)[0];
			CANMessageContainer container = (CANMessageContainer)((object[])e.Result)[1];
			if (exitPending)
			{
				serialPort.Close();
				this.Close();
			}
			else
			{
				if(hadError){
					//MessageBox.Show("There was an unexpected error.", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				btnStartLogging.Enabled = true;
				btnStopLogging.Enabled = false;
				if (!serialPort.IsOpen)
				{
					panelLogging.Enabled = false;
					btnOpenSerialPort.Enabled = true;
					btnCloseSerialPort.Enabled = false;
				}
				lstIDs.Items.Clear();
				LoadMessageContainer(container);
				messageContainer = container;
			}
		}

		private void LoadMessageContainer(CANMessageContainer container){
			canTable.Clear();
			lstIDs.Items.Clear();
			List<CANMessage> allMessages = new List<CANMessage>();
			foreach (string strMsgID in container.GetIDs()){
				lstIDs.Items.Add(strMsgID);
				List<CANMessage> listByID = container.GetList(strMsgID);
				allMessages.AddRange(listByID);
			}
			allMessages.Sort();
			foreach(CANMessage msg in allMessages){
				canTable.Add(msg);
			}
		}


    }
}
