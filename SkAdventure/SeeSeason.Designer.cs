namespace SkAdventure
{
    partial class SeeSeason
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
            this.btn_spring = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_spring
            // 
            this.btn_spring.Image = global::SkAdventure.Properties.Resources.spring_pre;
            this.btn_spring.Location = new System.Drawing.Point(172, 141);
            this.btn_spring.Name = "btn_spring";
            this.btn_spring.Size = new System.Drawing.Size(163, 57);
            this.btn_spring.TabIndex = 0;
            this.btn_spring.Text = " ";
            this.btn_spring.UseVisualStyleBackColor = true;
            this.btn_spring.Click += new System.EventHandler(this.btn_spring_Click);
            // 
            // button2
            // 
            this.button2.Image = global::SkAdventure.Properties.Resources.summer_pre;
            this.button2.Location = new System.Drawing.Point(466, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 57);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::SkAdventure.Properties.Resources.autumn_pre;
            this.button3.Location = new System.Drawing.Point(172, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 57);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = global::SkAdventure.Properties.Resources.winter_pre;
            this.button4.Location = new System.Drawing.Point(466, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 57);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SeeSeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkAdventure.Properties.Resources.background_seeseason;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_spring);
            this.Name = "SeeSeason";
            this.Text = "山科历险记";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_spring;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}