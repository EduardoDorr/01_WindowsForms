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
  public partial class HelloWorldUC : UserControl {
    public HelloWorldUC() {
      InitializeComponent();
    }

    private void btnChangeLabel_Click(object sender, EventArgs e) {
      lblTitle.Text = txtContent.Text;
    }
  }
}
