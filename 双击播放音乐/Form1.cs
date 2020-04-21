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

namespace 双击播放音乐
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载时 将歌曲的名字加载到ListBox中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //用来存放歌曲的全路径
        List<string> list = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[]str= Directory.GetFiles(@"音乐文件夹的地址");
            for(int i=0;i<str.Length;i++)
            {
                int index = str[i].LastIndexOf("\\");
                string strNew = str[i].Substring(index + 1);
                //将截取后的文件名加载到ListBox中
                listBox1.Items.Add(strNew);

                //将歌曲的全路径放到list泛型集合中
                list.Add(str[i]);
            }
        }
        /// <summary>
        /// 双击播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        SoundPlayer sp = new SoundPlayer();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
            //通过当前选中项的索引去泛型集合中拿到对应的全路径 赋值给sp的属性
            sp.SoundLocation=list[listBox1.SelectedIndex];
            sp.Play();
        }
        /// <summary>
        /// 点击上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        
        private void btnLast_Click(object sender, EventArgs e)
        {
            //另i等于当前选中的索引
            int i = listBox1.SelectedIndex;

            //点击上一曲的时候让索引--
            i--;
            //如果索引小于0，
            if(i==0)
            {
                //将最后一首歌的索引赋值给当前索引
                i = listBox1.Items.Count - 1;
            }
            //将改变后的索引重新赋值给当前选中的索引
            listBox1.SelectedIndex = i;
            //将改变后的索引带到泛型集合中 拿到其对应的全路径 赋值给sp对象
            sp.SoundLocation = list[i];
            sp.Play();
                        
        }
        /// <summary>
        /// 点击下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            //首先获得当前选中的索引
            int i = listBox1.SelectedIndex;
            i++;
            if(i==listBox1.Items.Count)
            {
                i = 0;
            }
            //将改变后的索引重新赋值给当前选中的索引
            listBox1.SelectedIndex = i;
            //将改变后的索引拿到泛型集合中 找到对应歌曲的全路径赋值给sp对象
            sp.SoundLocation=list[i];
            sp.Play();
        }
    }
}
