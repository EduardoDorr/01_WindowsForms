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
  public partial class ValidateCPF : Form {
    public ValidateCPF() {
      InitializeComponent();
    }

    private void btnReset_Click(object sender, EventArgs e) {
      mskCPF.Text = "";
      lblResult.Text = "";
    }

    private void btnValidate_Click(object sender, EventArgs e) {
      var isOK = true;
      
      isOK = Utility.Valida(mskCPF.Text);

      if (isOK) {
        lblResult.Text = "CPF VÁLIDO!";
        lblResult.ForeColor = Color.Green;
      }
      else {
        lblResult.Text = "CPF INVÁLIDO!";
        lblResult.ForeColor = Color.Red;
      }
    }
  }
}
