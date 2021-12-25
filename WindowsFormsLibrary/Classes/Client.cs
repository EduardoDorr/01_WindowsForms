using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using WindowsForms;
using Newtonsoft.Json;
using WindowsFormsLibrary.Database;
using System.Windows.Forms;

namespace WindowsFormsLibrary.Classes {
  public class Client {
    public class Unit {
      [Required(ErrorMessage = "Código do cliente é obrigatório.")]
      [RegularExpression("[0-9]+", ErrorMessage = "Código do cliente deve ser numérico.")]
      [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do cliente deve ter 6 dígitos.")]
      public string _ID { get; set; }

      [Required(ErrorMessage = "Nome do cliente é obrigatório.")]
      [StringLength(50, ErrorMessage = "Nome do cliente deve ter no máximo 50 caracteres.")]
      public string _Name { get; set; }

      [Required(ErrorMessage = "Nome da mãe é obrigatório.")]
      [StringLength(50, ErrorMessage = "Nome da mãe deve ter no máximo 50 caracteres.")]
      public string _MotherName { get; set; }

      [StringLength(50, ErrorMessage = "Nome do pai deve ter no máximo 50 caracteres.")]
      public string _FatherName { get; set; }

      public bool _HasFather { get; set; }

      [Required(ErrorMessage = "CPF do cliente é obrigatório.")]
      [RegularExpression("[0-9]+", ErrorMessage = "CPF do cliente deve ser numérico.")]
      [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF do cliente deve ter 11 dígitos.")]
      public string _CPF { get; set; }

      [Required(ErrorMessage = "RG do cliente é obrigatório.")]
      [RegularExpression("[0-9]+", ErrorMessage = "RG do cliente deve ser numérico.")]
      [StringLength(11, MinimumLength = 10, ErrorMessage = "RG do cliente deve ter 10 dígitos.")]
      public string _RG { get; set; }

      [Required(ErrorMessage = "Gênero do cliente é obrigatório.")]
      public int _Gender { get; set; }

      [Required(ErrorMessage = "CEP do cliente é obrigatório.")]
      [RegularExpression("[0-9]+", ErrorMessage = "CEP do cliente deve ser numérico.")]
      [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP do cliente deve ter 8 dígitos.")]
      public string _CEP { get; set; }

      [Required(ErrorMessage = "Logradouro é obrigatório.")]
      [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 caracteres.")]
      public string _Street { get; set; }

      [Required(ErrorMessage = "Complento é obrigatório.")]
      [StringLength(50, ErrorMessage = "Complemento deve ter no máximo 50 caracteres.")]
      public string _Complement { get; set; }

      [Required(ErrorMessage = "Bairro é obrigatório.")]
      [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres.")]
      public string _District { get; set; }

      [Required(ErrorMessage = "Cidade é obrigatória.")]
      [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres.")]
      public string _City { get; set; }

      [Required(ErrorMessage = "Estado é obrigatório.")]
      [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 caracteres.")]
      public string _State { get; set; }

      [Required(ErrorMessage = "Telefone é obrigatório.")]
      [RegularExpression("[0-9]+", ErrorMessage = "Telefone deve ser numérico.")]
      public string _Phone { get; set; }

      [Required(ErrorMessage = "Renda do cliente é obrigatória.")]
      [Range(0, double.MaxValue, ErrorMessage = "Valor da Renda deve ser positivo.")]
      [RegularExpression("[0-9]+", ErrorMessage = "Renda do cliente deve ser numérico.")]
      public double _Income { get; set; }

      [Required(ErrorMessage = "Profissão é obrigatória.")]
      [StringLength(50, ErrorMessage = "Profissão deve ter no máximo 50 caracteres.")]
      public string _Job { get; set; }


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
        if (this._FatherName == this._MotherName) {
          throw new Exception("Nome do pai e da mãe não podem ser iguais.");
        }

        if (this._HasFather) {
          if (this._FatherName == "") {
            throw new Exception("Nome do pai não pode ser vazio.");
          }
        }

        var validateCPF = Utility.Valida(this._CPF);

        if (!validateCPF) {
          throw new Exception("CPF é inválido.");
        }
      }

      #region "File CRUD"
      public void AddFile(string dir) {
        string vJSON = Client.SerializedClassUnit(this);
        DBFiles DB = new DBFiles(dir);

        if (DB.status) {
          DB.Add(this._ID, vJSON);

          if (DB.status) {
            MessageBox.Show("OK: " + DB.message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.message);
          }
        }
        else {
          throw new Exception(DB.message);
        }
      }

      public Unit SearchFile(string id, string dir) {
        DBFiles DB = new DBFiles(dir);

        if (DB.status) {
          string vJSON = DB.Search(id);

          if (DB.status) {

            return Client.DesSerializedClassUnit(vJSON);
          }
          else {
            throw new Exception(DB.message);
          }
        }
        else {
          throw new Exception(DB.message);
        }
      }

      public void EditFile(string dir) {
        string vJSON = Client.SerializedClassUnit(this);
        DBFiles DB = new DBFiles(dir);

        if (DB.status) {
          DB.Edit(this._ID, vJSON);

          if (DB.status) {
            MessageBox.Show("OK: " + DB.message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.message);
          }
        }
        else {
          throw new Exception(DB.message);
        }
      }

      public void DeleteFile(string dir) {
        DBFiles DB = new DBFiles(dir);

        if (DB.status) {
          DB.Clear(this._ID);

          if (DB.status) {
            MessageBox.Show("OK: " + DB.message,
                            "Mensagem",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else {
            throw new Exception(DB.message);
          }
        }
        else {
          throw new Exception(DB.message);
        }
      }

      public List<string> SearchAllFiles(string dir) {
        DBFiles DB = new DBFiles(dir);

        if (DB.status) {
          List<string> listJSON = DB.SearchAll();

          if (DB.status) {
            return listJSON;
          }
          else {
            throw new Exception(DB.message);
          }
        }
        else {
          throw new Exception(DB.message);
        }
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
