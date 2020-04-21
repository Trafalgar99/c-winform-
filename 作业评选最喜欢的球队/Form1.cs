using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 评选最喜欢的球队
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 程序加载时，comboBox自动选择第一个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            label2.Text = "你最喜欢的球队是：\n";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "你最喜欢的球队是：\n\ns"+comboBox1.SelectedItem.ToString();
        }
    }
}
