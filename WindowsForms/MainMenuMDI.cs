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
  public partial class MainMenuMDI : Form {
    public MainMenuMDI() {
      InitializeComponent();
    }
    private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e) {
      DemonstracaoKey f = new DemonstracaoKey();
      f.MdiParent = this;
      f.Show();
    }

    private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e) {
      HelloWorld f = new HelloWorld();
      f.MdiParent = this;
      f.Show();
    }

    private void máscaraToolStripMenuItem_Click(object sender, EventArgs e) {
      Mask f = new Mask();
      f.MdiParent = this;
      f.Show();
    }

    private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e) {
      ValidateCPF f = new ValidateCPF();
      f.MdiParent = this;
      f.Show();
    }

    private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e) {
      ValidateCPF2 f = new ValidateCPF2();
      f.MdiParent = this;
      f.Show();
    }

    private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e) {
      ValidatePassword f = new ValidatePassword();
      f.MdiParent = this;
      f.Show();
    }

    private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void cascataToolStripMenuItem_Click(object sender, EventArgs e) {
      this.LayoutMdi(MdiLayout.Cascade);
    }

    private void horizontalToolStripMenuItem_Click(object sender, EventArgs e) {
      this.LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void verticalToolStripMenuItem_Click(object sender, EventArgs e) {
      this.LayoutMdi(MdiLayout.TileVertical);
    }
  }
}
