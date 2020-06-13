using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Laxmi.TestAutomation.Framework
{
    public class ExcelDataReader
    {
        public static string GetExcelConnectionString()
        {
            string connectionString = "";
            var xlFilePath = ConfigurationManager.AppSettings["TestDataExcelPath"];
            //var connectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", xlFilePath);
            string fileExtension = Path.GetExtension(xlFilePath);
            if (fileExtension == ".xls")
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + xlFilePath + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
            if (fileExtension == ".xlsx")
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + xlFilePath + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
            return connectionString;
        }

        public static DataTable ReadExcelData(string queryString)
        {
            using (var connection = new OleDbConnection())
            {

                connection.ConnectionString = GetExcelConnectionString();
                connection.Open();
                //var query = string.Format("select * from [Prices$] where key='{0}'", keyName);
                DataTable dataTable = new DataTable();
                
                using (OleDbCommand oleDbCommand = new OleDbCommand())
                {
                    oleDbCommand.CommandText = queryString;// "Select * from [Prices$]";
                    oleDbCommand.Connection = connection;
                    using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
                    {
                        dataAdapter.SelectCommand = oleDbCommand;
                        dataAdapter.Fill(dataTable);
                        //return dataTable;
                    }
                }

                //var value = connection.Query<UserData>(query).FirstOrDefault();
                connection.Close();
                return dataTable;
            }
        }
    }
}
