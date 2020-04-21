using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //方法二：
       // List<string> list = new List<string>();//泛型集合
        /// <summary>
        /// 当程序加载的时候 将文件夹中的图片名称放到ListBox中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        string[] str = Directory.GetFiles(@"C:\Users\86158\Desktop\image", "*.jpg");
        private void Form1_Load(object sender, EventArgs e)
        {
            
            for(int i=0;i<str.Length;i++)
            {
                int index = str[i].LastIndexOf("\\");
                string strNew = str[i].Substring(index + 1);
                listBox1.Items.Add(strNew);

                //方法二：将全路径放到泛型集合中
               // list.Add(str[i]);
            }
       
        }
        /// <summary>
        /// 点击更换图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(str[listBox1.SelectedIndex]);
            //方法二：pictureBox1.Image = Image.FromFile(list[listBox1.SelectedIndex]);
        }
    }
}
