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
  public partial class Mask : Form {
    public Mask() {
      InitializeComponent();
    }

    private void btnHour_Click(object sender, EventArgs e) {
      mskTextBox.Mask = "00:00";
      lblActiveMask.Text = mskTextBox.Mask;
      mskTextBox.Text = "";
      lblContent.Text = "";
      mskTextBox.Focus();
    }

    private void btnShowContent_Click(object sender, EventArgs e) {
      lblContent.Text = mskTextBox.Text;
    }

    private void btnCEP_Click(object sender, EventArgs e) {
      mskTextBox.UseSystemPasswordChar = false;
      mskTextBox.Mask = "00000-000";
      lblActiveMask.Text = mskTextBox.Mask;
      mskTextBox.Text = "";
      lblContent.Text = "";
      mskTextBox.Focus();
    }

    private void btnCurrency_Click(object sender, EventArgs e) {
      mskTextBox.UseSystemPasswordChar = false;
      mskTextBox.Mask = "$ 000,000,000.00";
      lblActiveMask.Text = mskTextBox.Mask;
      mskTextBox.Text = "";
      lblContent.Text = "";
      mskTextBox.Focus();
    }

    private void btnDate_Click(object sender, EventArgs e) {
      mskTextBox.UseSystemPasswordChar = false;
      mskTextBox.Mask = "00/00/0000";
      lblActiveMask.Text = mskTextBox.Mask;
      mskTextBox.Text = "";
      lblContent.Text = "";
      mskTextBox.Focus();
    }

    private void btnTelephone_Click(object sender, EventArgs e) {
      mskTextBox.UseSystemPasswordChar = false;
      mskTextBox.Mask = "(00) 0 0000-0000";
      lblActiveMask.Text = mskTextBox.Mask;
      mskTextBox.Text = "";
      lblContent.Text = "";
      mskTextBox.Focus();
    }

    private void btnPassword_Click(object sender, EventArgs e) {
      mskTextBox.UseSystemPasswordChar = true;
      mskTextBox.Mask = "000000";
      lblActiveMask.Text = mskTextBox.Mask;
      mskTextBox.Text = "";
      lblContent.Text = "";
      mskTextBox.Focus();
    }
  }
}
