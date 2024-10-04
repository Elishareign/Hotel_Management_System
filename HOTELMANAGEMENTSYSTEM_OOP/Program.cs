using HOTELMANAGEMENTSYSTEM_OOP.Forms;
using HOTELMANAGEMENTSYSTEM_OOP.Model;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HOTELMANAGEMENTSYSTEM_OOP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            QuestPDF.Settings.License = LicenseType.Community;

            //DatabaseHelper.InitializeDatabase();
            // DatabaseHelper.AddSampleUsers();


            using (LoginForm loginForm = new LoginForm())
             {
                 if (loginForm.ShowDialog() == DialogResult.OK)
                 {
                     User loggedInUser = loginForm.LoggedInUser;
                     Form dashboardForm = new DashboardFrm(loggedInUser);
                     Application.Run(dashboardForm);
                 }
             } 
            //Form roomBookingForm = new RoomBookingForm(); 
            //Application.Run(roomBookingForm);

        }
    }
}
