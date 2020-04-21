using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 程序加载时 让4个picture都有图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\86158\Desktop\image\a52bb69a5764282afb49c5dc37eb49b1.jpg");
            pictureBox2.Image = Image.FromFile(@"C:\Users\86158\Desktop\image\a52bb69a5764282afb49c5dc37eb49b1.jpg");
            pictureBox3.Image = Image.FromFile(@"C:\Users\86158\Desktop\image\a52bb69a5764282afb49c5dc37eb49b1.jpg");
            pictureBox4.Image = Image.FromFile(@"C:\Users\86158\Desktop\image\a52bb69a5764282afb49c5dc37eb49b1.jpg");

            //同时播放音乐
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"asdsafsa";
            //sp.Play();
        }

        /// <summary>
        /// 每隔一秒 换一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            string[] str = Directory.GetFiles(@"C:\Users\86158\Desktop\image", "*.jpg");

            i++;
            if (i == str.Length) i = 0;
            pictureBox1.Image = Image.FromFile(str[i]);
            pictureBox2.Image = Image.FromFile(str[i]);
            pictureBox3.Image = Image.FromFile(str[i]);
            pictureBox4.Image = Image.FromFile(str[i]);
            //for (int i = 0; i<str.Length;i++)
            //{
            //    pictureBox1.Image = Image.FromFile(str[i]);
            //    pictureBox2.Image = Image.FromFile(str[i]);
            //    pictureBox3.Image = Image.FromFile(str[i]);
            //    pictureBox4.Image = Image.FromFile(str[i]);
            // }

        }
    }
}
