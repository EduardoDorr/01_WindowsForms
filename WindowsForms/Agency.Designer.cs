
namespace WindowsForms {
  partial class Agency {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agency));
      this.tlsMain = new System.Windows.Forms.ToolStrip();
      this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.tlsMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // tlsMain
      // 
      this.tlsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripButton});
      this.tlsMain.Location = new System.Drawing.Point(0, 0);
      this.tlsMain.Name = "tlsMain";
      this.tlsMain.Size = new System.Drawing.Size(384, 25);
      this.tlsMain.TabIndex = 33;
      this.tlsMain.Text = "toolStrip1";
      // 
      // closeToolStripButton
      // 
      this.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.closeToolStripButton.Image = global::WindowsForms.Properties.Resources.imgDeleteBar;
      this.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.closeToolStripButton.Name = "closeToolStripButton";
      this.closeToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.closeToolStripButton.Text = "&Fechar";
      this.closeToolStripButton.ToolTipText = "Fechar";
      this.closeToolStripButton.Click += new System.EventHandler(this.closeToolStripButton_Click);
      // 
      // Agency
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 336);
      this.Controls.Add(this.tlsMain);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Agency";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Agências";
      this.tlsMain.ResumeLayout(false);
      this.tlsMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip tlsMain;
    private System.Windows.Forms.ToolStripButton closeToolStripButton;
  }
}