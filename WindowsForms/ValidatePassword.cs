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
  public partial class ValidatePassword : Form {
    public ValidatePassword() {
      InitializeComponent();
    }

    private void txtPassword_TextChanged(object sender, EventArgs e) {
      var checkPassword = new ChecaForcaSenha();

      lblResult.Text = checkPassword
                        .GetForcaDaSenha(txtPassword.Text)
                        .ToString();

      if (lblResult.Text == "Inaceitavel" || lblResult.Text == "Fraca") {
        lblResult.ForeColor = Color.Red;
      }
      if (lblResult.Text == "Aceitavel") {
        lblResult.ForeColor = Color.Orange;
      }
      if (lblResult.Text == "Forte") {
        lblResult.ForeColor = Color.YellowGreen;
      }
      if (lblResult.Text == "Segura") {
        lblResult.ForeColor = Color.Green;
      }
    }

    private void btnReset_Click(object sender, EventArgs e) {
      txtPassword.Text = "";
      lblResult.Text = "";
    }

    private void bntShow_Click(object sender, EventArgs e) {
      if (txtPassword.PasswordChar == '*') {
        txtPassword.PasswordChar = '\0';
        bntShow.Text = "Esconder Senha";
      }
      else {
        txtPassword.PasswordChar = '*';
        bntShow.Text = "Mostrar Senha";
      }      
    }
  }
}
