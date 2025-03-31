namespace CSEmployeeAttendance25
{
    partial class FormMonthHours
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
            this.buttonFilterEmployee = new System.Windows.Forms.Button();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDailyHours = new System.Windows.Forms.TabPage();
            this.dgvMonthHours = new System.Windows.Forms.DataGridView();
            this.dgcRawEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHoursBMEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawBMEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawPunchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawDeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawInOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHourSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcMonthDaySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageMonthLog = new System.Windows.Forms.TabPage();
            this.dgvBiometricLogs = new System.Windows.Forms.DataGridView();
            this.dgcRawLogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcMonthInOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawRowType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageDailyHours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthHours)).BeginInit();
            this.tabPageMonthLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiometricLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.buttonFilterEmployee);
            this.panel1.Controls.Add(this.comboBoxEmployee);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.buttonLoadData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 519);
            this.panel1.TabIndex = 0;
            // 
            // buttonFilterEmployee
            // 
            this.buttonFilterEmployee.Location = new System.Drawing.Point(880, 11);
            this.buttonFilterEmployee.Name = "buttonFilterEmployee";
            this.buttonFilterEmployee.Size = new System.Drawing.Size(92, 29);
            this.buttonFilterEmployee.TabIndex = 39;
            this.buttonFilterEmployee.Text = "Filter";
            this.buttonFilterEmployee.UseVisualStyleBackColor = true;
            this.buttonFilterEmployee.Click += new System.EventHandler(this.buttonFilterEmployee_Click);
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownHeight = 100;
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.IntegralHeight = false;
            this.comboBoxEmployee.Location = new System.Drawing.Point(582, 12);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(296, 26);
            this.comboBoxEmployee.TabIndex = 38;
            this.comboBoxEmployee.Enter += new System.EventHandler(this.comboBoxEmployee_Enter);
            this.comboBoxEmployee.Leave += new System.EventHandler(this.comboBoxEmployee_Leave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDailyHours);
            this.tabControl1.Controls.Add(this.tabPageMonthLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 473);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPageDailyHours
            // 
            this.tabPageDailyHours.Controls.Add(this.dgvMonthHours);
            this.tabPageDailyHours.Location = new System.Drawing.Point(4, 27);
            this.tabPageDailyHours.Name = "tabPageDailyHours";
            this.tabPageDailyHours.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDailyHours.Size = new System.Drawing.Size(976, 442);
            this.tabPageDailyHours.TabIndex = 0;
            this.tabPageDailyHours.Text = "#Month Hours     ";
            this.tabPageDailyHours.UseVisualStyleBackColor = true;
            // 
            // dgvMonthHours
            // 
            this.dgvMonthHours.AllowUserToAddRows = false;
            this.dgvMonthHours.AllowUserToDeleteRows = false;
            this.dgvMonthHours.AllowUserToResizeColumns = false;
            this.dgvMonthHours.AllowUserToResizeRows = false;
            this.dgvMonthHours.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvMonthHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthHours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcRawEmployeeId,
            this.dgcRawEmployeeCode,
            this.dgcRawEmployeeName,
            this.dgcHoursBMEmpId,
            this.dgcRawBMEmployeeId,
            this.dgcRawPunchTime,
            this.dgcRawDeviceId,
            this.dgcRawInOut,
            this.dgcHourSalary,
            this.dgcMonthDaySalary});
            this.dgvMonthHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonthHours.Location = new System.Drawing.Point(3, 3);
            this.dgvMonthHours.Name = "dgvMonthHours";
            this.dgvMonthHours.ReadOnly = true;
            this.dgvMonthHours.Size = new System.Drawing.Size(970, 436);
            this.dgvMonthHours.TabIndex = 0;
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
            this.dgcRawEmployeeName.Width = 120;
            // 
            // dgcHoursBMEmpId
            // 
            this.dgcHoursBMEmpId.DataPropertyName = "BMEmployeeId";
            this.dgcHoursBMEmpId.HeaderText = "BM Emp Id";
            this.dgcHoursBMEmpId.Name = "dgcHoursBMEmpId";
            this.dgcHoursBMEmpId.ReadOnly = true;
            // 
            // dgcRawBMEmployeeId
            // 
            this.dgcRawBMEmployeeId.DataPropertyName = "PunchDate";
            this.dgcRawBMEmployeeId.HeaderText = "Punch Date";
            this.dgcRawBMEmployeeId.Name = "dgcRawBMEmployeeId";
            this.dgcRawBMEmployeeId.ReadOnly = true;
            // 
            // dgcRawPunchTime
            // 
            this.dgcRawPunchTime.DataPropertyName = "InTime12Hr";
            this.dgcRawPunchTime.HeaderText = "In";
            this.dgcRawPunchTime.Name = "dgcRawPunchTime";
            this.dgcRawPunchTime.ReadOnly = true;
            this.dgcRawPunchTime.Width = 80;
            // 
            // dgcRawDeviceId
            // 
            this.dgcRawDeviceId.DataPropertyName = "OutTime12Hr";
            this.dgcRawDeviceId.HeaderText = "Out";
            this.dgcRawDeviceId.Name = "dgcRawDeviceId";
            this.dgcRawDeviceId.ReadOnly = true;
            this.dgcRawDeviceId.Width = 80;
            // 
            // dgcRawInOut
            // 
            this.dgcRawInOut.DataPropertyName = "DayHours";
            this.dgcRawInOut.HeaderText = "Hours";
            this.dgcRawInOut.Name = "dgcRawInOut";
            this.dgcRawInOut.ReadOnly = true;
            // 
            // dgcHourSalary
            // 
            this.dgcHourSalary.DataPropertyName = "HourSalary";
            this.dgcHourSalary.HeaderText = "Hour Salary";
            this.dgcHourSalary.Name = "dgcHourSalary";
            this.dgcHourSalary.ReadOnly = true;
            // 
            // dgcMonthDaySalary
            // 
            this.dgcMonthDaySalary.DataPropertyName = "DaySalary";
            this.dgcMonthDaySalary.HeaderText = "Day Salary";
            this.dgcMonthDaySalary.Name = "dgcMonthDaySalary";
            this.dgcMonthDaySalary.ReadOnly = true;
            // 
            // tabPageMonthLog
            // 
            this.tabPageMonthLog.Controls.Add(this.dgvBiometricLogs);
            this.tabPageMonthLog.Location = new System.Drawing.Point(4, 27);
            this.tabPageMonthLog.Name = "tabPageMonthLog";
            this.tabPageMonthLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonthLog.Size = new System.Drawing.Size(976, 442);
            this.tabPageMonthLog.TabIndex = 1;
            this.tabPageMonthLog.Text = "#Month Log     ";
            this.tabPageMonthLog.UseVisualStyleBackColor = true;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dgcMonthInOut,
            this.dgcRawRowType});
            this.dgvBiometricLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBiometricLogs.Location = new System.Drawing.Point(3, 3);
            this.dgvBiometricLogs.Name = "dgvBiometricLogs";
            this.dgvBiometricLogs.ReadOnly = true;
            this.dgvBiometricLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBiometricLogs.Size = new System.Drawing.Size(970, 436);
            this.dgvBiometricLogs.TabIndex = 1;
            // 
            // dgcRawLogId
            // 
            this.dgcRawLogId.HeaderText = "LogId";
            this.dgcRawLogId.Name = "dgcRawLogId";
            this.dgcRawLogId.ReadOnly = true;
            this.dgcRawLogId.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Emp Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmployeeName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BMEmployeeId";
            this.dataGridViewTextBoxColumn4.HeaderText = "BM Emp Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PunchTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "Punch Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 170;
            // 
            // dgcMonthInOut
            // 
            this.dgcMonthInOut.DataPropertyName = "InOut";
            this.dgcMonthInOut.HeaderText = "In/Out";
            this.dgcMonthInOut.Name = "dgcMonthInOut";
            this.dgcMonthInOut.ReadOnly = true;
            // 
            // dgcRawRowType
            // 
            this.dgcRawRowType.DataPropertyName = "RecordType";
            this.dgcRawRowType.HeaderText = "R.Type";
            this.dgcRawRowType.Name = "dgcRawRowType";
            this.dgcRawRowType.ReadOnly = true;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadData.Location = new System.Drawing.Point(404, 11);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(92, 29);
            this.buttonLoadData.TabIndex = 6;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(275, 13);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(123, 24);
            this.dtpEndDate.TabIndex = 35;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(109, 13);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(123, 24);
            this.dtpStartDate.TabIndex = 34;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Start Date";
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
            this.label3.Text = "Month Hours";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(946, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 39;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(502, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(33, 29);
            this.buttonPrint.TabIndex = 40;
            this.buttonPrint.Text = "P";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // FormMonthHours
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
            this.Name = "FormMonthHours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCompanyInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageDailyHours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthHours)).EndInit();
            this.tabPageMonthLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiometricLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDailyHours;
        private System.Windows.Forms.TabPage tabPageMonthLog;
        private System.Windows.Forms.DataGridView dgvMonthHours;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dgvBiometricLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawLogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMonthInOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawRowType;
        private System.Windows.Forms.Button buttonFilterEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHoursBMEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawBMEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawPunchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawDeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawInOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHourSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMonthDaySalary;
        private System.Windows.Forms.Button buttonPrint;
    }
}

