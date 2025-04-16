namespace CSEmployeeAttendance25
{
    partial class FormImportAttendanceLog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageRawLogs = new System.Windows.Forms.TabPage();
            this.dgvBiometricLogs = new System.Windows.Forms.DataGridView();
            this.dgcRawLogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawBMEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawPunchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawRowType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageBatchHistory = new System.Windows.Forms.TabPage();
            this.dgvBatchHistory = new System.Windows.Forms.DataGridView();
            this.labelBatchCode = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonImportData = new System.Windows.Forms.Button();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgcHistoryBatchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHistoryStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHistoryEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHistoryBatchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcBatchInOutStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHistoryViewDetails = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dgcHistoryDeleteDetails = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageRawLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiometricLogs)).BeginInit();
            this.tabPageBatchHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.tabControlMain);
            this.panel1.Controls.Add(this.labelBatchCode);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.buttonImportData);
            this.panel1.Controls.Add(this.buttonBrowseFile);
            this.panel1.Controls.Add(this.textBoxFileName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 519);
            this.panel1.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageRawLogs);
            this.tabControlMain.Controls.Add(this.tabPageBatchHistory);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlMain.Location = new System.Drawing.Point(0, 83);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(834, 436);
            this.tabControlMain.TabIndex = 37;
            // 
            // tabPageRawLogs
            // 
            this.tabPageRawLogs.Controls.Add(this.dgvBiometricLogs);
            this.tabPageRawLogs.Location = new System.Drawing.Point(4, 27);
            this.tabPageRawLogs.Name = "tabPageRawLogs";
            this.tabPageRawLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRawLogs.Size = new System.Drawing.Size(826, 405);
            this.tabPageRawLogs.TabIndex = 0;
            this.tabPageRawLogs.Text = "#Raw Log Data     ";
            this.tabPageRawLogs.UseVisualStyleBackColor = true;
            // 
            // dgvBiometricLogs
            // 
            this.dgvBiometricLogs.AllowUserToAddRows = false;
            this.dgvBiometricLogs.AllowUserToDeleteRows = false;
            this.dgvBiometricLogs.AllowUserToResizeColumns = false;
            this.dgvBiometricLogs.AllowUserToResizeRows = false;
            this.dgvBiometricLogs.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvBiometricLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiometricLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcRawLogId,
            this.dgcRawEmployeeId,
            this.dgcRawEmployeeCode,
            this.dgcRawEmployeeName,
            this.dgcRawBMEmployeeId,
            this.dgcRawPunchTime,
            this.dgcRawRowType});
            this.dgvBiometricLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBiometricLogs.Location = new System.Drawing.Point(3, 3);
            this.dgvBiometricLogs.Name = "dgvBiometricLogs";
            this.dgvBiometricLogs.ReadOnly = true;
            this.dgvBiometricLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBiometricLogs.Size = new System.Drawing.Size(820, 399);
            this.dgvBiometricLogs.TabIndex = 0;
            // 
            // dgcRawLogId
            // 
            this.dgcRawLogId.HeaderText = "LogId";
            this.dgcRawLogId.Name = "dgcRawLogId";
            this.dgcRawLogId.ReadOnly = true;
            this.dgcRawLogId.Visible = false;
            // 
            // dgcRawEmployeeId
            // 
            this.dgcRawEmployeeId.DataPropertyName = "EmployeeId";
            this.dgcRawEmployeeId.HeaderText = "Employee Id";
            this.dgcRawEmployeeId.Name = "dgcRawEmployeeId";
            this.dgcRawEmployeeId.ReadOnly = true;
            this.dgcRawEmployeeId.Visible = false;
            // 
            // dgcRawEmployeeCode
            // 
            this.dgcRawEmployeeCode.DataPropertyName = "EmployeeCode";
            this.dgcRawEmployeeCode.HeaderText = "Emp Code";
            this.dgcRawEmployeeCode.Name = "dgcRawEmployeeCode";
            this.dgcRawEmployeeCode.ReadOnly = true;
            this.dgcRawEmployeeCode.Width = 90;
            // 
            // dgcRawEmployeeName
            // 
            this.dgcRawEmployeeName.DataPropertyName = "EmployeeName";
            this.dgcRawEmployeeName.HeaderText = "Employee Name";
            this.dgcRawEmployeeName.Name = "dgcRawEmployeeName";
            this.dgcRawEmployeeName.ReadOnly = true;
            this.dgcRawEmployeeName.Width = 250;
            // 
            // dgcRawBMEmployeeId
            // 
            this.dgcRawBMEmployeeId.DataPropertyName = "BMEmployeeId";
            this.dgcRawBMEmployeeId.HeaderText = "BM Emp Id";
            this.dgcRawBMEmployeeId.Name = "dgcRawBMEmployeeId";
            this.dgcRawBMEmployeeId.ReadOnly = true;
            this.dgcRawBMEmployeeId.Width = 90;
            // 
            // dgcRawPunchTime
            // 
            this.dgcRawPunchTime.DataPropertyName = "PunchTime";
            this.dgcRawPunchTime.HeaderText = "Punch Time";
            this.dgcRawPunchTime.Name = "dgcRawPunchTime";
            this.dgcRawPunchTime.ReadOnly = true;
            this.dgcRawPunchTime.Width = 150;
            // 
            // dgcRawRowType
            // 
            this.dgcRawRowType.DataPropertyName = "RecordType";
            this.dgcRawRowType.HeaderText = "R.Type";
            this.dgcRawRowType.Name = "dgcRawRowType";
            this.dgcRawRowType.ReadOnly = true;
            // 
            // tabPageBatchHistory
            // 
            this.tabPageBatchHistory.Controls.Add(this.dgvBatchHistory);
            this.tabPageBatchHistory.Location = new System.Drawing.Point(4, 27);
            this.tabPageBatchHistory.Name = "tabPageBatchHistory";
            this.tabPageBatchHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBatchHistory.Size = new System.Drawing.Size(826, 405);
            this.tabPageBatchHistory.TabIndex = 1;
            this.tabPageBatchHistory.Text = "#Batch History     ";
            this.tabPageBatchHistory.UseVisualStyleBackColor = true;
            // 
            // dgvBatchHistory
            // 
            this.dgvBatchHistory.AllowUserToAddRows = false;
            this.dgvBatchHistory.AllowUserToDeleteRows = false;
            this.dgvBatchHistory.AllowUserToResizeColumns = false;
            this.dgvBatchHistory.AllowUserToResizeRows = false;
            this.dgvBatchHistory.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvBatchHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcHistoryBatchCode,
            this.dgcHistoryStartDate,
            this.dgcHistoryEndDate,
            this.dgcHistoryBatchName,
            this.dgcBatchInOutStatus,
            this.dgcHistoryViewDetails,
            this.dgcHistoryDeleteDetails});
            this.dgvBatchHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBatchHistory.Location = new System.Drawing.Point(3, 3);
            this.dgvBatchHistory.Name = "dgvBatchHistory";
            this.dgvBatchHistory.ReadOnly = true;
            this.dgvBatchHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBatchHistory.Size = new System.Drawing.Size(820, 399);
            this.dgvBatchHistory.TabIndex = 1;
            this.dgvBatchHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatchHistory_CellContentClick);
            // 
            // labelBatchCode
            // 
            this.labelBatchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBatchCode.Location = new System.Drawing.Point(574, 17);
            this.labelBatchCode.Name = "labelBatchCode";
            this.labelBatchCode.Size = new System.Drawing.Size(237, 54);
            this.labelBatchCode.TabIndex = 36;
            this.labelBatchCode.Text = "Batch Code\r\nxxxxxxxxxxxx";
            this.labelBatchCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(304, 50);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(123, 24);
            this.dtpEndDate.TabIndex = 35;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            //this.dtpStartDate.MaxDate = Data.MicrosoftTools.SetActive;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(131, 50);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(123, 24);
            this.dtpStartDate.TabIndex = 34;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Start Date";
            // 
            // buttonImportData
            // 
            this.buttonImportData.Location = new System.Drawing.Point(443, 48);
            this.buttonImportData.Name = "buttonImportData";
            this.buttonImportData.Size = new System.Drawing.Size(113, 29);
            this.buttonImportData.TabIndex = 6;
            this.buttonImportData.Text = "Import";
            this.buttonImportData.UseVisualStyleBackColor = true;
            this.buttonImportData.Click += new System.EventHandler(this.buttonImportData_Click);
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(481, 12);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(75, 29);
            this.buttonBrowseFile.TabIndex = 5;
            this.buttonBrowseFile.Text = "Browse";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Enabled = false;
            this.textBoxFileName.Location = new System.Drawing.Point(131, 14);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(344, 24);
            this.textBoxFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(834, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Import Attendance Log";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(947, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 40;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(799, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 42;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgcHistoryBatchCode
            // 
            this.dgcHistoryBatchCode.DataPropertyName = "BatchCode";
            this.dgcHistoryBatchCode.HeaderText = "Batch Code";
            this.dgcHistoryBatchCode.Name = "dgcHistoryBatchCode";
            this.dgcHistoryBatchCode.ReadOnly = true;
            this.dgcHistoryBatchCode.Visible = false;
            this.dgcHistoryBatchCode.Width = 200;
            // 
            // dgcHistoryStartDate
            // 
            this.dgcHistoryStartDate.DataPropertyName = "StartDate";
            this.dgcHistoryStartDate.HeaderText = "Start Date";
            this.dgcHistoryStartDate.Name = "dgcHistoryStartDate";
            this.dgcHistoryStartDate.ReadOnly = true;
            this.dgcHistoryStartDate.Visible = false;
            this.dgcHistoryStartDate.Width = 120;
            // 
            // dgcHistoryEndDate
            // 
            this.dgcHistoryEndDate.DataPropertyName = "EndDate";
            this.dgcHistoryEndDate.HeaderText = "End Date";
            this.dgcHistoryEndDate.Name = "dgcHistoryEndDate";
            this.dgcHistoryEndDate.ReadOnly = true;
            this.dgcHistoryEndDate.Visible = false;
            this.dgcHistoryEndDate.Width = 120;
            // 
            // dgcHistoryBatchName
            // 
            this.dgcHistoryBatchName.DataPropertyName = "BatchName";
            this.dgcHistoryBatchName.HeaderText = "Batch Details";
            this.dgcHistoryBatchName.Name = "dgcHistoryBatchName";
            this.dgcHistoryBatchName.ReadOnly = true;
            this.dgcHistoryBatchName.Width = 360;
            // 
            // dgcBatchInOutStatus
            // 
            this.dgcBatchInOutStatus.DataPropertyName = "Status";
            this.dgcBatchInOutStatus.HeaderText = "Status";
            this.dgcBatchInOutStatus.Name = "dgcBatchInOutStatus";
            this.dgcBatchInOutStatus.ReadOnly = true;
            this.dgcBatchInOutStatus.Width = 160;
            // 
            // dgcHistoryViewDetails
            // 
            this.dgcHistoryViewDetails.HeaderText = "View";
            this.dgcHistoryViewDetails.Name = "dgcHistoryViewDetails";
            this.dgcHistoryViewDetails.ReadOnly = true;
            this.dgcHistoryViewDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcHistoryViewDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcHistoryViewDetails.Text = "View";
            this.dgcHistoryViewDetails.UseColumnTextForLinkValue = true;
            // 
            // dgcHistoryDeleteDetails
            // 
            this.dgcHistoryDeleteDetails.HeaderText = "Delete";
            this.dgcHistoryDeleteDetails.Name = "dgcHistoryDeleteDetails";
            this.dgcHistoryDeleteDetails.ReadOnly = true;
            this.dgcHistoryDeleteDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcHistoryDeleteDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcHistoryDeleteDetails.Text = "Delete";
            this.dgcHistoryDeleteDetails.UseColumnTextForLinkValue = true;
            this.dgcHistoryDeleteDetails.Visible = false;
            // 
            // FormImportAttendanceLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportAttendanceLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageRawLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiometricLogs)).EndInit();
            this.tabPageBatchHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonImportData;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageRawLogs;
        private System.Windows.Forms.TabPage tabPageBatchHistory;
        private System.Windows.Forms.Label labelBatchCode;
        private System.Windows.Forms.DataGridView dgvBiometricLogs;
        private System.Windows.Forms.DataGridView dgvBatchHistory;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawLogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawBMEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawPunchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawRowType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHistoryBatchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHistoryStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHistoryEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHistoryBatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBatchInOutStatus;
        private System.Windows.Forms.DataGridViewLinkColumn dgcHistoryViewDetails;
        private System.Windows.Forms.DataGridViewLinkColumn dgcHistoryDeleteDetails;
    }
}

