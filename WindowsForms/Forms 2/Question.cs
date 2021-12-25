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
  public partial class Question : Form {
    public Question(string imageName, string message) {
      InitializeComponent();

      Image img = (Image)Properties.Resources
                                   .ResourceManager
                                   .GetObject(imageName);
      picImage.Image = img;
      lblQuestion.Text = message;
    }

    private void btnOK_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Yes;
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }
}
