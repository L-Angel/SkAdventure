namespace SkAdventure
{
    partial class Form_autumn
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
            this.pictureBox_autumn1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_autumn2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_autumn3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_autumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_autumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_autumn3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_autumn1
            // 
            this.pictureBox_autumn1.Image = global::SkAdventure.Properties.Resources.autumn_1;
            this.pictureBox_autumn1.Location = new System.Drawing.Point(162, 12);
            this.pictureBox_autumn1.Name = "pictureBox_autumn1";
            this.pictureBox_autumn1.Size = new System.Drawing.Size(201, 148);
            this.pictureBox_autumn1.TabIndex = 0;
            this.pictureBox_autumn1.TabStop = false;
            // 
            // pictureBox_autumn2
            // 
            this.pictureBox_autumn2.Image = global::SkAdventure.Properties.Resources.autumn_2;
            this.pictureBox_autumn2.Location = new System.Drawing.Point(162, 185);
            this.pictureBox_autumn2.Name = "pictureBox_autumn2";
            this.pictureBox_autumn2.Size = new System.Drawing.Size(201, 152);
            this.pictureBox_autumn2.TabIndex = 1;
            this.pictureBox_autumn2.TabStop = false;
            // 
            // pictureBox_autumn3
            // 
            this.pictureBox_autumn3.Image = global::SkAdventure.Properties.Resources.autumn_3;
            this.pictureBox_autumn3.Location = new System.Drawing.Point(162, 363);
            this.pictureBox_autumn3.Name = "pictureBox_autumn3";
            this.pictureBox_autumn3.Size = new System.Drawing.Size(201, 146);
            this.pictureBox_autumn3.TabIndex = 2;
            this.pictureBox_autumn3.TabStop = false;
            // 
            // Form_autumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkAdventure.Properties.Resources.background_autumn;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.pictureBox_autumn3);
            this.Controls.Add(this.pictureBox_autumn2);
            this.Controls.Add(this.pictureBox_autumn1);
            this.Name = "Form_autumn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "秋";
            this.Load += new System.EventHandler(this.Form_autumn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_autumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_autumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_autumn3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_autumn1;
        private System.Windows.Forms.PictureBox pictureBox_autumn2;
        private System.Windows.Forms.PictureBox pictureBox_autumn3;
    }
}