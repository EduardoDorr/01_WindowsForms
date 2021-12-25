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

    private void chkHasFather_CheckedChanged(object sender, EventArgs e) {
      if (chkHasFather.Checked) {
        txtFatherName.Enabled = true;
      }
      else {
        txtFatherName.Enabled = false;
      }
    }

    private void newToolStripButton_Click(object sender, EventArgs e) {
      try {
        Client.Unit C = new Client.Unit();
        C = TestForm();
        C.ValidateClass();
        C.ValidateComplement();

        string vJSON = Client.SerializedClassUnit(C);

        DBFiles DB = new DBFiles("C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Publish\\DBFiles");

        if (DB.status) {
          MessageBox.Show("OK: " + DB.message,
                          "Mensagem",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
        else {
          MessageBox.Show("ERRO: " + DB.message,
                          "Mensagem",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
        }

        MessageBox.Show("Usuário cadastrado na base de dados!",
                        "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
      }
      catch (ValidationException ex) {
        MessageBox.Show(ex.Message,
                        "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message,
                        "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
      }
    }

    private void openToolStripButton_Click(object sender, EventArgs e) {

    }

    private void saveToolStripButton_Click(object sender, EventArgs e) {

    }

    private void deleteToolStripButton_Click(object sender, EventArgs e) {

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

            for (int i = 0; i < cmbStates.Items.Count - 1; i++) {
              var vPOS = Strings.InStr(cmbStates.Items[i].ToString(), "(" + vCEP.uf + ")");

              if (vPOS > 0) {
                cmbStates.SelectedIndex = i;
              }
            }
          }
        }
      }
    }

    Client.Unit TestForm() {
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
      //#############################################################

      //#############################################################
      // Address
      C._CEP = txtCEP.Text;
      C._Street = txtStreet.Text;
      C._Complement = txtComplement.Text;
      C._District = txtDistrict.Text;
      C._City = txtCity.Text;
      C._State = cmbStates.Text;

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
          C._Income = 0;
        }
      }
      //#############################################################

      return C;
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
