namespace SkAdventure
{
    partial class Form_winter
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
            this.pictureBox_winter1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_winter2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_winter3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_winter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_winter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_winter3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_winter1
            // 
            this.pictureBox_winter1.Image = global::SkAdventure.Properties.Resources.winter_1;
            this.pictureBox_winter1.Location = new System.Drawing.Point(21, 104);
            this.pictureBox_winter1.Name = "pictureBox_winter1";
            this.pictureBox_winter1.Size = new System.Drawing.Size(221, 142);
            this.pictureBox_winter1.TabIndex = 0;
            this.pictureBox_winter1.TabStop = false;
            // 
            // pictureBox_winter2
            // 
            this.pictureBox_winter2.Image = global::SkAdventure.Properties.Resources.winter_2;
            this.pictureBox_winter2.Location = new System.Drawing.Point(297, 104);
            this.pictureBox_winter2.Name = "pictureBox_winter2";
            this.pictureBox_winter2.Size = new System.Drawing.Size(220, 142);
            this.pictureBox_winter2.TabIndex = 1;
            this.pictureBox_winter2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox_winter3
            // 
            this.pictureBox_winter3.Image = global::SkAdventure.Properties.Resources.winter_3;
            this.pictureBox_winter3.Location = new System.Drawing.Point(550, 104);
            this.pictureBox_winter3.Name = "pictureBox_winter3";
            this.pictureBox_winter3.Size = new System.Drawing.Size(222, 142);
            this.pictureBox_winter3.TabIndex = 3;
            this.pictureBox_winter3.TabStop = false;
            // 
            // Form_winter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkAdventure.Properties.Resources.background_winter;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.pictureBox_winter3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox_winter2);
            this.Controls.Add(this.pictureBox_winter1);
            this.Name = "Form_winter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "冬";
            this.Load += new System.EventHandler(this.Form_winter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_winter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_winter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_winter3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_winter1;
        private System.Windows.Forms.PictureBox pictureBox_winter2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox_winter3;
    }
}