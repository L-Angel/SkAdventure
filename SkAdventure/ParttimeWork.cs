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
    public partial class ParttimeWork : Form
    {
        private SkAdventure sda = null;
        public ParttimeWork()
        {
            InitializeComponent();
        }
        public ParttimeWork(SkAdventure s)
        {
            this.sda = s;
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void ParttimeWork_Load(object sender, EventArgs e)
        {

        }

       

        private void btn_leaf_Click(object sender, EventArgs e)
        {
            sda.addMorality(10);
            sda.addPopularity(5);
            sda.addGrade(5);
            sda.addMoney(80);
            MessageBox.Show("利用课余时间发传单，自食其力，道德+10，成绩+5，人气+5,金钱+80");
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            sda.addMorality(5);
            sda.addPopularity(20);
            sda.addGrade(5);
            sda.addMoney(120);
            MessageBox.Show("利用课余时间做点餐员，自食其力，道德+5，成绩+5，人气+20,金钱+120");
        }

        private void btn_hometeacher_Click(object sender, EventArgs e)
        {
            sda.addMorality(5);
            sda.addPopularity(5);
            sda.addGrade(5);
            sda.addMoney(200);
            MessageBox.Show("利用课余时间做家教，自食其力，道德+5，成绩+5，人气+5,金钱+200");
        }
    }
}
