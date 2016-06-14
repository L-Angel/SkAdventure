namespace SkAdventure
{
    partial class MakeFriend
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
            this.btn_gogymnasium = new System.Windows.Forms.Button();
            this.btn_golibrary = new System.Windows.Forms.Button();
            this.btn_goenglishcorner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gogymnasium
            // 
            this.btn_gogymnasium.Image = global::SkAdventure.Properties.Resources.gogymnasium_pre;
            this.btn_gogymnasium.Location = new System.Drawing.Point(367, 314);
            this.btn_gogymnasium.Name = "btn_gogymnasium";
            this.btn_gogymnasium.Size = new System.Drawing.Size(159, 45);
            this.btn_gogymnasium.TabIndex = 0;
            this.btn_gogymnasium.UseVisualStyleBackColor = true;
            this.btn_gogymnasium.Click += new System.EventHandler(this.btn_gogymnasium_Click);
            // 
            // btn_golibrary
            // 
            this.btn_golibrary.Image = global::SkAdventure.Properties.Resources.golibrary_pre;
            this.btn_golibrary.Location = new System.Drawing.Point(367, 228);
            this.btn_golibrary.Name = "btn_golibrary";
            this.btn_golibrary.Size = new System.Drawing.Size(159, 45);
            this.btn_golibrary.TabIndex = 1;
            this.btn_golibrary.UseVisualStyleBackColor = true;
            this.btn_golibrary.Click += new System.EventHandler(this.btn_golibrary_Click);
            // 
            // btn_goenglishcorner
            // 
            this.btn_goenglishcorner.Image = global::SkAdventure.Properties.Resources.goenglishcorner_pre;
            this.btn_goenglishcorner.Location = new System.Drawing.Point(367, 395);
            this.btn_goenglishcorner.Name = "btn_goenglishcorner";
            this.btn_goenglishcorner.Size = new System.Drawing.Size(159, 45);
            this.btn_goenglishcorner.TabIndex = 2;
            this.btn_goenglishcorner.UseVisualStyleBackColor = true;
            this.btn_goenglishcorner.Click += new System.EventHandler(this.btn_goenglishcorner_Click);
            // 
            // MakeFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkAdventure.Properties.Resources.background_makefriend;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.btn_goenglishcorner);
            this.Controls.Add(this.btn_golibrary);
            this.Controls.Add(this.btn_gogymnasium);
            this.Name = "MakeFriend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "山科历险记";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gogymnasium;
        private System.Windows.Forms.Button btn_golibrary;
        private System.Windows.Forms.Button btn_goenglishcorner;
    }
}