
namespace WindowsForms {
  partial class HelloWorld {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloWorld));
      this.lblTitle = new System.Windows.Forms.Label();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnChangeLabel = new System.Windows.Forms.Button();
      this.txtContent = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(12, 33);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(213, 19);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "Visual Studio .NET Version";
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(374, 293);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(75, 23);
      this.btnExit.TabIndex = 1;
      this.btnExit.Text = "Fechar";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnChangeLabel
      // 
      this.btnChangeLabel.Location = new System.Drawing.Point(12, 55);
      this.btnChangeLabel.Name = "btnChangeLabel";
      this.btnChangeLabel.Size = new System.Drawing.Size(209, 23);
      this.btnChangeLabel.TabIndex = 2;
      this.btnChangeLabel.Text = "Modifica o Texto do Label";
      this.btnChangeLabel.UseVisualStyleBackColor = true;
      this.btnChangeLabel.Click += new System.EventHandler(this.btnChangeLabel_Click);
      // 
      // txtContent
      // 
      this.txtContent.Location = new System.Drawing.Point(12, 84);
      this.txtContent.Name = "txtContent";
      this.txtContent.Size = new System.Drawing.Size(437, 20);
      this.txtContent.TabIndex = 3;
      // 
      // HelloWorld
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(461, 328);
      this.Controls.Add(this.txtContent);
      this.Controls.Add(this.btnChangeLabel);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.lblTitle);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "HelloWorld";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Hello World!";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnChangeLabel;
    private System.Windows.Forms.TextBox txtContent;
  }
}

