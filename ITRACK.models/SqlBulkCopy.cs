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
using ITRACK.DBConfiguration;

namespace ITRACK.models
{
   public class SqlBulkCopyHelper
    {

       private string GetConnection()
       {
           try
           {
               ConnectionDetails Con = new ConnectionDetails();
               return Con.readConnection();
           }
           catch (Exception ex)
           {
               return "";
           }

       }

       /// <summary>
       /// Bulk Copy opration Using SqlBulk Copy
       /// </summary>
       /// <param 
       /// name="tbl"></param>
       public  void PerformBulkCopy(DataTable tbl)
       {

           try {
               string csDestination = GetConnection();

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
           table.Columns.Add("[LineNo]", typeof(string));
           table.Columns.Add("StyleNo", typeof(string));
           table.Columns.Add("OprationNO", typeof(string));
           table.Columns.Add("OparationName", typeof(string));
           table.Columns.Add("OprationGrade", typeof(string));
           table.Columns.Add("OprationRole", typeof(string));
           table.Columns.Add("PartName", typeof(string));
           table.Columns.Add("isOparationComplete", typeof(string));
           table.Columns.Add("OprationComplteAt", typeof(string));
           table.Columns.Add("EmployeeID", typeof(string));
           table.Columns.Add("BundleDetailsID", typeof(string));
           table.Columns.Add("OperationPoolID", typeof(string));
           table.Columns.Add("HourNo", typeof(string));
           table.Columns.Add("WorkstationNo", typeof(int));
           table.Columns.Add("OpNo", typeof(int));
          
           foreach (var item in data)
           {
               
               Debug.WriteLine(item.OprationBarcodesID);
              table.Rows.Add(item.OprationBarcodesID, item.LineNo,item.StyleNo,item.OprationNO, item.OparationName, item.OprationGrade,item.OprationRole,item.PartName,item.isOparationComplete,item.OprationComplteAt,item.EmployeeID,item.BundleDetailsID,item.OperationPoolID,item.HourNo,item.WorkstationNo,item.OpNo);
         
           } 
           return table;
       }
    }




    }

