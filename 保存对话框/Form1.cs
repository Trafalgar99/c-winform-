using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 保存对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当点击保存的时候 弹出保存对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //创建保存对话框对象
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title="请选择要保存的文件";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.InitialDirectory = @"C:\Users\86158\Desktop";
            //保存对话框没有多选的属性
            sfd.ShowDialog();

            //获得文件保存的路径
            string path=sfd.FileName;
            if(path=="")
            {
                MessageBox.Show("请选择要保存的文件");
                return;
            }
            //创建FileStream对象来写入文件
            using(FileStream fsWrite=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write ))
            {
                //获得文本框中的内容
                string words = textBox1.Text.Trim();

                //将字符串转换成字节数组
                byte[] buffer = System.Text.Encoding.Default.GetBytes(words);
                fsWrite.Write(buffer, 0, buffer.Length);

            }

            MessageBox.Show("保存成功");
              
        }
    }
}
