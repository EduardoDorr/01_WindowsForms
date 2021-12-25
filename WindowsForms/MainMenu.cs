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
  public partial class MainMenu : Form {
    public MainMenu() {
      InitializeComponent();
    }

    private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e) {
      DemonstracaoKey f = new DemonstracaoKey();
      f.ShowDialog();
    }

    private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e) {
      HelloWorld f = new HelloWorld();
      f.ShowDialog();
    }

    private void máscaraToolStripMenuItem_Click(object sender, EventArgs e) {
      Mask f = new Mask();
      f.ShowDialog();
    }

    private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e) {
      ValidateCPF f = new ValidateCPF();
      f.ShowDialog();
    }

    private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e) {
      ValidateCPF2 f = new ValidateCPF2();
      f.ShowDialog();
    }

    private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e) {
      ValidatePassword f = new ValidatePassword();
      f.ShowDialog();
    }

    private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }
  }
}
