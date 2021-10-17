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

    public bool Valida(string cpf) {
      int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
      int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
      string tempCpf;
      string digito;
      int soma;
      int resto;
      cpf = cpf.Trim();
      cpf = cpf.Replace(".", "").Replace("-", "");
      if (cpf.Length != 11)
        return false;
      tempCpf = cpf.Substring(0, 9);
      soma = 0;
      for (int i = 0; i < 9; i++)
        soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
      resto = soma % 11;
      if (resto < 2)
        resto = 0;
      else
        resto = 11 - resto;
      digito = resto.ToString();
      tempCpf = tempCpf + digito;
      soma = 0;
      for (int i = 0; i < 10; i++)
        soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
      resto = soma % 11;
      if (resto < 2)
        resto = 0;
      else
        resto = 11 - resto;
      digito = digito + resto.ToString();
      return cpf.EndsWith(digito);
    }

    private void btnReset_Click(object sender, EventArgs e) {
      mskCPF.Text = "";
      lblResult.Text = "";
    }

    private void btnValidate_Click(object sender, EventArgs e) {
      var isOK = true;
      
      isOK = Valida(mskCPF.Text);

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
