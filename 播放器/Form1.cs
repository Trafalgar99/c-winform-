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

namespace 播放器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 在程序一加载的时候取消播放器的自动播放功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            MusicPlayer.settings.autoStart = false;
            //你只要这个播放器的url属性赋值，播放器就会自动播放
            MusicPlayer.URL = @"某个wav文件的路径";

        }
        /// <summary>
        ///  点击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //播放
            MusicPlayer.Ctlcontrols.play();
        }
        /// <summary>
        /// 点击暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            MusicPlayer.Ctlcontrols.pause();
        }
        /// <summary>
        /// 点击停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            MusicPlayer.Ctlcontrols.stop();
        }
        /// <summary>
        /// 播放或者暂停  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        bool b = true;
        private void btnPlayOrPause_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndices.Count==0)
            {
                MessageBox.Show("请先选择歌曲");
                return;
            }
            if(btnPlayOrPause.Text=="播放")
            {
                if(b)
                {
                    //获得当前选中文件的索引
                    int index = listBox1.SelectedIndex;

                    //将这个索引拿到list泛型集合当中找到这个文件对应的全路径
                    //赋值给播放器
                    MusicPlayer.URL = list[index];
                }
                
                MusicPlayer.Ctlcontrols.play();
                btnPlayOrPause.Text = "暂停";
            }
            else if(btnPlayOrPause.Text=="暂停")
            {
                MusicPlayer.Ctlcontrols.pause();
                btnPlayOrPause.Text = "播放";
                b = false;
            }
        }
        /// <summary>
        /// 点击停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop2_Click(object sender, EventArgs e)
        {
            MusicPlayer.Ctlcontrols.stop();

        }

        //声明一个泛型集合存储音乐文件的全路径
        List<string> list = new List<string>();
        /// <summary>
        /// 点击淡出对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"C:\Users\86158\Desktop";
            ofd.Filter = "音乐文件|*.wav|所有文件|*.*";
            ofd.ShowDialog();

            //获得选中的文件的全路径
            string[]path=ofd.FileNames;
            for(int i=0;i<path.Length;i++)
            {
               

                int index = path[i].LastIndexOf("\\");
                //截取文件名
                string strNew = path[i].Substring(index + 1);

                //将文件名加载到listBox中
                //在加之前首先判断 如果有重复的项 就不加了 只加不重复的
                if (!listBox1.Items.Contains(strNew))
                {
                    listBox1.Items.Add(strNew);
                    list.Add(path[i]);//将文件的全路径加载到泛型集合中
                }
                
            }


        }
        /// <summary>
        /// 双击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MusicPlayer.URL = list[listBox1.SelectedIndex];
            MusicPlayer.Ctlcontrols.play();
        }
        /// <summary>
        /// 点击上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("请先选择歌曲");
                return;
            }
            int index = listBox1.SelectedIndex;
            index--;
            //清空所有选中的项
            listBox1.SelectedItems.Clear();
            if (index<0)
            {
                //让当前的索引等于最后一首歌的索引
                index = listBox1.Items.Count - 1;
            }
            //将改变后的索引重新的赋值给当前选中的索引
            listBox1.SelectedIndex = index;

            MusicPlayer.URL = list[listBox1.SelectedIndex];
            MusicPlayer.Ctlcontrols.play();
        }
        /// <summary>
        /// 点击下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("请先选择歌曲");
                return;
            }
            //首先获得当前选中项的索引
            int index = listBox1.SelectedIndex;
            index++;
            //清空所有选中的项
            listBox1.SelectedItems.Clear();
            if(index==listBox1.Items.Count)
            {
                index = 0;
            }
            //将改变后的索引重新赋值给当前选中的索引
            listBox1.SelectedIndex = index;
            MusicPlayer.URL = list[index];
            MusicPlayer.Ctlcontrols.play();
        }
        /// <summary>
        /// 当你点击删除时 删除你选中的歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获得当前选中项的数量
            int num=listBox1.SelectedItems.Count;
            for (int i=0;i<num;i++)
            {
                //listBox1.SelectedItems.Remove(listBox1.SelectedItem);


                //删除泛型集合中的数据
                list.RemoveAt(listBox1.SelectedIndex);


                //删除listbox中的数据
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        /// <summary>
        /// 当歌曲播放状态改变时触发这个时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MusicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //Ready Playing Pause Ended Stop Transitioning

            //只要播放状态一发生改变 我就输出播放状态
           // MessageBox.Show(MusicPlayer.playState.ToString());
           //如果播放器的当前播放状态已经是ended 让播放器进行下一曲
           if(MusicPlayer.playState== WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                int index = listBox1.SelectedIndex;
                index++;
                //清空当前选中项
                listBox1.SelectedItems.Clear();

                if(index==listBox1.Items.Count)
                {
                    index = 0;
                }
                listBox1.SelectedIndex = index;
                MusicPlayer.URL = list[index];
                //MusicPlayer.Ctlcontrols.play();
            }

           //播放器的状态为ready之后 应该去播放Playing
           if(MusicPlayer.playState== WMPLib.WMPPlayState.wmppsReady)
            {
                //操作系统原因，这里有时会抛出异常，与代码逻辑无关，不处理
                try
                {
                    MusicPlayer.Ctlcontrols.play();
                }
                catch
                {
                    //我在catch中啥都不做

                }
               
            }
        }
        /// <summary>
        /// 点击静音或者放音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            //我想静音
            if (label1.Tag.ToString() == "1")
            {
                //表示静音
                MusicPlayer.settings.mute = true;
                label1.Tag = "2";
                label1.Image = Image.FromFile(@"C:\Users\86158\Desktop\image\d7e11be84b22aedb658821945c8bcecf.jpg");
            }
            else if (label1.Tag.ToString() == "2")
            {
                MusicPlayer.settings.mute = false;
                label1.Tag = "1";
                label1.Image = Image.FromFile(@"C:\Users\86158\Desktop\image\2a0e22797bf16fad2aa4c543a5c4cb0b.jpg");
            }
        }
        /// <summary>
        /// 增大音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_2(object sender, EventArgs e)
        {

            MusicPlayer.settings.volume += 5;
            //MessageBox.Show(MusicPlayer.settings.volume.ToString());
        }
        /// <summary>
        /// 显示播放的时间和歌曲的名字 随机更换图片
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(MusicPlayer.playState== WMPLib.WMPPlayState.wmppsPlaying)
            {
                //这就是歌曲的播放时间
                lblTime.Text = MusicPlayer.Ctlcontrols.currentPositionString;

                //这就是歌曲的名称
                lblName.Text = MusicPlayer.currentMedia.name;

                //随机播放图片
                string[] path = Directory.GetFiles(@"C:\Users\86158\Desktop\image", "*.jpg");
                Random r = new Random();
                int rNum = r.Next(0, path.Length);
                pictureBox1.Image = Image.FromFile(path[rNum]);
            }


            
        }
    }
}
