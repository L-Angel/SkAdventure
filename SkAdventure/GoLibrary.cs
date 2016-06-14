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
    public partial class GoLibrary : Form
    {
        private SkAdventure sda = null;
        public GoLibrary()
        {
            InitializeComponent();
        }
        public GoLibrary(SkAdventure s)
        {
            this.sda = s;
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        private void btn_ignore_Click(object sender, EventArgs e)
        {
            sda.decPopularity(3);
            sda.decPower(1);
            MessageBox.Show("咦~对方忽略了您的打招呼，人气-3，能量-1");
        }

        private void btn_makefriend_Click(object sender, EventArgs e)
        {
            sda.addPopularity(5);
            sda.addPower(2);
            MessageBox.Show("hello~，结交到新朋友喽~！~，人气+5，能量+2");
        }
    }
}
