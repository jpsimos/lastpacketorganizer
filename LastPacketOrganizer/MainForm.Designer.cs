namespace LastPacketOrganizer
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHighlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highlightMatchingCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intersectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.canTable = new LastPacketOrganizer.CANTable();
            this.lstIDs = new System.Windows.Forms.ListBox();
            this.panelSerialPort = new System.Windows.Forms.GroupBox();
            this.panelLogging = new System.Windows.Forms.Panel();
            this.chkRowUpdates = new System.Windows.Forms.CheckBox();
            this.btnStopLogging = new System.Windows.Forms.Button();
            this.chkLinearList = new System.Windows.Forms.RadioButton();
            this.chkUniqueSet = new System.Windows.Forms.RadioButton();
            this.btnStartLogging = new System.Windows.Forms.Button();
            this.btnCloseSerialPort = new System.Windows.Forms.Button();
            this.btnOpenSerialPort = new System.Windows.Forms.Button();
            this.lstSerialPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.serialPortWorker = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.mainMenuStrip.SuspendLayout();
            this.mainTableLayout.SuspendLayout();
            this.panelSerialPort.SuspendLayout();
            this.panelLogging.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1113, 24);
            this.mainMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deselectAllToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deselectAllToolStripMenuItem.Text = "Deselect All";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHighlightsToolStripMenuItem,
            this.highlightMatchingCellsToolStripMenuItem,
            this.filteringToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // clearHighlightsToolStripMenuItem
            // 
            this.clearHighlightsToolStripMenuItem.Name = "clearHighlightsToolStripMenuItem";
            this.clearHighlightsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.clearHighlightsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.clearHighlightsToolStripMenuItem.Text = "Clear Highlights";
            this.clearHighlightsToolStripMenuItem.Click += new System.EventHandler(this.clearHighlightsToolStripMenuItem_Click);
            // 
            // highlightMatchingCellsToolStripMenuItem
            // 
            this.highlightMatchingCellsToolStripMenuItem.Name = "highlightMatchingCellsToolStripMenuItem";
            this.highlightMatchingCellsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.highlightMatchingCellsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.highlightMatchingCellsToolStripMenuItem.Text = "Highlight Matching Cells";
            this.highlightMatchingCellsToolStripMenuItem.Click += new System.EventHandler(this.highlightMatchingCellsToolStripMenuItem_Click);
            // 
            // filteringToolStripMenuItem
            // 
            this.filteringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.complementToolStripMenuItem,
            this.intersectToolStripMenuItem});
            this.filteringToolStripMenuItem.Name = "filteringToolStripMenuItem";
            this.filteringToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.filteringToolStripMenuItem.Text = "Filtering";
            // 
            // complementToolStripMenuItem
            // 
            this.complementToolStripMenuItem.Name = "complementToolStripMenuItem";
            this.complementToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.complementToolStripMenuItem.Text = "Complement";
            this.complementToolStripMenuItem.Click += new System.EventHandler(this.complementToolStripMenuItem_Click);
            // 
            // intersectToolStripMenuItem
            // 
            this.intersectToolStripMenuItem.Name = "intersectToolStripMenuItem";
            this.intersectToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.intersectToolStripMenuItem.Text = "Intersect";
            this.intersectToolStripMenuItem.Click += new System.EventHandler(this.intersectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 535);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1113, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 3;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainTableLayout.Controls.Add(this.canTable, 1, 0);
            this.mainTableLayout.Controls.Add(this.lstIDs, 0, 0);
            this.mainTableLayout.Controls.Add(this.panelSerialPort, 2, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.Size = new System.Drawing.Size(1113, 511);
            this.mainTableLayout.TabIndex = 2;
            // 
            // canTable
            // 
            this.canTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canTable.Location = new System.Drawing.Point(153, 3);
            this.canTable.Name = "canTable";
            this.canTable.Size = new System.Drawing.Size(757, 505);
            this.canTable.TabIndex = 2;
            // 
            // lstIDs
            // 
            this.lstIDs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstIDs.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIDs.FormattingEnabled = true;
            this.lstIDs.ItemHeight = 16;
            this.lstIDs.Location = new System.Drawing.Point(3, 3);
            this.lstIDs.Name = "lstIDs";
            this.lstIDs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstIDs.Size = new System.Drawing.Size(144, 505);
            this.lstIDs.Sorted = true;
            this.lstIDs.TabIndex = 1;
            this.lstIDs.SelectedValueChanged += new System.EventHandler(this.lstIDs_SelectedValueChanged);
            // 
            // panelSerialPort
            // 
            this.panelSerialPort.Controls.Add(this.panelLogging);
            this.panelSerialPort.Controls.Add(this.btnCloseSerialPort);
            this.panelSerialPort.Controls.Add(this.btnOpenSerialPort);
            this.panelSerialPort.Controls.Add(this.lstSerialPorts);
            this.panelSerialPort.Controls.Add(this.label1);
            this.panelSerialPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSerialPort.Location = new System.Drawing.Point(916, 3);
            this.panelSerialPort.Name = "panelSerialPort";
            this.panelSerialPort.Size = new System.Drawing.Size(194, 505);
            this.panelSerialPort.TabIndex = 3;
            this.panelSerialPort.TabStop = false;
            this.panelSerialPort.Text = "Serial";
            // 
            // panelLogging
            // 
            this.panelLogging.Controls.Add(this.chkRowUpdates);
            this.panelLogging.Controls.Add(this.btnStopLogging);
            this.panelLogging.Controls.Add(this.chkLinearList);
            this.panelLogging.Controls.Add(this.chkUniqueSet);
            this.panelLogging.Controls.Add(this.btnStartLogging);
            this.panelLogging.Enabled = false;
            this.panelLogging.Location = new System.Drawing.Point(10, 73);
            this.panelLogging.Name = "panelLogging";
            this.panelLogging.Size = new System.Drawing.Size(175, 89);
            this.panelLogging.TabIndex = 4;
            // 
            // chkRowUpdates
            // 
            this.chkRowUpdates.AutoSize = true;
            this.chkRowUpdates.Location = new System.Drawing.Point(6, 35);
            this.chkRowUpdates.Name = "chkRowUpdates";
            this.chkRowUpdates.Size = new System.Drawing.Size(91, 17);
            this.chkRowUpdates.TabIndex = 4;
            this.chkRowUpdates.Text = "Row Updates";
            this.chkRowUpdates.UseVisualStyleBackColor = true;
            // 
            // btnStopLogging
            // 
            this.btnStopLogging.Enabled = false;
            this.btnStopLogging.Location = new System.Drawing.Point(85, 58);
            this.btnStopLogging.Name = "btnStopLogging";
            this.btnStopLogging.Size = new System.Drawing.Size(78, 23);
            this.btnStopLogging.TabIndex = 3;
            this.btnStopLogging.Text = "Stop";
            this.btnStopLogging.UseVisualStyleBackColor = true;
            this.btnStopLogging.Click += new System.EventHandler(this.btnStopLogging_Click);
            // 
            // chkLinearList
            // 
            this.chkLinearList.AutoSize = true;
            this.chkLinearList.Checked = true;
            this.chkLinearList.Location = new System.Drawing.Point(6, 12);
            this.chkLinearList.Name = "chkLinearList";
            this.chkLinearList.Size = new System.Drawing.Size(73, 17);
            this.chkLinearList.TabIndex = 2;
            this.chkLinearList.TabStop = true;
            this.chkLinearList.Text = "Linear List";
            this.chkLinearList.UseVisualStyleBackColor = true;
            // 
            // chkUniqueSet
            // 
            this.chkUniqueSet.AutoSize = true;
            this.chkUniqueSet.Location = new System.Drawing.Point(85, 12);
            this.chkUniqueSet.Name = "chkUniqueSet";
            this.chkUniqueSet.Size = new System.Drawing.Size(78, 17);
            this.chkUniqueSet.TabIndex = 1;
            this.chkUniqueSet.Text = "Unique Set";
            this.chkUniqueSet.UseVisualStyleBackColor = true;
            // 
            // btnStartLogging
            // 
            this.btnStartLogging.Location = new System.Drawing.Point(6, 58);
            this.btnStartLogging.Name = "btnStartLogging";
            this.btnStartLogging.Size = new System.Drawing.Size(78, 23);
            this.btnStartLogging.TabIndex = 0;
            this.btnStartLogging.Text = "Start";
            this.btnStartLogging.UseVisualStyleBackColor = true;
            this.btnStartLogging.Click += new System.EventHandler(this.btnStartLogging_Click);
            // 
            // btnCloseSerialPort
            // 
            this.btnCloseSerialPort.Enabled = false;
            this.btnCloseSerialPort.Location = new System.Drawing.Point(128, 44);
            this.btnCloseSerialPort.Name = "btnCloseSerialPort";
            this.btnCloseSerialPort.Size = new System.Drawing.Size(57, 23);
            this.btnCloseSerialPort.TabIndex = 3;
            this.btnCloseSerialPort.Text = "Close";
            this.btnCloseSerialPort.UseVisualStyleBackColor = true;
            this.btnCloseSerialPort.Click += new System.EventHandler(this.btnCloseSerialPort_Click);
            // 
            // btnOpenSerialPort
            // 
            this.btnOpenSerialPort.Location = new System.Drawing.Point(42, 44);
            this.btnOpenSerialPort.Name = "btnOpenSerialPort";
            this.btnOpenSerialPort.Size = new System.Drawing.Size(57, 23);
            this.btnOpenSerialPort.TabIndex = 2;
            this.btnOpenSerialPort.Text = "Open";
            this.btnOpenSerialPort.UseVisualStyleBackColor = true;
            this.btnOpenSerialPort.Click += new System.EventHandler(this.btnOpenSerialPort_Click);
            // 
            // lstSerialPorts
            // 
            this.lstSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSerialPorts.FormattingEnabled = true;
            this.lstSerialPorts.Location = new System.Drawing.Point(42, 17);
            this.lstSerialPorts.Name = "lstSerialPorts";
            this.lstSerialPorts.Size = new System.Drawing.Size(143, 21);
            this.lstSerialPorts.TabIndex = 1;
            this.lstSerialPorts.Click += new System.EventHandler(this.lstSerialPorts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DtrEnable = true;
            this.serialPort.ReadTimeout = 400;
            this.serialPort.WriteTimeout = 100;
            // 
            // serialPortWorker
            // 
            this.serialPortWorker.WorkerSupportsCancellation = true;
            this.serialPortWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.serialPortWorker_DoWork);
            this.serialPortWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.serialPortWorker_RunWorkerCompleted);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "CAN log unique set|*.cus|CAN log linear list|*.cll";
            this.saveFileDialog.Title = "Save CAN Log";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "CAN log unique set|*.cus|CAN log linear list|*.cll";
            this.openFileDialog.Title = "Open CAN Log";
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 557);
            this.Controls.Add(this.mainTableLayout);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Last Packet Organizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainTableLayout.ResumeLayout(false);
            this.panelSerialPort.ResumeLayout(false);
            this.panelSerialPort.PerformLayout();
            this.panelLogging.ResumeLayout(false);
            this.panelLogging.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.TableLayoutPanel mainTableLayout;
		private System.Windows.Forms.ListBox lstIDs;
		private CANTable canTable;
		private System.IO.Ports.SerialPort serialPort;
		private System.Windows.Forms.GroupBox panelSerialPort;
		private System.Windows.Forms.Button btnCloseSerialPort;
		private System.Windows.Forms.Button btnOpenSerialPort;
		private System.Windows.Forms.ComboBox lstSerialPorts;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.BackgroundWorker serialPortWorker;
		private System.Windows.Forms.Panel panelLogging;
		private System.Windows.Forms.Button btnStopLogging;
		private System.Windows.Forms.RadioButton chkLinearList;
		private System.Windows.Forms.RadioButton chkUniqueSet;
		private System.Windows.Forms.Button btnStartLogging;
		private System.Windows.Forms.CheckBox chkRowUpdates;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.ToolStripMenuItem clearHighlightsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem highlightMatchingCellsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem filteringToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem complementToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem intersectToolStripMenuItem;
	}
}

