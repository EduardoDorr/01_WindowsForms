using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms {
  public partial class ValidateCPF2 : Form {
    public ValidateCPF2() {
      InitializeComponent();
    }

    private void btnReset_Click(object sender, EventArgs e) {
      mskCPF.Text = "";
    }

    private void btnValidate_Click(object sender, EventArgs e) {
      var maskContent = mskCPF.Text;
      maskContent = maskContent.Replace(".", "")
                               .Replace("-", "")
                               .Trim();

      if (maskContent == "") {
        MessageBox.Show("Você deve digitar um CPF!",
                        "Erro!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

        return;
      }

      if (maskContent.Length != 11) {
        MessageBox.Show("CPF está incompleto!",
                        "Erro!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

        return;
      }

      var dialBox = MessageBox.Show("Você tem certeza?",
                                    "Validação de CPF",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

      if (dialBox == DialogResult.Yes) {
        var isOK = true;

        isOK = Utility.Valida(mskCPF.Text);

        if (isOK) {
          MessageBox.Show("CPF VÁLIDO!",
                          "Mensagem de Validação",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
        else {
          MessageBox.Show("CPF INVÁLIDO!",
                          "Mensagem de Validação",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
        }
      }
    }
  }
}
