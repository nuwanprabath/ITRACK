using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.ComponentModel;
using System.Diagnostics;

namespace ITRACK.models
{
   public class SqlBulkCopyHelper
    {

       /// <summary>
       /// Bulk Copy opration Using SqlBulk Copy
       /// </summary>
       /// <param name="tbl"></param>
       public  void PerformBulkCopy(DataTable tbl)
       {

           try {
               string csDestination = @"Data Source=HP_G6\LOCALDB;Initial Catalog=ITRACKERPV;Integrated Security=True";

               using (SqlConnection destinationConnection = new SqlConnection(csDestination))
               using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
               {
                   destinationConnection.Open();
           
                   bulkCopy.DestinationTableName = "OprationBarcodes";
                   bulkCopy.WriteToServer(tbl);
                   destinationConnection.Close();
               }
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
           }
        
              
          
       }

       /// <summary>
       /// create datatable related to object list 
       /// </summary>
       /// <param name="data"></param>
       /// <returns></returns>
        public  DataTable ConvertTagsToDatatable(List<OprationBarcodes> data)
       {
         
           DataTable table = new DataTable();

           table.Columns.Add("OprationBarcodesID",typeof(string));
           table.Columns.Add("OprationNO", typeof(string));
           table.Columns.Add("OparationName", typeof(string));
           table.Columns.Add("OprationGrade", typeof(string));
           table.Columns.Add("OprationRole", typeof(string));
           table.Columns.Add("PartName", typeof(string));
           table.Columns.Add("isOparationComplete", typeof(string));
           table.Columns.Add("OprationComplteAt", typeof(string));
           table.Columns.Add("EmployeeID", typeof(string));
           table.Columns.Add("BundleDetailsID", typeof(string));
          
           foreach (var item in data)
           {
               
               Debug.WriteLine(item.OprationBarcodesID);
              table.Rows.Add(item.OprationBarcodesID, item.OprationNO, item.OparationName, item.OprationGrade,item.OprationRole,item.PartName,item.isOparationComplete,item.OprationComplteAt,item.EmployeeID,item.BundleDetailsID);
         
           } 
           return table;
       }
    }




    }

