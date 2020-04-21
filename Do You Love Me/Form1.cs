using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_You_Love_Me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击爱时，窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你呦");
            this.Close();
        }
        /// <summary>
        /// 当鼠标进入按钮的可见区域时，重新赋值给button一个新坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //首先获取窗体的高度
            int maxLength = this.ClientSize.Height;//this.Height
            //在获得窗体的宽度
            int maxWidth = this.ClientSize.Width;


            Random r = new Random();
            int x=r.Next(0,maxWidth - button2.Width+1);
            int y=r.Next(0, maxLength - button2.Height+1);

            button2.Location = new Point(x,y);

        }
    }
}
