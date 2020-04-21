using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 下拉框控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当程序加载时 向下拉框中添加数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(1);
        }
    }
}
