using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.Reports
{
   public class OprationBarcodeList
    {

        public string  CutTicketNo { get; set; }

        public string StyleNo { get; set; }

        public string  PoNo { get; set; }

        public string  Color { get; set; }
          
        public string Size { get; set; }

        public string BundleNo { get; set; }
       
       public string PartName { get; set; }

        public string NoOfPts { get; set; }

        public string OprationNo { get; set; }

        public string OprationName { get; set; }

      public string OprationNo2 { get; set; }

        public string OprationName2 { get; set; }
        public string OprationType { get; set; }

        public string OpRole { get; set; }

        public string Barcode { get; set; }

       public string Barcode2 { get; set; }

        public string  CutNo { get; set; }

       public OprationBarcodeList(){}


      public  OprationBarcodeList(
          string _CutTicketNo,
          string _styleNo,
          string _PoNo,
          string _Color,
          string _size,
          string _BundleNo,
          string _partName,
          string _noPcs,
          string _OprationNo,
          string _OprationName,
          string _OprationType,
          string _OpRole,
          string _barcode,
          string _cutNo,
          string _barcode2,
          string _oprationNo2,
          string _oprationName2

          
          ) {
              this.CutTicketNo = _CutTicketNo;
              this.StyleNo = _styleNo;
              this.PoNo = _PoNo;
              this.Color = _Color;
              this.Size = _size;
              this.BundleNo = _BundleNo;
              this.PartName = _partName;
              this.NoOfPts = _noPcs;
              this.OprationNo = _OprationNo;
              this.OprationName = _OprationName;
              this.OprationType = _OprationType;
              this.OpRole = _OpRole;
              this.Barcode = _barcode;
              this.CutNo = _cutNo;
              this.Barcode2 = _barcode2;
              this.OprationName2 = _oprationName2;
              this.OprationNo2 = _oprationNo2;

          
          
        }


      List<OprationBarcodeList> lstBarcodes = new List<OprationBarcodeList>();
      private bool _isNewRow = false;
      private bool _isBreackRequired = false;

      public List<OprationBarcodeList> BarcodeList(int _key) {

          try {

              GenaricRepository<OprationBarcodes> _OprationBarcodesRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());

              var barcodes = from item in _OprationBarcodesRepository.GetAll().ToList()  where item.BundleDetails.BundleHeader.CuttingItemID == _key orderby item.OprationBarcodesID select item;
              int i = 0 ;
              OprationBarcodeList oList = new OprationBarcodeList();
              
              foreach (var barcode in barcodes) {
                
                  
                  if (_isNewRow == true) {
                      i = 0;
                   
                  }
                  if (i == 0) {

                      // left side of sticker 
                      oList.CutTicketNo = barcode.BundleDetails.BundleHeader.CuttingItem.CuttingHeaderID;
                      oList.StyleNo = barcode.BundleDetails.BundleHeader.CuttingItem.CuttingHeader.StyleID;
                      oList.StyleNo = barcode.BundleDetails.BundleHeader.CuttingItem.CuttingHeader.StyleID;
                      oList.Color = barcode.BundleDetails.BundleHeader.CuttingItem.Color;
                      oList.Size = barcode.BundleDetails.BundleHeader.CuttingItem.Size;
                      oList.BundleNo = Convert.ToString(barcode.BundleDetails.BundleDetailsID);
                      oList.PartName = barcode.PartName;
                      oList.NoOfPts = Convert.ToString(barcode.BundleDetails.NoOfItem);
                      oList.OprationNo = barcode.OprationNO;
                      oList.OprationName = barcode.OparationName;
                      oList.OprationType = barcode.OprationGrade;
                      oList.OpRole = barcode.OprationRole;
                      oList.Barcode = barcode.OprationBarcodesID;
                      _isNewRow = false;
                  
                  }
              
                  //right slide of sheet 
                 if (i != 0)
                 {

                                 if (barcode.PartName != oList.PartName)
                                 {
                                     // if part not same 
                                     oList.Barcode2 = "";
                                     oList.OprationNo2 = "";
                                     oList.OprationName2 = "";

                                     _isBreackRequired = true;


                                     lstBarcodes.Add(new OprationBarcodeList(
                                             oList.CutTicketNo,
                                             oList.StyleNo,
                                             oList.StyleNo,
                                             oList.Color,
                                             oList.Size,
                                             oList.BundleNo,
                                             oList.PartName,
                                             oList.NoOfPts,
                                             oList.OprationNo,
                                             oList.OprationName,
                                             oList.OprationType,
                                             barcode.OprationRole,
                                              "*" + oList.Barcode + "*",
                                             "",
                                             oList.Barcode2,
                                             oList.OprationNo2,
                                             oList.OprationName2

                                         ));






                                     //assign as left side of new part 

                                     // left side of sticker 
                                     oList.CutTicketNo = barcode.BundleDetails.BundleHeader.CuttingItem.CuttingHeaderID;
                                     oList.StyleNo = barcode.BundleDetails.BundleHeader.CuttingItem.CuttingHeader.StyleID;
                                     oList.StyleNo = barcode.BundleDetails.BundleHeader.CuttingItem.CuttingHeader.StyleID;
                                     oList.Color = barcode.BundleDetails.BundleHeader.CuttingItem.Color;
                                     oList.Size = barcode.BundleDetails.BundleHeader.CuttingItem.Size;
                                     oList.BundleNo = Convert.ToString(barcode.BundleDetails.BundleDetailsID);
                                     oList.PartName = barcode.PartName;
                                     oList.NoOfPts = Convert.ToString(barcode.BundleDetails.NoOfItem);
                                     oList.OprationNo = barcode.OprationNO;
                                     oList.OprationName = barcode.OparationName;
                                     oList.OprationType = barcode.OprationGrade;
                                     oList.OpRole = barcode.OprationRole;
                                     oList.Barcode = "*" + barcode.OprationBarcodesID + "*";




                                 }
                                 else
                                 {

                                                     // if part same 
                                                     oList.Barcode2 = "*" + barcode.OprationBarcodesID + "*";
                                                     oList.OprationNo2 = barcode.OprationNO;
                                                     oList.OprationName2 = barcode.OparationName;
                                                     lstBarcodes.Add(new OprationBarcodeList(
                                                oList.CutTicketNo,
                                                oList.StyleNo,
                                                oList.StyleNo,
                                                oList.Color,
                                                oList.Size,
                                                oList.BundleNo,
                                                oList.PartName,
                                                oList.NoOfPts,
                                                oList.OprationNo,
                                                oList.OprationName,
                                                oList.OprationType,
                                                barcode.OprationRole,
                                                "*" + oList.Barcode + "*",
                                                "",
                                                oList.Barcode2,
                                                oList.OprationNo2,
                                                oList.OprationName2

                                            ));

                                                     _isNewRow = true;

                                 }
                  


                    

                   
                    
                 }

                 i = 1;
             

                  
                  /*

                  lstBarcodes.Add(new OprationBarcodeList( 
                      barcode.BundleDetails.BundleHeader.CuttingItem.CuttingHeaderID,
                      barcode.BundleDetails.BundleHeader.CuttingItem.CuttingHeader.StyleID,
                      barcode.BundleDetails.BundleHeader.CuttingItem.CuttingHeader.StyleID,
                      barcode.BundleDetails.BundleHeader.CuttingItem.Color,
                      barcode.BundleDetails.BundleHeader.CuttingItem.Size,
                      Convert.ToString( barcode.BundleDetails.BundleDetailsID),
                      barcode.PartName,
                      Convert.ToString( barcode.BundleDetails.NoOfItem),
                      barcode.OprationNO,
                      barcode.OparationName,
                      barcode.OprationGrade,
                      barcode.OprationRole,
                      "*"+barcode.OprationBarcodesID+"*",


                  )); */
              }


              return lstBarcodes;
          }
          catch(Exception ex){

              Debug.WriteLine(ex.Message);
              return null;
          }
      }

    }
}
