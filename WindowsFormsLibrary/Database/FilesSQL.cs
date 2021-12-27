using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLibrary.Database {
  public class FilesSQL {
    public bool Status { get; set; }
    public string Message { get; set; }
    public string Table { get; set; }
    public SQLServer DB { get; set; }

    public FilesSQL(string table) {
      Status = true;

      try {
        DB = new SQLServer();
        Table = table;
        Message = "Conexão com a tabela criada com sucesso";
      }
      catch (Exception ex) {
        Status = false;
        Message = "Conexão com a tabela falhou" + ex.Message;
      }
    }

    public void Add(string id, string jsonUnit) {
      Status = true;

      try {
        // INSERT INTO {CLIENTE} (ID, JSON) VALUES ('{ID VALUE}', '{JSON}')
        var sql = $"INSERT INTO {Table} (ID, JSON) VALUES ('{id}', '{jsonUnit}')";
        DB.SQLCommand(sql);
        Status = true;
        Message = $"Cliente cadastrado com sucesso! ID: {id}";
      }
      catch (Exception ex) {
        Status = false;
        Message = $"Inclusão não permitida: {ex.Message}";
      }
    }

    public string Search(string id) {
      Status = true;

      try {
        // SELECT ID, JSON FROM {CLIENTE} WHERE ID = '{ID VALUE}'
        var sql = $"SELECT ID, JSON FROM {Table} WHERE ID = '{id}'";
        var dt = DB.SQLQuery(sql);

        if (dt.Rows.Count > 0) {
          string content = dt.Rows[0]["JSON"].ToString();
          Status = true;
          Message = $"Cliente recuperado da base de dados! ID: {id}";

          return content;
        }
        else {
          Status = false;
          Message = $"cliente não cadastrado! ID não existe: {id}";
        }
      }
      catch (Exception ex) {
        Status = false;
        Message = $"Erro ao buscar o cliente na base de dados: {ex.Message}";
      }

      return "";
    }

    public List<string> SearchAll() {
      Status = true;
      List<string> listComplete = new List<string>();

      try {
        // SELECT ID, JSON FROM {CLIENTE}
        var sql = $"SELECT ID, JSON FROM {Table}";
        var dt = DB.SQLQuery(sql);

        if (dt.Rows.Count > 0) {
          for (int i = 0; i < dt.Rows.Count; i++) {
            string content = dt.Rows[i]["JSON"].ToString();
            listComplete.Add(content);
          }
          Status = true;
          Message = "Lista populada com sucesso!";
        }
        else {
          Status = false;
          Message = "Base de dados está vazia! Não há clientes cadastrados!";
        }
      }
      catch (Exception ex) {
        Status = false;
        Message = "Erro ao popular a lista: " + ex.Message;
      }

      return listComplete;
    }

    public void Clear(string id) {
      Status = true;

      try {
        // SELECT ID, JSON FROM CLIENTE WHERE ID = '{ID VALUE}'
        var sql = $"SELECT ID, JSON FROM {Table} WHERE ID = '{id}'";
        var dt = DB.SQLQuery(sql);

        if (dt.Rows.Count > 0) {
          // DELETE FROM CLIENTE WHERE ID = '{ID VALUE}'
          sql = $"DELETE FROM {Table} WHERE ID = '{id}'";
          DB.SQLCommand(sql);
          Status = true;
          Message = $"Cliente excluído com sucesso! ID: {id}";
        }
        else {
          Status = false;
          Message = $"Cliente não cadastrado! ID não existe: {id}";
        }
      }
      catch (Exception ex) {
        Status = false;
        Message = $"Erro ao excluir o cliente na base de dados: {ex.Message}";
      }
    }

    public void Edit(string id, string jsonUnit) {
      Status = true;

      try {
        // SELECT ID, JSON FROM {CLIENTE} WHERE ID = '{ID VALUE}'
        var sql = $"SELECT ID, JSON FROM {Table} WHERE ID = '{id}'";
        var dt = DB.SQLQuery(sql);

        if (dt.Rows.Count > 0) {
          // UPDATE {CLIENTE} SET JSON = '{JSON}' WHERE ID = '{ID VALUE}'
          sql = $"UPDATE {Table} SET JSON = '{jsonUnit}' WHERE ID = '{id}'";
          DB.SQLCommand(sql);
          Status = true;
          Message = $"Cliente alterado com sucesso! ID: {id}";
        }
        else {
          Status = false;
          Message = $"Cliente não cadastrado! ID não existe: {id}";
        }
      }
      catch (Exception ex) {
        Status = false;
        Message = "Alteração não permitida: " + ex.Message;
      }
    }
  }
}
