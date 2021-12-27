using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsLibrary.Database {
  public class LocalDB {
    public string StringConn { get; set; }
    public SqlConnection ConnDB { get; set; }

    public LocalDB() {
      try {
        StringConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\WindowsForms\\WindowsFormsLibrary\\Database\\DataFile.mdf;Integrated Security=True";
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
