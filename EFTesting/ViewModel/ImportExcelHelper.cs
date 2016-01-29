using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.ViewModel
{
public  class ImportExcelHelper
    {


    public DataSet GetOprationList() {
        try {

            System.Data.OleDb.OleDbConnection MyConnection;
            System.Data.DataSet DtSet;
            System.Data.OleDb.OleDbDataAdapter MyCommand;
            MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\\test.xlsx';Extended Properties=Excel 12.0;");
            MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
            MyCommand.TableMappings.Add("Table", "TestTable");
            DtSet = new System.Data.DataSet();
            MyCommand.Fill(DtSet);
            return DtSet;
        }
        catch(Exception ex){
            Debug.WriteLine(ex.Message);
            return null;
        }
    }





    public  DataTable UploadExcelSheet(string fileName)
    {
        DataTable uploadDataTable;
        using (OleDbConnection objXConn = new OleDbConnection())
        {
            objXConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName +
                                            ";Extended Properties=\"Excel 12.0;IMEX=1\"";

            objXConn.Open();

            OleDbCommand objCommand =
                new OleDbCommand("SELECT * FROM Template$ ", objXConn);
            OleDbDataAdapter objDataAdapter = new OleDbDataAdapter();

            // retrieve the Select command for the Spreadsheet
            objDataAdapter.SelectCommand = objCommand;

            // Create a DataSet
            DataSet objDataSet = new DataSet();

            // Populate the DataSet with the spreadsheet worksheet data
            objDataAdapter.Fill(objDataSet);
            uploadDataTable = objDataSet.Tables[0];
        }

        return uploadDataTable;
    }


    }
}
