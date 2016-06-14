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
    public partial class MakeFriend : Form
    {
        private SkAdventure sda = null;
        public MakeFriend()
        {
            InitializeComponent();
        }
        public MakeFriend(SkAdventure s)
        {
            this.sda = s;
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_golibrary_Click(object sender, EventArgs e)
        {
            Form f = new GoLibrary(sda);
            f.Show();
        }

        private void btn_gogymnasium_Click(object sender, EventArgs e)
        {
            Form f = new GoGymnasium(sda);
            f.Show();
        }

        private void btn_goenglishcorner_Click(object sender, EventArgs e)
        {
            Form f = new GoEnglishCorner(sda);
            f.Show();
        }
    }
}
