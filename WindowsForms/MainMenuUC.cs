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
  public partial class MainMenuUC : Form {
    int controlDemonstracaoKey = 0;
    int controlHelloWorld = 0;
    int controlMask = 0;
    int controlValidateCPF = 0;
    int controlValidateCPF2 = 0;
    int controlValidatePassword = 0;
    int controlImageFile = 0;
    int controlCustomerRegister = 0;

    public MainMenuUC() {
      InitializeComponent();

      novoToolStripMenuItem.Enabled = false;
      abrirImagemToolStripMenuItem.Enabled = false;
      fecharAbaToolStripMenuItem.Enabled = false;
      desconectarToolStripMenuItem.Enabled = false;
      cadastrosToolStripMenuItem.Enabled = false;
    }

    private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e) {
      DemonstracaoKeyUC uC = new DemonstracaoKeyUC();
      TabPage tb = new TabPage();
      uC.Dock = DockStyle.Fill;
      controlDemonstracaoKey++;

      tb.Name = "Demonstração Key " + controlDemonstracaoKey;
      tb.Text = "Demonstração Key " + controlDemonstracaoKey;
      tb.ImageIndex = 0;
      tb.Controls.Add(uC);

      tbcApplications.TabPages.Add(tb);
    }

    private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e) {
      controlHelloWorld++;
      HelloWorldUC uC = new HelloWorldUC();
      TabPage tb = new TabPage();
      uC.Dock = DockStyle.Fill;

      tb.Name = "Hello World " + controlHelloWorld;
      tb.Text = "Hello World " + controlHelloWorld;
      tb.ImageIndex = 1;
      tb.Controls.Add(uC);

      tbcApplications.TabPages.Add(tb);
    }

    private void máscaraToolStripMenuItem_Click(object sender, EventArgs e) {
      controlMask++;
      MaskUC uC = new MaskUC();
      TabPage tb = new TabPage();
      uC.Dock = DockStyle.Fill;

      tb.Name = "Máscara " + controlMask;
      tb.Text = "Máscara " + controlMask;
      tb.ImageIndex = 2;
      tb.Controls.Add(uC);

      tbcApplications.TabPages.Add(tb);
    }

    private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e) {
      controlValidateCPF++;
      ValidateCPFUC uC = new ValidateCPFUC();
      TabPage tb = new TabPage();
      uC.Dock = DockStyle.Fill;

      tb.Name = "Validação CPF " + controlValidateCPF;
      tb.Text = "Validação CPF " + controlValidateCPF;
      tb.ImageIndex = 3;
      tb.Controls.Add(uC);

      tbcApplications.TabPages.Add(tb);
    }

    private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e) {
      controlValidateCPF2++;
      ValidateCPF2UC uC = new ValidateCPF2UC();
      TabPage tb = new TabPage();
      uC.Dock = DockStyle.Fill;

      tb.Name = "Validação CPF 2 " + controlValidateCPF2;
      tb.Text = "Validação CPF 2 " + controlValidateCPF2;
      tb.ImageIndex = 4;
      tb.Controls.Add(uC);

      tbcApplications.TabPages.Add(tb);
    }

    private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e) {
      controlValidatePassword++;
      ValidatePasswordUC uC = new ValidatePasswordUC();
      TabPage tb = new TabPage();
      uC.Dock = DockStyle.Fill;

      tb.Name = "Validação Senha " + controlValidatePassword;
      tb.Text = "Validação Senha " + controlValidatePassword;
      tb.ImageIndex = 5;
      tb.Controls.Add(uC);

      tbcApplications.TabPages.Add(tb);
    }

    private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e) {
      OpenFileDialog Db = new OpenFileDialog();
      Db.InitialDirectory = "C:\\Users\\edudo\\Desktop\\Alura\\WindowsForm\\Referência\\Imagens";
      Db.Filter = "PNG|*.PNG";
      Db.Title = "Escolha a Imagem";

      if (Db.ShowDialog() == DialogResult.OK) {
        string fileName = Db.FileName;

        controlImageFile++;
        ImageFileUC uC = new ImageFileUC(fileName);
        TabPage tb = new TabPage();
        uC.Dock = DockStyle.Fill;

        tb.Name = "Arquivo Imagem " + controlImageFile;
        tb.Text = "Arquivo Imagem " + controlImageFile;
        tb.ImageIndex = 6;
        tb.Controls.Add(uC);

        tbcApplications.TabPages.Add(tb);
      }
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

    private void fecharAbaToolStripMenuItem_Click(object sender, EventArgs e) {
      if (tbcApplications.SelectedTab != null) {
        CloseTab(tbcApplications.SelectedTab);
      }
    }

    private void conectarToolStripMenuItem_Click(object sender, EventArgs e) {
      Login F = new Login();
      F.ShowDialog();

      if (F.DialogResult == DialogResult.OK) {

        string login = F._Login;
        string password = F._Password;

        if (Utility.ValidatePassword(login, password)) {
          novoToolStripMenuItem.Enabled = true;
          abrirImagemToolStripMenuItem.Enabled = true;
          fecharAbaToolStripMenuItem.Enabled = true;
          desconectarToolStripMenuItem.Enabled = true;
          conectarToolStripMenuItem.Enabled = false;
          cadastrosToolStripMenuItem.Enabled = true;

          MessageBox.Show($"Bem vindo {login}!",
                           "Mensagem",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }
        else {
          MessageBox.Show("Usuário ou Senha Inválida!",
                          "Mensagem",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
        }
      }
    }

    private void desconectarToolStripMenuItem_Click(object sender, EventArgs e) {
      Question Db = new Question("imgQuestion", "Tem certeza?");
      Db.ShowDialog();

      var dialBox = Db.DialogResult;

      if (dialBox == DialogResult.Yes) {
        for (int i = tbcApplications.TabPages.Count - 1; i >= 0; i--) {
          CloseTab(tbcApplications.TabPages[i]);
        }

        MessageBox.Show("Usuário Desconectado!",
                        "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        
        novoToolStripMenuItem.Enabled = false;
        abrirImagemToolStripMenuItem.Enabled = false;
        fecharAbaToolStripMenuItem.Enabled = false;
        desconectarToolStripMenuItem.Enabled = false;
        conectarToolStripMenuItem.Enabled = true;
        cadastrosToolStripMenuItem.Enabled = false;
      }
    }

    private void tbcApplications_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Right) {
        var contextMenu = new ContextMenuStrip();
        var vToolTip001 = DrawItems("Fecha Aba", "imgTabClose");
        var vToolTip002 = DrawItems("Fechar Abas à Esquerda", "imgTabCloseLeft");
        var vToolTip003 = DrawItems("Fechar Abas à Direita", "imgTabCloseRight");
        var vToolTip004 = DrawItems("Fechar Abas Exceto Esta", "imgTabCloseAllExcept");
        var vToolTip005 = DrawItems("Fechar Abas", "imgTabCloseAll");

        contextMenu.Items.Add(vToolTip001);
        contextMenu.Items.Add(vToolTip002);
        contextMenu.Items.Add(vToolTip003);
        contextMenu.Items.Add(vToolTip004);
        contextMenu.Items.Add(vToolTip005);

        vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
        vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
        vToolTip003.Click += new System.EventHandler(vToolTip003_Click);
        vToolTip004.Click += new System.EventHandler(vToolTip002_Click)
                           + new System.EventHandler(vToolTip003_Click);
        vToolTip005.Click += new System.EventHandler(vToolTip005_Click);

        contextMenu.Show(this, e.Location);
      }
    }

    private void vToolTip001_Click(object sender, EventArgs e) {
      if (tbcApplications.SelectedTab != null) {
        CloseTab(tbcApplications.SelectedTab);
      }
    }

    private void vToolTip002_Click(object sender, EventArgs e) {
      if (tbcApplications.SelectedTab != null) {
        for (int i = tbcApplications.SelectedIndex - 1; i >= 0; i--) {
          CloseTab(tbcApplications.TabPages[i]);
        }
      }
    }

    private void vToolTip003_Click(object sender, EventArgs e) {
      if (tbcApplications.SelectedTab != null) {
        for (int i = tbcApplications.TabPages.Count - 1; i > tbcApplications.SelectedIndex; i--) {
          CloseTab(tbcApplications.TabPages[i]);
        }
      }
    }

    private void vToolTip005_Click(object sender, EventArgs e) {
      for (int i = tbcApplications.TabPages.Count - 1; i >= 0; i--) {
        CloseTab(tbcApplications.TabPages[i]);
      }
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

    private void clienteToolStripMenuItem_Click(object sender, EventArgs e) {
      if (controlCustomerRegister == 0) {
        controlCustomerRegister++;
        CustomerRegisterUC uC = new CustomerRegisterUC();
        TabPage tb = new TabPage();
        uC.Dock = DockStyle.Fill;

        tb.Name = "Cadastro de Clientes";
        tb.Text = "Cadastro de Clientes";
        tb.ImageIndex = 7;
        tb.Controls.Add(uC);

        tbcApplications.TabPages.Add(tb);
      }
      else {
        MessageBox.Show($"Cadastro de Clientes já está aberto!",
                         "Mensagem",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
      }
    }

    private void CloseTab(TabPage tb) {
      if (tb.Name == "Cadastro de Clientes") {
        controlCustomerRegister = 0;
      }

      tbcApplications.TabPages.Remove(tb);
    }

    private void agênciaToolStripMenuItem_Click(object sender, EventArgs e) {
      Agency F = new Agency();
      F.ShowDialog();
    }
  }
}
