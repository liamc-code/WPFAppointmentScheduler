namespace A2LC
{
    partial class frmBooking
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
            this.grpPatient = new System.Windows.Forms.GroupBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.lblPostal = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpAdditional = new System.Windows.Forms.GroupBox();
            this.rtxPurpose = new System.Windows.Forms.RichTextBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFillFields = new System.Windows.Forms.Button();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblPostalError = new System.Windows.Forms.Label();
            this.lblAgeError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.grpPatient.SuspendLayout();
            this.grpAdditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatient
            // 
            this.grpPatient.Controls.Add(this.dtpDob);
            this.grpPatient.Controls.Add(this.txtEmail);
            this.grpPatient.Controls.Add(this.lblEmail);
            this.grpPatient.Controls.Add(this.txtPhone);
            this.grpPatient.Controls.Add(this.lblPhone);
            this.grpPatient.Controls.Add(this.txtPostal);
            this.grpPatient.Controls.Add(this.lblPostal);
            this.grpPatient.Controls.Add(this.txtProvince);
            this.grpPatient.Controls.Add(this.lblProvince);
            this.grpPatient.Controls.Add(this.txtCity);
            this.grpPatient.Controls.Add(this.lblCity);
            this.grpPatient.Controls.Add(this.txtAddress);
            this.grpPatient.Controls.Add(this.lblAddress);
            this.grpPatient.Controls.Add(this.lblDob);
            this.grpPatient.Controls.Add(this.txtName);
            this.grpPatient.Controls.Add(this.lblName);
            this.grpPatient.Location = new System.Drawing.Point(28, 31);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(202, 454);
            this.grpPatient.TabIndex = 0;
            this.grpPatient.TabStop = false;
            this.grpPatient.Text = "Patient Information";
            // 
            // dtpDob
            // 
            this.dtpDob.AllowDrop = true;
            this.dtpDob.CustomFormat = "MMMM dd, yyyy";
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(10, 89);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(166, 20);
            this.dtpDob.TabIndex = 2;
            this.dtpDob.ValueChanged += new System.EventHandler(this.DateChangedEvent);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(10, 401);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.TextChangedEvent);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 384);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(10, 348);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(166, 20);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.TextChanged += new System.EventHandler(this.TextChangedEvent);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 331);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(10, 298);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(166, 20);
            this.txtPostal.TabIndex = 11;
            this.txtPostal.TextChanged += new System.EventHandler(this.TextChangedEvent);
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Location = new System.Drawing.Point(7, 281);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(64, 13);
            this.lblPostal.TabIndex = 10;
            this.lblPostal.Text = "Postal Code";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(10, 245);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(166, 20);
            this.txtProvince.TabIndex = 9;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(7, 228);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(49, 13);
            this.lblProvince.TabIndex = 8;
            this.lblProvince.Text = "Province";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(10, 195);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(166, 20);
            this.txtCity.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(7, 178);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(10, 142);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(166, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 125);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(7, 73);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(66, 13);
            this.lblDob.TabIndex = 2;
            this.lblDob.Text = "Date of Birth";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Patient Name";
            // 
            // grpAdditional
            // 
            this.grpAdditional.Controls.Add(this.rtxPurpose);
            this.grpAdditional.Controls.Add(this.lblPurpose);
            this.grpAdditional.Controls.Add(this.cmbDuration);
            this.grpAdditional.Controls.Add(this.dtpAppointmentTime);
            this.grpAdditional.Controls.Add(this.lblDuration);
            this.grpAdditional.Controls.Add(this.lblAppointmentTime);
            this.grpAdditional.Location = new System.Drawing.Point(274, 31);
            this.grpAdditional.Name = "grpAdditional";
            this.grpAdditional.Size = new System.Drawing.Size(262, 344);
            this.grpAdditional.TabIndex = 1;
            this.grpAdditional.TabStop = false;
            this.grpAdditional.Text = "Appointment Information";
            // 
            // rtxPurpose
            // 
            this.rtxPurpose.Location = new System.Drawing.Point(9, 142);
            this.rtxPurpose.Name = "rtxPurpose";
            this.rtxPurpose.Size = new System.Drawing.Size(234, 176);
            this.rtxPurpose.TabIndex = 21;
            this.rtxPurpose.Text = "";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(6, 125);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(120, 13);
            this.lblPurpose.TabIndex = 19;
            this.lblPurpose.Text = "Purpose of Appointment";
            // 
            // cmbDuration
            // 
            this.cmbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDuration.FormattingEnabled = true;
            this.cmbDuration.Location = new System.Drawing.Point(9, 89);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(166, 21);
            this.cmbDuration.TabIndex = 18;
            // 
            // dtpAppointmentTime
            // 
            this.dtpAppointmentTime.AllowDrop = true;
            this.dtpAppointmentTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentTime.Location = new System.Drawing.Point(9, 36);
            this.dtpAppointmentTime.Name = "dtpAppointmentTime";
            this.dtpAppointmentTime.Size = new System.Drawing.Size(166, 20);
            this.dtpAppointmentTime.TabIndex = 16;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(6, 73);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(109, 13);
            this.lblDuration.TabIndex = 16;
            this.lblDuration.Text = "Appointment Duration";
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Location = new System.Drawing.Point(6, 20);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(147, 13);
            this.lblAppointmentTime.TabIndex = 17;
            this.lblAppointmentTime.Text = "Requested Appointment Time";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(299, 381);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(106, 23);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Book Appointment";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.BookEvent);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(411, 381);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Fields";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetEvent);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(411, 414);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.PrintFileEvent);
            // 
            // btnFillFields
            // 
            this.btnFillFields.Location = new System.Drawing.Point(299, 414);
            this.btnFillFields.Name = "btnFillFields";
            this.btnFillFields.Size = new System.Drawing.Size(106, 23);
            this.btnFillFields.TabIndex = 4;
            this.btnFillFields.Text = "Pre-Fill Fields";
            this.btnFillFields.UseVisualStyleBackColor = true;
            this.btnFillFields.Click += new System.EventHandler(this.PrefillEvent);
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(271, 458);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(0, 13);
            this.lblEmailError.TabIndex = 6;
            // 
            // lblPostalError
            // 
            this.lblPostalError.AutoSize = true;
            this.lblPostalError.ForeColor = System.Drawing.Color.Red;
            this.lblPostalError.Location = new System.Drawing.Point(271, 481);
            this.lblPostalError.Name = "lblPostalError";
            this.lblPostalError.Size = new System.Drawing.Size(0, 13);
            this.lblPostalError.TabIndex = 7;
            // 
            // lblAgeError
            // 
            this.lblAgeError.AutoSize = true;
            this.lblAgeError.ForeColor = System.Drawing.Color.Red;
            this.lblAgeError.Location = new System.Drawing.Point(271, 528);
            this.lblAgeError.Name = "lblAgeError";
            this.lblAgeError.Size = new System.Drawing.Size(0, 13);
            this.lblAgeError.TabIndex = 9;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(271, 505);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(0, 13);
            this.lblPhoneError.TabIndex = 8;
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 571);
            this.Controls.Add(this.lblAgeError);
            this.Controls.Add(this.lblPhoneError);
            this.Controls.Add(this.lblPostalError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnFillFields);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.grpAdditional);
            this.Controls.Add(this.grpPatient);
            this.Name = "frmBooking";
            this.Text = "Booking Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.grpAdditional.ResumeLayout(false);
            this.grpAdditional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpAdditional;
        private System.Windows.Forms.RichTextBox rtxPurpose;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.ComboBox cmbDuration;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnFillFields;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPostalError;
        private System.Windows.Forms.Label lblAgeError;
        private System.Windows.Forms.Label lblPhoneError;
    }
}

