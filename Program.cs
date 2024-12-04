using Carl_Rental_System.Forms.Admin_Interface;
using Carl_Rental_System.Forms.User_Interface;
using System;
using System.Windows.Forms;

namespace Carl_Rental_System
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
            Application.Run(new UserLogIn());
        }
    }
}
