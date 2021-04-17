
namespace Sahand
{
    partial class Aks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btaks = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btaks
            // 
            this.btaks.Location = new System.Drawing.Point(666, 209);
            this.btaks.Name = "btaks";
            this.btaks.Size = new System.Drawing.Size(106, 39);
            this.btaks.TabIndex = 1;
            this.btaks.Text = "ثبت و انتخاب";
            this.btaks.UseVisualStyleBackColor = true;
            this.btaks.Click += new System.EventHandler(this.btaks_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(414, 210);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(106, 38);
            this.btexit.TabIndex = 2;
            this.btexit.Text = "خروج";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // Aks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btaks);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Aks";
            this.Text = "Aks";
            this.Load += new System.EventHandler(this.Aks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btaks;
        private System.Windows.Forms.Button btexit;
    }
}