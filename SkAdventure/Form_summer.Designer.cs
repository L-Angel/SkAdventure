namespace SkAdventure
{
    partial class Form_summer
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
            this.pictureBox_summer3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_summer2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_summer1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_summer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_summer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_summer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_summer3
            // 
            this.pictureBox_summer3.Image = global::SkAdventure.Properties.Resources.summer_3;
            this.pictureBox_summer3.Location = new System.Drawing.Point(535, 113);
            this.pictureBox_summer3.Name = "pictureBox_summer3";
            this.pictureBox_summer3.Size = new System.Drawing.Size(222, 142);
            this.pictureBox_summer3.TabIndex = 0;
            this.pictureBox_summer3.TabStop = false;
            // 
            // pictureBox_summer2
            // 
            this.pictureBox_summer2.Image = global::SkAdventure.Properties.Resources.summer_2;
            this.pictureBox_summer2.Location = new System.Drawing.Point(284, 113);
            this.pictureBox_summer2.Name = "pictureBox_summer2";
            this.pictureBox_summer2.Size = new System.Drawing.Size(220, 142);
            this.pictureBox_summer2.TabIndex = 1;
            this.pictureBox_summer2.TabStop = false;
            // 
            // pictureBox_summer1
            // 
            this.pictureBox_summer1.Image = global::SkAdventure.Properties.Resources.summer_1;
            this.pictureBox_summer1.Location = new System.Drawing.Point(37, 113);
            this.pictureBox_summer1.Name = "pictureBox_summer1";
            this.pictureBox_summer1.Size = new System.Drawing.Size(222, 142);
            this.pictureBox_summer1.TabIndex = 2;
            this.pictureBox_summer1.TabStop = false;
            // 
            // Form_summer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkAdventure.Properties.Resources.background_summer;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.pictureBox_summer1);
            this.Controls.Add(this.pictureBox_summer2);
            this.Controls.Add(this.pictureBox_summer3);
            this.Name = "Form_summer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "夏";
            this.Shown += new System.EventHandler(this.Form_summer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_summer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_summer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_summer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_summer3;
        private System.Windows.Forms.PictureBox pictureBox_summer2;
        private System.Windows.Forms.PictureBox pictureBox_summer1;
    }
}