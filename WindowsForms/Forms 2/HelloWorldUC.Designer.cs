
namespace WindowsForms {
  partial class HelloWorldUC {
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

    #region Código gerado pelo Designer de Componentes

    /// <summary> 
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent() {
      this.txtContent = new System.Windows.Forms.TextBox();
      this.btnChangeLabel = new System.Windows.Forms.Button();
      this.lblTitle = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtContent
      // 
      this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtContent.Location = new System.Drawing.Point(20, 66);
      this.txtContent.Name = "txtContent";
      this.txtContent.Size = new System.Drawing.Size(437, 20);
      this.txtContent.TabIndex = 6;
      // 
      // btnChangeLabel
      // 
      this.btnChangeLabel.Location = new System.Drawing.Point(20, 37);
      this.btnChangeLabel.Name = "btnChangeLabel";
      this.btnChangeLabel.Size = new System.Drawing.Size(209, 23);
      this.btnChangeLabel.TabIndex = 5;
      this.btnChangeLabel.Text = "Modifica o Texto do Label";
      this.btnChangeLabel.UseVisualStyleBackColor = true;
      this.btnChangeLabel.Click += new System.EventHandler(this.btnChangeLabel_Click);
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(20, 15);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(213, 19);
      this.lblTitle.TabIndex = 4;
      this.lblTitle.Text = "Visual Studio .NET Version";
      // 
      // HelloWorldUC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtContent);
      this.Controls.Add(this.btnChangeLabel);
      this.Controls.Add(this.lblTitle);
      this.Name = "HelloWorldUC";
      this.Size = new System.Drawing.Size(477, 367);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtContent;
    private System.Windows.Forms.Button btnChangeLabel;
    private System.Windows.Forms.Label lblTitle;
  }
}
