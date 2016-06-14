namespace SkAdventure
{
    partial class LearnSkill
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
            this.btn_chemistry = new System.Windows.Forms.Button();
            this.btn_computer = new System.Windows.Forms.Button();
            this.btn_english = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_chemistry
            // 
            this.btn_chemistry.BackgroundImage = global::SkAdventure.Properties.Resources.chemistry_pre;
            this.btn_chemistry.Location = new System.Drawing.Point(331, 211);
            this.btn_chemistry.Name = "btn_chemistry";
            this.btn_chemistry.Size = new System.Drawing.Size(162, 45);
            this.btn_chemistry.TabIndex = 0;
            this.btn_chemistry.UseVisualStyleBackColor = true;
            this.btn_chemistry.Click += new System.EventHandler(this.btn_chemistry_Click);
            // 
            // btn_computer
            // 
            this.btn_computer.BackgroundImage = global::SkAdventure.Properties.Resources.computer_pre;
            this.btn_computer.Location = new System.Drawing.Point(331, 279);
            this.btn_computer.Name = "btn_computer";
            this.btn_computer.Size = new System.Drawing.Size(162, 45);
            this.btn_computer.TabIndex = 1;
            this.btn_computer.UseVisualStyleBackColor = true;
            this.btn_computer.Click += new System.EventHandler(this.btn_computer_Click);
            // 
            // btn_english
            // 
            this.btn_english.BackgroundImage = global::SkAdventure.Properties.Resources.english_pre;
            this.btn_english.Location = new System.Drawing.Point(331, 346);
            this.btn_english.Name = "btn_english";
            this.btn_english.Size = new System.Drawing.Size(162, 47);
            this.btn_english.TabIndex = 2;
            this.btn_english.UseVisualStyleBackColor = true;
            this.btn_english.Click += new System.EventHandler(this.btn_english_Click);
            // 
            // LearnSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkAdventure.Properties.Resources.background_learnskill;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.btn_english);
            this.Controls.Add(this.btn_computer);
            this.Controls.Add(this.btn_chemistry);
            this.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "LearnSkill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.LearnSkill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_chemistry;
        private System.Windows.Forms.Button btn_computer;
        private System.Windows.Forms.Button btn_english;

    }
}