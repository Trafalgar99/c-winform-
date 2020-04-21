using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01控件的事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当你点击这个按钮时触发这个事件，事件的本质就是一个方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Button btn = (Button)sender;
            MessageBox.Show("我被点击了"); 


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
