
namespace WindowsForms {
  partial class Mask {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mask));
      this.mskTextBox = new System.Windows.Forms.MaskedTextBox();
      this.lblContent = new System.Windows.Forms.Label();
      this.lblActiveMask = new System.Windows.Forms.Label();
      this.btnHour = new System.Windows.Forms.Button();
      this.btnCEP = new System.Windows.Forms.Button();
      this.btnCurrency = new System.Windows.Forms.Button();
      this.btnDate = new System.Windows.Forms.Button();
      this.btnPassword = new System.Windows.Forms.Button();
      this.btnTelephone = new System.Windows.Forms.Button();
      this.btnShowContent = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // mskTextBox
      // 
      this.mskTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mskTextBox.Location = new System.Drawing.Point(23, 31);
      this.mskTextBox.Name = "mskTextBox";
      this.mskTextBox.Size = new System.Drawing.Size(258, 26);
      this.mskTextBox.TabIndex = 0;
      // 
      // lblContent
      // 
      this.lblContent.AutoSize = true;
      this.lblContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblContent.Location = new System.Drawing.Point(23, 246);
      this.lblContent.Name = "lblContent";
      this.lblContent.Size = new System.Drawing.Size(0, 19);
      this.lblContent.TabIndex = 1;
      // 
      // lblActiveMask
      // 
      this.lblActiveMask.AutoSize = true;
      this.lblActiveMask.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblActiveMask.Location = new System.Drawing.Point(23, 75);
      this.lblActiveMask.Name = "lblActiveMask";
      this.lblActiveMask.Size = new System.Drawing.Size(0, 19);
      this.lblActiveMask.TabIndex = 2;
      // 
      // btnHour
      // 
      this.btnHour.Location = new System.Drawing.Point(23, 110);
      this.btnHour.Name = "btnHour";
      this.btnHour.Size = new System.Drawing.Size(82, 37);
      this.btnHour.TabIndex = 3;
      this.btnHour.Text = "Hora";
      this.btnHour.UseVisualStyleBackColor = true;
      this.btnHour.Click += new System.EventHandler(this.btnHour_Click);
      // 
      // btnCEP
      // 
      this.btnCEP.Location = new System.Drawing.Point(111, 110);
      this.btnCEP.Name = "btnCEP";
      this.btnCEP.Size = new System.Drawing.Size(82, 37);
      this.btnCEP.TabIndex = 4;
      this.btnCEP.Text = "CEP";
      this.btnCEP.UseVisualStyleBackColor = true;
      this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
      // 
      // btnCurrency
      // 
      this.btnCurrency.Location = new System.Drawing.Point(199, 110);
      this.btnCurrency.Name = "btnCurrency";
      this.btnCurrency.Size = new System.Drawing.Size(82, 37);
      this.btnCurrency.TabIndex = 5;
      this.btnCurrency.Text = "Moeda";
      this.btnCurrency.UseVisualStyleBackColor = true;
      this.btnCurrency.Click += new System.EventHandler(this.btnCurrency_Click);
      // 
      // btnDate
      // 
      this.btnDate.Location = new System.Drawing.Point(23, 153);
      this.btnDate.Name = "btnDate";
      this.btnDate.Size = new System.Drawing.Size(82, 37);
      this.btnDate.TabIndex = 6;
      this.btnDate.Text = "Data";
      this.btnDate.UseVisualStyleBackColor = true;
      this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
      // 
      // btnPassword
      // 
      this.btnPassword.Location = new System.Drawing.Point(111, 153);
      this.btnPassword.Name = "btnPassword";
      this.btnPassword.Size = new System.Drawing.Size(82, 37);
      this.btnPassword.TabIndex = 7;
      this.btnPassword.Text = "Senha";
      this.btnPassword.UseVisualStyleBackColor = true;
      this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
      // 
      // btnTelephone
      // 
      this.btnTelephone.Location = new System.Drawing.Point(199, 153);
      this.btnTelephone.Name = "btnTelephone";
      this.btnTelephone.Size = new System.Drawing.Size(82, 37);
      this.btnTelephone.TabIndex = 8;
      this.btnTelephone.Text = "Telefone";
      this.btnTelephone.UseVisualStyleBackColor = true;
      this.btnTelephone.Click += new System.EventHandler(this.btnTelephone_Click);
      // 
      // btnShowContent
      // 
      this.btnShowContent.Location = new System.Drawing.Point(23, 196);
      this.btnShowContent.Name = "btnShowContent";
      this.btnShowContent.Size = new System.Drawing.Size(258, 37);
      this.btnShowContent.TabIndex = 9;
      this.btnShowContent.Text = "Ver Conteúdo";
      this.btnShowContent.UseVisualStyleBackColor = true;
      this.btnShowContent.Click += new System.EventHandler(this.btnShowContent_Click);
      // 
      // Mask
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(312, 283);
      this.Controls.Add(this.btnShowContent);
      this.Controls.Add(this.btnTelephone);
      this.Controls.Add(this.btnPassword);
      this.Controls.Add(this.btnDate);
      this.Controls.Add(this.btnCurrency);
      this.Controls.Add(this.btnCEP);
      this.Controls.Add(this.btnHour);
      this.Controls.Add(this.lblActiveMask);
      this.Controls.Add(this.lblContent);
      this.Controls.Add(this.mskTextBox);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Mask";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Exemplos de Máscaras";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MaskedTextBox mskTextBox;
    private System.Windows.Forms.Label lblContent;
    private System.Windows.Forms.Label lblActiveMask;
    private System.Windows.Forms.Button btnHour;
    private System.Windows.Forms.Button btnCEP;
    private System.Windows.Forms.Button btnCurrency;
    private System.Windows.Forms.Button btnDate;
    private System.Windows.Forms.Button btnPassword;
    private System.Windows.Forms.Button btnTelephone;
    private System.Windows.Forms.Button btnShowContent;
  }
}