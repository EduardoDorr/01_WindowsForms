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
  public partial class Main : Form {
    public Main() {
      InitializeComponent();
    }

    private void btnDemonstracaoKey_Click(object sender, EventArgs e) {
      DemonstracaoKey f = new DemonstracaoKey();
      f.ShowDialog();
    }

    private void btnHelloWorld_Click(object sender, EventArgs e) {
      HelloWorld f = new HelloWorld();
      f.ShowDialog();
    }

    private void btnMask_Click(object sender, EventArgs e) {
      Mask f = new Mask();
      f.ShowDialog();
    }

    private void btnValidateCPF_Click(object sender, EventArgs e) {
      ValidateCPF f = new ValidateCPF();
      f.ShowDialog();
    }

    private void btnValidateCPF2_Click(object sender, EventArgs e) {
      ValidateCPF2 f = new ValidateCPF2();
      f.ShowDialog();
    }

    private void btnValidatePassword_Click(object sender, EventArgs e) {
      ValidatePassword f = new ValidatePassword();
      f.ShowDialog();
    }
  }
}
