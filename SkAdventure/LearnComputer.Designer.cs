namespace SkAdventure
{
    partial class LearnComputer
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
            this.btn_learncomputer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_learncomputer
            // 
            this.btn_learncomputer.Image = global::SkAdventure.Properties.Resources.computerlearn_pre;
            this.btn_learncomputer.Location = new System.Drawing.Point(576, 367);
            this.btn_learncomputer.Name = "btn_learncomputer";
            this.btn_learncomputer.Size = new System.Drawing.Size(102, 46);
            this.btn_learncomputer.TabIndex = 0;
            this.btn_learncomputer.UseVisualStyleBackColor = true;
            this.btn_learncomputer.Click += new System.EventHandler(this.btn_learncomputer_Click);
            // 
            // LearnComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkAdventure.Properties.Resources.background_learncomputer;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.btn_learncomputer);
            this.Name = "LearnComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "山科历险记";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_learncomputer;
    }
}