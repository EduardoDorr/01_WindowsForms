
namespace WindowsForms {
  partial class ValidatePassword {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidatePassword));
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.lblResult = new System.Windows.Forms.Label();
      this.btnReset = new System.Windows.Forms.Button();
      this.bntShow = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtPassword
      // 
      this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPassword.Location = new System.Drawing.Point(12, 45);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(218, 20);
      this.txtPassword.TabIndex = 0;
      this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
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
      // bntShow
      // 
      this.bntShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.bntShow.Location = new System.Drawing.Point(245, 71);
      this.bntShow.Name = "bntShow";
      this.bntShow.Size = new System.Drawing.Size(111, 23);
      this.bntShow.TabIndex = 3;
      this.bntShow.Text = "Mostrar Senha";
      this.bntShow.UseVisualStyleBackColor = true;
      this.bntShow.Click += new System.EventHandler(this.bntShow_Click);
      // 
      // ValidatePassword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 154);
      this.Controls.Add(this.bntShow);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.txtPassword);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(384, 193);
      this.Name = "ValidatePassword";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Validação de Senhas";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button bntShow;
  }
}