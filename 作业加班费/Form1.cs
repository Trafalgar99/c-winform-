using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1211._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击确定时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int pay = 0, hour;
            string sum;
            if (comboBox1.Text == "平时加班")
            {
                pay = 10;
            }
            else if(comboBox1.Text=="双休加班")
            {
                pay = 15;
            }
            else if(comboBox1.Text=="节假日加班")
            {
                pay = 20;
            }
            hour=Convert.ToInt32(textBox1.Text);
            sum=(hour*pay).ToString();
            MessageBox.Show("加班费为："+sum);
        }
    }
}
