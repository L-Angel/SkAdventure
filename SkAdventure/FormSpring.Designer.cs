namespace SkAdventure
{
    partial class FormSpring
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
            this.pictureBox_spring3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_spring2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_spring1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spring3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spring2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spring1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_spring3
            // 
            this.pictureBox_spring3.Image = global::SkAdventure.Properties.Resources.spring_3;
            this.pictureBox_spring3.Location = new System.Drawing.Point(536, 102);
            this.pictureBox_spring3.Name = "pictureBox_spring3";
            this.pictureBox_spring3.Size = new System.Drawing.Size(222, 142);
            this.pictureBox_spring3.TabIndex = 0;
            this.pictureBox_spring3.TabStop = false;
            // 
            // pictureBox_spring2
            // 
            this.pictureBox_spring2.Image = global::SkAdventure.Properties.Resources.spring_2;
            this.pictureBox_spring2.Location = new System.Drawing.Point(287, 102);
            this.pictureBox_spring2.Name = "pictureBox_spring2";
            this.pictureBox_spring2.Size = new System.Drawing.Size(219, 142);
            this.pictureBox_spring2.TabIndex = 1;
            this.pictureBox_spring2.TabStop = false;
            // 
            // pictureBox_spring1
            // 
            this.pictureBox_spring1.Image = global::SkAdventure.Properties.Resources.spring_1;
            this.pictureBox_spring1.Location = new System.Drawing.Point(30, 102);
            this.pictureBox_spring1.Name = "pictureBox_spring1";
            this.pictureBox_spring1.Size = new System.Drawing.Size(221, 142);
            this.pictureBox_spring1.TabIndex = 2;
            this.pictureBox_spring1.TabStop = false;
            this.pictureBox_spring1.WaitOnLoad = true;
            // 
            // FormSpring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkAdventure.Properties.Resources.background_spring;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.pictureBox_spring1);
            this.Controls.Add(this.pictureBox_spring2);
            this.Controls.Add(this.pictureBox_spring3);
            this.Name = "FormSpring";
            this.Text = "春";
            this.Load += new System.EventHandler(this.FormSpring_Load);
            this.Shown += new System.EventHandler(this.FormSpring_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spring3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spring2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spring1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_spring3;
        private System.Windows.Forms.PictureBox pictureBox_spring2;
        private System.Windows.Forms.PictureBox pictureBox_spring1;
    }
}