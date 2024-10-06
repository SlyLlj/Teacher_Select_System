namespace WinFormsApp1
{
    partial class StudentForm
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
            panel6 = new Panel();
            panel8 = new Panel();
            学生端 = new Label();
            登出 = new Button();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            panelMenu = new Panel();
            panel12 = new Panel();
            修改密码 = new Button();
            paneljgcx = new Panel();
            button8 = new Button();
            button7 = new Button();
            panel5 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            jgcx = new Button();
            panel9 = new Panel();
            button6 = new Button();
            panel4 = new Panel();
            button5 = new Button();
            组长组队 = new Panel();
            button4 = new Button();
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
            paneljgcx.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            组长组队.SuspendLayout();
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
            panel6.Size = new Size(1163, 65);
            panel6.TabIndex = 1;
            panel6.Paint += panel6_Paint;
            // 
            // panel8
            // 
            panel8.Controls.Add(学生端);
            panel8.Controls.Add(登出);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(942, 0);
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
            学生端.Text = "学生端";
            学生端.Click += 学生端_Click_1;
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
            pictureBox1.Image = Student.Properties.Resources.logo;
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
            label1.Click += label1_Click_1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Location = new Point(124, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1036, 559);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.SteelBlue;
            panelMenu.Controls.Add(panel12);
            panelMenu.Controls.Add(paneljgcx);
            panelMenu.Controls.Add(panel5);
            panelMenu.Controls.Add(panel4);
            panelMenu.Controls.Add(组长组队);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 65);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(125, 548);
            panelMenu.TabIndex = 2;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // panel12
            // 
            panel12.Controls.Add(修改密码);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 317);
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
            // paneljgcx
            // 
            paneljgcx.BackColor = SystemColors.Highlight;
            paneljgcx.Controls.Add(button8);
            paneljgcx.Controls.Add(button7);
            paneljgcx.Dock = DockStyle.Top;
            paneljgcx.Location = new Point(0, 216);
            paneljgcx.Name = "paneljgcx";
            paneljgcx.Size = new Size(125, 101);
            paneljgcx.TabIndex = 6;
            paneljgcx.Visible = false;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(0, 48);
            button8.Name = "button8";
            button8.Size = new Size(125, 50);
            button8.TabIndex = 1;
            button8.Text = "志愿结果";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(0, -5);
            button7.Name = "button7";
            button7.Size = new Size(125, 56);
            button7.TabIndex = 0;
            button7.Text = "组队结果";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(button6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 162);
            panel5.Name = "panel5";
            panel5.Size = new Size(125, 54);
            panel5.TabIndex = 5;
            panel5.Paint += panel5_Paint;
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
            button6.Click += button6_Click_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(button5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(125, 54);
            panel4.TabIndex = 4;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(3, 6);
            button5.Name = "button5";
            button5.Size = new Size(116, 37);
            button5.TabIndex = 0;
            button5.Text = "志愿填报";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // 组长组队
            // 
            组长组队.Controls.Add(button4);
            组长组队.Dock = DockStyle.Top;
            组长组队.Location = new Point(0, 54);
            组长组队.Name = "组长组队";
            组长组队.Size = new Size(125, 54);
            组长组队.TabIndex = 3;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(3, 6);
            button4.Name = "button4";
            button4.Size = new Size(116, 37);
            button4.TabIndex = 0;
            button4.Text = "组长组队";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_2;
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
            panelmain.Location = new Point(123, 65);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(1040, 548);
            panelmain.TabIndex = 3;
            panelmain.Paint += panel12_Paint;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 613);
            Controls.Add(panelmain);
            Controls.Add(panelMenu);
            Controls.Add(panel6);
            Name = "StudentForm";
            Text = "学生端";
            Load += Form1_Load;
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panel12.ResumeLayout(false);
            paneljgcx.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel4.ResumeLayout(false);
            组长组队.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel6;
        private Label label1;
        private Panel panel7;
        private Panel panel8;
        private Button 登出;
        private Label 学生端;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panelMenu;
        private Panel paneljgcx;
        private Button button8;
        private Button button7;
        private Panel panel5;
        private Panel panel10;
        private Panel panel11;
        private Button jgcx;
        private Panel panel9;
        private Button button6;
        private Panel panel4;
        private Button button5;
        private Panel 组长组队;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private Button 个人信息;
        private Button button2;
        private Panel panelmain;
        private Panel panel12;
        private Button 修改密码;
    }
}