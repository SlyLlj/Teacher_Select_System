namespace teacher
{
    partial class TeacherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            panel6 = new Panel();
            panel8 = new Panel();
            学生端 = new Label();
            登出 = new Button();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelMenu = new Panel();
            panel12 = new Panel();
            修改密码 = new Button();
            panel5 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            jgcx = new Button();
            panel9 = new Panel();
            button6 = new Button();
            panel4 = new Panel();
            志愿填报 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            个人信息 = new Button();
            button2 = new Button();
            panelmain = new Panel();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panel12.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.SteelBlue;
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1881, 65);
            panel6.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(学生端);
            panel8.Controls.Add(登出);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(1660, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(221, 65);
            panel8.TabIndex = 4;
            // 
            // 学生端
            // 
            学生端.AutoSize = true;
            学生端.ForeColor = SystemColors.ControlLight;
            学生端.Location = new Point(26, 22);
            学生端.Name = "学生端";
            学生端.Size = new Size(54, 20);
            学生端.TabIndex = 0;
            学生端.Text = "教师端";
            学生端.Click += 学生端_Click;
            // 
            // 登出
            // 
            登出.FlatStyle = FlatStyle.Flat;
            登出.ForeColor = SystemColors.ControlLightLight;
            登出.Location = new Point(102, -4);
            登出.Name = "登出";
            登出.Size = new Size(119, 72);
            登出.TabIndex = 1;
            登出.Text = "登出";
            登出.UseVisualStyleBackColor = true;
            登出.Click += 登出_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(857, 65);
            panel7.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(123, 9);
            label1.Name = "label1";
            label1.Size = new Size(360, 45);
            label1.TabIndex = 0;
            label1.Text = "毕业设计师生双选系统";
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.SteelBlue;
            panelMenu.Controls.Add(panel12);
            panelMenu.Controls.Add(panel5);
            panelMenu.Controls.Add(panel4);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 65);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(125, 958);
            panelMenu.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.Controls.Add(修改密码);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 162);
            panel12.Name = "panel12";
            panel12.Size = new Size(125, 54);
            panel12.TabIndex = 7;
            // 
            // 修改密码
            // 
            修改密码.FlatAppearance.BorderSize = 0;
            修改密码.FlatStyle = FlatStyle.Flat;
            修改密码.ForeColor = SystemColors.Control;
            修改密码.Location = new Point(3, 6);
            修改密码.Name = "修改密码";
            修改密码.Size = new Size(116, 37);
            修改密码.TabIndex = 0;
            修改密码.Text = "修改密码";
            修改密码.UseVisualStyleBackColor = true;
            修改密码.Click += 修改密码_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(button6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 108);
            panel5.Name = "panel5";
            panel5.Size = new Size(125, 54);
            panel5.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(jgcx);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(125, 54);
            panel10.TabIndex = 7;
            // 
            // panel11
            // 
            panel11.Location = new Point(1, 49);
            panel11.Name = "panel11";
            panel11.Size = new Size(121, 109);
            panel11.TabIndex = 6;
            // 
            // jgcx
            // 
            jgcx.FlatAppearance.BorderSize = 0;
            jgcx.FlatStyle = FlatStyle.Flat;
            jgcx.ForeColor = SystemColors.Control;
            jgcx.Location = new Point(3, 6);
            jgcx.Name = "jgcx";
            jgcx.Size = new Size(116, 37);
            jgcx.TabIndex = 0;
            jgcx.Text = "结果查询";
            jgcx.UseVisualStyleBackColor = true;
            jgcx.Click += jgcx_Click;
            // 
            // panel9
            // 
            panel9.Location = new Point(1, 49);
            panel9.Name = "panel9";
            panel9.Size = new Size(121, 109);
            panel9.TabIndex = 6;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(6, 6);
            button6.Name = "button6";
            button6.Size = new Size(113, 37);
            button6.TabIndex = 0;
            button6.Text = "结果查询";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(志愿填报);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(125, 54);
            panel4.TabIndex = 4;
            // 
            // 志愿填报
            // 
            志愿填报.FlatAppearance.BorderSize = 0;
            志愿填报.FlatStyle = FlatStyle.Flat;
            志愿填报.ForeColor = SystemColors.Control;
            志愿填报.Location = new Point(3, 6);
            志愿填报.Name = "志愿填报";
            志愿填报.Size = new Size(116, 37);
            志愿填报.TabIndex = 0;
            志愿填报.Text = "志愿填报";
            志愿填报.UseVisualStyleBackColor = true;
            志愿填报.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 54);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(个人信息);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 54);
            panel2.TabIndex = 2;
            // 
            // 个人信息
            // 
            个人信息.FlatAppearance.BorderSize = 0;
            个人信息.FlatStyle = FlatStyle.Flat;
            个人信息.ForeColor = SystemColors.Control;
            个人信息.Location = new Point(3, 6);
            个人信息.Name = "个人信息";
            个人信息.Size = new Size(116, 37);
            个人信息.TabIndex = 0;
            个人信息.Text = "个人信息";
            个人信息.UseVisualStyleBackColor = true;
            个人信息.Click += 个人信息_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(12, 8);
            button2.Name = "button2";
            button2.Size = new Size(116, 37);
            button2.TabIndex = 0;
            button2.Text = "个人信息";
            button2.UseVisualStyleBackColor = true;
            // 
            // panelmain
            // 
            panelmain.Dock = DockStyle.Fill;
            panelmain.Location = new Point(125, 65);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(1756, 958);
            panelmain.TabIndex = 4;
            panelmain.Paint += panelmain_Paint;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1881, 1023);
            Controls.Add(panelmain);
            Controls.Add(panelMenu);
            Controls.Add(panel6);
            Name = "TeacherForm";
            Text = "教师端";
            Load += TeacherForm_Load;
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panel8;
        private Label 学生端;
        private Button 登出;
        private Panel panel7;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelMenu;
        private Panel panel12;
        private Button 修改密码;
        private Panel panel5;
        private Panel panel10;
        private Panel panel11;
        private Button jgcx;
        private Panel panel9;
        private Button button6;
        private Panel panel4;
        private Button 志愿填报;
        private Panel panel1;
        private Panel panel2;
        private Button 个人信息;
        private Button button2;
        private Panel panelmain;
    }
}