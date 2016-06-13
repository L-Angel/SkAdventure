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
    public partial class SeeSeason : Form
    {
        public SeeSeason()
        {
            InitializeComponent();
        }

        private void btn_spring_Click(object sender, EventArgs e)
        {
            Form f = new FormSpring();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form_summer();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Form_autumn();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Form_winter();
            f.Show();
        }
    }
}
