using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using WindowsForms;
using Newtonsoft.Json;
using WindowsFormsLibrary.Database;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsLibrary.Classes {
  public class Client {
    public class Unit {
      [Required(ErrorMessage = "Código do cliente é obrigatório.")]
      [RegularExpression("[0-9]+", ErrorMessage = "Código do cliente deve ser numérico.")]
      [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do cliente deve ter 6 dígitos.")]
      public string ID { get; set; }

      [Required(ErrorMessage = "Nome do cliente é obrigatório.")]
      [StringLength(50, ErrorMessage = "Nome do cliente deve ter no máximo 50 caracteres.")]
      public string Name { get; set; }

      [Required(ErrorMessage = "Nome da mãe é obrigatório.")]
      [StringLength(50, ErrorMessage = "Nome da mãe deve ter no máximo 50 caracteres.")]
      public string MotherName { get; set; }

      [StringLength(50, ErrorMessage = "Nome do pai deve ter no máximo 50 caracteres.")]
      public string FatherName { get; set; }

      public int HasFather { get; set; }

      [Required(ErrorMessage = "CPF do cliente é obrigatório.")]
      [RegularExpression("[0-9]+", ErrorMessage = "CPF do cliente deve ser numérico.")]
      [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF do cliente deve ter 11 dígitos.")]
      public string CPF { get; set; }

      [Required(ErrorMessage = "RG do cliente é obrigatório.")]
      [RegularExpression("[0-9]+", ErrorMessage = "RG do cliente deve ser numérico.")]
      [StringLength(10, MinimumLength = 10, ErrorMessage = "RG do cliente deve ter 10 dígitos.")]
      public string RG { get; set; }

      [Required(ErrorMessage = "Gênero do cliente é obrigatório.")]
      public int Gender { get; set; }

      [Required(ErrorMessage = "CEP do cliente é obrigatório.")]
      [RegularExpression("[0-9]+", ErrorMessage = "CEP do cliente deve ser numérico.")]
      [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP do cliente deve ter 8 dígitos.")]
      public string CEP { get; set; }

      [Required(ErrorMessage = "Logradouro é obrigatório.")]
      [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 caracteres.")]
      public string Street { get; set; }

      [Required(ErrorMessage = "Complento é obrigatório.")]
      [StringLength(50, ErrorMessage = "Complemento deve ter no máximo 50 caracteres.")]
      public string Complement { get; set; }

      [Required(ErrorMessage = "Bairro é obrigatório.")]
      [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres.")]
      public string District { get; set; }

      [Required(ErrorMessage = "Cidade é obrigatória.")]
      [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres.")]
      public string City { get; set; }

      [Required(ErrorMessage = "Estado é obrigatório.")]
      [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 caracteres.")]
      public string State { get; set; }

      [Required(ErrorMessage = "Telefone é obrigatório.")]
      [RegularExpression("[0-9]+", ErrorMessage = "Telefone deve ser numérico.")]
      public string Phone { get; set; }

      [Required(ErrorMessage = "Renda do cliente é obrigatória.")]
      [Range(0, double.MaxValue, ErrorMessage = "Valor da Renda deve ser positivo.")]
      [RegularExpression("[0-9]+", ErrorMessage = "Renda do cliente deve ser numérico.")]
      public double Income { get; set; }

      [Required(ErrorMessage = "Profissão é obrigatória.")]
      [StringLength(50, ErrorMessage = "Profissão deve ter no máximo 50 caracteres.")]
      public string Job { get; set; }


      public void ValidateClass() {
        ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
        List<ValidationResult> results = new List<ValidationResult>();
        bool isValid = Validator.TryValidateObject(this, context, results, true);

        if (isValid == false) {
          StringBuilder sbrErrors = new StringBuilder();
          foreach (var validationResult in results) {
            sbrErrors.AppendLine(validationResult.ErrorMessage);
          }
          throw new ValidationException(sbrErrors.ToString());
        }
      }

      public void ValidateComplement() {
        if (this.FatherName == this.MotherName) {
          throw new Exception("Nome do pai e da mãe não podem ser iguais.");
        }

        if (this.HasFather == 1) {
          if (this.FatherName == "") {
            throw new Exception("Nome do pai não pode ser vazio.");
          }
        }

        var validateCPF = Utility.Valida(this.CPF);

        if (!validateCPF) {
          throw new Exception("CPF é inválido.");
        }
      }

      #region "CRUD File"
      public void AddFile(string dir) {
        string vJSON = Client.SerializedClassUnit(this);
        Files DB = new Files(dir);

        if (DB.Status) {
          DB.Add(this.ID, vJSON);

          if (DB.Status) {
            MessageBox.Show("OK: " + DB.Message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public Unit SearchFile(string id, string dir) {
        Files DB = new Files(dir);

        if (DB.Status) {
          string vJSON = DB.Search(id);

          if (DB.Status) {

            return Client.DesSerializedClassUnit(vJSON);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public void EditFile(string dir) {
        string vJSON = Client.SerializedClassUnit(this);
        Files DB = new Files(dir);

        if (DB.Status) {
          DB.Edit(this.ID, vJSON);

          if (DB.Status) {
            MessageBox.Show("OK: " + DB.Message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public void DeleteFile(string dir) {
        Files DB = new Files(dir);

        if (DB.Status) {
          DB.Clear(this.ID);

          if (DB.Status) {
            MessageBox.Show("OK: " + DB.Message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public List<List<string>> SearchAllFile(string dir) {
        Files DB = new Files(dir);

        if (DB.Status) {
          List<string> listJSON = DB.SearchAll();

          if (DB.Status) {
            var C = new Unit();
            var listComplete = new List<List<string>>();

            for (int i = 0; i < listJSON.Count; i++) {
              C = Client.DesSerializedClassUnit(listJSON[i]);
              listComplete.Add(new List<string> { C.ID, C.Name });
            }

            return listComplete;
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      #endregion

      #region "CRUD DB"
      public void AddFileDB(string table) {
        string vJSON = Client.SerializedClassUnit(this);
        FilesDB DB = new FilesDB(table);

        if (DB.Status) {
          DB.Add(this.ID, vJSON);

          if (DB.Status) {
            MessageBox.Show("OK: " + DB.Message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public Unit SearchFileDB(string id, string table) {
        FilesDB DB = new FilesDB(table);

        if (DB.Status) {
          string vJSON = DB.Search(id);

          if (DB.Status) {

            return Client.DesSerializedClassUnit(vJSON);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public void EditFileDB(string table) {
        string vJSON = Client.SerializedClassUnit(this);
        FilesDB DB = new FilesDB(table);

        if (DB.Status) {
          DB.Edit(this.ID, vJSON);

          if (DB.Status) {
            MessageBox.Show("OK: " + DB.Message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public void DeleteFileDB(string table) {
        FilesDB DB = new FilesDB(table);

        if (DB.Status) {
          DB.Clear(this.ID);

          if (DB.Status) {
            MessageBox.Show("OK: " + DB.Message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public List<List<string>> SearchAllFileDB(string table) {
        FilesDB DB = new FilesDB(table);

        if (DB.Status) {
          List<string> listJSON = DB.SearchAll();

          if (DB.Status) {
            var C = new Unit();
            var listComplete = new List<List<string>>();

            for (int i = 0; i < listJSON.Count; i++) {
              C = Client.DesSerializedClassUnit(listJSON[i]);
              listComplete.Add(new List<string> { C.ID, C.Name });
            }

            return listComplete;
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }
      #endregion

      #region "CRUD NOSQL"
      public void AddFileNOSQL(string table) {
        string vJSON = Client.SerializedClassUnit(this);
        FilesSQL DB = new FilesSQL(table);

        if (DB.Status) {
          DB.Add(this.ID, vJSON);

          if (DB.Status) {
            MessageBox.Show("OK: " + DB.Message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public Unit SearchFileNOSQL(string id, string table) {
        FilesSQL DB = new FilesSQL(table);

        if (DB.Status) {
          string vJSON = DB.Search(id);

          if (DB.Status) {

            return Client.DesSerializedClassUnit(vJSON);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public void EditFileNOSQL(string table) {
        string vJSON = Client.SerializedClassUnit(this);
        FilesSQL DB = new FilesSQL(table);

        if (DB.Status) {
          DB.Edit(this.ID, vJSON);

          if (DB.Status) {
            MessageBox.Show("OK: " + DB.Message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public void DeleteFileNOSQL(string table) {
        FilesSQL DB = new FilesSQL(table);

        if (DB.Status) {
          DB.Clear(this.ID);

          if (DB.Status) {
            MessageBox.Show("OK: " + DB.Message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }

      public List<List<string>> SearchAllFileNOSQL(string table) {
        FilesSQL DB = new FilesSQL(table);

        if (DB.Status) {
          List<string> listJSON = DB.SearchAll();

          if (DB.Status) {
            var C = new Unit();
            var listComplete = new List<List<string>>();

            for (int i = 0; i < listJSON.Count; i++) {
              C = Client.DesSerializedClassUnit(listJSON[i]);
              listComplete.Add(new List<string> { C.ID, C.Name });
            }

            return listComplete;
          }
          else {
            throw new Exception(DB.Message);
          }
        }
        else {
          throw new Exception(DB.Message);
        }
      }
      #endregion

      #region "CRUD SQL"
      public void AddFileSQL() {
        try {
          var DB = new SQLServer();
          string SQL = ToInsert();

          DB.SQLCommand(SQL);
          DB.SQLClose();
          MessageBox.Show($"Cliente cadastrado com sucesso! ID: {ID}",
                           "Mensagem",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }
        catch (Exception ex) {
          throw new Exception($"Inclusão não permitida: {ex.Message}");
        }
      }

      public Unit SearchFileSQL(string id) {
        try {
          string SQL = $"SELECT * FROM Client2 WHERE ID = '{id}'";
          var DB = new SQLServer();
          var DT = DB.SQLQuery(SQL);

          if (DT.Rows.Count == 0) {
            DB.SQLClose();
            throw new Exception($"cliente não cadastrado! ID não existe: {id}");
          }
          else {
            Unit u = DataRowToUnit(DT.Rows[0]);

            return u;
          }

        }
        catch (Exception ex) {

          throw new Exception($"Erro ao buscar o cliente na base de dados: {ex.Message}");
        }
      }

      public void EditFileSQL() {
        try {
          string SQL = $"SELECT * FROM Client2 WHERE ID = '{ID}'";
          var DB = new SQLServer();
          var DT = DB.SQLQuery(SQL);

          if (DT.Rows.Count == 0) {
            DB.SQLClose();
            throw new Exception($"cliente não cadastrado! ID não existe: {ID}");
          }
          else {
            SQL = ToUpdate(ID);
            DB.SQLCommand(SQL);
            DB.SQLClose();

            MessageBox.Show($"Cliente alterado com sucesso! ID: {ID}",
                             "Mensagem",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
          }
        }
        catch (Exception ex) {

          throw new Exception("Erro ao alterar o cliente na base de dados: " + ex.Message);
        }
      }

      public void DeleteFileSQL() {
        try {
          string SQL = $"SELECT * FROM Client2 WHERE ID = '{ID}'";
          var DB = new SQLServer();
          var DT = DB.SQLQuery(SQL);

          if (DT.Rows.Count == 0) {
            DB.SQLClose();
            throw new Exception($"cliente não cadastrado! ID não existe: {ID}");
          }
          else {
            SQL = $"DELETE FROM Client2 WHERE ID = '{ID}'";
            DB.SQLCommand(SQL);
            DB.SQLClose();

            MessageBox.Show($"Cliente excluído com sucesso! ID: {ID}",
                             "Mensagem",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
          }
        }
        catch (Exception ex) {

          throw new Exception($"Erro ao excluir o cliente na base de dados: {ex.Message}");
        }
      }

      public List<List<string>> SearchAllFileSQL() {
        List<List<string>> listComplete = new List<List<string>>();

        try {
          string SQL = "SELECT * FROM Client2";
          var DB = new SQLServer();
          var DT = DB.SQLQuery(SQL);

          if (DT.Rows.Count > 0) {
            for (int i = 0; i < DT.Rows.Count; i++) {
              listComplete.Add(new List<string> { DT.Rows[i]["ID"].ToString(), DT.Rows[i]["Name"].ToString() });
            }
          }
          else {
            throw new Exception("Base de dados está vazia! Não há clientes cadastrados!");
          }
        }
        catch (Exception ex) {

          throw new Exception($"Erro ao popular a lista: {ex.Message}");
        }

        return listComplete;
      }

        #endregion

      #region "AuxFunc"
        public string ToInsert() {
        string SQL = @"INSERT INTO Client2 
                      (ID
                      ,Name
                      ,MotherName
                      ,FatherName
                      ,HasFather
                      ,CPF
                      ,RG
                      ,Gender
                      ,CEP
                      ,Street
                      ,Complement
                      ,District
                      ,City
                      ,State
                      ,Phone
                      ,Income
                      ,Job)
                      VALUES";

        SQL += $"('{ID}'" +
               $",'{Name}'" +
               $",'{MotherName}'" +
               $",'{FatherName}'" +
               $", {Convert.ToString(HasFather)}" +
               $",'{CPF}'" +
               $",'{RG}'" +
               $", {Convert.ToString(Gender)}" +
               $",'{CEP}'" +
               $",'{Street}'" +
               $",'{Complement}'" +
               $",'{District}'" +
               $",'{City}'" +
               $",'{State}'" +
               $",'{Phone}'" +
               $", {Convert.ToString(Income)}" +
               $",'{Job}');";

        return SQL;
      }

      public string ToUpdate(string id) {
        string SQL = $"UPDATE Client2" +
                     $" SET" +
                     $" ID = '{ID}'" +
                     $",Name = '{Name}'" +
                     $",MotherName = '{MotherName}'" +
                     $",FatherName = '{FatherName}'" +
                     $",HasFather = {Convert.ToString(HasFather)}" +
                     $",CPF = '{CPF}'" +
                     $",RG = '{RG}'" +
                     $",Gender = {Convert.ToString(Gender)}" +
                     $",CEP = '{CEP}'" +
                     $",Street = '{Street}'" +
                     $",Complement = '{Complement}'" +
                     $",District = '{District}'" +
                     $",City = '{City}'" +
                     $",State = '{State}'" +
                     $",Phone = '{Phone}'" +
                     $",Income = '{Convert.ToString(Income)}'" +
                     $",Job = '{Job}'" +
                     $" WHERE ID = '{id}'";

        return SQL;
      }

      public Unit DataRowToUnit(DataRow dr) {
        Unit u = new Unit();
        u.ID = dr["ID"].ToString();
        u.Name = dr["Name"].ToString();
        u.MotherName = dr["MotherName"].ToString();
        u.FatherName = dr["FatherName"].ToString();
        u.HasFather = Convert.ToInt32(dr["HasFather"]);
        u.CPF = dr["CPF"].ToString();
        u.RG = dr["RG"].ToString();
        u.CEP = dr["CEP"].ToString();
        u.Street = dr["Street"].ToString();
        u.Complement = dr["Complement"].ToString();
        u.District = dr["District"].ToString();
        u.City = dr["City"].ToString();
        u.State = dr["State"].ToString();
        u.Phone = dr["Phone"].ToString();
        u.Job = dr["Job"].ToString();
        u.Income = Convert.ToDouble(dr["Income"]);

        return u;
      }

      #endregion
    }

    public class List {
      public List<Unit> _ListUnit { get; set; }
    }

    public static Unit DesSerializedClassUnit(string vJSON) {

      return JsonConvert.DeserializeObject<Unit>(vJSON);
    }

    public static string SerializedClassUnit(Unit unit) {

      return JsonConvert.SerializeObject(unit);
    }
  }
}
