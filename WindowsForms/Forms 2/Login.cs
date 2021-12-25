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
  public partial class Login : Form {
    public string _Login { get; private set; }
    public string _Password { get; private set; }


    public Login() {
      InitializeComponent();

      lblLogin.Text = "Usuário:";
      lblPassword.Text = "Senha:";
      btnOK.Text = "Login";
      btnCancel.Text = "Cancela";
    }

    private void btnOK_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.OK;

      _Login = txtLogin.Text;
      _Password = txtPassword.Text;

      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }
}
