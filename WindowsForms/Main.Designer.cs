
namespace WindowsForms {
  partial class Main {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.btnDemonstracaoKey = new System.Windows.Forms.Button();
      this.btnHelloWorld = new System.Windows.Forms.Button();
      this.btnMask = new System.Windows.Forms.Button();
      this.btnValidateCPF = new System.Windows.Forms.Button();
      this.btnValidateCPF2 = new System.Windows.Forms.Button();
      this.btnValidatePassword = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnDemonstracaoKey
      // 
      this.btnDemonstracaoKey.Image = ((System.Drawing.Image)(resources.GetObject("btnDemonstracaoKey.Image")));
      this.btnDemonstracaoKey.Location = new System.Drawing.Point(12, 12);
      this.btnDemonstracaoKey.Name = "btnDemonstracaoKey";
      this.btnDemonstracaoKey.Size = new System.Drawing.Size(114, 48);
      this.btnDemonstracaoKey.TabIndex = 0;
      this.btnDemonstracaoKey.Text = "Demonstração Key";
      this.btnDemonstracaoKey.UseVisualStyleBackColor = true;
      this.btnDemonstracaoKey.Click += new System.EventHandler(this.btnDemonstracaoKey_Click);
      // 
      // btnHelloWorld
      // 
      this.btnHelloWorld.Image = ((System.Drawing.Image)(resources.GetObject("btnHelloWorld.Image")));
      this.btnHelloWorld.Location = new System.Drawing.Point(132, 12);
      this.btnHelloWorld.Name = "btnHelloWorld";
      this.btnHelloWorld.Size = new System.Drawing.Size(114, 48);
      this.btnHelloWorld.TabIndex = 1;
      this.btnHelloWorld.Text = "Hello World";
      this.btnHelloWorld.UseVisualStyleBackColor = true;
      this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
      // 
      // btnMask
      // 
      this.btnMask.Image = ((System.Drawing.Image)(resources.GetObject("btnMask.Image")));
      this.btnMask.Location = new System.Drawing.Point(252, 12);
      this.btnMask.Name = "btnMask";
      this.btnMask.Size = new System.Drawing.Size(114, 48);
      this.btnMask.TabIndex = 2;
      this.btnMask.Text = "Máscara";
      this.btnMask.UseVisualStyleBackColor = true;
      this.btnMask.Click += new System.EventHandler(this.btnMask_Click);
      // 
      // btnValidateCPF
      // 
      this.btnValidateCPF.Image = ((System.Drawing.Image)(resources.GetObject("btnValidateCPF.Image")));
      this.btnValidateCPF.Location = new System.Drawing.Point(12, 66);
      this.btnValidateCPF.Name = "btnValidateCPF";
      this.btnValidateCPF.Size = new System.Drawing.Size(114, 48);
      this.btnValidateCPF.TabIndex = 3;
      this.btnValidateCPF.Text = "Valida CPF";
      this.btnValidateCPF.UseVisualStyleBackColor = true;
      this.btnValidateCPF.Click += new System.EventHandler(this.btnValidateCPF_Click);
      // 
      // btnValidateCPF2
      // 
      this.btnValidateCPF2.Image = ((System.Drawing.Image)(resources.GetObject("btnValidateCPF2.Image")));
      this.btnValidateCPF2.Location = new System.Drawing.Point(132, 66);
      this.btnValidateCPF2.Name = "btnValidateCPF2";
      this.btnValidateCPF2.Size = new System.Drawing.Size(114, 48);
      this.btnValidateCPF2.TabIndex = 4;
      this.btnValidateCPF2.Text = "Valida CPF 2";
      this.btnValidateCPF2.UseVisualStyleBackColor = true;
      this.btnValidateCPF2.Click += new System.EventHandler(this.btnValidateCPF2_Click);
      // 
      // btnValidatePassword
      // 
      this.btnValidatePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnValidatePassword.Image")));
      this.btnValidatePassword.Location = new System.Drawing.Point(252, 66);
      this.btnValidatePassword.Name = "btnValidatePassword";
      this.btnValidatePassword.Size = new System.Drawing.Size(114, 48);
      this.btnValidatePassword.TabIndex = 5;
      this.btnValidatePassword.Text = "Valida Senha";
      this.btnValidatePassword.UseVisualStyleBackColor = true;
      this.btnValidatePassword.Click += new System.EventHandler(this.btnValidatePassword_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(377, 126);
      this.Controls.Add(this.btnValidatePassword);
      this.Controls.Add(this.btnValidateCPF2);
      this.Controls.Add(this.btnValidateCPF);
      this.Controls.Add(this.btnMask);
      this.Controls.Add(this.btnHelloWorld);
      this.Controls.Add(this.btnDemonstracaoKey);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Principal";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnDemonstracaoKey;
    private System.Windows.Forms.Button btnHelloWorld;
    private System.Windows.Forms.Button btnMask;
    private System.Windows.Forms.Button btnValidateCPF;
    private System.Windows.Forms.Button btnValidateCPF2;
    private System.Windows.Forms.Button btnValidatePassword;
  }
}