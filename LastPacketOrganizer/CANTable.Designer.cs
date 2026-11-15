namespace LastPacketOrganizer
{
	partial class CANTable
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataTable = new System.Windows.Forms.DataGridView();
			this.colTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// dataTable
			// 
			this.dataTable.AllowUserToAddRows = false;
			this.dataTable.AllowUserToDeleteRows = false;
			this.dataTable.AllowUserToResizeRows = false;
			this.dataTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTimeStamp,
            this.colID,
            this.colData,
            this.colLength,
            this.colBus});
			this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataTable.Location = new System.Drawing.Point(0, 0);
			this.dataTable.Name = "dataTable";
			this.dataTable.ReadOnly = true;
			this.dataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataTable.ShowEditingIcon = false;
			this.dataTable.Size = new System.Drawing.Size(736, 406);
			this.dataTable.TabIndex = 1;
			// 
			// colTimeStamp
			// 
			this.colTimeStamp.HeaderText = "Timestamp";
			this.colTimeStamp.Name = "colTimeStamp";
			this.colTimeStamp.ReadOnly = true;
			this.colTimeStamp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.colTimeStamp.Width = 115;
			// 
			// colID
			// 
			this.colID.HeaderText = "ID";
			this.colID.Name = "colID";
			this.colID.ReadOnly = true;
			this.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// colData
			// 
			this.colData.HeaderText = "Data";
			this.colData.Name = "colData";
			this.colData.ReadOnly = true;
			this.colData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.colData.Width = 220;
			// 
			// colLength
			// 
			this.colLength.HeaderText = "Length";
			this.colLength.Name = "colLength";
			this.colLength.ReadOnly = true;
			this.colLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.colLength.Width = 50;
			// 
			// colBus
			// 
			this.colBus.HeaderText = "Bus";
			this.colBus.Name = "colBus";
			this.colBus.ReadOnly = true;
			this.colBus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.colBus.Width = 50;
			// 
			// CANTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataTable);
			this.Name = "CANTable";
			this.Size = new System.Drawing.Size(736, 406);
			((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataTable;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTimeStamp;
		private System.Windows.Forms.DataGridViewTextBoxColumn colID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colData;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLength;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBus;
	}
}
