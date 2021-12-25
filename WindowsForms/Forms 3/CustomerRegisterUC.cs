using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLibrary.Classes;
using WindowsFormsLibrary.Database;
using Microsoft.VisualBasic;


namespace WindowsForms {
  public partial class CustomerRegisterUC : UserControl {
    public CustomerRegisterUC() {
      InitializeComponent();

      CleanForm();

      tlsMain.Items[0].ToolTipText = "Incluir na base de dados um novo cliente";
      tlsMain.Items[1].ToolTipText = "Carregar um cliente já existente";
      tlsMain.Items[2].ToolTipText = "Atualizar os dados de um cliente já existente";
      tlsMain.Items[3].ToolTipText = "Apaga o cliente atual carregado da base de dados";
      tlsMain.Items[4].ToolTipText = "Limpa os dados na tela";

      grbID.Text = "ID Cliente";
      btnSearch.Text = "Buscar";

      grbPersonalData.Text = "Dados Pessoais";
      lblCustomerName.Text = "Nome";
      lblFatherName.Text = "Nome do Pai";
      lblMotherName.Text = "Nome da Mãe";
      lblCPF.Text = "CPF";
      lblRG.Text = "RG";
      grbGender.Text = "Gênero";
      rdbMale.Text = "Masculino";
      rdbFemale.Text = "Feminino";
      rdbNoGender.Text = "Outro";

      grbAddress.Text = "Endereço";
      lblCEP.Text = "CEP";
      lblStreet.Text = "Logradouro";
      lblComplement.Text = "Complemento";
      lblCity.Text = "Cidade";
      lblDistrict.Text = "Bairro";
      lblState.Text = "Estado";

      grbOthers.Text = "Outros";
      lblPhone.Text = "Telefone";
      lblJob.Text = "Profissão";
      lblFamilyIncome.Text = "Renda Familiar";

      txtFatherName.Enabled = false;

      cmbStates.Items.Clear();
      cmbStates.Items.Add("Acre (AC)");
      cmbStates.Items.Add("Alagoas (AL)");
      cmbStates.Items.Add("Amapá (AP)");
      cmbStates.Items.Add("Amazonas (AM)");
      cmbStates.Items.Add("Bahia (BA)");
      cmbStates.Items.Add("Ceará (CE)");
      cmbStates.Items.Add("Distrito Federal (DF)");
      cmbStates.Items.Add("Espírito Santo (ES)");
      cmbStates.Items.Add("Goiás (GO)");
      cmbStates.Items.Add("Maranhão (MA)");
      cmbStates.Items.Add("Mato Grosso (MT)");
      cmbStates.Items.Add("Mato Grosso do Sul (MS)");
      cmbStates.Items.Add("Minas Gerais (MG)");
      cmbStates.Items.Add("Pará (PA)");
      cmbStates.Items.Add("Paraíba (PB)");
      cmbStates.Items.Add("Paraná (PR)");
      cmbStates.Items.Add("Pernambuco (PE)");
      cmbStates.Items.Add("Piauí (PI)");
      cmbStates.Items.Add("Rio de Janeiro (RJ)");
      cmbStates.Items.Add("Rio Grande do Norte (RN)");
      cmbStates.Items.Add("Rio Grande do Sul (RS)");
      cmbStates.Items.Add("Rondônia (RO)");
      cmbStates.Items.Add("Roraima (RR)");
      cmbStates.Items.Add("Santa Catarina (SC)");
      cmbStates.Items.Add("São Paulo (SP)");
      cmbStates.Items.Add("Sergipe (SE)");
      cmbStates.Items.Add("Tocantins (TO)");
    }

