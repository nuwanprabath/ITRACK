using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Excel=Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using Excell = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using ITRACK.models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MyTeamApp
{
    class ExcelHelpers
    {
        public  string DB_PATH = @"";
        
        private static Excell.Workbook MyBook = null;
        private static Excell.Application MyApp = null;
        private static Excell.Worksheet MySheet = null;
        private static int lastRow=0;
        public static BindingList<OperationPool> oprationList = new BindingList<OperationPool>();
       
        public  void InitializeExcel()
        {
            MyApp = new Excell.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(DB_PATH);
            int WorkSheetNo = 0;
            for (int i = 1; i < MyBook.Sheets.Count; i++) {
                MySheet = (Excell.Worksheet)MyBook.Sheets[i];
                if (MySheet.Name == "Sheet1")
                {
                    WorkSheetNo = i;
                }
            }

            MySheet = (Excell.Worksheet)MyBook.Sheets[1];  // Explict cast is not required here

            
            lastRow = MySheet.Cells.SpecialCells(Excell.XlCellType.xlCellTypeLastCell).Row;
        }

        public void InitializeDevidingPlan()
        {
            MyApp = new Excell.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(DB_PATH);
            int WorkSheetNo = 1;
            for (int i = 1; i < MyBook.Sheets.Count; i++)
            {
                MySheet = (Excell.Worksheet)MyBook.Sheets[i];
                if (MySheet.Name == "DVP")
                {
                    WorkSheetNo = i;
                }
            }

            MySheet = (Excell.Worksheet)MyBook.Sheets[WorkSheetNo];  // Explict cast is not required here


            lastRow = MySheet.Cells.SpecialCells(Excell.XlCellType.xlCellTypeLastCell).Row;
        }

        public  void InitializeOprationBreakdown()
        {
            MyApp = new Excell.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(DB_PATH);
            int WorkSheetNo = 0;
            for (int i = 1; i < MyBook.Sheets.Count; i++)
            {
                MySheet = (Excell.Worksheet)MyBook.Sheets[i];
                if (MySheet.Name == "OPERATION BREAK DOWN")
                {
                    WorkSheetNo = i;
                }
            }

            MySheet = (Excell.Worksheet)MyBook.Sheets[WorkSheetNo];  // Explict cast is not required here


            lastRow = MySheet.Cells.SpecialCells(Excell.XlCellType.xlCellTypeLastCell).Row;
        }



       TempOpration AssignTempOperation(TempOpration _TempOpration)
        {
            try
            {
        
                return _TempOpration;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return null;

            }
        }

       GenaricRepository<OperationPool> _OperationRepository = new GenaricRepository<OperationPool>(new ItrackContext());

       private List<OperationPool> GetoprationByID(string ID)
       {
           try
           {
               return _OperationRepository.GetAll().Where(u => u.OperationPoolID == ID).ToList();


           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return null;

           }

       }


        /// <summary>
        /// taking opration pool details from selected excel file 
        /// </summary>
        TempOpration _TempOpration = new TempOpration();
        public  BindingList<OperationPool> ReadMyExcel(DevExpress.XtraEditors.ProgressBarControl bar )
        {
            
            TempOpration t = new TempOpration();
            bar.Show();
            bar.Properties.Maximum = lastRow;
            bar.Properties.Step = 1;
            oprationList.Clear();
            // EmpList.Clear();
            for (int index = 5; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "G" + index.ToString()).Cells.Value;

                string opration = "";
                string _OprationName = "";
                string _MachineType = "None";
                string _SMVtype = "none";
                string _SMV = "";
                string _PartName = "None";
                string _OprationRole = "None";
                string _OprationGrade = "None";
                bool _hasData = false;
                
                if (MySheet.Cells[index, 1].Value != null) {
                    opration = (string)(MySheet.Cells[index, 1].Value.ToString());
                    t.OprationID = opration;
                    _hasData = true;
                   // Debug.WriteLine(opration);

                }
               

              

                if (MySheet.Cells[index, 2].Value != null)
                {
                    _OprationName = (string)(MySheet.Cells[index, 2].Value.ToString());
                    t.OparationName = _OprationName;
                    if (MySheet.Cells[index, 1].Value != null)
                    {

                    }
                    else {
                        t.PartName = t.OparationName;
                       
                    }
                   

                }

             if (MySheet.Cells[index, 3].Value != null)
                {
                    _MachineType = (string)(MySheet.Cells[index, 3].Value.ToString());
                    t.MachineType = _MachineType;
                   // Debug.WriteLine(opration);

                }

            if (MySheet.Cells[index, 4].Value != null)
                {
                    _SMVtype = (string)(MySheet.Cells[index, 4].Value.ToString());
                    t.SMVType = _SMVtype;
                   // D ebug.WriteLine(opration);

                }

            if (MySheet.Cells[index, 6].Value != null)
                {
                    _SMV = (string)(MySheet.Cells[index, 6].Value.ToString());
                    _SMVtype = "M/C";


                    try {
                        t.SMV = Convert.ToDouble(_SMV);
                        t.SMVType = _SMVtype;
                    }
                catch(Exception ex){
                    t.SMV = 0;
                    t.SMVType = _SMVtype;
                }
                 
                   // D ebug.WriteLine(opration);

                }


                 if (MySheet.Cells[index, 7].Value != null)
                {
                    _SMV = (string)(MySheet.Cells[index, 7].Value.ToString());
                    _SMVtype = "M/A";

                    try {
                        t.SMV = Convert.ToDouble(_SMV);
                        t.SMVType = _SMVtype;
                    }
                     catch(Exception ex){
                         t.SMV = 0;
                         t.SMVType = _SMVtype;
                     }
                
                   // D ebug.WriteLine(opration);

                }

                 if (MySheet.Cells[index, 8].Value != null)
                 {
                     _OprationRole = (string)(MySheet.Cells[index, 8].Value.ToString());
                     t.OprationRole = _OprationRole;
                     // D ebug.WriteLine(opration);

                 }
                 else {
                     t.OprationRole ="None";
                 }

                 if (MySheet.Cells[index, 9].Value != null)
                 {
                     _OprationGrade = (string)(MySheet.Cells[index, 9].Value.ToString());
                     t.OprationGrade = _OprationGrade;
                     // D ebug.WriteLine(opration);

                 }
                 else {
                     t.OprationGrade = "None";
                 }

                 GenaricRepository<TempOpration> _TempOprationRepository = new GenaricRepository<TempOpration>(new ItrackContext());
               
                bar.PerformStep();
               
                if (_hasData == true && GetoprationByID(t.OprationID).Count == 0)
                {

                    
                    _TempOprationRepository.Insert(t);
                }

                //oprationList.Add(new OperationPool
                // {

                //     OperationPoolID = MyValues.GetValue(1, 1).ToString(),
                //     OpationName = MyValues.GetValue(1, 2).ToString(),
                //     MachineType = MyValues.GetValue(1, 3).ToString(),
                //     SMVType = MyValues.GetValue(1, 4).ToString(),
                //     SMV = Convert.ToDouble(MyValues.GetValue(1, 4).ToString())
                // });


                                        

                
            }

            bar.Hide();
            
            return oprationList;
        }

     
        public delegate void UpdateTextCallback(string text);
        public async Task<bool> DoDividingPlanReading()
        {
            await Task.Run(() =>
            {
               ReadDevidingPlan();
            });

            return true;
        }

        public static async Task<bool> ReadDevidingPlan() {

            try {

                DividingPlanTemp temp = new DividingPlanTemp();
                bool _hasData= false;


                if (MySheet.Cells[4, 2].Value != null)
                {
                    temp.StyleID = (string)(MySheet.Cells[4, 2].Value.ToString());

                    _hasData = true;
                    // Debug.WriteLine(opration);

                }

                if (MySheet.Cells[4, 4].Value != null)
                {
                    temp.LineNo = (string)(MySheet.Cells[4, 4].Value.ToString());

                    _hasData = true;
                    // Debug.WriteLine(opration);

                }


                if (MySheet.Cells[5, 6].Value != null)
                {
                    temp.Target = (string)(MySheet.Cells[5, 6].Value.ToString());

                    _hasData = true;
                  

                }

                if (MySheet.Cells[4, 6].Value != null)
                {
                    string i = (string)(MySheet.Cells[4, 6].Value.ToString());
                    temp.TotalEmployee = i;

                
                    // Debug.WriteLine(opration);

                }
 
                if (MySheet.Cells[6, 6].Value != null)
                {
                    temp.ProductionPerHour = (string)(MySheet.Cells[6, 6].Value.ToString());

                    _hasData = true;
                    // Debug.WriteLine(opration);

                }

                for (int index = 9; index <= lastRow; index++)
                {

                    if (MySheet.Cells[index, 1].Value != null)
                    {
                        temp.OprationNo = (string)(MySheet.Cells[index, 1].Value.ToString());

                        _hasData = true;
                        // Debug.WriteLine(opration);

                    }
                    else {
                        temp.OprationNo = "";
                        _hasData = false;
                    }

                    if (MySheet.Cells[index, 2].Value != null)
                    {
                        temp.OprationName = (string)(MySheet.Cells[index, 2].Value.ToString());


                        // Debug.WriteLine(opration);

                    }
                    else {
                        temp.OprationName = "";
                    }



                    if (MySheet.Cells[index, 3].Value != null)
                    {
                        temp.MachineType = (string)(MySheet.Cells[index, 3].Value.ToString());


                        // Debug.WriteLine(opration);

                    }
                    else {

                        temp.MachineType = "";
                    }

                    if (MySheet.Cells[index, 4].Value != null)
                    {
                        temp.SMV = (string)(MySheet.Cells[index, 4].Value.ToString());
                        temp.SMVType = "M/C";


                        try
                        {
                            temp.SMV = temp.SMV;
                            temp.SMVType = temp.SMVType;
                        }
                        catch (Exception ex)
                        {
                            temp.SMV = "0";
                            temp.SMVType = temp.SMVType;
                        }

                        // D ebug.WriteLine(opration);

                    }


                    if (MySheet.Cells[index, 5].Value != null)
                    {
                        temp.SMV = (string)(MySheet.Cells[index, 5].Value.ToString());
                        temp.SMVType = "M/A";
                          temp.MachineType ="None";

                        try
                        {
                            temp.SMV = temp.SMV;
                            temp.SMVType = temp.SMVType;
                        }
                        catch (Exception ex)
                        {
                            temp.SMV = "0";
                            temp.SMVType = temp.SMVType;
                        }

                        // D ebug.WriteLine(opration);

                    }
                    GenaricRepository<DividingPlanTemp> _DevidingPlanRepository = new GenaricRepository<DividingPlanTemp>(new ItrackContext());
               
                    if (_hasData) {
                        _DevidingPlanRepository.Insert(temp);
                        Debug.WriteLine(temp.OprationNo + " | " + temp.OprationName + " | " + temp.MachineType + " | " + temp.SMVType + " | " + temp.SMV);
               
                    }
                  
                  
                }

                return true;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return false;
            }
        } 

        public static void CloseExcel()
        {
            MyBook.Saved = true;
            MyApp.Quit();

        }
        
    }
    
}
