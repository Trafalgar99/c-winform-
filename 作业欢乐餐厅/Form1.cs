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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击登录时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //获取用户名和密码
            string userName = comboBox1.SelectedItem.ToString();
            string userPwd = textBox1.Text;
            //判断
            if (
                  (userName == "frank" && userPwd == "frank")
                ||(userName == "tom" && userPwd=="tom")
                ||(userName == "jack" && userPwd == "jack")
                ||(userName == "alice" && userPwd == "alice")
                ||(userName == "张三" && userPwd == "123456")
                )//预置的所有用户
            {
                MessageBox.Show("登陆成功");
                Form2 form2 = new Form2();
                this.Visible = false;
                form2.Show();
                
            }
            else
            {
                MessageBox.Show("登录失败");
                textBox1.Text = "";
            }
        }
        /// <summary>
        /// 点击退出时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 程序加载时，默认选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //先让combox选中第一个，即提示语
            comboBox1.SelectedIndex = 0;
            //将form赋值给frm，
            Tool.frm1 = this;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
