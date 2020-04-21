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

namespace 记事本程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 程序加载时 将panel隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //隐藏panel
            panel1.Visible = false;
            //取消文本框的自动换行
            textBox1.WordWrap = false;
        }

        /// <summary>
        /// 声明一个存储文件全路径的泛型集合
        /// </summary>
        List<string> list = new List<string>();
        /// <summary>
        /// 点击弹出打开对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文件";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"C:\Users\86158\Desktop";
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            ofd.ShowDialog();//打开对话框

            //获得选中文件的路径
            string path=ofd.FileName;
            int index = path.LastIndexOf("\\");
            string newPath = path.Substring(index + 1);
            //将打开的文件的全路径存储在咱们声明的泛型集合当中
            list.Add(path);
            ///将截取到的文件名存到listBox中
            listBox1.Items.Add(newPath);
            if(path=="")
            {
                MessageBox.Show("请选择路径");
                return;
            }
            using (FileStream fsRead = new FileStream(path, FileMode.Open,FileAccess.Read))
            {
                //创建缓冲区的大小
                byte[] buffer = new byte[fsRead.Length];
                //表示实际读取到的字节数
                int r=fsRead.Read(buffer,0,buffer.Length);
                //将读取到的字节数组转换成字符串 然后赋值给文本框 
                textBox1.Text = System.Text.Encoding.Default.GetString(buffer);

            }
        }
        /// <summary>
        /// 点击保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择要保存的文件";
            sfd.InitialDirectory = @"C:\Users\86158\Desktop";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";

            sfd.ShowDialog();


            //获得文件保存的路径
            string path=sfd.FileName;
            if(path=="")
            {
                MessageBox.Show("请选择要保存的路径");
                return;
            }
            using(FileStream fsWrite=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
            {
                string words = textBox1.Text.Trim();
                byte[] buffer = System.Text.Encoding.Default.GetBytes(words);
                fsWrite.Write(buffer,0,buffer.Length);

            }
            MessageBox.Show("写入成功");
        }
        /// <summary>
        /// 总动换行或者取消自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if(自动换行ToolStripMenuItem.Text=="☆自动换行")
            {
                textBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "☆取消自动换行";
            }
            else if(自动换行ToolStripMenuItem.Text== "☆取消自动换行")
            {
                textBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "☆自动换行";
            }
        }
        /// <summary>
        /// 字体对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            //将字体对话框对象的文本赋值给文本框中字体的文本
            fd.ShowDialog();
            textBox1.Font=fd.Font;
           
        }
        /// <summary>
        /// 颜色对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
           
        }
        /// <summary>
        /// 点击显示panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        /// <summary>
        /// 点击隐藏panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        /// <summary>
        /// 点击按钮 隐藏panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        /// <summary>
        /// 双击显示对应的文件内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            using(FileStream fsRead=new FileStream(list[listBox1.SelectedIndex],FileMode.Open,FileAccess.Read))
            {
                byte[] buffer = new byte[fsRead.Length];
                int r = fsRead.Read(buffer, 0, buffer.Length);

                //将读取到的字节数组转换成字符串 然后重新赋值给文本框
                textBox1.Text = System.Text.Encoding.Default.GetString(buffer);
            
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
