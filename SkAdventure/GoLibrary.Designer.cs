namespace SkAdventure
{
    partial class GoLibrary
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
            this.btn_ignore = new System.Windows.Forms.Button();
            this.btn_makefriend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ignore
            // 
            this.btn_ignore.Image = global::SkAdventure.Properties.Resources.btn_ignore_pre;
            this.btn_ignore.Location = new System.Drawing.Point(336, 266);
            this.btn_ignore.Name = "btn_ignore";
            this.btn_ignore.Size = new System.Drawing.Size(118, 37);
            this.btn_ignore.TabIndex = 0;
            this.btn_ignore.UseVisualStyleBackColor = true;
            this.btn_ignore.Click += new System.EventHandler(this.btn_ignore_Click);
            // 
            // btn_makefriend
            // 
            this.btn_makefriend.Image = global::SkAdventure.Properties.Resources.btn_makefriend_pre;
            this.btn_makefriend.Location = new System.Drawing.Point(552, 266);
            this.btn_makefriend.Name = "btn_makefriend";
            this.btn_makefriend.Size = new System.Drawing.Size(118, 37);
            this.btn_makefriend.TabIndex = 1;
            this.btn_makefriend.UseVisualStyleBackColor = true;
            this.btn_makefriend.Click += new System.EventHandler(this.btn_makefriend_Click);
            // 
            // GoLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkAdventure.Properties.Resources.background_makefriend_library;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.btn_makefriend);
            this.Controls.Add(this.btn_ignore);
            this.Name = "GoLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书馆";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ignore;
        private System.Windows.Forms.Button btn_makefriend;
    }
}