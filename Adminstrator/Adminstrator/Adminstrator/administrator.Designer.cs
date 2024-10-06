namespace Adminstrator
{
    partial class administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administrator));
            panel6 = new Panel();
            panel8 = new Panel();
            管理员端 = new Label();
            登出 = new Button();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelMenu = new Panel();
            panel12 = new Panel();
            分配 = new Button();
            panelxtpz = new Panel();
            panel2 = new Panel();
            系统配置 = new Button();
            panelxx = new Panel();
            学生信息 = new Button();
            教师信息 = new Button();
            panel5 = new Panel();
            panelxxxg = new Panel();
            信息导入与修改 = new Button();
            panel11 = new Panel();
            panel9 = new Panel();
            button6 = new Button();
            panelmain = new Panel();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panel12.SuspendLayout();
            panelxtpz.SuspendLayout();
            panelxx.SuspendLayout();
            panel5.SuspendLayout();
            panelxxxg.SuspendLayout();
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
            panel6.Size = new Size(1902, 65);
            panel6.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(管理员端);
            panel8.Controls.Add(登出);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(1681, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(221, 65);
            panel8.TabIndex = 4;
            // 
            // 管理员端
            // 
            管理员端.AutoSize = true;
            管理员端.ForeColor = SystemColors.ControlLight;
            管理员端.Location = new Point(16, 22);
            管理员端.Name = "管理员端";
            管理员端.Size = new Size(69, 20);
            管理员端.TabIndex = 0;
            管理员端.Text = "管理员端";
            管理员端.Click += 管理员端_Click;
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
            panelMenu.Controls.Add(panelxtpz);
            panelMenu.Controls.Add(panelxx);
            panelMenu.Controls.Add(panel5);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 65);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(125, 968);
            panelMenu.TabIndex = 3;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // panel12
            // 
            panel12.Controls.Add(分配);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 209);
            panel12.Name = "panel12";
            panel12.Size = new Size(125, 54);
            panel12.TabIndex = 10;
            // 
            // 分配
            // 
            分配.FlatAppearance.BorderSize = 0;
            分配.FlatStyle = FlatStyle.Flat;
            分配.ForeColor = SystemColors.Control;
            分配.Location = new Point(0, 3);
            分配.Name = "分配";
            分配.Size = new Size(125, 48);
            分配.TabIndex = 0;
            分配.Text = "分配";
            分配.UseVisualStyleBackColor = true;
            分配.Click += 分配_Click;
            // 
            // panelxtpz
            // 
            panelxtpz.Controls.Add(panel2);
            panelxtpz.Controls.Add(系统配置);
            panelxtpz.Dock = DockStyle.Top;
            panelxtpz.Location = new Point(0, 155);
            panelxtpz.Name = "panelxtpz";
            panelxtpz.Size = new Size(125, 54);
            panelxtpz.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 104);
            panel2.TabIndex = 6;
            // 
            // 系统配置
            // 
            系统配置.FlatAppearance.BorderSize = 0;
            系统配置.FlatStyle = FlatStyle.Flat;
            系统配置.ForeColor = SystemColors.Control;
            系统配置.Location = new Point(0, 0);
            系统配置.Name = "系统配置";
            系统配置.Size = new Size(125, 54);
            系统配置.TabIndex = 0;
            系统配置.Text = "系统配置";
            系统配置.UseVisualStyleBackColor = true;
            系统配置.Click += 系统配置_Click;
            // 
            // panelxx
            // 
            panelxx.BackColor = SystemColors.Highlight;
            panelxx.Controls.Add(学生信息);
            panelxx.Controls.Add(教师信息);
            panelxx.Dock = DockStyle.Top;
            panelxx.Location = new Point(0, 54);
            panelxx.Name = "panelxx";
            panelxx.Size = new Size(125, 101);
            panelxx.TabIndex = 6;
            panelxx.Visible = false;
            panelxx.Paint += panelxx_Paint;
            // 
            // 学生信息
            // 
            学生信息.FlatAppearance.BorderSize = 0;
            学生信息.FlatStyle = FlatStyle.Flat;
            学生信息.ForeColor = SystemColors.Control;
            学生信息.Location = new Point(0, 48);
            学生信息.Name = "学生信息";
            学生信息.Size = new Size(125, 50);
            学生信息.TabIndex = 1;
            学生信息.Text = "学生信息";
            学生信息.UseVisualStyleBackColor = true;
            学生信息.Click += 学生信息_Click;
            // 
            // 教师信息
            // 
            教师信息.FlatAppearance.BorderSize = 0;
            教师信息.FlatStyle = FlatStyle.Flat;
            教师信息.ForeColor = SystemColors.Control;
            教师信息.Location = new Point(0, -5);
            教师信息.Name = "教师信息";
            教师信息.Size = new Size(125, 56);
            教师信息.TabIndex = 0;
            教师信息.Text = "教师信息";
            教师信息.UseVisualStyleBackColor = true;
            教师信息.Click += 教师信息_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panelxxxg);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(button6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(125, 54);
            panel5.TabIndex = 5;
            // 
            // panelxxxg
            // 
            panelxxxg.Controls.Add(信息导入与修改);
            panelxxxg.Controls.Add(panel11);
            panelxxxg.Dock = DockStyle.Top;
            panelxxxg.Location = new Point(0, 0);
            panelxxxg.Name = "panelxxxg";
            panelxxxg.Size = new Size(125, 54);
            panelxxxg.TabIndex = 7;
            // 
            // 信息导入与修改
            // 
            信息导入与修改.FlatAppearance.BorderSize = 0;
            信息导入与修改.FlatStyle = FlatStyle.Flat;
            信息导入与修改.Font = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            信息导入与修改.ForeColor = SystemColors.Control;
            信息导入与修改.Location = new Point(0, 0);
            信息导入与修改.Name = "信息导入与修改";
            信息导入与修改.Size = new Size(125, 54);
            信息导入与修改.TabIndex = 7;
            信息导入与修改.Text = "信息导入与修改";
            信息导入与修改.UseVisualStyleBackColor = true;
            信息导入与修改.Click += 信息导入与修改_Click_1;
            // 
            // panel11
            // 
            panel11.Location = new Point(1, 49);
            panel11.Name = "panel11";
            panel11.Size = new Size(121, 109);
            panel11.TabIndex = 6;
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
            // panelmain
            // 
            panelmain.Dock = DockStyle.Fill;
            panelmain.Font = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            panelmain.Location = new Point(125, 65);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(1777, 968);
            panelmain.TabIndex = 4;
            panelmain.Paint += panelmain_Paint;
            // 
            // administrator
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelmain);
            Controls.Add(panelMenu);
            Controls.Add(panel6);
            Name = "administrator";
            Text = "管理员端";
            Load += Form1_Load;
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panelxtpz.ResumeLayout(false);
            panelxx.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panelxxxg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panel8;
        private Label 管理员端;
        private Button 登出;
        private Panel panel7;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelMenu;
        private Panel panelxx;
        private Button 学生信息;
        private Button 教师信息;
        private Panel panel5;
        private Panel panelxxxg;
        private Panel panel11;
        private Panel panel9;
        private Button button6;
        private Panel panelmain;
        private Panel panelxtpz;
        private Panel panel2;
        private Button 系统配置;
        private Panel panel12;
        private Button 分配;
        private Button 信息导入与修改;
    }
}