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
  public partial class MouseCapture : Form {
    public MouseCapture() {
      InitializeComponent();
    }

    private void btnMouse_MouseDown(object sender, MouseEventArgs e) {
      string str1 = e.Button.ToString();

      MessageBox.Show(str1);
    }
  }
}
