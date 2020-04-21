using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 单选框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击登录时候进行判断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text.Trim();//去除空格
            string userPwd = txtPwd.Text;
            //学生被选中
            if (rdoStudent.Checked)
            {
               
                if(userName=="student"&&userPwd=="student")
                {
                    MessageBox.Show("学生登录成功");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入");
                    txtName.Text = "";
                    txtPwd.Text = "";
                    txtName.Focus();//获得焦点
                }
            }
            else//老师被选中
            {
                if(userName=="teacher"&&userPwd=="teacher")
                {
                    MessageBox.Show("老师登录成功");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入");
                    txtName.Text = "";
                    txtPwd.Text = "";
                    txtName.Focus();//获得焦点
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
