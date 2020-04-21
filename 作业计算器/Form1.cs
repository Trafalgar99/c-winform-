using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            z = x + y;
            
            textBox3.Text=z.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            z = x - y;

            textBox3.Text = z.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            z = x * y;

            textBox3.Text = z.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            if(y==0)
            {
                textBox2.ReadOnly = true;
                MessageBox.Show("输入错误","分母不能为零",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
            else
            {
                z = x /y;

                textBox3.Text = z.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }
    }
}
