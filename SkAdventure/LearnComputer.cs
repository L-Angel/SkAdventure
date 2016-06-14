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
    public partial class LearnComputer : Form
    {
        private SkAdventure sda = null;
        public LearnComputer()
        {
            InitializeComponent();
        }
        public LearnComputer(SkAdventure s)
        {
            this.sda = s;
            InitializeComponent();
        }

        private void btn_learncomputer_Click(object sender, EventArgs e)
        {
            sda.addGrade(5);
            sda.addPower(10);
            MessageBox.Show("学习我大信息的专业技能，必须点个赞。成绩+5，能量+10");
        }
    }
}
