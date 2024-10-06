namespace student
{
    partial class Volunteer_Results
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
            stunu = new Label();
            组长学号 = new Label();
            name = new Label();
            组长姓名 = new Label();
            textBox3 = new TextBox();
            项目名称 = new Label();
            指导老师 = new GroupBox();
            textBox6 = new TextBox();
            label1 = new Label();
            textBox5 = new TextBox();
            联系电话 = new Label();
            textBox4 = new TextBox();
            邮箱 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            研究方向 = new Label();
            导师姓名 = new Label();
            label2 = new Label();
            label3 = new Label();
            指导老师.SuspendLayout();
            SuspendLayout();
            // 
            // stunu
            // 
            stunu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stunu.AutoSize = true;
            stunu.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stunu.Location = new Point(340, 38);
            stunu.Name = "stunu";
            stunu.Size = new Size(107, 27);
            stunu.TabIndex = 19;
            stunu.Text = "studentnu";
            stunu.Click += stunu_Click;
            // 
            // 组长学号
            // 
            组长学号.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            组长学号.AutoSize = true;
            组长学号.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            组长学号.Location = new Point(222, 38);
            组长学号.Name = "组长学号";
            组长学号.Size = new Size(112, 27);
            组长学号.TabIndex = 18;
            组长学号.Text = "组长学号：";
            组长学号.Click += 组长学号_Click;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            name.AutoSize = true;
            name.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(108, 38);
            name.Name = "name";
            name.Size = new Size(65, 27);
            name.TabIndex = 17;
            name.Text = "name";
            // 
            // 组长姓名
            // 
            组长姓名.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            组长姓名.AutoSize = true;
            组长姓名.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            组长姓名.Location = new Point(40, 38);
            组长姓名.Name = "组长姓名";
            组长姓名.Size = new Size(72, 27);
            组长姓名.TabIndex = 16;
            组长姓名.Text = "组长：";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(160, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(506, 27);
            textBox3.TabIndex = 37;
            // 
            // 项目名称
            // 
            项目名称.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            项目名称.AutoSize = true;
            项目名称.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            项目名称.Location = new Point(42, 100);
            项目名称.Name = "项目名称";
            项目名称.Size = new Size(112, 27);
            项目名称.TabIndex = 36;
            项目名称.Text = "项目名称：";
            // 
            // 指导老师
            // 
            指导老师.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            指导老师.Controls.Add(textBox6);
            指导老师.Controls.Add(label1);
            指导老师.Controls.Add(textBox5);
            指导老师.Controls.Add(联系电话);
            指导老师.Controls.Add(textBox4);
            指导老师.Controls.Add(邮箱);
            指导老师.Controls.Add(textBox2);
            指导老师.Controls.Add(textBox1);
            指导老师.Controls.Add(研究方向);
            指导老师.Controls.Add(导师姓名);
            指导老师.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            指导老师.Location = new Point(42, 165);
            指导老师.Name = "指导老师";
            指导老师.Size = new Size(624, 289);
            指导老师.TabIndex = 38;
            指导老师.TabStop = false;
            指导老师.Text = "指导老师";
            指导老师.Enter += 指导老师_Enter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(386, 59);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(147, 30);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(298, 59);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 14;
            label1.Text = "导师id";
            label1.Click += label1_Click_2;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox5.Location = new Point(435, 228);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(157, 30);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // 联系电话
            // 
            联系电话.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            联系电话.AutoSize = true;
            联系电话.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            联系电话.Location = new Point(347, 228);
            联系电话.Name = "联系电话";
            联系电话.Size = new Size(82, 24);
            联系电话.TabIndex = 12;
            联系电话.Text = "联系电话";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox4.Location = new Point(118, 228);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 30);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // 邮箱
            // 
            邮箱.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            邮箱.AutoSize = true;
            邮箱.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            邮箱.Location = new Point(66, 228);
            邮箱.Name = "邮箱";
            邮箱.Size = new Size(46, 24);
            邮箱.TabIndex = 10;
            邮箱.Text = "邮箱";
            邮箱.Click += label1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(118, 126);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(474, 69);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 30);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // 研究方向
            // 
            研究方向.AutoSize = true;
            研究方向.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            研究方向.Location = new Point(30, 126);
            研究方向.Name = "研究方向";
            研究方向.Size = new Size(82, 24);
            研究方向.TabIndex = 7;
            研究方向.Text = "研究方向";
            // 
            // 导师姓名
            // 
            导师姓名.AutoSize = true;
            导师姓名.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            导师姓名.Location = new Point(30, 59);
            导师姓名.Name = "导师姓名";
            导师姓名.Size = new Size(82, 24);
            导师姓名.TabIndex = 6;
            导师姓名.Text = "导师姓名";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(569, 38);
            label2.Name = "label2";
            label2.Size = new Size(103, 27);
            label2.TabIndex = 40;
            label2.Text = "teamnum";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(503, 38);
            label3.Name = "label3";
            label3.Size = new Size(72, 27);
            label3.TabIndex = 39;
            label3.Text = "组号：";
            // 
            // Volunteer_Results
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 494);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(指导老师);
            Controls.Add(textBox3);
            Controls.Add(项目名称);
            Controls.Add(stunu);
            Controls.Add(组长学号);
            Controls.Add(name);
            Controls.Add(组长姓名);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Volunteer_Results";
            Text = "Volunteer_Results";
            Load += Volunteer_Results_Load;
            指导老师.ResumeLayout(false);
            指导老师.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stunu;
        private Label 组长学号;
        private Label name;
        private Label 组长姓名;
        private TextBox textBox3;
        private Label 项目名称;
        private GroupBox 指导老师;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label 研究方向;
        private Label 导师姓名;
        private Label 邮箱;
        private TextBox textBox5;
        private Label 联系电话;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}