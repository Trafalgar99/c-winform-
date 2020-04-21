namespace TreeView
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("c:\\");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("B:\\");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("我的电脑", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("网络邻居");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("回收站");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("我的下载");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("我的图片");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("我的音乐");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("我的文档", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(236, 155);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点4";
            treeNode1.Text = "c:\\";
            treeNode2.Name = "节点5";
            treeNode2.Text = "B:\\";
            treeNode3.Name = "节点0";
            treeNode3.Text = "我的电脑";
            treeNode4.Name = "节点1";
            treeNode4.Text = "网络邻居";
            treeNode5.Name = "节点2";
            treeNode5.Text = "回收站";
            treeNode6.Name = "节点6";
            treeNode6.Text = "我的下载";
            treeNode7.Name = "节点7";
            treeNode7.Text = "我的图片";
            treeNode8.Name = "节点8";
            treeNode8.Text = "我的音乐";
            treeNode9.Name = "节点3";
            treeNode9.Text = "我的文档";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(416, 369);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 696);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

