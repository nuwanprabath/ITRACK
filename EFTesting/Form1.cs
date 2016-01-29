using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITRACK.models;

namespace EFTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     


       

        void addGroup() {

                     using (var  context = new ItrackContext() ){
                            var group = new List<Group>
                            {
                                new Group { GroupName ="Vougue Tex",Address="address",TeleNo="077426888" ,FaxNo="011252325" }
              
                            };
                            group.ForEach(s => context.Group.Add(s));
                            context.SaveChanges();
                        }
        }





        private void button1_Click(object sender, EventArgs e)
        {
          //  addStudent();
              addGroup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UI.frmMain main = new UI.frmMain();
            main.Show();

        }
    }
}
