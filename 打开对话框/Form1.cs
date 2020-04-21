using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打开对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击打开对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //创建打开对话框的对象
            OpenFileDialog ofd = new OpenFileDialog();
            //设置打开对话框的标题
            ofd.Title = "请选择要打开的文件";
            //设置打开对话框可以多选
            ofd.Multiselect = true;

            //设置打开对话框的文件类型
            ofd.Filter = "文本文件|*.txt|音乐文件|*.wav|图片文件|*.jpg|所有文件|*.*";
            //设置打开对话框的初始目录
            ofd.InitialDirectory = @"C:\Users\86158\Desktop";
            //调用对象的打开对话框的方法
            ofd.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
