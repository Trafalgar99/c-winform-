using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1211._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 程序加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            label1.Text = "总计共有0支球队";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //获取数量
            int count=listBox2.Items.Count;
            label1.Text = "总计共有" + count.ToString()+"支球队";

        }
        /// <summary>
        /// 双击listbox1时添加至listbox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            /* //添加至listbox2
             bool flag = true;
             string it;
             foreach (string  it in listBox2.Items)
             {
                 if (listBox1.SelectedItem == it)
                 {
                     flag = false;
                     break;
                 }
             }
             if (flag) listBox2.Items.Add(it);*/
            if (!listBox2.Items.Contains(listBox1.SelectedItem))
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("已存在"); 
            }
            
        }
        /// <summary>
        /// 双击重定向时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           //附带去重操作
            foreach(string item in listBox1.SelectedItems)
                if(!listBox2.Items.Contains(item))
            listBox2.Items.Add(item);

        }
        /// <summary>
        /// 点击删除时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
