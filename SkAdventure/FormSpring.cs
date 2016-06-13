﻿using System;
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
    public partial class FormSpring : Form
    {
        public FormSpring()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FormSpring_Shown(object sender, EventArgs e)
        {
            Thread picturethread = new Thread(new ThreadStart(showPictures));
            picturethread.Start();
        }
        private void showPictures()
        {
            Point currentPoint = this.pictureBox_spring1.Location;
            int pointy = currentPoint.Y;

            this.pictureBox_spring1.Location = new Point(-250, pointy);
            this.pictureBox_spring2.Location = new Point(-250, pointy);
            this.pictureBox_spring3.Location = new Point(-250, pointy);
           
           
            for (int i = 0; i < 55; i++)
            {
                Thread.Sleep(5);
                this.pictureBox_spring3.Location = new Point(i * 10, pointy);
            }
            // Thread.Sleep(500);
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(5);
                this.pictureBox_spring2.Location = new Point(i * 10, pointy);
            }
            //  Thread.Sleep(500);
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(50);
                this.pictureBox_spring1.Location = new Point(i * 10, pointy);
            }
             
        }

        private void FormSpring_Load(object sender, EventArgs e)
        {

        }
    }
}
