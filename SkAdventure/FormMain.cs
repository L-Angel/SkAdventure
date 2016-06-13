using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkAdventure
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            string username = this.textBox_Username.Text;
            string college = this.comboBox_College.Text;
            Form f = new SkAdventure(username,college);
            f.Show();
            this.Hide();
        }
    }
}
