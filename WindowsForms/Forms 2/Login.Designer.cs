
namespace WindowsForms {
  partial class Login {
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
      this.picLogin = new System.Windows.Forms.PictureBox();
      this.lblLogin = new System.Windows.Forms.Label();
      this.lblPassword = new System.Windows.Forms.Label();
      this.txtLogin = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
      this.SuspendLayout();
      // 
      // picLogin
      // 
      this.picLogin.Image = global::WindowsForms.Properties.Resources.imgKey;
      this.picLogin.Location = new System.Drawing.Point(12, 8);
      this.picLogin.Name = "picLogin";
      this.picLogin.Size = new System.Drawing.Size(100, 93);
      this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picLogin.TabIndex = 0;
      this.picLogin.TabStop = false;
      // 
      // lblLogin
      // 
      this.lblLogin.AutoSize = true;
      this.lblLogin.Location = new System.Drawing.Point(119, 17);
      this.lblLogin.Name = "lblLogin";
      this.lblLogin.Size = new System.Drawing.Size(33, 13);
      this.lblLogin.TabIndex = 1;
      this.lblLogin.Text = "Login";
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Location = new System.Drawing.Point(119, 65);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(38, 13);
      this.lblPassword.TabIndex = 2;
      this.lblPassword.Text = "Senha";
      // 
      // txtLogin
      // 
      this.txtLogin.Location = new System.Drawing.Point(122, 33);
      this.txtLogin.Name = "txtLogin";
      this.txtLogin.Size = new System.Drawing.Size(151, 20);
      this.txtLogin.TabIndex = 3;
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(122, 81);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(151, 20);
      this.txtPassword.TabIndex = 4;
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(12, 114);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 5;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(198, 114);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Cancela";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(279, 149);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtLogin);
      this.Controls.Add(this.lblPassword);
      this.Controls.Add(this.lblLogin);
      this.Controls.Add(this.picLogin);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picLogin;
    private System.Windows.Forms.Label lblLogin;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtLogin;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
  }
}