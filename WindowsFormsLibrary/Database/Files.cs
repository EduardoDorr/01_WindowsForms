using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsLibrary.Database {
  public class Files {
    public string Dir { get; set; }
    public bool Status { get; set; }
    public string Message { get; set; }

    public Files(string dir) {
      Status = true;

      try {
        if (!Directory.Exists(dir)) {
          Directory.CreateDirectory(dir);
        }

        Dir = dir;
        Status = true;
        Message = "Conexão com Banco de Dados criada com sucesso!";
      }
      catch (Exception ex) {
        Status = false;
        Message = "Conexão com Banco de Dados falhou: " + ex.Message;
      }      
    }

    public void Add(string id, string jsonUnit) {
      Status = true;

      if (File.Exists(Dir + "\\" + id + ".json")) {
        Status = false;
        Message = "Inclusão não permitida! ID já existe: " + id;
      }
      else {
        try {
          File.WriteAllText(Dir + "\\" + id + ".json", jsonUnit);
          Status = true;
          Message = "Usuário cadastrado na base de dados! ID: " + id;
        }
        catch (Exception ex) {
          Status = false;
          Message = "Inclusão não permitida: " + ex.Message;
        }
      }
    }

    public string Search(string id) {
      Status = true;

      try {
        if (!(File.Exists(Dir + "\\" + id + ".json"))) {
          Status = false;
          Message = "Usuário não cadastrado! ID não existe: " + id;
        }
        else {
          string user  = File.ReadAllText(Dir + "\\" + id + ".json");
          Status = true;
          Message = "Usuário recuperado da base de dados! ID: " + id;

          return user;
        }
      }
      catch (Exception ex) {
        Status = false;
        Message = "Valor do código não permitido: " + ex.Message;
      }

      return "";
    }

    public List<string> SearchAll() {
      Status = true;
      List<string> list = new List<string>();

      try {
        var files = Directory.GetFiles(Dir, "*.json");

        if (files.Length < 1) {
          Status = false;
          Message = "Base de dados está vazia! Não há clientes cadastrados!";

          return null;
        }

        for (int i = 0; i < files.Length; i++) {
          string user = File.ReadAllText(files[i]);
          list.Add(user);
        }
      }
      catch (Exception ex) {
        Status = false;
        Message = "Erro ao popular a lista: " + ex.Message;
      }

      return list;
    }

    public void Clear(string id) {
      Status = true;

      try {
        if (!File.Exists(Dir + "\\" + id + ".json")) {
          Status = false;
          Message = "Usuário não cadastrado! ID não existe: " + id;
        }
        else {
          File.Delete(Dir + "\\" + id + ".json");
          Status = true;
          Message = "Usuário excluído da base de dados! ID: " + id;
        }
      }
      catch (Exception ex) {
        Status = false;
        Message = "Valor do código não permitido: " + ex.Message;
      }
    }

    public void Edit(string id, string jsonUnit) {
      Status = true;

      if (!(File.Exists(Dir + "\\" + id + ".json"))) {
        Status = false;
        Message = "Alteração não permitida! ID não existe: " + id;
      }
      else {
        try {
          File.Delete(Dir + "\\" + id + ".json");
          File.WriteAllText(Dir + "\\" + id + ".json", jsonUnit);
          Status = true;
          Message = "Usuário alterado na base de dados! ID: " + id;
        }
        catch (Exception ex) {
          Status = false;
          Message = "Alteração não permitida: " + ex.Message;
        }
      }
    }
  }
}
