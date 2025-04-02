namespace CSEmployeeAttendance25
{
    partial class FormManageMissingLog
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
            this.comboBoxBatchCode = new System.Windows.Forms.ComboBox();
            this.buttonApplyInOut = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageAllRecords = new System.Windows.Forms.TabPage();
            this.dgvBiometricLogs = new System.Windows.Forms.DataGridView();
            this.dgcRawLogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawBMEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawPunchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawRowType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageOneEntry = new System.Windows.Forms.TabPage();
            this.dgvOneEntry = new System.Windows.Forms.DataGridView();
            this.dgcOneLogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcOneEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcOneEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcOneBMEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPunchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcOneRecordType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcOneAddLog = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPageDuplicateEntry = new System.Windows.Forms.TabPage();
            this.dgvTwoPlusEntry = new System.Windows.Forms.DataGridView();
            this.dgcTwoLogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTwoEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTwoEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTwoEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTwoBMEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTwoPunchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTwoRecordType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTwoDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonDeleteLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAutoDeleteDuplicates = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageAllRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiometricLogs)).BeginInit();
            this.tabPageOneEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOneEntry)).BeginInit();
            this.tabPageDuplicateEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTwoPlusEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.buttonAutoDeleteDuplicates);
            this.panel1.Controls.Add(this.comboBoxBatchCode);
            this.panel1.Controls.Add(this.buttonApplyInOut);
            this.panel1.Controls.Add(this.tabControlMain);
            this.panel1.Controls.Add(this.buttonLoadData);
            this.panel1.Controls.Add(this.buttonDeleteLog);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 519);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxBatchCode
            // 
            this.comboBoxBatchCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBatchCode.FormattingEnabled = true;
            this.comboBoxBatchCode.Location = new System.Drawing.Point(131, 14);
            this.comboBoxBatchCode.Name = "comboBoxBatchCode";
            this.comboBoxBatchCode.Size = new System.Drawing.Size(391, 26);
            this.comboBoxBatchCode.TabIndex = 40;
            // 
            // buttonApplyInOut
            // 
            this.buttonApplyInOut.Enabled = false;
            this.buttonApplyInOut.Location = new System.Drawing.Point(647, 12);
            this.buttonApplyInOut.Name = "buttonApplyInOut";
            this.buttonApplyInOut.Size = new System.Drawing.Size(113, 29);
            this.buttonApplyInOut.TabIndex = 38;
            this.buttonApplyInOut.Text = "Apply In/Out";
            this.buttonApplyInOut.UseVisualStyleBackColor = true;
            this.buttonApplyInOut.Click += new System.EventHandler(this.buttonApplyInOut_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageAllRecords);
            this.tabControlMain.Controls.Add(this.tabPageOneEntry);
            this.tabControlMain.Controls.Add(this.tabPageDuplicateEntry);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlMain.Location = new System.Drawing.Point(0, 47);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(984, 472);
            this.tabControlMain.TabIndex = 37;
            // 
            // tabPageAllRecords
            // 
            this.tabPageAllRecords.Controls.Add(this.dgvBiometricLogs);
            this.tabPageAllRecords.Location = new System.Drawing.Point(4, 27);
            this.tabPageAllRecords.Name = "tabPageAllRecords";
            this.tabPageAllRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllRecords.Size = new System.Drawing.Size(976, 441);
            this.tabPageAllRecords.TabIndex = 0;
            this.tabPageAllRecords.Text = "#All Records     ";
            this.tabPageAllRecords.UseVisualStyleBackColor = true;
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
            this.dgvBiometricLogs.Size = new System.Drawing.Size(970, 435);
            this.dgvBiometricLogs.TabIndex = 0;
            // 
            // dgcRawLogId
            // 
            this.dgcRawLogId.DataPropertyName = "LogId";
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
            // tabPageOneEntry
            // 
            this.tabPageOneEntry.Controls.Add(this.dgvOneEntry);
            this.tabPageOneEntry.Location = new System.Drawing.Point(4, 27);
            this.tabPageOneEntry.Name = "tabPageOneEntry";
            this.tabPageOneEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOneEntry.Size = new System.Drawing.Size(976, 441);
            this.tabPageOneEntry.TabIndex = 1;
            this.tabPageOneEntry.Text = "#One Entry     ";
            this.tabPageOneEntry.UseVisualStyleBackColor = true;
            // 
            // dgvOneEntry
            // 
            this.dgvOneEntry.AllowUserToAddRows = false;
            this.dgvOneEntry.AllowUserToDeleteRows = false;
            this.dgvOneEntry.AllowUserToResizeColumns = false;
            this.dgvOneEntry.AllowUserToResizeRows = false;
            this.dgvOneEntry.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvOneEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOneEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcOneLogId,
            this.dgcOneEmployeeId,
            this.dgcEmployeeCode,
            this.dgcOneEmployeeName,
            this.dgcOneBMEmployeeId,
            this.dgcPunchTime,
            this.dgcOneRecordType,
            this.dgcOneAddLog});
            this.dgvOneEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOneEntry.Location = new System.Drawing.Point(3, 3);
            this.dgvOneEntry.Name = "dgvOneEntry";
            this.dgvOneEntry.ReadOnly = true;
            this.dgvOneEntry.Size = new System.Drawing.Size(970, 435);
            this.dgvOneEntry.TabIndex = 1;
            this.dgvOneEntry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOneEntry_CellContentClick);
            // 
            // dgcOneLogId
            // 
            this.dgcOneLogId.DataPropertyName = "LogId";
            this.dgcOneLogId.HeaderText = "LogId";
            this.dgcOneLogId.Name = "dgcOneLogId";
            this.dgcOneLogId.ReadOnly = true;
            this.dgcOneLogId.Visible = false;
            // 
            // dgcOneEmployeeId
            // 
            this.dgcOneEmployeeId.DataPropertyName = "EmployeeId";
            this.dgcOneEmployeeId.HeaderText = "Employee Id";
            this.dgcOneEmployeeId.Name = "dgcOneEmployeeId";
            this.dgcOneEmployeeId.ReadOnly = true;
            this.dgcOneEmployeeId.Visible = false;
            // 
            // dgcEmployeeCode
            // 
            this.dgcEmployeeCode.DataPropertyName = "EmployeeCode";
            this.dgcEmployeeCode.HeaderText = "Emp Code";
            this.dgcEmployeeCode.Name = "dgcEmployeeCode";
            this.dgcEmployeeCode.ReadOnly = true;
            this.dgcEmployeeCode.Width = 90;
            // 
            // dgcOneEmployeeName
            // 
            this.dgcOneEmployeeName.DataPropertyName = "EmployeeName";
            this.dgcOneEmployeeName.HeaderText = "Employee Name";
            this.dgcOneEmployeeName.Name = "dgcOneEmployeeName";
            this.dgcOneEmployeeName.ReadOnly = true;
            this.dgcOneEmployeeName.Width = 250;
            // 
            // dgcOneBMEmployeeId
            // 
            this.dgcOneBMEmployeeId.DataPropertyName = "BMEmployeeId";
            this.dgcOneBMEmployeeId.HeaderText = "BM Emp Id";
            this.dgcOneBMEmployeeId.Name = "dgcOneBMEmployeeId";
            this.dgcOneBMEmployeeId.ReadOnly = true;
            this.dgcOneBMEmployeeId.Width = 90;
            // 
            // dgcPunchTime
            // 
            this.dgcPunchTime.DataPropertyName = "PunchTime";
            this.dgcPunchTime.HeaderText = "Punch Time";
            this.dgcPunchTime.Name = "dgcPunchTime";
            this.dgcPunchTime.ReadOnly = true;
            this.dgcPunchTime.Width = 150;
            // 
            // dgcOneRecordType
            // 
            this.dgcOneRecordType.DataPropertyName = "RecordType";
            this.dgcOneRecordType.HeaderText = "R.Type";
            this.dgcOneRecordType.Name = "dgcOneRecordType";
            this.dgcOneRecordType.ReadOnly = true;
            // 
            // dgcOneAddLog
            // 
            this.dgcOneAddLog.HeaderText = "Add";
            this.dgcOneAddLog.Name = "dgcOneAddLog";
            this.dgcOneAddLog.ReadOnly = true;
            this.dgcOneAddLog.Text = "Add Log";
            this.dgcOneAddLog.UseColumnTextForLinkValue = true;
            // 
            // tabPageDuplicateEntry
            // 
            this.tabPageDuplicateEntry.Controls.Add(this.dgvTwoPlusEntry);
            this.tabPageDuplicateEntry.Location = new System.Drawing.Point(4, 27);
            this.tabPageDuplicateEntry.Name = "tabPageDuplicateEntry";
            this.tabPageDuplicateEntry.Size = new System.Drawing.Size(976, 441);
            this.tabPageDuplicateEntry.TabIndex = 2;
            this.tabPageDuplicateEntry.Text = "#Duplicate Entry     ";
            this.tabPageDuplicateEntry.UseVisualStyleBackColor = true;
            // 
            // dgvTwoPlusEntry
            // 
            this.dgvTwoPlusEntry.AllowUserToAddRows = false;
            this.dgvTwoPlusEntry.AllowUserToDeleteRows = false;
            this.dgvTwoPlusEntry.AllowUserToResizeColumns = false;
            this.dgvTwoPlusEntry.AllowUserToResizeRows = false;
            this.dgvTwoPlusEntry.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvTwoPlusEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTwoPlusEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcTwoLogId,
            this.dgcTwoEmployeeId,
            this.dgcTwoEmployeeCode,
            this.dgcTwoEmployeeName,
            this.dgcTwoBMEmployeeId,
            this.dgcTwoPunchTime,
            this.dgcTwoRecordType,
            this.dgcTwoDelete});
            this.dgvTwoPlusEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTwoPlusEntry.Location = new System.Drawing.Point(0, 0);
            this.dgvTwoPlusEntry.Name = "dgvTwoPlusEntry";
            this.dgvTwoPlusEntry.ReadOnly = true;
            this.dgvTwoPlusEntry.Size = new System.Drawing.Size(976, 441);
            this.dgvTwoPlusEntry.TabIndex = 2;
            this.dgvTwoPlusEntry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTwoPlusEntry_CellContentClick);
            // 
            // dgcTwoLogId
            // 
            this.dgcTwoLogId.DataPropertyName = "LogId";
            this.dgcTwoLogId.HeaderText = "LogId";
            this.dgcTwoLogId.Name = "dgcTwoLogId";
            this.dgcTwoLogId.ReadOnly = true;
            this.dgcTwoLogId.Visible = false;
            // 
            // dgcTwoEmployeeId
            // 
            this.dgcTwoEmployeeId.DataPropertyName = "EmployeeId";
            this.dgcTwoEmployeeId.HeaderText = "Employee Id";
            this.dgcTwoEmployeeId.Name = "dgcTwoEmployeeId";
            this.dgcTwoEmployeeId.ReadOnly = true;
            this.dgcTwoEmployeeId.Visible = false;
            // 
            // dgcTwoEmployeeCode
            // 
            this.dgcTwoEmployeeCode.DataPropertyName = "EmployeeCode";
            this.dgcTwoEmployeeCode.HeaderText = "Emp Code";
            this.dgcTwoEmployeeCode.Name = "dgcTwoEmployeeCode";
            this.dgcTwoEmployeeCode.ReadOnly = true;
            this.dgcTwoEmployeeCode.Width = 90;
            // 
            // dgcTwoEmployeeName
            // 
            this.dgcTwoEmployeeName.DataPropertyName = "EmployeeName";
            this.dgcTwoEmployeeName.HeaderText = "Employee Name";
            this.dgcTwoEmployeeName.Name = "dgcTwoEmployeeName";
            this.dgcTwoEmployeeName.ReadOnly = true;
            this.dgcTwoEmployeeName.Width = 250;
            // 
            // dgcTwoBMEmployeeId
            // 
            this.dgcTwoBMEmployeeId.DataPropertyName = "BMEmployeeId";
            this.dgcTwoBMEmployeeId.HeaderText = "BM Emp Id";
            this.dgcTwoBMEmployeeId.Name = "dgcTwoBMEmployeeId";
            this.dgcTwoBMEmployeeId.ReadOnly = true;
            this.dgcTwoBMEmployeeId.Width = 90;
            // 
            // dgcTwoPunchTime
            // 
            this.dgcTwoPunchTime.DataPropertyName = "PunchTime";
            this.dgcTwoPunchTime.HeaderText = "Punch Time";
            this.dgcTwoPunchTime.Name = "dgcTwoPunchTime";
            this.dgcTwoPunchTime.ReadOnly = true;
            this.dgcTwoPunchTime.Width = 150;
            // 
            // dgcTwoRecordType
            // 
            this.dgcTwoRecordType.DataPropertyName = "RecordType";
            this.dgcTwoRecordType.HeaderText = "R.Type";
            this.dgcTwoRecordType.Name = "dgcTwoRecordType";
            this.dgcTwoRecordType.ReadOnly = true;
            // 
            // dgcTwoDelete
            // 
            this.dgcTwoDelete.HeaderText = "Delete";
            this.dgcTwoDelete.Name = "dgcTwoDelete";
            this.dgcTwoDelete.ReadOnly = true;
            this.dgcTwoDelete.Text = "Delete Log";
            this.dgcTwoDelete.UseColumnTextForLinkValue = true;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(528, 12);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(113, 29);
            this.buttonLoadData.TabIndex = 5;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // buttonDeleteLog
            // 
            this.buttonDeleteLog.ForeColor = System.Drawing.Color.Red;
            this.buttonDeleteLog.Location = new System.Drawing.Point(12, 12);
            this.buttonDeleteLog.Name = "buttonDeleteLog";
            this.buttonDeleteLog.Size = new System.Drawing.Size(113, 29);
            this.buttonDeleteLog.TabIndex = 39;
            this.buttonDeleteLog.Text = "Delete Log";
            this.buttonDeleteLog.UseVisualStyleBackColor = true;
            this.buttonDeleteLog.Visible = false;
            this.buttonDeleteLog.Click += new System.EventHandler(this.buttonDeleteLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Batch Code";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(984, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Manage Missing Log";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(950, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 40;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAutoDeleteDuplicates
            // 
            this.buttonAutoDeleteDuplicates.Location = new System.Drawing.Point(766, 12);
            this.buttonAutoDeleteDuplicates.Name = "buttonAutoDeleteDuplicates";
            this.buttonAutoDeleteDuplicates.Size = new System.Drawing.Size(186, 29);
            this.buttonAutoDeleteDuplicates.TabIndex = 41;
            this.buttonAutoDeleteDuplicates.Text = "Auto Delete Duplicates";
            this.buttonAutoDeleteDuplicates.UseVisualStyleBackColor = true;
            this.buttonAutoDeleteDuplicates.Click += new System.EventHandler(this.buttonAutoDeleteDuplicates_Click);
            // 
            // FormManageMissingLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManageMissingLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageAllRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiometricLogs)).EndInit();
            this.tabPageOneEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOneEntry)).EndInit();
            this.tabPageDuplicateEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTwoPlusEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAllRecords;
        private System.Windows.Forms.TabPage tabPageOneEntry;
        private System.Windows.Forms.DataGridView dgvBiometricLogs;
        private System.Windows.Forms.Button buttonDeleteLog;
        private System.Windows.Forms.Button buttonApplyInOut;
        private System.Windows.Forms.TabPage tabPageDuplicateEntry;
        private System.Windows.Forms.DataGridView dgvOneEntry;
        private System.Windows.Forms.DataGridView dgvTwoPlusEntry;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxBatchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawLogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawBMEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawPunchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawRowType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOneLogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOneEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOneEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOneBMEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPunchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOneRecordType;
        private System.Windows.Forms.DataGridViewLinkColumn dgcOneAddLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTwoLogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTwoEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTwoEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTwoEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTwoBMEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTwoPunchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTwoRecordType;
        private System.Windows.Forms.DataGridViewLinkColumn dgcTwoDelete;
        private System.Windows.Forms.Button buttonAutoDeleteDuplicates;
    }
}

