using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 快捷键
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击项目弹出一个对话框 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }
        /// <summary>
        /// 给窗体注册快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.A&&e.Alt)//相当于按下Alt+A
            {
                textBox1.Text = "+";
                textBox1.BackColor = Color.Yellow;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
