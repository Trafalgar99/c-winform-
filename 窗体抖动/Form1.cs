using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体抖动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击抖动按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(button1.Location);
            //获得button按钮的坐标
            //Point p = button1.Location;
            //MessageBox.Show(p.ToString());

            for(int i=0;i<500;i++)
            {
                this.Location = new Point(65, 65);
                this.Location = new Point(50, 50);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
