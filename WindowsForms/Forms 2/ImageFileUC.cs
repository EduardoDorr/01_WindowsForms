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
  public partial class ImageFileUC : UserControl {
    public ImageFileUC(string fileName) {
      InitializeComponent();

      picImage.Image = Image.FromFile(fileName);
      lblImageFile.Text = fileName;
    }

    private void brtnColor_Click(object sender, EventArgs e) {
      ColorDialog CDb = new ColorDialog();

      if (CDb.ShowDialog() == DialogResult.OK) {
        lblImageFile.ForeColor = CDb.Color;
      }
    }

    private void btnFont_Click(object sender, EventArgs e) {
      FontDialog FDb = new FontDialog();

      if (FDb.ShowDialog() == DialogResult.OK) {
        lblImageFile.Font = FDb.Font;
      }
    }
  }
}
