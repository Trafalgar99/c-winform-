using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 文本框中的内容只要一发生改变 就将文本框中的文本赋值给label控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text; 
        }
        /// <summary>
        /// 每一秒钟执行一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //将当前的时间赋值给label
            label2.Text = DateTime.Now.ToString();
        }
        /// <summary>
        /// 程序加载的时候就将时间赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //将当前的时间赋值给label
            label2.Text = DateTime.Now.ToString();
            //alt+shift+f10;
            //创建播放音乐的对象
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"assaddcsdasd";

            //如果当前时间的秒部分到了30，开始播放音乐 
            if(DateTime.Now.Second==30)
            {
                sp.Play();
            }
        }
    }
}
