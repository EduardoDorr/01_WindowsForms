
namespace WindowsForms {
  partial class ValidateCPF2 {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateCPF2));
      this.mskCPF = new System.Windows.Forms.MaskedTextBox();
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
      // btnReset
      // 
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
      this.btnValidate.Location = new System.Drawing.Point(245, 71);
      this.btnValidate.Name = "btnValidate";
      this.btnValidate.Size = new System.Drawing.Size(111, 23);
      this.btnValidate.TabIndex = 3;
      this.btnValidate.Text = "Valida";
      this.btnValidate.UseVisualStyleBackColor = true;
      this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
      // 
      // ValidateCPF2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 154);
      this.Controls.Add(this.btnValidate);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.mskCPF);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "ValidateCPF2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Validação CPF";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MaskedTextBox mskCPF;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnValidate;
  }
}