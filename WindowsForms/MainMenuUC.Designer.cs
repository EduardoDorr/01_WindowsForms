
namespace WindowsForms {
  partial class MainMenuUC {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuUC));
      this.mnuMain = new System.Windows.Forms.MenuStrip();
      this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.máscaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.validaCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.validaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.validaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.byteBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fecharAbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.imlImages = new System.Windows.Forms.ImageList(this.components);
      this.tbcApplications = new System.Windows.Forms.TabControl();
      this.mnuMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // mnuMain
      // 
      this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.byteBankToolStripMenuItem,
            this.açõesToolStripMenuItem});
      this.mnuMain.Location = new System.Drawing.Point(0, 0);
      this.mnuMain.Name = "mnuMain";
      this.mnuMain.Size = new System.Drawing.Size(818, 24);
      this.mnuMain.TabIndex = 0;
      this.mnuMain.Text = "menuStrip1";
      // 
      // arquivoToolStripMenuItem
      // 
      this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.sairToolStripMenuItem});
      this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
      this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.arquivoToolStripMenuItem.Text = "Arquivo";
      // 
      // conectarToolStripMenuItem
      // 
      this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
      this.conectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
      this.conectarToolStripMenuItem.Text = "Conectar";
      this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
      // 
      // desconectarToolStripMenuItem
      // 
      this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
      this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
      this.desconectarToolStripMenuItem.Text = "Desconectar";
      this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
      // 
      // novoToolStripMenuItem
      // 
      this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demonstraçãoKeyToolStripMenuItem,
            this.helloWorldToolStripMenuItem,
            this.máscaraToolStripMenuItem,
            this.validaCPFToolStripMenuItem,
            this.validaCPF2ToolStripMenuItem,
            this.validaSenhaToolStripMenuItem});
      this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
      this.novoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
      this.novoToolStripMenuItem.Text = "Novo";
      // 
      // demonstraçãoKeyToolStripMenuItem
      // 
      this.demonstraçãoKeyToolStripMenuItem.Image = global::WindowsForms.Properties.Resources.imgDemonstracaoKey;
      this.demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
      this.demonstraçãoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
      this.demonstraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.demonstraçãoKeyToolStripMenuItem.Text = "Demonstração &Key";
      this.demonstraçãoKeyToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoKeyToolStripMenuItem_Click);
      // 
      // helloWorldToolStripMenuItem
      // 
      this.helloWorldToolStripMenuItem.Image = global::WindowsForms.Properties.Resources.imgHelloWorld;
      this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
      this.helloWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
      this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.helloWorldToolStripMenuItem.Text = "Hello &World";
      this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.helloWorldToolStripMenuItem_Click);
      // 
      // máscaraToolStripMenuItem
      // 
      this.máscaraToolStripMenuItem.Image = global::WindowsForms.Properties.Resources.imgMask;
      this.máscaraToolStripMenuItem.Name = "máscaraToolStripMenuItem";
      this.máscaraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
      this.máscaraToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.máscaraToolStripMenuItem.Text = "&Máscara";
      this.máscaraToolStripMenuItem.Click += new System.EventHandler(this.máscaraToolStripMenuItem_Click);
      // 
      // validaCPFToolStripMenuItem
      // 
      this.validaCPFToolStripMenuItem.Image = global::WindowsForms.Properties.Resources.imgValidateCPF;
      this.validaCPFToolStripMenuItem.Name = "validaCPFToolStripMenuItem";
      this.validaCPFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
      this.validaCPFToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.validaCPFToolStripMenuItem.Text = "Valida &CPF";
      this.validaCPFToolStripMenuItem.Click += new System.EventHandler(this.validaCPFToolStripMenuItem_Click);
      // 
      // validaCPF2ToolStripMenuItem
      // 
      this.validaCPF2ToolStripMenuItem.Image = global::WindowsForms.Properties.Resources.imgValidateCPF2;
      this.validaCPF2ToolStripMenuItem.Name = "validaCPF2ToolStripMenuItem";
      this.validaCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
      this.validaCPF2ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.validaCPF2ToolStripMenuItem.Text = "Valida C&PF 2";
      this.validaCPF2ToolStripMenuItem.Click += new System.EventHandler(this.validaCPF2ToolStripMenuItem_Click);
      // 
      // validaSenhaToolStripMenuItem
      // 
      this.validaSenhaToolStripMenuItem.Image = global::WindowsForms.Properties.Resources.imgValidatePassword;
      this.validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
      this.validaSenhaToolStripMenuItem.ShortcutKeyDisplayString = "";
      this.validaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
      this.validaSenhaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.validaSenhaToolStripMenuItem.Text = "Valida &Senha";
      this.validaSenhaToolStripMenuItem.Click += new System.EventHandler(this.validaSenhaToolStripMenuItem_Click);
      // 
      // sairToolStripMenuItem
      // 
      this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
      this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.sairToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
      this.sairToolStripMenuItem.Text = "Sair";
      this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
      // 
      // byteBankToolStripMenuItem
      // 
      this.byteBankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
      this.byteBankToolStripMenuItem.Image = global::WindowsForms.Properties.Resources.imgMoney;
      this.byteBankToolStripMenuItem.Name = "byteBankToolStripMenuItem";
      this.byteBankToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
      this.byteBankToolStripMenuItem.Text = "ByteBank";
      // 
      // cadastrosToolStripMenuItem
      // 
      this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
      this.cadastrosToolStripMenuItem.Image = global::WindowsForms.Properties.Resources.imgRegister;
      this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
      this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.cadastrosToolStripMenuItem.Text = "Cadastros";
      // 
      // clienteToolStripMenuItem
      // 
      this.clienteToolStripMenuItem.Image = global::WindowsForms.Properties.Resources.imgUser;
      this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
      this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.clienteToolStripMenuItem.Text = "Cliente";
      this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
      // 
      // açõesToolStripMenuItem
      // 
      this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem,
            this.fecharAbaToolStripMenuItem});
      this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
      this.açõesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
      this.açõesToolStripMenuItem.Text = "Ações";
      // 
      // abrirImagemToolStripMenuItem
      // 
      this.abrirImagemToolStripMenuItem.DoubleClickEnabled = true;
      this.abrirImagemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirImagemToolStripMenuItem.Image")));
      this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
      this.abrirImagemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
      this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
      this.abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
      this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.abrirImagemToolStripMenuItem_Click);
      // 
      // fecharAbaToolStripMenuItem
      // 
      this.fecharAbaToolStripMenuItem.Name = "fecharAbaToolStripMenuItem";
      this.fecharAbaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
      this.fecharAbaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
      this.fecharAbaToolStripMenuItem.Text = "Fechar Aba";
      this.fecharAbaToolStripMenuItem.Click += new System.EventHandler(this.fecharAbaToolStripMenuItem_Click);
      // 
      // imlImages
      // 
      this.imlImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlImages.ImageStream")));
      this.imlImages.TransparentColor = System.Drawing.Color.Transparent;
      this.imlImages.Images.SetKeyName(0, "DemonstracaoKey.png");
      this.imlImages.Images.SetKeyName(1, "HelloWorld.png");
      this.imlImages.Images.SetKeyName(2, "Mask.png");
      this.imlImages.Images.SetKeyName(3, "ValidateCPF.png");
      this.imlImages.Images.SetKeyName(4, "ValidateCPF2.png");
      this.imlImages.Images.SetKeyName(5, "ValidatePassword.png");
      this.imlImages.Images.SetKeyName(6, "imgFolder.png");
      this.imlImages.Images.SetKeyName(7, "imgUser.png");
      // 
      // tbcApplications
      // 
      this.tbcApplications.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbcApplications.ImageList = this.imlImages;
      this.tbcApplications.Location = new System.Drawing.Point(0, 24);
      this.tbcApplications.Name = "tbcApplications";
      this.tbcApplications.SelectedIndex = 0;
      this.tbcApplications.Size = new System.Drawing.Size(818, 567);
      this.tbcApplications.TabIndex = 1;
      this.tbcApplications.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbcApplications_MouseDown);
      // 
      // MainMenuUC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(818, 591);
      this.Controls.Add(this.tbcApplications);
      this.Controls.Add(this.mnuMain);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.mnuMain;
      this.Name = "MainMenuUC";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Principal";
      this.mnuMain.ResumeLayout(false);
      this.mnuMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mnuMain;
    private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem máscaraToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem validaCPFToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem validaCPF2ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem validaSenhaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    private System.Windows.Forms.ImageList imlImages;
    private System.Windows.Forms.TabControl tbcApplications;
    private System.Windows.Forms.ToolStripMenuItem açõesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fecharAbaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem byteBankToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
  }
}