using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 定时器的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }



            //事件2  星星闪烁

            
            string words = textBox1.Text;
            textBox1.Text =textBox1.Text[textBox1.Text.Length-1]+ textBox1.Text.Substring(0,textBox1.Text.Length-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            timer2.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 定时器 弹幕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            //使字幕移动-
            label1.Left = label1.Left - 10;
            if (label1.Left - 10 < 0)
            {
                //经此处理后 Form加宽也能使得功能正常
                label1.Left = this.Size.Width; ;
            }
        }
    }
}
