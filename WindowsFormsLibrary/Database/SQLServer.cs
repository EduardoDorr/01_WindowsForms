using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WindowsFormsLibrary.Database {
  public class SQLServer {
    public string StringConn { get; set; }
    public SqlConnection ConnDB { get; set; }

    public SQLServer() {
      try {
        //_StringConn = "Data Source=EDUARDO-PC;Initial Catalog=ByteBank;Persist Security Info=True;User ID=sa;Password=admin123";
        StringConn = ConfigurationManager.ConnectionStrings["SQLDB"].ConnectionString;
        ConnDB = new SqlConnection(StringConn);
        ConnDB.Open();
      }
      catch (Exception ex) {

        throw new Exception(ex.Message);
      }
    }

    public string SQLCommand(string SQL) {
      try {
        var myCommand = new SqlCommand(SQL, ConnDB);
        myCommand.CommandTimeout = 0;
        var myReader = myCommand.ExecuteReader();

        return "";
      }
      catch (Exception ex) {

        throw new Exception(ex.Message);
      }
    }

    public DataTable SQLQuery(string SQL) {
      DataTable dt = new DataTable();
      try {
        var myCommand = new SqlCommand(SQL, ConnDB);
        myCommand.CommandTimeout = 0;
        var myReader = myCommand.ExecuteReader();

        dt.Load(myReader);

        return dt;
      }
      catch (Exception ex) {

        throw new Exception(ex.Message);
      }
    }

    public void SQLClose() {
      ConnDB.Close();
    }
  }
}
