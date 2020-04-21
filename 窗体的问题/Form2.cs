using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体的问题
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击form2窗体的时候 所有窗体都关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            //怎么样才能访问到form1对象？
            Test.frm.Close();   

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
