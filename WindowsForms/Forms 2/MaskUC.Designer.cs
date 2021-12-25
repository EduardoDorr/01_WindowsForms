
namespace WindowsForms {
  partial class MaskUC {
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
      this.btnShowContent = new System.Windows.Forms.Button();
      this.btnTelephone = new System.Windows.Forms.Button();
      this.btnPassword = new System.Windows.Forms.Button();
      this.btnDate = new System.Windows.Forms.Button();
      this.btnCurrency = new System.Windows.Forms.Button();
      this.btnCEP = new System.Windows.Forms.Button();
      this.btnHour = new System.Windows.Forms.Button();
      this.lblActiveMask = new System.Windows.Forms.Label();
      this.lblContent = new System.Windows.Forms.Label();
      this.mskTextBox = new System.Windows.Forms.MaskedTextBox();
      this.SuspendLayout();
      // 
      // btnShowContent
      // 
      this.btnShowContent.Location = new System.Drawing.Point(35, 209);
      this.btnShowContent.Name = "btnShowContent";
      this.btnShowContent.Size = new System.Drawing.Size(258, 37);
      this.btnShowContent.TabIndex = 19;
      this.btnShowContent.Text = "Ver Conteúdo";
      this.btnShowContent.UseVisualStyleBackColor = true;
      this.btnShowContent.Click += new System.EventHandler(this.btnShowContent_Click);
      // 
      // btnTelephone
      // 
      this.btnTelephone.Location = new System.Drawing.Point(211, 166);
      this.btnTelephone.Name = "btnTelephone";
      this.btnTelephone.Size = new System.Drawing.Size(82, 37);
      this.btnTelephone.TabIndex = 18;
      this.btnTelephone.Text = "Telefone";
      this.btnTelephone.UseVisualStyleBackColor = true;
      this.btnTelephone.Click += new System.EventHandler(this.btnTelephone_Click);
      // 
      // btnPassword
      // 
      this.btnPassword.Location = new System.Drawing.Point(123, 166);
      this.btnPassword.Name = "btnPassword";
      this.btnPassword.Size = new System.Drawing.Size(82, 37);
      this.btnPassword.TabIndex = 17;
      this.btnPassword.Text = "Senha";
      this.btnPassword.UseVisualStyleBackColor = true;
      this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
      // 
      // btnDate
      // 
      this.btnDate.Location = new System.Drawing.Point(35, 166);
      this.btnDate.Name = "btnDate";
      this.btnDate.Size = new System.Drawing.Size(82, 37);
      this.btnDate.TabIndex = 16;
      this.btnDate.Text = "Data";
      this.btnDate.UseVisualStyleBackColor = true;
      this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
      // 
      // btnCurrency
      // 
      this.btnCurrency.Location = new System.Drawing.Point(211, 123);
      this.btnCurrency.Name = "btnCurrency";
      this.btnCurrency.Size = new System.Drawing.Size(82, 37);
      this.btnCurrency.TabIndex = 15;
      this.btnCurrency.Text = "Moeda";
      this.btnCurrency.UseVisualStyleBackColor = true;
      this.btnCurrency.Click += new System.EventHandler(this.btnCurrency_Click);
      // 
      // btnCEP
      // 
      this.btnCEP.Location = new System.Drawing.Point(123, 123);
      this.btnCEP.Name = "btnCEP";
      this.btnCEP.Size = new System.Drawing.Size(82, 37);
      this.btnCEP.TabIndex = 14;
      this.btnCEP.Text = "CEP";
      this.btnCEP.UseVisualStyleBackColor = true;
      this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
      // 
      // btnHour
      // 
      this.btnHour.Location = new System.Drawing.Point(35, 123);
      this.btnHour.Name = "btnHour";
      this.btnHour.Size = new System.Drawing.Size(82, 37);
      this.btnHour.TabIndex = 13;
      this.btnHour.Text = "Hora";
      this.btnHour.UseVisualStyleBackColor = true;
      this.btnHour.Click += new System.EventHandler(this.btnHour_Click);
      // 
      // lblActiveMask
      // 
      this.lblActiveMask.AutoSize = true;
      this.lblActiveMask.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblActiveMask.Location = new System.Drawing.Point(35, 88);
      this.lblActiveMask.Name = "lblActiveMask";
      this.lblActiveMask.Size = new System.Drawing.Size(0, 19);
      this.lblActiveMask.TabIndex = 12;
      // 
      // lblContent
      // 
      this.lblContent.AutoSize = true;
      this.lblContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblContent.Location = new System.Drawing.Point(35, 259);
      this.lblContent.Name = "lblContent";
      this.lblContent.Size = new System.Drawing.Size(0, 19);
      this.lblContent.TabIndex = 11;
      // 
      // mskTextBox
      // 
      this.mskTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mskTextBox.Location = new System.Drawing.Point(35, 44);
      this.mskTextBox.Name = "mskTextBox";
      this.mskTextBox.Size = new System.Drawing.Size(258, 26);
      this.mskTextBox.TabIndex = 10;
      // 
      // MaskUC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
      this.Name = "MaskUC";
      this.Size = new System.Drawing.Size(328, 322);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnShowContent;
    private System.Windows.Forms.Button btnTelephone;
    private System.Windows.Forms.Button btnPassword;
    private System.Windows.Forms.Button btnDate;
    private System.Windows.Forms.Button btnCurrency;
    private System.Windows.Forms.Button btnCEP;
    private System.Windows.Forms.Button btnHour;
    private System.Windows.Forms.Label lblActiveMask;
    private System.Windows.Forms.Label lblContent;
    private System.Windows.Forms.MaskedTextBox mskTextBox;
  }
}
