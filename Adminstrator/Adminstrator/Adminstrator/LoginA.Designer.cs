namespace student
{
    partial class LoginA
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
            panel1 = new Panel();
            登录 = new Button();
            管理员端登录页面 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            密码 = new Label();
            账号 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(登录);
            panel1.Controls.Add(管理员端登录页面);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(密码);
            panel1.Controls.Add(账号);
            panel1.Location = new Point(33, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 423);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // 登录
            // 
            登录.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            登录.BackColor = SystemColors.ActiveCaption;
            登录.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            登录.ForeColor = SystemColors.Control;
            登录.Location = new Point(203, 298);
            登录.Name = "登录";
            登录.Size = new Size(112, 48);
            登录.TabIndex = 117;
            登录.Text = "登录";
            登录.UseVisualStyleBackColor = false;
            登录.Click += 登录_Click;
            // 
            // 管理员端登录页面
            // 
            管理员端登录页面.AutoSize = true;
            管理员端登录页面.Font = new Font("华文行楷", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            管理员端登录页面.Location = new Point(112, 66);
            管理员端登录页面.Name = "管理员端登录页面";
            管理员端登录页面.Size = new Size(321, 39);
            管理员端登录页面.TabIndex = 9;
            管理员端登录页面.Text = "欢迎登录管理员端";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 7;
            // 
            // 密码
            // 
            密码.AutoSize = true;
            密码.Font = new Font("华文仿宋", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            密码.Location = new Point(88, 218);
            密码.Name = "密码";
            密码.Size = new Size(70, 31);
            密码.TabIndex = 6;
            密码.Text = "密码";
            // 
            // 账号
            // 
            账号.AutoSize = true;
            账号.Font = new Font("华文仿宋", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            账号.Location = new Point(88, 151);
            账号.Name = "账号";
            账号.Size = new Size(70, 31);
            账号.TabIndex = 5;
            账号.Text = "账号";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 447);
            Controls.Add(panel1);
            Name = "login";
            Text = "login";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label 管理员端登录页面;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label 密码;
        private Label 账号;
        private Button 登录;
    }
}