namespace CSEmployeeAttendance25
{
    partial class FormCompanyInfo
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
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpShiftEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpShiftStart = new System.Windows.Forms.DateTimePicker();
            this.textBoxWebsite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxContactNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.numericFromHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDeductionMinutes = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownToHour = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxAdjustment = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxApplyAdjustment = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFromHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeductionMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToHour)).BeginInit();
            this.groupBoxAdjustment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.checkBoxApplyAdjustment);
            this.panel1.Controls.Add(this.groupBoxAdjustment);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.dtpShiftEnd);
            this.panel1.Controls.Add(this.dtpShiftStart);
            this.panel1.Controls.Add(this.textBoxWebsite);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxContactNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxCompanyName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 376);
            this.panel1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(353, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 18);
            this.label17.TabIndex = 12;
            this.label17.Text = "End";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "Shift Start";
            // 
            // dtpShiftEnd
            // 
            this.dtpShiftEnd.CustomFormat = "hh:mm tt";
            this.dtpShiftEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShiftEnd.Location = new System.Drawing.Point(397, 204);
            this.dtpShiftEnd.Name = "dtpShiftEnd";
            this.dtpShiftEnd.Size = new System.Drawing.Size(104, 24);
            this.dtpShiftEnd.TabIndex = 13;
            // 
            // dtpShiftStart
            // 
            this.dtpShiftStart.CustomFormat = "hh:mm tt";
            this.dtpShiftStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShiftStart.Location = new System.Drawing.Point(192, 204);
            this.dtpShiftStart.Name = "dtpShiftStart";
            this.dtpShiftStart.Size = new System.Drawing.Size(106, 24);
            this.dtpShiftStart.TabIndex = 11;
            // 
            // textBoxWebsite
            // 
            this.textBoxWebsite.Location = new System.Drawing.Point(192, 140);
            this.textBoxWebsite.Name = "textBoxWebsite";
            this.textBoxWebsite.Size = new System.Drawing.Size(309, 24);
            this.textBoxWebsite.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Website";
            // 
            // textBoxContactNo
            // 
            this.textBoxContactNo.Location = new System.Drawing.Point(192, 110);
            this.textBoxContactNo.Name = "textBoxContactNo";
            this.textBoxContactNo.Size = new System.Drawing.Size(309, 24);
            this.textBoxContactNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact No.";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(192, 80);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(309, 24);
            this.textBoxEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(273, 327);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 29);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Cancel";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(192, 327);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 29);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Save";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(192, 50);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(309, 24);
            this.textBoxAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(192, 20);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(309, 24);
            this.textBoxCompanyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(546, 42);
            this.label6.TabIndex = 2;
            this.label6.Text = "Company Info";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(511, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // numericFromHour
            // 
            this.numericFromHour.DecimalPlaces = 2;
            this.numericFromHour.Location = new System.Drawing.Point(110, 30);
            this.numericFromHour.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericFromHour.Name = "numericFromHour";
            this.numericFromHour.Size = new System.Drawing.Size(58, 24);
            this.numericFromHour.TabIndex = 2;
            this.numericFromHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericFromHour.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericUpDownDeductionMinutes
            // 
            this.numericUpDownDeductionMinutes.Location = new System.Drawing.Point(382, 30);
            this.numericUpDownDeductionMinutes.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownDeductionMinutes.Name = "numericUpDownDeductionMinutes";
            this.numericUpDownDeductionMinutes.Size = new System.Drawing.Size(58, 24);
            this.numericUpDownDeductionMinutes.TabIndex = 8;
            this.numericUpDownDeductionMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownDeductionMinutes.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hour Setting";
            // 
            // numericUpDownToHour
            // 
            this.numericUpDownToHour.DecimalPlaces = 2;
            this.numericUpDownToHour.Location = new System.Drawing.Point(228, 30);
            this.numericUpDownToHour.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownToHour.Name = "numericUpDownToHour";
            this.numericUpDownToHour.Size = new System.Drawing.Size(58, 24);
            this.numericUpDownToHour.TabIndex = 5;
            this.numericUpDownToHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownToHour.Value = new decimal(new int[] {
            845,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Min.";
            // 
            // groupBoxAdjustment
            // 
            this.groupBoxAdjustment.Controls.Add(this.label12);
            this.groupBoxAdjustment.Controls.Add(this.label11);
            this.groupBoxAdjustment.Controls.Add(this.label10);
            this.groupBoxAdjustment.Controls.Add(this.label9);
            this.groupBoxAdjustment.Controls.Add(this.label8);
            this.groupBoxAdjustment.Controls.Add(this.numericUpDownToHour);
            this.groupBoxAdjustment.Controls.Add(this.label7);
            this.groupBoxAdjustment.Controls.Add(this.numericUpDownDeductionMinutes);
            this.groupBoxAdjustment.Controls.Add(this.numericFromHour);
            this.groupBoxAdjustment.Location = new System.Drawing.Point(25, 247);
            this.groupBoxAdjustment.Name = "groupBoxAdjustment";
            this.groupBoxAdjustment.Size = new System.Drawing.Size(497, 71);
            this.groupBoxAdjustment.TabIndex = 14;
            this.groupBoxAdjustment.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Hr";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Hr";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Adjust";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "To";
            // 
            // checkBoxApplyAdjustment
            // 
            this.checkBoxApplyAdjustment.AutoSize = true;
            this.checkBoxApplyAdjustment.Checked = true;
            this.checkBoxApplyAdjustment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxApplyAdjustment.Location = new System.Drawing.Point(54, 245);
            this.checkBoxApplyAdjustment.Name = "checkBoxApplyAdjustment";
            this.checkBoxApplyAdjustment.Size = new System.Drawing.Size(176, 22);
            this.checkBoxApplyAdjustment.TabIndex = 0;
            this.checkBoxApplyAdjustment.Text = "Apply Time Adjustment";
            this.checkBoxApplyAdjustment.UseVisualStyleBackColor = true;
            this.checkBoxApplyAdjustment.CheckedChanged += new System.EventHandler(this.checkBoxApplyAdjustment_CheckedChanged);
            // 
            // FormCompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(546, 418);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompanyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCompanyInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFromHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeductionMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToHour)).EndInit();
            this.groupBoxAdjustment.ResumeLayout(false);
            this.groupBoxAdjustment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxWebsite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxContactNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpShiftEnd;
        private System.Windows.Forms.DateTimePicker dtpShiftStart;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownToHour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownDeductionMinutes;
        private System.Windows.Forms.NumericUpDown numericFromHour;
        private System.Windows.Forms.GroupBox groupBoxAdjustment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxApplyAdjustment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