    private void newToolStripButton_Click(object sender, EventArgs e) {
      var dir = "C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Publish\\DBFiles";

      try {
        Client.Unit C = new Client.Unit();
        C = ReadFromForm();
        C.ValidateClass();
        C.ValidateComplement();
        C.AddFile(dir);
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message,
                        "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
      }

      #region Old
      //string vJSON = Client.SerializedClassUnit(C);

      //DBFiles DB = new DBFiles("C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Publish\\DBFiles");

      //if (DB.status) {
      //  DB.Add(C._ID, vJSON);

      //  if (DB.status) {
      //    MessageBox.Show("OK: " + DB.message,
      //                    "Mensagem",
      //                    MessageBoxButtons.OK,
      //                    MessageBoxIcon.Information);
      //  }
      //  else {
      //    MessageBox.Show("ERRO: " + DB.message,
      //                    "Mensagem",
      //                    MessageBoxButtons.OK,
      //                    MessageBoxIcon.Error);
      //  }
      //}
      //else {
      //  MessageBox.Show("ERRO: " + DB.message,
      //                  "Mensagem",
      //                  MessageBoxButtons.OK,
      //                  MessageBoxIcon.Error);
      //}
      #endregion
    }

    private void openToolStripButton_Click(object sender, EventArgs e) {
      var id = txtID.Text;
      var dir = "C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Publish\\DBFiles";

      if (txtID.Text == "") {
        MessageBox.Show("ERRO: ID está vazio!",
                        "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
      }
      else {
        try {
          Client.Unit C = new Client.Unit();
          C = C.SearchFile(id, dir);
          WriteToForm(C);
        }
        catch (Exception ex) {
          MessageBox.Show(ex.Message,
                          "Mensagem",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
        }
      }

      #region Old
      //DBFiles DB = new DBFiles("C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Publish\\DBFiles");

      //if (DB.status) {
      //  string vJSON = DB.Search(txtID.Text);

      //  if (DB.status) {
      //    WriteToForm(vJSON);
      //  }
      //  else {
      //    MessageBox.Show("ERRO: " + DB.message,
      //                    "Mensagem",
      //                    MessageBoxButtons.OK,
      //                    MessageBoxIcon.Error);
      //  }
      //}
      //else {
      //  MessageBox.Show("ERRO: " + DB.message,
      //                  "Mensagem",
      //                  MessageBoxButtons.OK,
      //                  MessageBoxIcon.Error);
      //}
      #endregion;
    }

    private void saveToolStripButton_Click(object sender, EventArgs e) {
      var dir = "C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Publish\\DBFiles";

      try {
        Client.Unit C = new Client.Unit();
        C = ReadFromForm();
        C.ValidateClass();
        C.ValidateComplement();
        C.EditFile(dir);
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message,
                        "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
      }

      #region Old
      //string vJSON = Client.SerializedClassUnit(C);
      //DBFiles DB = new DBFiles("C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Publish\\DBFiles");

      //if (DB.status) {
      //  DB.Edit(C._ID, vJSON);

      //  if (DB.status) {
      //    MessageBox.Show("OK: " + DB.message,
      //                    "Mensagem",
      //                    MessageBoxButtons.OK,
      //                    MessageBoxIcon.Information);
      //  }
      //  else {
      //    MessageBox.Show("ERRO: " + DB.message,
      //                    "Mensagem",
      //                    MessageBoxButtons.OK,
      //                    MessageBoxIcon.Error);
      //  }
      //}
      //else {
      //  MessageBox.Show("ERRO: " + DB.message,
      //                  "Mensagem",
      //                  MessageBoxButtons.OK,
      //                  MessageBoxIcon.Error);
      //}
      #endregion
    }

    private void deleteToolStripButton_Click(object sender, EventArgs e) {
      var id = txtID.Text;
      var dir = "C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Publish\\DBFiles";

      if (id == "") {
        MessageBox.Show("ERRO: ID está vazio!",
                        "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
      }
      else {
        try {
          Client.Unit C = new Client.Unit();
          C = C.SearchFile(id, dir);
          WriteToForm(C);

          Question Db = new Question("imgQuestion", "Tem certeza?");
          Db.ShowDialog();

          var dialBox = Db.DialogResult;

          if (dialBox == DialogResult.Yes) {
            C.DeleteFile(dir);
            CleanForm();
          }
        }
        catch (Exception ex) {
          MessageBox.Show(ex.Message,
                          "Mensagem",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
        }
      }

      #region Old
      //DBFiles DB = new DBFiles("C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Publish\\DBFiles");

      //if (DB.status) {
      //  string vJSON = DB.Search(txtID.Text);
      //  Client.Unit C = Client.DesSerializedClassUnit(vJSON);
      //  WriteToForm(C);

      //  Question Db = new Question("imgQuestion", "Tem certeza?");
      //  Db.ShowDialog();

      //  var dialBox = Db.DialogResult;

      //  if (dialBox == DialogResult.Yes) {
      //    DB.Clear(txtID.Text);

      //    if (DB.status) {
      //      MessageBox.Show("OK: " + DB.message,
      //                      "Mensagem",
      //                      MessageBoxButtons.OK,
      //                      MessageBoxIcon.Information);

      //      CleanForm();
      //    }
      //    else {
      //      MessageBox.Show("ERRO: " + DB.message,
      //                      "Mensagem",
      //                      MessageBoxButtons.OK,
      //                      MessageBoxIcon.Error);
      //    }
      //  }
      //}
      //else {
      //  MessageBox.Show("ERRO: " + DB.message,
      //                  "Mensagem",
      //                  MessageBoxButtons.OK,
      //                  MessageBoxIcon.Error);
      //}
      #endregion
    }

    private void cleanToolStripButton_Click(object sender, EventArgs e) {
      CleanForm();
    }
    
    private void txtCEP_Leave(object sender, EventArgs e) {
      var cep = txtCEP.Text;

      if (cep != "") {
        if (cep.Length == 8) {
          if (Information.IsNumeric(cep)) {
            var vJSON = Utility.GenerateJSONCEP(txtCEP.Text);

            CEP.Unit vCEP = new CEP.Unit();
            vCEP = CEP.DesSerializedClassUnit(vJSON);

            txtStreet.Text = vCEP.logradouro;
            txtDistrict.Text = vCEP.bairro;
            txtCity.Text = vCEP.localidade;

            cmbStates.SelectedIndex = -1;

            for (int i = 0; i <= cmbStates.Items.Count - 1; i++) {
              var vPOS = Strings.InStr(cmbStates.Items[i].ToString(), "(" + vCEP.uf + ")");

              if (vPOS > 0) {
                cmbStates.SelectedIndex = i;
              }
            }
          }
        }
      }
    }

    private void chkHasFather_CheckedChanged(object sender, EventArgs e) {
      if (chkHasFather.Checked) {
        txtFatherName.Enabled = true;
      }
      else {
        txtFatherName.Enabled = false;
        txtFatherName.Text = "";
      }
    }
    private void btnSearch_Click(object sender, EventArgs e) {
      var dir = "C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Publish\\DBFiles";
      try {
        Client.Unit C = new Client.Unit();
        List<string> listJSON = C.SearchAllFiles(dir);
        List<List<string>> listComplete = new List<List<string>>();

        for (int i = 0; i < listJSON.Count; i++) {
          C = Client.DesSerializedClassUnit(listJSON[i]);
          listComplete.Add(new List<string> { C._ID, C._Name });
        }

        Search F = new Search(listComplete);
        F.ShowDialog();

        if (F.DialogResult == DialogResult.OK) {
          var idSelected = F._IDSelected;
          C = C.SearchFile(idSelected, dir);
          WriteToForm(C);
        }
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message,
                        "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
      }

      #region Old
      //DBFiles DB = new DBFiles("C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Publish\\DBFiles");

      //if (DB.status) {
      //  List<string> listJSON = DB.SearchAll();

      //  if (DB.status) {
      //    List<List<string>> listComplete = new List<List<string>>();

      //    for (int i = 0; i < listJSON.Count; i++) {
      //      Client.Unit C = Client.DesSerializedClassUnit(listJSON[i]);
      //      listComplete.Add(new List<string> { C._ID, C._Name });
      //    }

      //    Search F = new Search(listComplete);
      //    F.ShowDialog();

      //    if (F.DialogResult == DialogResult.OK) {
      //      var idSelected = F._IDSelected;
      //      string vJSON = DB.Search(idSelected);
      //      Client.Unit C = Client.DesSerializedClassUnit(vJSON);
      //      WriteToForm(C);
      //    }
      //  }
      //  else {
      //    MessageBox.Show("ERRO: " + DB.message,
      //                    "Mensagem",
      //                    MessageBoxButtons.OK,
      //                    MessageBoxIcon.Error);
      //  }
      //}
      //else {
      //  MessageBox.Show("ERRO: " + DB.message,
      //                  "Mensagem",
      //                  MessageBoxButtons.OK,
      //                  MessageBoxIcon.Error);
      //}
      #endregion
    }

    Client.Unit ReadFromForm() {
      Client.Unit C = new Client.Unit();

      //#############################################################
      // Personal Data
      C._ID = txtID.Text;
      C._Name = txtCustomerName.Text;
      C._MotherName = txtMotherName.Text;
      C._FatherName = txtFatherName.Text;
      
      if (chkHasFather.Checked) {
        C._HasFather = true;
      }
      else {
        C._HasFather = false;
      }

      if (rdbMale.Checked) {
        C._Gender = 0;
      }
      if (rdbFemale.Checked) {
        C._Gender = 1;
      }
      if (rdbNoGender.Checked) {
        C._Gender = 2;
      }
      C._CPF = txtCPF.Text;
      C._RG = txtRG.Text;
      //#############################################################

      //#############################################################
      // Address
      C._CEP = txtCEP.Text;
      C._Street = txtStreet.Text;
      C._Complement = txtComplement.Text;
      C._District = txtDistrict.Text;
      C._City = txtCity.Text;

      if (cmbStates.SelectedIndex < 0) {
        C._State = "";
      }
      else {
        C._State = cmbStates.Items[cmbStates.SelectedIndex].ToString();
      }
      //#############################################################

      //#############################################################
      // Others
      C._Phone = txtPhone.Text;
      C._Job = txtJob.Text;

      if (Information.IsNumeric(txtFamilyIncome.Text)) {
        Double vRenda = Convert.ToDouble(txtFamilyIncome.Text);

        if (vRenda < 0) {
          C._Income = 0;
        }
        else {
          C._Income = vRenda;
        }
      }
      //#############################################################

      return C;
    }

    private void WriteToForm(Client.Unit C) {
      //#############################################################
      // Personal Data
      txtID.Text = C._ID;
      txtCustomerName.Text = C._Name;
      txtMotherName.Text = C._MotherName;

      if (C._HasFather) {
        chkHasFather.Checked = true;
        txtFatherName.Text = C._FatherName;
      }
      else {
        chkHasFather.Checked = false;
        txtFatherName.Text = "";
      }

      if (C._Gender == 0) {
        rdbMale.Checked = true;
      }
      if (C._Gender == 1) {
        rdbFemale.Checked = true;
      }
      if (C._Gender == 2) {
        rdbNoGender.Checked = true;
      }
      txtCPF.Text = C._CPF;
      txtRG.Text = C._RG;
      //#############################################################

      //#############################################################
      // Address
      txtCEP.Text = C._CEP;
      txtStreet.Text = C._Street;
      txtComplement.Text = C._Complement;
      txtDistrict.Text = C._District;
      txtCity.Text = C._City;

      if (C._State == "") {
        cmbStates.SelectedIndex = -1;
      }
      else {
        for (int i = 0; i <= cmbStates.Items.Count - 1; i++) {
          if (C._State == cmbStates.Items[i].ToString()) {
            cmbStates.SelectedIndex = i;
          }
        }
      }
      //#############################################################

      //#############################################################
      // Others
      txtPhone.Text = C._Phone;
      txtJob.Text = C._Job;
      txtFamilyIncome.Text = C._Income.ToString();
      //#############################################################
    }

    private void CleanForm() {
      txtID.Text = "";
      txtCustomerName.Text = "";
      txtMotherName.Text = "";
      txtFatherName.Text = "";
      chkHasFather.Checked = false;
      txtCPF.Text = "";
      txtRG.Text = "";
      rdbMale.Checked = true;
      txtCEP.Text = "";
      txtStreet.Text = "";
      txtComplement.Text = "";
      txtCity.Text = "";
      txtDistrict.Text = "";
      cmbStates.SelectedIndex = -1;
      txtPhone.Text = "";
      txtJob.Text = "";
      txtFamilyIncome.Text = "";
    }

  }
}
