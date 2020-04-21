namespace 简单记事本
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
            this.btnWordWarp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWordWarp
            // 
            this.btnWordWarp.Location = new System.Drawing.Point(205, 70);
            this.btnWordWarp.Name = "btnWordWarp";
            this.btnWordWarp.Size = new System.Drawing.Size(115, 44);
            this.btnWordWarp.TabIndex = 0;
            this.btnWordWarp.Text = "自动换行";
            this.btnWordWarp.UseVisualStyleBackColor = true;
            this.btnWordWarp.Click += new System.EventHandler(this.btnWordWarp_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(542, 70);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 44);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(166, 167);
            this.txtWords.Multiline = true;
            this.txtWords.Name = "txtWords";
            this.txtWords.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtWords.Size = new System.Drawing.Size(604, 386);
            this.txtWords.TabIndex = 2;
            this.txtWords.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(323, 223);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 28);
            this.txtName.TabIndex = 5;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(313, 362);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(252, 28);
            this.txtPwd.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(542, 487);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 34);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 623);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWords);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnWordWarp);
            this.Name = "Form1";
            this.Text = "记事本";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWordWarp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
    }
}

