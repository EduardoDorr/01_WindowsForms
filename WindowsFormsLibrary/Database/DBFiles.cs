using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsLibrary.Database {
  public class DBFiles {
    public string _Dir { get; set; }

    public bool status;
    public string message;

    public DBFiles(string dir) {
      status = true;

      try {
        if (!Directory.Exists(dir)) {
          Directory.CreateDirectory(dir);
        }

        _Dir = dir;
        status = true;
        message = "Conexão com Banco de Dados criada com sucesso!";
      }
      catch (Exception ex) {
        status = false;
        message = "Conexão com Banco de Dados falhou: " + ex.Message;
      }      
    }

    public void Add(string id, string jsonUnit) {
      status = true;

      if (File.Exists(_Dir + "\\" + id + ".json")) {
        status = false;
        message = "Inclusão não permitida! ID já existe: " + id;
      }
      else {
        try {
          File.WriteAllText(_Dir + "\\" + id + ".json", jsonUnit);
          status = true;
          message = "Usuário cadastrado na base de dados! ID: " + id;
        }
        catch (Exception ex) {
          status = false;
          message = "Inclusão não permitida: " + ex.Message;
        }
      }
    }

    public string Search(string id) {
      status = true;

      try {
        if (!(File.Exists(_Dir + "\\" + id + ".json"))) {
          status = false;
          message = "Usuário não cadastrado! ID não existe: " + id;
        }
        else {
          string user  = File.ReadAllText(_Dir + "\\" + id + ".json");
          status = true;
          message = "Usuário recuperado da base de dados! ID: " + id;

          return user;
        }
      }
      catch (Exception ex) {
        status = false;
        message = "Valor do código não permitido: " + ex.Message;
      }

      return "";
    }

    public List<string> SearchAll() {
      status = true;
      List<string> list = new List<string>();

      try {
        var files = Directory.GetFiles(_Dir, "*.json");

        if (files.Length < 1) {
          status = false;
          message = "Base de dados está vazia! Não há clientes cadastrados!";

          return null;
        }

        for (int i = 0; i < files.Length; i++) {
          string user = File.ReadAllText(files[i]);
          list.Add(user);
        }
      }
      catch (Exception ex) {
        status = false;
        message = "Erro ao popular a lista: " + ex.Message;
      }

      return list;
    }

    public void Clear(string id) {
      status = true;

      try {
        if (!File.Exists(_Dir + "\\" + id + ".json")) {
          status = false;
          message = "Usuário não cadastrado! ID não existe: " + id;
        }
        else {
          File.Delete(_Dir + "\\" + id + ".json");
          status = true;
          message = "Usuário excluído da base de dados! ID: " + id;
        }
      }
      catch (Exception ex) {
        status = false;
        message = "Valor do código não permitido: " + ex.Message;
      }
    }

    public void Edit(string id, string jsonUnit) {
      status = true;

      if (!(File.Exists(_Dir + "\\" + id + ".json"))) {
        status = false;
        message = "Alteração não permitida! ID não existe: " + id;
      }
      else {
        try {
          File.Delete(_Dir + "\\" + id + ".json");
          File.WriteAllText(_Dir + "\\" + id + ".json", jsonUnit);
          status = true;
          message = "Usuário alterado na base de dados! ID: " + id;
        }
        catch (Exception ex) {
          status = false;
          message = "Alteração não permitida: " + ex.Message;
        }
      }
    }
  }
}
