using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace SkAdventure
{
    public partial class Form_Start : Form
    {
        private int flag = 1;
        public Form_Start()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
  
           // new FormMain().Show();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Start_Load(object sender, EventArgs e)
        {
         
            Thread childThread = new Thread(new ThreadStart(this.Child_Show_Anim));
            childThread.Start();
          
        
        }

        private void Child_Show_Anim()
        {
            flag = 1;
            Point childposition = this.pictureBox_child.Location;
            for (int i = 0; i < 40; i++)
            {
                Thread.Sleep(5);
                this.pictureBox_child.Location = new Point(childposition.X + i*10, childposition.Y + i);
            }
            //Point circlecenter = new Point(childposition.X + 100,childposition.Y + 100);
           // float circleradius = 10;
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(5);
                this.pictureBox_child.Location = new Point(childposition.X + 40*10+i * 10, childposition.Y - i*10);
                //this.pictureBox_child.Location = new Point(Convert.ToInt32(circlecenter.X + Math.Sqrt(circleradius * circleradius - (i - circlecenter.Y) * (i - circlecenter.Y))), childposition.Y + i);
            }
           
        }

        private void Form_Start_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void Form_Start_Shown(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
            tm.Interval = 4000;
            tm.Tick += new EventHandler(tmr_Tick);
            tm.Start();
            //Thread.Sleep(10000);
            //new FormMain().Show();
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            if (flag <= 1)
            {
                Form f = new FormMain();
                f.Show();
                this.Hide();
            }
            flag += 1;
            
        }
    }
}
