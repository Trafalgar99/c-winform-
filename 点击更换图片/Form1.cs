using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 点击更换图片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 程序加载的时候给图片空间来一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\86158\Desktop\image\d7e11be84b22aedb658821945c8bcecf.jpg");
        }
        /// <summary>
        /// 点击下一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        int i = 0;
        //获得所有照片路径  
        string[] str = Directory.GetFiles(@"C:\Users\86158\Desktop\image", "*.jpg");
        private void btnNext_Click(object sender, EventArgs e)
        {

            
            i++;//将照片的索引加1
            
           
            if(i==str.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(str[i]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击上一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            i--;
            if(i<0)   //如果小于0 表示在索引为0的那张图片又点了一下上一页
            {
                i = str.Length - 1;//让图片的索引等于最后一张图片的索引 
            }
            pictureBox1.Image = Image.FromFile(str[i]); 
        }
    }
}
