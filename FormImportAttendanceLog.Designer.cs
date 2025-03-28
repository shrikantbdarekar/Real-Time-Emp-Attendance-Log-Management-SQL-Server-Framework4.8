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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgcRawEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawBMEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawPunchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawDeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawInOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRawRowType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgcHistoryBatchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHistoryStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHistoryEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHistoryViewDetails = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 519);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 436);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "#Raw Log Data     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcRawEmployeeId,
            this.dgcRawEmployeeCode,
            this.dgcRawEmployeeName,
            this.dgcRawBMEmployeeId,
            this.dgcRawPunchTime,
            this.dgcRawDeviceId,
            this.dgcRawInOut,
            this.dgcRawRowType});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(970, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgcRawEmployeeId
            // 
            this.dgcRawEmployeeId.HeaderText = "Employee Id";
            this.dgcRawEmployeeId.Name = "dgcRawEmployeeId";
            this.dgcRawEmployeeId.ReadOnly = true;
            this.dgcRawEmployeeId.Visible = false;
            // 
            // dgcRawEmployeeCode
            // 
            this.dgcRawEmployeeCode.HeaderText = "Emp Code";
            this.dgcRawEmployeeCode.Name = "dgcRawEmployeeCode";
            this.dgcRawEmployeeCode.ReadOnly = true;
            this.dgcRawEmployeeCode.Width = 90;
            // 
            // dgcRawEmployeeName
            // 
            this.dgcRawEmployeeName.HeaderText = "Employee Name";
            this.dgcRawEmployeeName.Name = "dgcRawEmployeeName";
            this.dgcRawEmployeeName.ReadOnly = true;
            this.dgcRawEmployeeName.Width = 250;
            // 
            // dgcRawBMEmployeeId
            // 
            this.dgcRawBMEmployeeId.HeaderText = "BM Emp Id";
            this.dgcRawBMEmployeeId.Name = "dgcRawBMEmployeeId";
            this.dgcRawBMEmployeeId.ReadOnly = true;
            this.dgcRawBMEmployeeId.Width = 90;
            // 
            // dgcRawPunchTime
            // 
            this.dgcRawPunchTime.HeaderText = "Punch Time";
            this.dgcRawPunchTime.Name = "dgcRawPunchTime";
            this.dgcRawPunchTime.ReadOnly = true;
            this.dgcRawPunchTime.Width = 150;
            // 
            // dgcRawDeviceId
            // 
            this.dgcRawDeviceId.HeaderText = "Device Id";
            this.dgcRawDeviceId.Name = "dgcRawDeviceId";
            this.dgcRawDeviceId.ReadOnly = true;
            // 
            // dgcRawInOut
            // 
            this.dgcRawInOut.HeaderText = "In/Out";
            this.dgcRawInOut.Name = "dgcRawInOut";
            this.dgcRawInOut.ReadOnly = true;
            // 
            // dgcRawRowType
            // 
            this.dgcRawRowType.HeaderText = "R.Type";
            this.dgcRawRowType.Name = "dgcRawRowType";
            this.dgcRawRowType.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "#Batch History     ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcHistoryBatchCode,
            this.dgcHistoryStartDate,
            this.dgcHistoryEndDate,
            this.dgcHistoryViewDetails});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(970, 399);
            this.dataGridView2.TabIndex = 1;
            // 
            // dgcHistoryBatchCode
            // 
            this.dgcHistoryBatchCode.HeaderText = "Batch Code";
            this.dgcHistoryBatchCode.Name = "dgcHistoryBatchCode";
            this.dgcHistoryBatchCode.ReadOnly = true;
            this.dgcHistoryBatchCode.Width = 200;
            // 
            // dgcHistoryStartDate
            // 
            this.dgcHistoryStartDate.HeaderText = "Start Date";
            this.dgcHistoryStartDate.Name = "dgcHistoryStartDate";
            this.dgcHistoryStartDate.ReadOnly = true;
            this.dgcHistoryStartDate.Width = 120;
            // 
            // dgcHistoryEndDate
            // 
            this.dgcHistoryEndDate.HeaderText = "End Date";
            this.dgcHistoryEndDate.Name = "dgcHistoryEndDate";
            this.dgcHistoryEndDate.ReadOnly = true;
            this.dgcHistoryEndDate.Width = 120;
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
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(574, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 54);
            this.label5.TabIndex = 36;
            this.label5.Text = "Batch Code\r\nxxxxxxxxxxxx";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(304, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 24);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 24);
            this.dateTimePicker1.TabIndex = 34;
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
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(443, 48);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(113, 29);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Import";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(481, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 29);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Browse";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 24);
            this.textBox1.TabIndex = 1;
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
            this.label3.Size = new System.Drawing.Size(984, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Import Attendance Log";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormImportAttendanceLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportAttendanceLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCompanyInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawBMEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawPunchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawDeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawInOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRawRowType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHistoryBatchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHistoryStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHistoryEndDate;
        private System.Windows.Forms.DataGridViewLinkColumn dgcHistoryViewDetails;
    }
}

