namespace SkAdventure
{
    partial class Form_Start
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Start));
            this.pictureBox_child = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_child)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_child
            // 
            this.pictureBox_child.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_child.Image = global::SkAdventure.Properties.Resources.child_new;
            this.pictureBox_child.Location = new System.Drawing.Point(30, 220);
            this.pictureBox_child.Name = "pictureBox_child";
            this.pictureBox_child.Size = new System.Drawing.Size(165, 252);
            this.pictureBox_child.TabIndex = 0;
            this.pictureBox_child.TabStop = false;
            this.pictureBox_child.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.pictureBox_child);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "山科历险记";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Start_FormClosing);
            this.Load += new System.EventHandler(this.Form_Start_Load);
            this.Shown += new System.EventHandler(this.Form_Start_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_child)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_child;

    }
}

