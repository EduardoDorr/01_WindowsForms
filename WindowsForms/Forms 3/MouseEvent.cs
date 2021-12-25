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
  public partial class MouseEvent : Form {
    public MouseEvent() {
      InitializeComponent();
    }

    private void btnMouse_MouseEnter(object sender, EventArgs e) {
      btnMouse.Text = "Mouse Enter";
    }

    private void btnMouse_MouseLeave(object sender, EventArgs e) {
      btnMouse.Text = "Mouse Leave";
    }

    private void btnMouse_MouseHover(object sender, EventArgs e) {
      btnMouse.Text = "Mouse Hover";
    }

    private void btnMouse_MouseDown(object sender, MouseEventArgs e) {
      btnMouse.Text = "Mouse Down";
    }

    private void btnMouse_MouseUp(object sender, MouseEventArgs e) {
      btnMouse.Text = "Mouse Up";
    }
  }
}
