using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 修改节点名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //首先还要获得当前选中结点
           TreeNode tn= treeView1.SelectedNode;
            tn.Text = txtChange.Text;
        }
        /// <summary>
        /// 展开全部节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();  
        }
        /// <summary>
        /// 添加根节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(txtParent.Text);
        }
        /// <summary>
        /// 添加子结点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //首先获得选中的根节点
            TreeNode tn= treeView1.SelectedNode;

            //给选中的根节点添加子结点
            tn.Nodes.Add(txtChild.Text);
        }
        /// <summary>
        /// 折叠全部结点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
