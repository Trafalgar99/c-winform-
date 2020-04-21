using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打开对话框练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击打开时 弹出打开对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //声明一个存储图片文件全路径的泛型集合   
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            //首先创建打开对话框的对象
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "请选择图片文件";
            ofd.Filter = "图片文件|*.jpg|所有文件|*.*";
            ofd.InitialDirectory = @"C:\Users\86158\Desktop";

            ofd.ShowDialog();

            //获取用户在打开对话框中选中的文件的全路径
            string[]names=ofd.FileNames;

            //通过循环来截取
            for(int i=0;i<names.Length;++i)
            {
                int index = names[i].LastIndexOf("\\");
                string strNew = names[i].Substring(index+1);
                listBox1.Items.Add(strNew);
                list.Add(names[i]);
            }

        }
        /// <summary>
        /// 点击更换图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(list[listBox1.SelectedIndex]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
