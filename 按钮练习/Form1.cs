using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 按钮练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击按钮3的时候，第一 让按钮2消失 让按钮1可用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            btn2.Visible = false;
            btn1.Enabled = true;
        }
        /// <summary>
        /// 按钮1的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Green;
            btn1.Enabled = false;
        }
        /// <summary>
        /// 当窗体加载的时候让按钮3消失
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            btn3.Visible = false;
        }
        /// <summary>
        /// 点击按钮2时，按钮3出现了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            btn3.Visible = true;
            btn3.BackColor = Color.Red;
        }
    }
}
