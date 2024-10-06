namespace student
{
    partial class loginS
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
            pwdTextBox = new TextBox();
            button1 = new Button();
            UidTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pwdTextBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(UidTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 423);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pwdTextBox
            // 
            pwdTextBox.Location = new Point(222, 229);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.PasswordChar = '*';
            pwdTextBox.Size = new Size(204, 27);
            pwdTextBox.TabIndex = 11;
            pwdTextBox.TextChanged += pwdTextBox_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(247, 306);
            button1.Name = "button1";
            button1.Size = new Size(112, 48);
            button1.TabIndex = 12;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // UidTextBox
            // 
            UidTextBox.Location = new Point(222, 161);
            UidTextBox.Name = "UidTextBox";
            UidTextBox.Size = new Size(204, 27);
            UidTextBox.TabIndex = 10;
            UidTextBox.TextChanged += UidTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("华文仿宋", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(130, 225);
            label3.Name = "label3";
            label3.Size = new Size(70, 31);
            label3.TabIndex = 9;
            label3.Text = "密码";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("华文仿宋", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(130, 157);
            label2.Name = "label2";
            label2.Size = new Size(70, 31);
            label2.TabIndex = 8;
            label2.Text = "账号";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("华文行楷", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 61);
            label1.Name = "label1";
            label1.Size = new Size(283, 39);
            label1.TabIndex = 7;
            label1.Text = "欢迎登录学生端";
            label1.Click += label1_Click;
            // 
            // loginS
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 447);
            Controls.Add(panel1);
            Name = "loginS";
            Text = "loginS";
            Load += loginS_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox pwdTextBox;
        private TextBox UidTextBox;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}