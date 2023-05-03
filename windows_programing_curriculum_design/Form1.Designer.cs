namespace windows_programing_curriculum_design
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
            this.button1 = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.tipLinkLabel = new System.Windows.Forms.LinkLabel();
            this.fromTitle = new System.Windows.Forms.Label();
            this.accountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(18, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordTextBox.Location = new System.Drawing.Point(18, 119);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(266, 38);
            this.passwordTextBox.TabIndex = 1;
            // 
            // accountTextBox
            // 
            this.accountTextBox.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountTextBox.Location = new System.Drawing.Point(18, 34);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.PasswordChar = '*';
            this.accountTextBox.Size = new System.Drawing.Size(266, 38);
            this.accountTextBox.TabIndex = 1;
            // 
            // loginPanel
            // 
            this.loginPanel.AutoSize = true;
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanel.Controls.Add(this.linkLabel1);
            this.loginPanel.Controls.Add(this.accountLinkLabel);
            this.loginPanel.Controls.Add(this.tipLinkLabel);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.accountTextBox);
            this.loginPanel.Controls.Add(this.button1);
            this.loginPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginPanel.Location = new System.Drawing.Point(532, 63);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(302, 327);
            this.loginPanel.TabIndex = 2;
            // 
            // tipLinkLabel
            // 
            this.tipLinkLabel.AutoSize = true;
            this.tipLinkLabel.LinkColor = System.Drawing.Color.Red;
            this.tipLinkLabel.Location = new System.Drawing.Point(139, 168);
            this.tipLinkLabel.Name = "tipLinkLabel";
            this.tipLinkLabel.Size = new System.Drawing.Size(0, 15);
            this.tipLinkLabel.TabIndex = 2;
            // 
            // fromTitle
            // 
            this.fromTitle.AutoSize = true;
            this.fromTitle.BackColor = System.Drawing.Color.Transparent;
            this.fromTitle.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fromTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fromTitle.Location = new System.Drawing.Point(36, 156);
            this.fromTitle.Name = "fromTitle";
            this.fromTitle.Size = new System.Drawing.Size(458, 90);
            this.fromTitle.TabIndex = 3;
            this.fromTitle.Text = "宿舍管理系统";
            this.fromTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountLinkLabel
            // 
            this.accountLinkLabel.AutoSize = true;
            this.accountLinkLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.accountLinkLabel.Location = new System.Drawing.Point(18, 4);
            this.accountLinkLabel.Name = "accountLinkLabel";
            this.accountLinkLabel.Size = new System.Drawing.Size(72, 27);
            this.accountLinkLabel.TabIndex = 3;
            this.accountLinkLabel.TabStop = true;
            this.accountLinkLabel.Text = "用户名";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(18, 89);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 27);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "密码";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::windows_programing_curriculum_design.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(892, 509);
            this.Controls.Add(this.fromTitle);
            this.Controls.Add(this.loginPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(910, 556);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(910, 556);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "登录窗口";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.LinkLabel tipLinkLabel;
        private System.Windows.Forms.Label fromTitle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel accountLinkLabel;
    }
}

