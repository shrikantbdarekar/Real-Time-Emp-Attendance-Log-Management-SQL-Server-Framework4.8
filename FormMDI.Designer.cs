namespace CSEmployeeAttendance25
{
    partial class FormMDI
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
            this.menuStripMDI = new System.Windows.Forms.MenuStrip();
            this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompanyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBiometricMachine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportAttendanceLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageMissingLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.AutoSize = false;
            this.menuStripMDI.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStripMDI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetting,
            this.mnuEmployee,
            this.mnuAttendance,
            this.mnuReport,
            this.mnuExit});
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Size = new System.Drawing.Size(1200, 37);
            this.menuStripMDI.TabIndex = 0;
            this.menuStripMDI.Text = "menuStrip1";
            // 
            // mnuSetting
            // 
            this.mnuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCompanyInfo,
            this.mnuBiometricMachine,
            this.mnuUserAccount,
            this.mnuChangePassword});
            this.mnuSetting.Name = "mnuSetting";
            this.mnuSetting.Size = new System.Drawing.Size(71, 33);
            this.mnuSetting.Text = "Setting";
            // 
            // mnuCompanyInfo
            // 
            this.mnuCompanyInfo.Name = "mnuCompanyInfo";
            this.mnuCompanyInfo.Size = new System.Drawing.Size(209, 26);
            this.mnuCompanyInfo.Text = "Company Info";
            this.mnuCompanyInfo.Click += new System.EventHandler(this.mnuCompanyInfo_Click);
            // 
            // mnuUserAccount
            // 
            this.mnuUserAccount.Name = "mnuUserAccount";
            this.mnuUserAccount.Size = new System.Drawing.Size(209, 26);
            this.mnuUserAccount.Text = "User Account";
            this.mnuUserAccount.Click += new System.EventHandler(this.mnuUserAccount_Click);
            // 
            // mnuBiometricMachine
            // 
            this.mnuBiometricMachine.Name = "mnuBiometricMachine";
            this.mnuBiometricMachine.Size = new System.Drawing.Size(209, 26);
            this.mnuBiometricMachine.Text = "Biometric Machine";
            this.mnuBiometricMachine.Click += new System.EventHandler(this.mnuBiometricMachine_Click);
            // 
            // mnuChangePassword
            // 
            this.mnuChangePassword.Name = "mnuChangePassword";
            this.mnuChangePassword.Size = new System.Drawing.Size(209, 26);
            this.mnuChangePassword.Text = "Change Password";
            this.mnuChangePassword.Click += new System.EventHandler(this.mnuChangePassword_Click);
            // 
            // mnuEmployee
            // 
            this.mnuEmployee.Name = "mnuEmployee";
            this.mnuEmployee.Size = new System.Drawing.Size(90, 33);
            this.mnuEmployee.Text = "Employee";
            this.mnuEmployee.Click += new System.EventHandler(this.mnuEmployee_Click);
            // 
            // mnuAttendance
            // 
            this.mnuAttendance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImportAttendanceLog,
            this.mnuManageMissingLog,
            this.mnuCalculateSalary});
            this.mnuAttendance.Name = "mnuAttendance";
            this.mnuAttendance.Size = new System.Drawing.Size(100, 33);
            this.mnuAttendance.Text = "Attendance";
            // 
            // mnuImportAttendanceLog
            // 
            this.mnuImportAttendanceLog.Name = "mnuImportAttendanceLog";
            this.mnuImportAttendanceLog.Size = new System.Drawing.Size(239, 26);
            this.mnuImportAttendanceLog.Text = "Import Attendance Log";
            this.mnuImportAttendanceLog.Click += new System.EventHandler(this.mnuImportAttendanceLog_Click);
            // 
            // mnuManageMissingLog
            // 
            this.mnuManageMissingLog.Name = "mnuManageMissingLog";
            this.mnuManageMissingLog.Size = new System.Drawing.Size(239, 26);
            this.mnuManageMissingLog.Text = "Manage Missing Log";
            this.mnuManageMissingLog.Click += new System.EventHandler(this.mnuManageMissingLog_Click);
            // 
            // mnuCalculateSalary
            // 
            this.mnuCalculateSalary.Name = "mnuCalculateSalary";
            this.mnuCalculateSalary.Size = new System.Drawing.Size(239, 26);
            this.mnuCalculateSalary.Text = "Calculate Salary";
            this.mnuCalculateSalary.Click += new System.EventHandler(this.mnuCalculateSalary_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(69, 33);
            this.mnuReport.Text = "Report";
            this.mnuReport.Click += new System.EventHandler(this.mnuReport_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(46, 33);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.menuStripMDI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMDI;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI | Attendance Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMDI;
        private System.Windows.Forms.ToolStripMenuItem mnuSetting;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuAttendance;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCompanyInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuUserAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuBiometricMachine;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassword;
        private System.Windows.Forms.ToolStripMenuItem mnuImportAttendanceLog;
        private System.Windows.Forms.ToolStripMenuItem mnuManageMissingLog;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculateSalary;
    }
}