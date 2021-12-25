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
  public partial class Search : Form {
    private List<List<string>> _ListComplete = new List<List<string>> ();
    public string _IDSelected { get; set; }
    private class ItemBox {
      public string _ID { get; set; }
      public string _Name { get; set; }

      public override string ToString() {
        return _Name;
      }
    }

    public Search(List<List<string>> listComplete) {
      InitializeComponent();

      tlsMain.Items[0].ToolTipText = "Carregar a seleção";
      tlsMain.Items[1].ToolTipText = "Fechar seleção";

      _ListComplete = listComplete;
      ListFill();
      lstUsers.Sorted = true;
    }

    private void closeToolStripButton_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void openToolStripButton_Click(object sender, EventArgs e) {
      var itemSelected = lstUsers.Items[lstUsers.SelectedIndex] as ItemBox;
      _IDSelected = itemSelected._ID;

      DialogResult = DialogResult.OK;
      this.Close();
    }

    private void ListFill() {
      ListClear();

      for (int i = 0; i < _ListComplete.Count; i++) {
        ItemBox X = new ItemBox();
        X._ID = _ListComplete[i][0];
        X._Name = _ListComplete[i][1];
        lstUsers.Items.Add(X);
      }

      lstUsers.SelectedIndex = 0; // Always Initializes the list with index 0 selected
    }

    private void ListClear() {
      lstUsers.Items.Clear();
    }
  }
}
