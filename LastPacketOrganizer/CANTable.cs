// Author Jacob A. Psimos

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LastPacketOrganizer
{
	public partial class CANTable : UserControl
	{

		private Dictionary<string, int> uniqueRowMap = new Dictionary<string, int>();

		public CANTable()
		{
			InitializeComponent();
			dataTable.GetType().GetProperty("DoubleBuffered",
				System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(dataTable, true, null);
		}

		public void Clear(){
			dataTable.Rows.Clear();
			uniqueRowMap.Clear();
		}


		public void Add(CANMessage msg){
			string strMsgID = msg.ID.ToString(msg.Extended ? "X8" : "X3");
			int rowIndex = dataTable.Rows.Add(new object[]{
				msg.Timestamp.ToString("hh:mm:ss:fff"),
				strMsgID,
				Utilities.ByteArrayToString(msg.Data),
				msg.Length.ToString(),
				msg.BusID.ToString()
			});
			//dataTable.Sort(dataTable.Columns[1], ListSortDirection.Ascending);
			if(!uniqueRowMap.ContainsKey(strMsgID)){
				uniqueRowMap.Add(strMsgID, rowIndex);
			}else{
				uniqueRowMap[strMsgID] = rowIndex;
			}
		}

		public bool Update(CANMessage msg){
			string strMsgID = msg.ID.ToString(msg.Extended ? "X8" : "X3");
			if (uniqueRowMap.ContainsKey(strMsgID)){
				DataGridViewRow row = dataTable.Rows[uniqueRowMap[strMsgID]];
				row.Cells[0].Value = msg.Timestamp.ToString("hh:mm:ss:fff");
				//row.Cells[1].Value = msg.ID.ToString(msg.Extended ? "X8" : "X3");
				row.Cells[2].Value = Utilities.ByteArrayToString(msg.Data);
				row.Cells[3].Value = msg.Length.ToString();
				row.Cells[4].Value = msg.BusID.ToString();
				return true;
			}else{
				Add(msg);
			}
			return false;
		}

		public void HighlightMatchingColValue(Color c){
			foreach(DataGridViewCell cell in dataTable.SelectedCells){
				string expectedValue = cell.Value.ToString();
				foreach (DataGridViewRow row in dataTable.Rows)
				{
					if (row.Cells[cell.ColumnIndex].Value.ToString() == expectedValue)
					{
						row.Cells[cell.ColumnIndex].Style.BackColor = c;
					}
				}
			}
		}

		public void ClearHighlights(){
			foreach (DataGridViewRow row in dataTable.Rows)
			{
				row.DefaultCellStyle.BackColor = Color.White;
			}
		}

		public void DeselectAll(){
			dataTable.ClearSelection();
		}


	}
}
