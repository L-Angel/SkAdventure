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
    public partial class Form_autumn : Form
    {
        public Form_autumn()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form_autumn_Load(object sender, EventArgs e)
        {
            Thread picturethread = new Thread(new ThreadStart(showPictures));
            picturethread.Start();
        }
        private void showPictures()
        {
            Point currentPoint = this.pictureBox_autumn1.Location;
            int pointx = currentPoint.X;

            this.pictureBox_autumn1.Location = new Point(pointx, -250);
            this.pictureBox_autumn2.Location = new Point(pointx, -250);
            this.pictureBox_autumn3.Location = new Point(pointx, -250);


            for (int i = 0; i < 37; i++)
            {
                Thread.Sleep(5);
                this.pictureBox_autumn3.Location = new Point(pointx, i*10);
            }
            // Thread.Sleep(500);
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(5);
                this.pictureBox_autumn2.Location = new Point(pointx, i*10);
            }
            //  Thread.Sleep(500);
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(50);
                this.pictureBox_autumn1.Location = new Point(pointx, i*10);
            }

        }
    }
}
