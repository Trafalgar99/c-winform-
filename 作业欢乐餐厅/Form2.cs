using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1216
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 单机空白处 调用下一个窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        /// <summary>
        /// 窗体2加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            //将form1赋值给tool，后续可以对form1进行控制
            Tool.frm2 = this;
            //将计时器打开
            timer1.Start();
            //对时间赋予一初始值
            mlbl.Text = DateTime.Now.ToString();
        }
        /// <summary>
        /// 每过1秒获取一次时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //获取时间
           mlbl.Text = DateTime.Now.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mlbl_Leave(object sender, EventArgs e)
        {
           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //form2关闭时 另form1显形
            Tool.frm1.Visible=true;
        }
    }
}
