using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1211
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 提交选择时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int count = 0;
            //List<string> list = listBox1.SelectedItems;

            foreach (string item in listBox1.SelectedItems)
            {
                
                label2.Text+='*'+item+'\n';
                count++;
                if (count >= 3)
                {
                    //MessageBox.Show("最多只能选三门");
                    break;
                }
            }
            MessageBox.Show("选择成功");

         }

        private void Form1_Load(object sender, EventArgs e)
        {
            //可以多选
            listBox1.SelectionMode = SelectionMode.MultiExtended;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
