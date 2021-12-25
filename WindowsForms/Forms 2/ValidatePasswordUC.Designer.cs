
namespace WindowsForms {
  partial class ValidatePasswordUC {
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
      this.bntShow = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.lblResult = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // bntShow
      // 
      this.bntShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.bntShow.Location = new System.Drawing.Point(253, 90);
      this.bntShow.Name = "bntShow";
      this.bntShow.Size = new System.Drawing.Size(111, 23);
      this.bntShow.TabIndex = 7;
      this.bntShow.Text = "Mostrar Senha";
      this.bntShow.UseVisualStyleBackColor = true;
      this.bntShow.Click += new System.EventHandler(this.bntShow_Click);
      // 
      // btnReset
      // 
      this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnReset.Location = new System.Drawing.Point(253, 61);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(111, 23);
      this.btnReset.TabIndex = 6;
      this.btnReset.Text = "Limpa";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // lblResult
      // 
      this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblResult.AutoSize = true;
      this.lblResult.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblResult.Location = new System.Drawing.Point(20, 109);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(0, 22);
      this.lblResult.TabIndex = 5;
      // 
      // txtPassword
      // 
      this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPassword.Location = new System.Drawing.Point(20, 64);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(218, 20);
      this.txtPassword.TabIndex = 4;
      this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
      // 
      // ValidatePasswordUC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.bntShow);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.txtPassword);
      this.Name = "ValidatePasswordUC";
      this.Size = new System.Drawing.Size(384, 193);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button bntShow;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.TextBox txtPassword;
  }
}
