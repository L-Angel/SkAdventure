namespace SkAdventure
{
    partial class ParttimeWork
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
            this.btn_hometeacher = new System.Windows.Forms.Button();
            this.btn_leaf = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hometeacher
            // 
            this.btn_hometeacher.Image = global::SkAdventure.Properties.Resources.btn_hometeacher_pre;
            this.btn_hometeacher.Location = new System.Drawing.Point(126, 220);
            this.btn_hometeacher.Name = "btn_hometeacher";
            this.btn_hometeacher.Size = new System.Drawing.Size(146, 37);
            this.btn_hometeacher.TabIndex = 0;
            this.btn_hometeacher.UseVisualStyleBackColor = true;
            this.btn_hometeacher.Click += new System.EventHandler(this.btn_hometeacher_Click);
            // 
            // btn_leaf
            // 
            this.btn_leaf.BackgroundImage = global::SkAdventure.Properties.Resources.btn_leaf_pre;
            this.btn_leaf.Location = new System.Drawing.Point(126, 306);
            this.btn_leaf.Name = "btn_leaf";
            this.btn_leaf.Size = new System.Drawing.Size(146, 37);
            this.btn_leaf.TabIndex = 1;
            this.btn_leaf.UseVisualStyleBackColor = true;
            this.btn_leaf.Click += new System.EventHandler(this.btn_leaf_Click);
            // 
            // btn_order
            // 
            this.btn_order.Image = global::SkAdventure.Properties.Resources.btn_order_pre;
            this.btn_order.Location = new System.Drawing.Point(126, 388);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(146, 37);
            this.btn_order.TabIndex = 2;
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // ParttimeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SkAdventure.Properties.Resources.background_parttimework;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_leaf);
            this.Controls.Add(this.btn_hometeacher);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ParttimeWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "山科历险记";
            this.Load += new System.EventHandler(this.ParttimeWork_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hometeacher;
        private System.Windows.Forms.Button btn_leaf;
        private System.Windows.Forms.Button btn_order;
    }
}