using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdi窗体设计
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 展示子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //分别创建子窗体对象
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;//指定子窗体的父窗体
            frm2.Show();//显示子窗体
           
            Form3 frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
           
            Form4 frm4 = new Form4();
            frm4.MdiParent = this;
            frm4.Show();



        }


        /// <summary>
        /// 横向排列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 横向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        /// <summary>
        /// 纵向排列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 纵向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
