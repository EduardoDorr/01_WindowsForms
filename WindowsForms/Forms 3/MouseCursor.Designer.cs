
namespace WindowsForms {
  partial class MouseCursor {
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
      this.btnMouse = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnMouse
      // 
      this.btnMouse.Location = new System.Drawing.Point(13, 13);
      this.btnMouse.Name = "btnMouse";
      this.btnMouse.Size = new System.Drawing.Size(327, 180);
      this.btnMouse.TabIndex = 0;
      this.btnMouse.Text = "button1";
      this.btnMouse.UseVisualStyleBackColor = true;
      this.btnMouse.Click += new System.EventHandler(this.btnMouse_Click);
      // 
      // MouseCursor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(352, 205);
      this.Controls.Add(this.btnMouse);
      this.Name = "MouseCursor";
      this.Text = "MouseCursor";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnMouse;
  }
}