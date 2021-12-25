
namespace WindowsForms {
  partial class Question {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
      this.lblQuestion = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.picImage = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
      this.SuspendLayout();
      // 
      // lblQuestion
      // 
      this.lblQuestion.AutoSize = true;
      this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblQuestion.Location = new System.Drawing.Point(18, 9);
      this.lblQuestion.Name = "lblQuestion";
      this.lblQuestion.Size = new System.Drawing.Size(229, 20);
      this.lblQuestion.TabIndex = 0;
      this.lblQuestion.Text = "Você deseja validar a CPF?";
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(147, 60);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(115, 23);
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "Sim, continue!";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(147, 89);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(115, 23);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Não, pare!";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // picImage
      // 
      this.picImage.Image = global::WindowsForms.Properties.Resources.imgQuestion;
      this.picImage.Location = new System.Drawing.Point(48, 53);
      this.picImage.Name = "picImage";
      this.picImage.Size = new System.Drawing.Size(64, 64);
      this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.picImage.TabIndex = 3;
      this.picImage.TabStop = false;
      // 
      // Question
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(289, 151);
      this.Controls.Add(this.picImage);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.lblQuestion);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Question";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Question";
      ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblQuestion;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.PictureBox picImage;
  }
}