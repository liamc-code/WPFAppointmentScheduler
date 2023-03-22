/*
 * Program Name: Patient Booking Software
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
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBooking());
        }
    }
}
