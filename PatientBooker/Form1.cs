/*
 * Program Name: Patient Booking Software (Form1)
 * 
 * Purpose: Fully functional booking software for patients. 
 * 
 * Revision History:
 *  created Mar 13, 2023 by L. Conn
 *  edited Mar 16, 2023 by L. Conn
 * 
 */

using System;
using System.Windows.Forms;

namespace A2LC
{
    public partial class frmBooking : Form
    {
        // Form Vars
        bool[] validSpecialFields = new bool[4];
        Office office;
        public frmBooking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            office = new Office();
            
            // set all valid special fields to false
            for(int i = 0; i < validSpecialFields.Length; i++)
            {
                validSpecialFields[i] = false;
            }

            // Set appointment durations
            cmbDuration.Items.Add("15 mins");
            cmbDuration.Items.Add("30 mins");
            cmbDuration.Items.Add("45 mins");
            cmbDuration.Items.Add("1 hour");
            cmbDuration.SelectedIndex = 0;

            // Run dob date change event on start
            DateChangedEvent(dtpDob, EventArgs.Empty);

        }

        // Validation for postal, phone, and email fields 
        private void TextChangedEvent(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string regPattern;
            string currError;

            // For the following special fields
            switch(textBox.Name) 
            {
                case "txtPostal":
                    currError = "Postal Code must be a valid format (e.g. L7L 6Z3)";
                    validSpecialFields[0] = office.IsValidPostal(textBox.Text);

                    if (validSpecialFields[0]) {
                        lblPostalError.Text = "";
                    } 
                    else
                    {
                        lblPostalError.Text = currError;
                    }
                    break;
                case "txtPhone":
                    currError = "Phone number must be in a valid format (e.g 1234567890)";
                    validSpecialFields[1] = office.IsValidPhone(textBox.Text);

                    if (validSpecialFields[1])
                    {
                        lblPhoneError.Text = "";
                    }
                    else
                    {
                        lblPhoneError.Text = currError;
                    }
                    break;
                case "txtEmail":
                    currError = "Email must be provided in valid format (e.g john@gmail.com)";
                    // attempt to validate email
                    try
                    {
                        validSpecialFields[2] = office.IsValidEmail(textBox.Text);
                        lblEmailError.Text = "";
                    }
                    catch (FormatException)
                    {
                        lblEmailError.Text = currError;
                        validSpecialFields[2] = false;
                    } 
                    catch(ArgumentException)
                    {
                        lblEmailError.Text = currError;
                        validSpecialFields[2] = false;
                    }
                    break;
            }
        }

        // Validation for date of birth field
        private void DateChangedEvent(object sender, EventArgs e)
        {
            // DateTime vars
            DateTime dob = dtpDob.Value;
            string currError = "Patient must be at least 18 years of age";
            validSpecialFields[3] = office.IsValidAge(dob);

            if (validSpecialFields[3])
            {
                lblAgeError.Text = "";
            } else
            {
                lblAgeError.Text = currError;
            }

        }

        // Book Appointment Event
        private void BookEvent(object sender, EventArgs e)
        {
            // user entries for appointment object
            string name = txtName.Text;
            DateTime dob = dtpDob.Value;
            int age;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string postal = txtPostal.Text;
            long phone;
            string email = txtEmail.Text;
            DateTime apptStartTime = dtpAppointmentTime.Value;
            string apptDuration = cmbDuration.Text;
            string apptDesc = rtxPurpose.Text;

            // new object
            Office.Appointment newAppt;

            // validate fields
            try
            {
                // check for empty/invalid fields
                office.CheckTextFields(new string[] { name, address, city, province, postal, txtPhone.Text, email, apptDuration, apptDesc }, validSpecialFields);

                long.TryParse(txtPhone.Text, out phone);
                age = DateTime.Today.Year - dob.Year;

                // fill object
                newAppt = new Office.Appointment(name, age, address, city, province, postal, phone, email, apptStartTime, apptDuration, apptDesc);
                // check time conflicts and add
                office.AddPatient(newAppt);
                MessageBox.Show(string.Format("Sucessfully booked your appointment on {0:MM-dd} at {0:hh:mm}", apptStartTime), "Success",
                                MessageBoxButtons.OK);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Details", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Details", MessageBoxButtons.OK);
            }
        }

        // Pre-fill Correct Fields event
        private void PrefillEvent(object sender, EventArgs e)
        {
            // Correct user entries 
            txtName.Text = "John Doe";
            dtpDob.Value = DateTime.Today.AddYears(-19);
            txtAddress.Text = "123 Castle Cr";
            txtCity.Text = "Waterloo";
            txtProvince.Text = "Ontario";
            txtPostal.Text = "N2L 7X8";
            txtPhone.Text = "7051238992"; 
            txtEmail.Text = "joedoe@gmail.com";
            dtpAppointmentTime.Value = DateTime.Today.AddDays(1);
            cmbDuration.SelectedIndex = 0;
            rtxPurpose.Text = "Description of purpose for the visit goes here.";
        }

        // Reset Fields event
        private void ResetEvent(object sender, EventArgs e)
        {
            // Clear all control fields
            txtName.Text = "";
            dtpDob.Value = DateTime.Now;
            txtAddress.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";
            txtPostal.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            dtpAppointmentTime.Value = DateTime.Now;
            cmbDuration.SelectedIndex = 0;
            rtxPurpose.Text = "";
        }

        // Print all appointments to txt file
        private void PrintFileEvent(object sender, EventArgs e)
        {
            office.WriteAppointments();
        }
    }
}
