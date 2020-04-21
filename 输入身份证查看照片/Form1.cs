using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 输入身份证查看照片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 在程序加载的时候 将pictureBox隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
        /// <summary>
        /// 点击按钮的时候判断年龄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            input =input.Substring(6, 4);
            //获得当前年份
            int nowYear = DateTime.Now.Year;

            //拿当前的年份去跟用户输入的年份进行比较
            if(nowYear-Convert.ToInt32(input)>=18)
            {
                pictureBox1.Visible = true;
            }
            else//小于18岁
            {
                MessageBox.Show("你还小");
                pictureBox1.Visible = false;
            }

        }
    }
}
