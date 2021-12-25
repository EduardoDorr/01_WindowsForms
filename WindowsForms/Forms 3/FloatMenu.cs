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
  public partial class FloatMenu : Form {
    public FloatMenu() {
      InitializeComponent();
    }

    private void FloatMenu_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Right) {
        //var posX = e.X;
        //var posY = e.Y;
        //MessageBox.Show(e.Button.ToString() + " at " + posX + "," + posY);

        var contextMenu = new ContextMenuStrip();
        var vToolTip001 = DrawItems("Item 1", "imgFolder");
        DrawSubItems(vToolTip001, "SubItem 1");
        DrawSubItems(vToolTip001, "SubItem 2", "imgKey");
        var vToolTip002 = DrawItems("Item 2", "imgKey");
        var vToolTip003 = DrawItems("Item 3", "imgValidatePassword");

        contextMenu.Items.Add(vToolTip001);
        contextMenu.Items.Add(vToolTip002);
        contextMenu.Items.Add(vToolTip003);

        vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
        vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
        vToolTip003.Click += new System.EventHandler(vToolTip003_Click);

        contextMenu.Show(this, e.Location);
      }
    }

    private void vToolTip001_Click(object sender, EventArgs e) {
      MessageBox.Show("Item 1 Pressed");
    }

    private void vToolTip002_Click(object sender, EventArgs e) {
      MessageBox.Show("Item 2 Pressed");
    }

    private void vToolTip003_Click(object sender, EventArgs e) {
      MessageBox.Show("Item 3 Pressed");
    }

    private ToolStripMenuItem DrawItems(string menuName) {
      var vToolTip = new ToolStripMenuItem();
      vToolTip.Text = menuName;

      return vToolTip;
    }

    private ToolStripMenuItem DrawItems(string menuName, string imageName) {
      var vToolTip = new ToolStripMenuItem();
      vToolTip.Text = menuName;
      Image img = (Image)Properties.Resources
                                   .ResourceManager
                                   .GetObject(imageName);
      vToolTip.Image = img;

      return vToolTip;
    }

    private void DrawSubItems(ToolStripMenuItem menuName, string subMenuName) {
      menuName.DropDownItems.Add(subMenuName);
    }

    private void DrawSubItems(ToolStripMenuItem menuName, string subMenuName, string subMenuImage) {
      Image img = (Image)Properties.Resources
                                   .ResourceManager
                                   .GetObject(subMenuImage);

      menuName.DropDownItems.Add(subMenuName, img);
    }
  }
}
