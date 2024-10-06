namespace Student
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
            确认 = new Button();
            pwdwrong = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // 原密码
            // 
            原密码.AutoSize = true;
            原密码.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            原密码.Location = new Point(160, 111);
            原密码.Name = "原密码";
            原密码.Size = new Size(82, 30);
            原密码.TabIndex = 0;
            原密码.Text = "原密码";
            // 
            // 新密码
            // 
            新密码.Anchor = AnchorStyles.Left;
            新密码.AutoSize = true;
            新密码.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            新密码.Location = new Point(160, 189);
            新密码.Name = "新密码";
            新密码.Size = new Size(82, 30);
            新密码.TabIndex = 1;
            新密码.Text = "新密码";
            // 
            // 确认密码
            // 
            确认密码.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            确认密码.AutoSize = true;
            确认密码.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            确认密码.Location = new Point(137, 268);
            确认密码.Name = "确认密码";
            确认密码.Size = new Size(105, 30);
            确认密码.TabIndex = 2;
            确认密码.Text = "确认密码";
            确认密码.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(266, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(266, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(266, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 27);
            textBox3.TabIndex = 5;
            // 
            // 确认
            // 
            确认.Anchor = AnchorStyles.Bottom;
            确认.BackColor = SystemColors.ActiveCaption;
            确认.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            确认.ForeColor = SystemColors.Control;
            确认.Location = new Point(245, 358);
            确认.Name = "确认";
            确认.Size = new Size(109, 38);
            确认.TabIndex = 117;
            确认.Text = "确认";
            确认.UseVisualStyleBackColor = false;
            确认.Click += 确认_Click;
            // 
            // pwdwrong
            // 
            pwdwrong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pwdwrong.AutoSize = true;
            pwdwrong.Location = new Point(506, 118);
            pwdwrong.Name = "pwdwrong";
            pwdwrong.Size = new Size(69, 20);
            pwdwrong.TabIndex = 118;
            pwdwrong.Text = "密码错误";
            pwdwrong.Visible = false;
            pwdwrong.Click += pwdwrong_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(385, 358);
            button1.Name = "button1";
            button1.Size = new Size(109, 38);
            button1.TabIndex = 119;
            button1.Text = "忘记密码";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(506, 276);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 120;
            label1.Text = "密码不一致";
            label1.Visible = false;
            label1.Click += label1_Click_1;
            // 
            // Change_Password
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 494);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pwdwrong);
            Controls.Add(确认);
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
        private Button 确认;
        private Label pwdwrong;
        private Button button1;
        private Label label1;
    }
}