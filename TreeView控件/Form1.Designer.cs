namespace TreeView控件
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("我的电脑");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("网上邻居");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("回收站");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("我的文档");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtParent = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtChild = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(40, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "我的电脑";
            treeNode2.Name = "节点1";
            treeNode2.Text = "网上邻居";
            treeNode3.Name = "节点2";
            treeNode3.Text = "回收站";
            treeNode4.Name = "节点3";
            treeNode4.Text = "我的文档";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(358, 473);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加根节点";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtParent
            // 
            this.txtParent.Location = new System.Drawing.Point(495, 63);
            this.txtParent.Name = "txtParent";
            this.txtParent.Size = new System.Drawing.Size(142, 28);
            this.txtParent.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(495, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "添加子节点";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtChild
            // 
            this.txtChild.Location = new System.Drawing.Point(495, 204);
            this.txtChild.Name = "txtChild";
            this.txtChild.Size = new System.Drawing.Size(142, 28);
            this.txtChild.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "修改节点名称";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(495, 328);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(142, 28);
            this.txtChange.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(495, 456);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 45);
            this.button4.TabIndex = 7;
            this.button4.Text = "展开全部节点";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(495, 520);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 45);
            this.button5.TabIndex = 8;
            this.button5.Text = "折叠全部节点";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 603);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtChild);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtParent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtChild;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

