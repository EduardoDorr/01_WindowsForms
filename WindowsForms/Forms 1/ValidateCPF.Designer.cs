
namespace WindowsForms {
  partial class ValidateCPF {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateCPF));
      this.mskCPF = new System.Windows.Forms.MaskedTextBox();
      this.lblResult = new System.Windows.Forms.Label();
      this.btnReset = new System.Windows.Forms.Button();
      this.btnValidate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // mskCPF
      // 
      this.mskCPF.Location = new System.Drawing.Point(12, 45);
      this.mskCPF.Mask = "000,000,000-00";
      this.mskCPF.Name = "mskCPF";
      this.mskCPF.Size = new System.Drawing.Size(218, 20);
      this.mskCPF.TabIndex = 0;
      // 
      // lblResult
      // 
      this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblResult.AutoSize = true;
      this.lblResult.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblResult.Location = new System.Drawing.Point(12, 90);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(0, 22);
      this.lblResult.TabIndex = 1;
      // 
      // btnReset
      // 
      this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnReset.Location = new System.Drawing.Point(245, 42);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(111, 23);
      this.btnReset.TabIndex = 2;
      this.btnReset.Text = "Limpa";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // btnValidate
      // 
      this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnValidate.Location = new System.Drawing.Point(245, 71);
      this.btnValidate.Name = "btnValidate";
      this.btnValidate.Size = new System.Drawing.Size(111, 23);
      this.btnValidate.TabIndex = 3;
      this.btnValidate.Text = "Valida";
      this.btnValidate.UseVisualStyleBackColor = true;
      this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
      // 
      // ValidateCPF
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 154);
      this.Controls.Add(this.btnValidate);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.mskCPF);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(384, 193);
      this.Name = "ValidateCPF";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Validação CPF";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MaskedTextBox mskCPF;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnValidate;
  }
}