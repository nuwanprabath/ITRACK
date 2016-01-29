using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.Reports
{
   public class clsProductionSummary
    {
        public int LineNo { get; set; }

        public string StyleNo { get; set; }

        public int LineInput { get; set; }

        public int LineOut { get; set; }

        public int CutQty { get; set; }

        public int WharehouseIn { get; set; }

        public int WharehouseOut { get; set; }


    



      public  clsProductionSummary() { }

      public  clsProductionSummary(
            string _styleNo,
            int _LineIn,
            int _LineOut,
            int _CutQty,
            int _WhIn,
            int _WhOut

            
            ) {

                this.StyleNo = _styleNo;
                this.LineInput = _LineIn;
                this.LineNo = _LineOut;
                this.CutQty = _CutQty;
                this.WharehouseIn = _WhIn;
                this.WharehouseOut = _WhOut;
        }


    //  List<clsProductionSummary> lstSummary = new List<clsProductionSummary>();
   //   clsProductionSummary _summary = new clsProductionSummary();
       public bool GetInputCount()
       {
           try {

               GenaricRepository<OprationBarcodes> _BarcodeEditRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
               var itemList = from items in _BarcodeEditRepository.GetAll().ToList() where items.OprationRole == "In" && items.isOparationComplete == true group items by items.OprationComplteAt.Date into ItemG select new { Date = Convert.ToDateTime(ItemG.Key.ToString("dd-MM-yyyy")), Count = ItemG.Sum(c => c.BundleDetails.NoOfItem) };

               foreach (var item in itemList) {

                   Debug.WriteLine(item.Date + "  " + item.Count + "  " , "");
                   
                 //  lstSummary.Add(_summary);
               
               }
               return true;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return false;
               
           }
       
       }


       public void getSampleDate(){
        
         GenaricRepository<OprationBarcodes> _BarcodeEditRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
         var itemList = from items in _BarcodeEditRepository.GetAll().ToList() where items.OprationRole == "In" && items.OprationComplteAt.Day == 04 && items.OprationComplteAt.Month == 07 && items.OprationComplteAt.Year == 2015 select items ;
             Debug.WriteLine(itemList.Count());
       }



       public int GetOutPut(string _date,string LineName)
       {
           try
           {

               GenaricRepository<OprationBarcodes> _BarcodeEditRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
               var itemList = from items in _BarcodeEditRepository.GetAll().ToList() where items.OprationRole == "Out" && items.isOparationComplete == true && items.OprationComplteAt == DateTime.ParseExact(_date, "dd-MMM-yyyy", System.Globalization.CultureInfo.InvariantCulture)  group items by items.OprationComplteAt.Date into ItemG select new { Date = ItemG.Key, OutPut = ItemG.Sum(c => c.BundleDetails.NoOfItem) };

               return Convert.ToInt16(itemList.Last().OutPut);
              
           }
           catch (Exception ex)
           {
               Debug.WriteLine(ex.Message);
               return 0;

           }

       }

       
    }
}
