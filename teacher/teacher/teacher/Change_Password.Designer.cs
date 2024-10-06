namespace teacher
{
    partial class Change_Password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            原密码 = new Label();
            新密码 = new Label();
            确认密码 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pwdwrong = new Label();
            密码不一致 = new Label();
            确认 = new Button();
            忘记密码 = new Button();
            SuspendLayout();
            // 
            // 原密码
            // 
            原密码.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            原密码.AutoSize = true;
            原密码.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            原密码.Location = new Point(575, 171);
            原密码.Name = "原密码";
            原密码.Size = new Size(107, 39);
            原密码.TabIndex = 0;
            原密码.Text = "原密码";
            // 
            // 新密码
            // 
            新密码.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            新密码.AutoSize = true;
            新密码.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            新密码.Location = new Point(575, 349);
            新密码.Name = "新密码";
            新密码.Size = new Size(107, 39);
            新密码.TabIndex = 1;
            新密码.Text = "新密码";
            // 
            // 确认密码
            // 
            确认密码.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            确认密码.AutoSize = true;
            确认密码.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            确认密码.Location = new Point(545, 518);
            确认密码.Name = "确认密码";
            确认密码.Size = new Size(137, 39);
            确认密码.TabIndex = 2;
            确认密码.Text = "确认密码";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(702, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 46);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(702, 346);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(372, 46);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(702, 515);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(372, 46);
            textBox3.TabIndex = 5;
            // 
            // pwdwrong
            // 
            pwdwrong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pwdwrong.AutoSize = true;
            pwdwrong.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pwdwrong.Location = new Point(1107, 174);
            pwdwrong.Name = "pwdwrong";
            pwdwrong.Size = new Size(114, 32);
            pwdwrong.TabIndex = 119;
            pwdwrong.Text = "密码错误";
            pwdwrong.Visible = false;
            // 
            // 密码不一致
            // 
            密码不一致.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            密码不一致.AutoSize = true;
            密码不一致.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            密码不一致.Location = new Point(1107, 523);
            密码不一致.Name = "密码不一致";
            密码不一致.Size = new Size(139, 32);
            密码不一致.TabIndex = 120;
            密码不一致.Text = "密码不一致";
            密码不一致.Visible = false;
            // 
            // 确认
            // 
            确认.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            确认.BackColor = SystemColors.ActiveCaption;
            确认.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            确认.ForeColor = SystemColors.Control;
            确认.Location = new Point(738, 677);
            确认.Name = "确认";
            确认.Size = new Size(122, 59);
            确认.TabIndex = 121;
            确认.Text = "确认";
            确认.UseVisualStyleBackColor = false;
            // 
            // 忘记密码
            // 
            忘记密码.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            忘记密码.BackColor = SystemColors.ActiveCaption;
            忘记密码.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            忘记密码.ForeColor = SystemColors.Control;
            忘记密码.Location = new Point(939, 677);
            忘记密码.Name = "忘记密码";
            忘记密码.Size = new Size(134, 59);
            忘记密码.TabIndex = 122;
            忘记密码.Text = "忘记密码";
            忘记密码.UseVisualStyleBackColor = false;
            忘记密码.Click += 忘记密码_Click;
            // 
            // Change_Password
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1756, 958);
            Controls.Add(忘记密码);
            Controls.Add(确认);
            Controls.Add(密码不一致);
            Controls.Add(pwdwrong);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(确认密码);
            Controls.Add(新密码);
            Controls.Add(原密码);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Change_Password";
            Text = "Change_Password";
            Load += Change_Password_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label 原密码;
        private Label 新密码;
        private Label 确认密码;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label pwdwrong;
        private Label 密码不一致;
        private Button 确认;
        private Button 忘记密码;
    }
}