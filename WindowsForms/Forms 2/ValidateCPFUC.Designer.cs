
namespace WindowsForms {
  partial class ValidateCPFUC {
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
      this.btnValidate = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.mskCPF = new System.Windows.Forms.MaskedTextBox();
      this.lblResult = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnValidate
      // 
      this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnValidate.Location = new System.Drawing.Point(253, 99);
      this.btnValidate.Name = "btnValidate";
      this.btnValidate.Size = new System.Drawing.Size(111, 23);
      this.btnValidate.TabIndex = 6;
      this.btnValidate.Text = "Valida";
      this.btnValidate.UseVisualStyleBackColor = true;
      this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
      // 
      // btnReset
      // 
      this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnReset.Location = new System.Drawing.Point(253, 70);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(111, 23);
      this.btnReset.TabIndex = 5;
      this.btnReset.Text = "Limpa";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // mskCPF
      // 
      this.mskCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mskCPF.Location = new System.Drawing.Point(20, 73);
      this.mskCPF.Mask = "000,000,000-00";
      this.mskCPF.Name = "mskCPF";
      this.mskCPF.Size = new System.Drawing.Size(218, 20);
      this.mskCPF.TabIndex = 4;
      // 
      // lblResult
      // 
      this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblResult.AutoSize = true;
      this.lblResult.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblResult.Location = new System.Drawing.Point(20, 100);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(0, 22);
      this.lblResult.TabIndex = 7;
      // 
      // ValidateCPFUC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.btnValidate);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.mskCPF);
      this.Name = "ValidateCPFUC";
      this.Size = new System.Drawing.Size(384, 193);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnValidate;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.MaskedTextBox mskCPF;
    private System.Windows.Forms.Label lblResult;
  }
}
