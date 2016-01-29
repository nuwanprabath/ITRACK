using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTesting
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


            using (var ctx = new ItrackContext())
            {
                new ItrackContextInitializer().InitializeDatabase(ctx);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Enable title bar skinning 
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.Run(new UI.frmMain());
           
        }
    }
}
