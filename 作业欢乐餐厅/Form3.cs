using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1216
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tool.frm2.Visible=true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //将form2隐藏
            Tool.frm2.Visible = false;

            radioButton2.Checked = true;
            groupBox3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           /* if(radioButton2.Checked==true)
            {
                groupBox2.Enabled = false;
            }*/
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            /*if(radioButton1.Checked==true)
            {
                groupBox2.Enabled = true;
            }*/
        }
        /// <summary>
        /// 点击添加时，将菜名加到listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            /*if(!listBox2.Items.Contains(textBox1.Text+"-----"+comboBox1.SelectedItem))
            listBox2.Items.Add(textBox1.Text + "-----" + comboBox1.SelectedItem);*/
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double price=0;
            if(checkBox1.Checked)
            {
                int index = checkBox1.Text.LastIndexOf("(");
                int index2 = checkBox1.Text.LastIndexOf(")");
                string str = checkBox1.Text.Substring(index + 1, index2 - index - 1);
                price += Convert.ToDouble(str);
            }
            if(checkBox2.Checked)
            {
                int index = checkBox2.Text.LastIndexOf("(");
                int index2 = checkBox2.Text.LastIndexOf(")");
                string str = checkBox2.Text.Substring(index + 1, index2 - index - 1);
                price += Convert.ToDouble(str);
            }
            if(checkBox3.Checked)
            {
                int index = checkBox2.Text.LastIndexOf("(");
                int index2 = checkBox2.Text.LastIndexOf(")");
                string str = checkBox2.Text.Substring(index + 1, index2 - index - 1);
                price += Convert.ToDouble(str);
            }
            if(radioButton3.Checked)
            {
                int index = radioButton3.Text.LastIndexOf("(");
                int index2 = radioButton3.Text.LastIndexOf(")");
                string str = radioButton3.Text.Substring(index + 1, index2 - index - 1);
                price += Convert.ToDouble(str);
            }
            if(radioButton4.Checked)
            {
                int index = radioButton4.Text.LastIndexOf("(");
                int index2 = radioButton4.Text.LastIndexOf(")");
                string str = radioButton4.Text.Substring(index + 1, index2 - index - 1);
                price += Convert.ToDouble(str);
            }
            if (radioButton5.Checked)
            {
                int index = radioButton5.Text.LastIndexOf("(");
                int index2 = radioButton5.Text.LastIndexOf(")");
                string str = radioButton5.Text.Substring(index + 1, index2 - index - 1);
                price += Convert.ToDouble(str);
            }
            if (radioButton6.Checked)
            {
                int index = radioButton6.Text.LastIndexOf("(");
                int index2 = radioButton6.Text.LastIndexOf(")");
                string str = radioButton6.Text.Substring(index + 1, index2 - index - 1);
                price += Convert.ToDouble(str);
            }
            MessageBox.Show("共需要：" + price.ToString() + " 元", "总价格",  MessageBoxButtons.OKCancel);

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
        }
    }
}
