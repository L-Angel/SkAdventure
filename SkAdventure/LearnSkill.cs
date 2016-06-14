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
    public partial class LearnSkill : Form
    {
        private String username;
        private String college;
        private SkAdventure sda = null;
        public LearnSkill()
        {
            InitializeComponent();
        }

        public LearnSkill(String username, String college) {
            this.username = username;
            this.college = college;
            InitializeComponent();
        }
        public LearnSkill(String username, String college,SkAdventure s)
        {
            this.username = username;
            this.college = college;
            this.sda = s;
            InitializeComponent();
        }

        private void LearnSkill_Load(object sender, EventArgs e)
        {
            /*
            if (this.college!=null&&this.college.Equals("信息科学与工程学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到信息科学与工程学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，励志成为一名光荣的程序猿，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("矿业与安全工程学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":"; 
                this.label_content.Text = "欢迎来到矿业与安全工程学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("测绘科学与工程学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到测绘科学与工程学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("地球科学与工程学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到地球科学与工程学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("土木工程与建筑学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到土木工程与建筑学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("机械电子工程学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到机械电子工程学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("数学与系统科学学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到数学与系统科学学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("经济管理学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到经济管理学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("电气与自动化工程学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到电气与自动化工程学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("电子通信与物理学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到电子通信与物理学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("化学与环境工程学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到化学与环境工程学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("材料科学与工程学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到材料科学与工程学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("交通学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到交通学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("文法学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到文法学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("外国语学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到外国语学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("艺术与设计学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到艺术与设计学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("马克思主义学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到马克思主义学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("体育学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到体育学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
            else if (this.college != null && this.college.Equals("继续教育学院"))
            {
                this.label_welcome.Text = "亲爱的同学" + this.username + ":";
                this.label_content.Text = "欢迎来到继续教育学院，由于您发挥不怕苦，不怕累的革命精神。加强自己专业知识技能学习，您的能量+10！成绩+5！";
            }
             * */
        }

        private void btn_chemistry_Click(object sender, EventArgs e)
        {
            sda.addPower(10);
            sda.addGrade(5);
            MessageBox.Show("wa~,这么努力的做实验呢~，能量+10，成绩+5");
        }

        private void btn_english_Click(object sender, EventArgs e)
        {
            sda.addPower(10);
            sda.addGrade(5);
            MessageBox.Show("wa~，学习英语好刻苦~，能量+10，成绩+5");
        }

        private void btn_computer_Click(object sender, EventArgs e)
        {
            Form f = new LearnComputer(this.sda);
            f.Show();
        }
    }
}
