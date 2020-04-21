using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体的问题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 在窗体1中点击按钮 出现form2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //创建窗体2对象
            Form2 frm2 = new Form2();
            //调用窗体2对象的show方法
            frm2.Show();
            //将当前窗体对象赋值给静态类中的Form1类型字段
            Test.frm = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
