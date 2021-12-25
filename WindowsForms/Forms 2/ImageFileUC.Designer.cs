
namespace WindowsForms {
  partial class ImageFileUC {
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
      this.lblImageFile = new System.Windows.Forms.Label();
      this.picImage = new System.Windows.Forms.PictureBox();
      this.brtnColor = new System.Windows.Forms.Button();
      this.btnFont = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
      this.SuspendLayout();
      // 
      // lblImageFile
      // 
      this.lblImageFile.AutoSize = true;
      this.lblImageFile.Location = new System.Drawing.Point(17, 54);
      this.lblImageFile.Name = "lblImageFile";
      this.lblImageFile.Size = new System.Drawing.Size(29, 13);
      this.lblImageFile.TabIndex = 0;
      this.lblImageFile.Text = "label";
      // 
      // picImage
      // 
      this.picImage.Location = new System.Drawing.Point(20, 86);
      this.picImage.Name = "picImage";
      this.picImage.Size = new System.Drawing.Size(210, 150);
      this.picImage.TabIndex = 1;
      this.picImage.TabStop = false;
      // 
      // brtnColor
      // 
      this.brtnColor.Location = new System.Drawing.Point(20, 10);
      this.brtnColor.Name = "brtnColor";
      this.brtnColor.Size = new System.Drawing.Size(75, 23);
      this.brtnColor.TabIndex = 2;
      this.brtnColor.Text = "Cor";
      this.brtnColor.UseVisualStyleBackColor = true;
      this.brtnColor.Click += new System.EventHandler(this.brtnColor_Click);
      // 
      // btnFont
      // 
      this.btnFont.Location = new System.Drawing.Point(101, 10);
      this.btnFont.Name = "btnFont";
      this.btnFont.Size = new System.Drawing.Size(75, 23);
      this.btnFont.TabIndex = 3;
      this.btnFont.Text = "Fonte";
      this.btnFont.UseVisualStyleBackColor = true;
      this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
      // 
      // ImageFileUC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnFont);
      this.Controls.Add(this.brtnColor);
      this.Controls.Add(this.picImage);
      this.Controls.Add(this.lblImageFile);
      this.Name = "ImageFileUC";
      this.Size = new System.Drawing.Size(691, 354);
      ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblImageFile;
    private System.Windows.Forms.PictureBox picImage;
    private System.Windows.Forms.Button brtnColor;
    private System.Windows.Forms.Button btnFont;
  }
}
