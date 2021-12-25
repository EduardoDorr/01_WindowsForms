
namespace WindowsForms {
  partial class DemonstracaoKeyUC {
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
      this.lblLower = new System.Windows.Forms.Label();
      this.lblUpper = new System.Windows.Forms.Label();
      this.lblMaius = new System.Windows.Forms.Label();
      this.lblMinus = new System.Windows.Forms.Label();
      this.btnReset = new System.Windows.Forms.Button();
      this.txtMsg = new System.Windows.Forms.TextBox();
      this.txtInput = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblLower
      // 
      this.lblLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblLower.Location = new System.Drawing.Point(753, 110);
      this.lblLower.Name = "lblLower";
      this.lblLower.Size = new System.Drawing.Size(32, 23);
      this.lblLower.TabIndex = 20;
      // 
      // lblUpper
      // 
      this.lblUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblUpper.Location = new System.Drawing.Point(753, 62);
      this.lblUpper.Name = "lblUpper";
      this.lblUpper.Size = new System.Drawing.Size(32, 23);
      this.lblUpper.TabIndex = 19;
      // 
      // lblMaius
      // 
      this.lblMaius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblMaius.AutoSize = true;
      this.lblMaius.Location = new System.Drawing.Point(705, 62);
      this.lblMaius.Name = "lblMaius";
      this.lblMaius.Size = new System.Drawing.Size(38, 13);
      this.lblMaius.TabIndex = 18;
      this.lblMaius.Text = "Maius.";
      // 
      // lblMinus
      // 
      this.lblMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblMinus.AutoSize = true;
      this.lblMinus.Location = new System.Drawing.Point(705, 110);
      this.lblMinus.Name = "lblMinus";
      this.lblMinus.Size = new System.Drawing.Size(38, 13);
      this.lblMinus.TabIndex = 17;
      this.lblMinus.Text = "Minus.";
      // 
      // btnReset
      // 
      this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnReset.Location = new System.Drawing.Point(713, 14);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(75, 28);
      this.btnReset.TabIndex = 16;
      this.btnReset.Text = "Limpa";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // txtMsg
      // 
      this.txtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtMsg.Location = new System.Drawing.Point(13, 46);
      this.txtMsg.Multiline = true;
      this.txtMsg.Name = "txtMsg";
      this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtMsg.Size = new System.Drawing.Size(686, 334);
      this.txtMsg.TabIndex = 15;
      this.txtMsg.TabStop = false;
      // 
      // txtInput
      // 
      this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtInput.Location = new System.Drawing.Point(13, 14);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(100, 20);
      this.txtInput.TabIndex = 14;
      this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
      // 
      // DemonstracaoKeyUC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblLower);
      this.Controls.Add(this.lblUpper);
      this.Controls.Add(this.lblMaius);
      this.Controls.Add(this.lblMinus);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.txtMsg);
      this.Controls.Add(this.txtInput);
      this.Name = "DemonstracaoKeyUC";
      this.Size = new System.Drawing.Size(800, 426);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblLower;
    private System.Windows.Forms.Label lblUpper;
    private System.Windows.Forms.Label lblMaius;
    private System.Windows.Forms.Label lblMinus;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.TextBox txtMsg;
    private System.Windows.Forms.TextBox txtInput;
  }
}
