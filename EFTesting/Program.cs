using DevExpress.Office.Utils;
using EFTesting.UI;
using ITRACK.DBConfiguration;
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
            ConnectionDetails Con = new ConnectionDetails();
            string ConnectionString = Con.readConnection();


            try
            {
                using (var ctx = new ItrackContext())
                {

                    Debug.WriteLine(ConnectionString);
                    ctx.Database.Connection.ConnectionString = ConnectionString;
                    // MessageBox.Show("Connection String Is -" + ctx.Database.Connection.ConnectionString);
                    var group = new List<Group>
            {
                new Group { GroupName ="Vougue Tex",Address="address",TeleNo="077426888" ,FaxNo="011252325",GroupID="VT" }
              
            };

                 

           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Enable title bar skinning 
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.Run(new UI.frmMain());

                    
                  //  new ItrackContextInitializer().InitializeDatabase(ctx);
                }
            }
            catch (Exception ex)
            {
             
         
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Configuration config = new Configuration();
                //config.ShowDialog();
            }


        }
    }
}
