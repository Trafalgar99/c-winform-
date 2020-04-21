using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 简单记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 程序加载的时候
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            btnWordWarp.Visible = false;
            btnSave.Visible = false;
            txtWords.Visible = false;

            //取消文本框的自动换行
            txtWords.WordWrap = false;
        }
        /// <summary>
        /// 点击登录的时候发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //首先获得用户输入的用户名
            string name = txtName.Text;

            //再获得用户输入的密码
            string pwd = txtPwd.Text;

            if(name=="admin"&&pwd=="admin")
            {
                MessageBox.Show("登陆成功");
                //登陆成功后让两个文本框，两个label和登录按钮都不可见
                txtName.Visible = false;
                txtPwd.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                btnLogin.Visible = false;

                //换行按钮，保存按钮，文本框出现
                btnWordWarp.Visible = true;
                btnSave.Visible = true;
                txtWords.Visible = true;

            }
            else
            {
                MessageBox.Show("登陆失败");
                //如果登陆失败则清除两个文本框中的内容
                txtName.Text = "";
                txtPwd.Text = "";

                //让文本框对象获得焦点
                txtName.Focus();

            }
        }
        /// <summary>
        /// 自动换行点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWordWarp_Click(object sender, EventArgs e)
        {
            if(btnWordWarp.Text=="自动换行")
            {
                txtWords.WordWrap = true;
                btnWordWarp.Text = "取消自动换行";
            }
            else if(btnWordWarp.Text=="取消自动换行")
            {
                //取消自动换行
                txtWords.WordWrap = false;
                btnWordWarp.Text = "自动换行";  
            }
        }
        /// <summary>
        /// 点击保存时 将文本框中的内容保存至桌面的txt文件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (FileStream fsWrite = new FileStream(@"C:\Users\86158\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = txtWords.Text;
                //将字符串转换为字节数组
                byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
                fsWrite.Write(buffer,0,buffer.Length);
            }

            MessageBox.Show("保存成功");
        }
    }
}
