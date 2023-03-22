/*
 * Program Name: Patient Booking Software (Office class)
 * 
 * Purpose: Fully functional booking software for patients. 
 * 
 * Revision History:
 *  created Mar 13, 2023 by L. Conn
 *  edited Mar 16, 2023 by L. Conn
 * 
 */

using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace A2LC
{
    internal class Office
    {
        // All appointment objects
        private List<Appointment> _appointments;

        public Office()
        {
            _appointments = new List<Appointment>();
        }

        //Checks for time conflicts against appointment list and adds patient
        public void AddPatient(Appointment newAppt)
        {
            foreach (Appointment existingAppt in _appointments)
            {
                if ((newAppt.GetAppointmentStartTime() < existingAppt.GetAppointmentEndTime()) &&
                    (newAppt.GetAppointmentEndTime() > existingAppt.GetAppointmentStartTime()))
                {
                    throw new Exception("A reservation already exists for this time slot!" +
                                        " Please select a different time.");
                }
            }
            // Add patient to list
            _appointments.Add(newAppt);
        }

        // Validate text fields
        public void CheckTextFields(string[] textFields, bool[] validSpecialFields)
        {
            // Check the special fields for invalid
            foreach(bool specialField in validSpecialFields)
            {

                if (!specialField)
                {
                    throw new ArgumentException("One or more fields entered are not valid.");
                }
            }

            // Check rest of text fields for empty
            foreach(string field in textFields)
            {
                if (string.IsNullOrEmpty(field))
                {
                    throw new ArgumentException("One or more fields entered are not valid.");
                }
            }
        }

        // Write all appointments in session to txt
        public void WriteAppointments()
        {
            if (_appointments.Count == 0) // no appointments
            {
                MessageBox.Show("There are currently no schduled appointments to print.", "Empty Appointment List", MessageBoxButtons.OK);
            }
            else
            {
                StreamWriter writer = null;
                try
                {
                    // init file stream
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Appointments.txt");
                    writer = new StreamWriter(filePath, true);

                    // For each appointment to write file
                    foreach (Appointment appointment in _appointments)
                    {
                        // Head seperator
                        writer.WriteLine("-----------------------------------------------------");
                        // Appointment object in string format
                        writer.WriteLine(appointment.ToString());
                    }

                    // Success message
                    MessageBox.Show(string.Format("Sucessfully printed {0} appointment(s) to Appointment.txt", _appointments.Count), "Success", MessageBoxButtons.OK);

                }
                catch (IOException ex)
                {
                    MessageBox.Show("An error occured while writing to text file.", "File Error", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error has occured while writing to file", "File Error", MessageBoxButtons.OK);
                }
                finally
                {
                    if (writer != null)
                    {
                        // close txt
                        writer.Dispose();
                    }
                }
            }
        }

        // Validate phone format
        public bool IsValidPhone(string phone)
        {
            bool isValid = false;
            string regPattern = @"^\d{10}$";
            if (Regex.IsMatch(phone, regPattern))
            {
                isValid = true;
            }
            return isValid;
        }

        // Validate postal format
        public bool IsValidPostal(string postal)
        {
            bool isValid = false;
            string regPattern = @"^[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]\d$";
            if (Regex.IsMatch(postal, regPattern))
            {
                isValid = true;
            }
            return isValid;
        }

        // Validate email format
        public bool IsValidEmail(string email)
        {
            bool isValid = false;
            
            // empty textbox
            if (string.IsNullOrEmpty(email))
            {
                // exception for null
                throw new ArgumentException();
                
            }
            MailAddress mailAdress = new MailAddress(email);
            isValid = true;
            return isValid;
        }

        // Validate user min age
        public bool IsValidAge(DateTime dob)
        {
            bool isValid = true;
            DateTime minDob = DateTime.Today.AddYears(-18);

            // test dob
            if (dob > minDob)
            {
                isValid = false;
            }
            return isValid;
        }

        // Create Individual appointments class
        public class Appointment
        {
            // object vars
            private string _name;
            private int _age;
            private string _address;
            private string _city;
            private string _province;
            private string _postal;
            private long _phone;
            private string _email;
            private DateTime _apptStartTime;
            private DateTime _apptEndTime;
            private double _apptDuration;
            private string _apptDurationStamp;
            private string _apptDesc;

            public Appointment(string name, int age, string address, string city, string province, string postal, long phone, string email,
                               DateTime apptStartTime, string apptDuration, string apptDesc)
            {
                _name = name;
                _age = age;
                _address = address;
                _city = city;
                _province = province;
                _postal = postal;
                _phone = phone;
                _email = email;
                // includes full duration description
                _apptDurationStamp = apptDuration;
                // only the duration number
                double.TryParse(apptDuration.Split()[0], out _apptDuration);
                
                if (apptDuration.Contains("mins"))
                {
                    // convert mins to hours
                    _apptDuration = _apptDuration / 60.0;
                }
                _apptStartTime = apptStartTime;
                _apptEndTime = apptStartTime.AddHours(_apptDuration);
                _apptDesc = apptDesc;
            }

            // Get start time of appointment
            public DateTime GetAppointmentStartTime()
            {
                return _apptStartTime;
            }

            // Get end time of appointment
            public DateTime GetAppointmentEndTime()
            {
                return _apptEndTime;
            }



            // Override formatting of text output
            public override string ToString()
            {
                string formattedStr;

                // Convert phone num to (xxx) xxx-xxxx format
                string phone = _phone.ToString();
                string formatPhone = string.Format("({0}) {1}-{2}", phone.Substring(0, 3), phone.Substring(3, 3), phone.Substring(6));

                // Formatted string
                formattedStr = $"Patient Name: {_name}\nAge: {_age}\nAddress: {_address}\nCity: {_city}\nProvince: {_province}\n" +
                         $"Postal Code: {_postal}\nPhone Number: {formatPhone}\nEmail: {_email}\n\nAppointment time: {_apptStartTime:MM/dd/yyyy hh:mm tt}\n" +
                         $"Appointment Duration: {_apptDurationStamp}\nDescription: {_apptDesc}";
                return formattedStr;
            }


        }
    }
}
