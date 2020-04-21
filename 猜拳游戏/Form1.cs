using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜拳游戏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fist = "石头";
            PlayGame(fist);
        }
        /// <summary>
        /// 封装出来的比赛的方法
        /// </summary>
        /// <param name="fist"></param>
        private void PlayGame(string fist)
        {
            //创建玩家对象
            Player p = new Player();
            //调用玩家对象出拳的方法
            int pNum = p.ShowFist(fist);
            //将石头赋值给label的文本
            lblPlayer.Text = fist;

            //创建电脑对象
            Computer c = new Computer();
            //调用电脑出拳的方法
            int cNum = c.ShowFist();
            //将电脑对象的属性赋值给电脑label的文本
            lblComputer.Text = c.Fist;

            //创建裁判对象 调用比赛的方法 返回比赛结果
            State s = Judge.judge(pNum, cNum);
            lblResult.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fist = "剪刀";
            PlayGame(fist);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fist = "布";
            PlayGame(fist);  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
