using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 表格加载时候
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            if (radioButton2.Checked)
            {
                groupBox3.Enabled = false;
            }
            else
            {
                groupBox3.Enabled = true;
            }
            pictureBox1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        } 

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1, s2;
            s1 = "";
            s2 = "";
            if (checkBox3.Checked)
            {
                s1 = s1 + checkBox3.Text+" ";
            }
            if (checkBox4.Checked)
            {
                s1 = s1 + checkBox4.Text + " ";
            }
            if (checkBox5.Checked)
            {
                s1 = s1 + checkBox5.Text + " ";
            }
            if (checkBox6.Checked)
            {
                s2 = s2 + checkBox6.Text + " ";
            }
            if (checkBox7.Checked)
            {
                s2 = s2 + checkBox7.Text + " ";
            }
            if (checkBox8.Checked)
            {
                s2 = s2 + checkBox8.Text + " ";
            }
            pictureBox1.Visible = true;
            MessageBox.Show("您点的是："+s1+s2,"下单",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
        }

        private void 建议ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 同步ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //新建Form2实例
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
