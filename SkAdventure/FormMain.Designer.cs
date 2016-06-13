namespace SkAdventure
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.comboBox_College = new System.Windows.Forms.ComboBox();
            this.btn_Sure = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Username
            // 
            resources.ApplyResources(this.textBox_Username, "textBox_Username");
            this.textBox_Username.Name = "textBox_Username";
            // 
            // comboBox_College
            // 
            this.comboBox_College.FormattingEnabled = true;
            this.comboBox_College.Items.AddRange(new object[] {
            resources.GetString("comboBox_College.Items"),
            resources.GetString("comboBox_College.Items1"),
            resources.GetString("comboBox_College.Items2"),
            resources.GetString("comboBox_College.Items3"),
            resources.GetString("comboBox_College.Items4"),
            resources.GetString("comboBox_College.Items5"),
            resources.GetString("comboBox_College.Items6"),
            resources.GetString("comboBox_College.Items7"),
            resources.GetString("comboBox_College.Items8"),
            resources.GetString("comboBox_College.Items9"),
            resources.GetString("comboBox_College.Items10"),
            resources.GetString("comboBox_College.Items11"),
            resources.GetString("comboBox_College.Items12"),
            resources.GetString("comboBox_College.Items13"),
            resources.GetString("comboBox_College.Items14"),
            resources.GetString("comboBox_College.Items15"),
            resources.GetString("comboBox_College.Items16"),
            resources.GetString("comboBox_College.Items17"),
            resources.GetString("comboBox_College.Items18")});
            resources.ApplyResources(this.comboBox_College, "comboBox_College");
            this.comboBox_College.Name = "comboBox_College";
            // 
            // btn_Sure
            // 
            this.btn_Sure.BackgroundImage = global::SkAdventure.Properties.Resources.MainSure;
            resources.ApplyResources(this.btn_Sure, "btn_Sure");
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.UseVisualStyleBackColor = true;
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Image = global::SkAdventure.Properties.Resources.MainCancel;
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkAdventure.Properties.Resources.MainBackground;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Sure);
            this.Controls.Add(this.comboBox_College);
            this.Controls.Add(this.textBox_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.ComboBox comboBox_College;
        private System.Windows.Forms.Button btn_Sure;
        private System.Windows.Forms.Button btn_Cancel;
    }
}