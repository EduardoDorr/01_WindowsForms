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
  public partial class DemonstracaoKeyUC : UserControl {
    public DemonstracaoKeyUC() {
      InitializeComponent();
    }

    private void txtInput_KeyDown(object sender, KeyEventArgs e) {
      txtMsg.AppendText("\r\n" + "Pressionei a tecla: " + e.KeyCode + "\r\n");
      txtMsg.AppendText("\t" + "Código da tecla: " + (int)e.KeyCode + "\r\n");
      txtMsg.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");

      lblLower.Text = e.KeyCode.ToString().ToLower();
      lblUpper.Text = e.KeyCode.ToString().ToUpper();
    }

    private void btnReset_Click(object sender, EventArgs e) {
      txtMsg.Text = "";
      txtInput.Text = "";
      lblLower.Text = "";
      lblUpper.Text = "";
    }
  }
}
