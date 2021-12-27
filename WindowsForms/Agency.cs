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
  public partial class Agency : Form {
    public Agency() {
      InitializeComponent();

      tlsMain.Items[0].ToolTipText = "Fechar a caixa de seleção";
      this.Text = "Cadastro de Agências";
    }

    private void closeToolStripButton_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
