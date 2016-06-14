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
    public partial class SkAdventure : Form
    {
        private String username="null";
        private String college="无";
        private int morality = 0;
        private int power = 0;
        private int money = 0;
        private int grade = 0;
        private int popularity = 0;
        public SkAdventure()
        {
            InitializeComponent();
        }
        public SkAdventure(String username,String college)
        {
            InitializeComponent();
            this.username = username;
            this.college = college;
            this.InitSystem();
        }
        private void InitSystem() {
            this.label_username.Text = this.username;
            this.label_college.Text = this.college;
            updateParam();
        }
        private void updateParam()
        {
            this.label_power.Text = this.power.ToString();
            this.label_money.Text = this.money.ToString();
            this.label_popularity.Text = this.popularity.ToString();
            this.label_morality.Text = this.morality.ToString();
            this.label_grade.Text = this.grade.ToString();
        }
        private void SkAdventure_Load(object sender, EventArgs e)
        {
            Console.WriteLine(123);
        }

        private void btn_xuezhecanting_KeyDown(object sender, KeyEventArgs e)
        {
            //this.btn_xuezhecanting.Image = Image.FromFile("../../Resources/xuezhecanting_after.png");
        }

        private void btn_xueyuancanting_Click(object sender, EventArgs e)
        {

        }

        private void btn_yanhu_Click(object sender, EventArgs e)
        {
            Form f = new YanHu();
            f.Show();
        }

        private void btn_fenghucaochang_Click(object sender, EventArgs e)
        {
            Form f = new FengYu();
            f.Show();

        }

        private void btn_tushuguan_Click(object sender, EventArgs e)
        {
            Form f = new TuShuGuan();
            f.Show();
        }

        private void btn_lizhifang_Click(object sender, EventArgs e)
        {
            Form f =new LiZhiFang();
            f.Show();
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_LearnSkill_Click(object sender, EventArgs e)
        {
            Form f = new LearnSkill(this.username,this.college,this);
            f.Show();
            updateParam();
        }


        public void addMoney(int m)
        {
            this.money += m;
            this.updateParam();
        }
        public void addPower(int p)
        {
            this.power += p;
            this.updateParam();
        }
        public void addGrade(int g)
        {
            this.grade += g;
            this.updateParam();
        }
        public void addMorality(int m)
        {
            this.morality += m;
            updateParam();
        }
        public void addPopularity(int p)
        {
            this.popularity += p;
            this.updateParam();
        }
        public void decMoney(int m)
        {
            this.money -= m;
            this.updateParam();
        }
        public void decPower(int p)
        {
            this.power -= p;
            this.updateParam();
        }
        public void decGrade(int g)
        {
            this.grade -= g;
            this.updateParam();
        }
        public void decMorality(int m)
        {
            this.morality -= m;
            this.updateParam();
        }
        public void decPopularity(int p)
        {
            this.popularity -= p;
            this.updateParam();
        }

        private void btn_SeeSeason_Click(object sender, EventArgs e)
        {
            Form f = new SeeSeason(this);
            f.Show();
        }

        private void btn_MakeFriend_Click(object sender, EventArgs e)
        {
            Form f = new MakeFriend(this);
            f.Show();
        }

        private void btn_ParttimeWork_Click(object sender, EventArgs e)
        {
            Form f = new ParttimeWork(this);
            f.Show();
        }
    }
}
