using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsLibrary.Database {
  public class DBFiles {
    public string _Dir { get; set; }

    public bool status = true;
    public string message;

    public DBFiles(string dir) {
      try {
        if (!Directory.Exists(dir)) {
          Directory.CreateDirectory(dir);
        }

        _Dir = dir;
        status = true;
        message = "Conexão com Banco de Dados criada com sucesso!";
      }
      catch (NullReferenceException ex) {
        status = false;
        message = "Conexão com Banco de Dados falhou: " + ex.Message;
      }      
    }
  }
}
