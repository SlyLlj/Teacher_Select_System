namespace student
{
    partial class Personal_Information
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
            panel4 = new Panel();
            联系管理员 = new Button();
            提交 = new Button();
            panel3 = new Panel();
            dianhuaTextBox = new TextBox();
            联系电话 = new Label();
            youxiangTextBox = new TextBox();
            邮箱 = new Label();
            banbieTextBox = new TextBox();
            班别 = new Label();
            zhuanyeTextBox = new TextBox();
            专业 = new Label();
            xueyuanTextBox = new TextBox();
            学院 = new Label();
            nianjiTextBox = new TextBox();
            年级 = new Label();
            panel2 = new Panel();
            xingbieTextBox = new TextBox();
            性别 = new Label();
            xingmingTextBox = new TextBox();
            学号 = new Label();
            label2 = new Label();
            xuehaoTextBox = new TextBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 541);
            panel1.TabIndex = 89;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.Controls.Add(联系管理员);
            panel4.Controls.Add(提交);
            panel4.Location = new Point(357, 414);
            panel4.Name = "panel4";
            panel4.Size = new Size(527, 67);
            panel4.TabIndex = 118;
            panel4.Paint += panel4_Paint;
            // 
            // 联系管理员
            // 
            联系管理员.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            联系管理员.BackColor = SystemColors.ActiveCaption;
            联系管理员.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            联系管理员.ForeColor = SystemColors.Control;
            联系管理员.Location = new Point(387, 15);
            联系管理员.Name = "联系管理员";
            联系管理员.Size = new Size(109, 38);
            联系管理员.TabIndex = 117;
            联系管理员.Text = "修改";
            联系管理员.UseVisualStyleBackColor = false;
            联系管理员.Click += 联系管理员_Click;
            // 
            // 提交
            // 
            提交.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            提交.BackColor = SystemColors.ActiveCaption;
            提交.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            提交.ForeColor = SystemColors.Control;
            提交.Location = new Point(243, 15);
            提交.Name = "提交";
            提交.Size = new Size(109, 38);
            提交.TabIndex = 116;
            提交.Text = "提交";
            提交.UseVisualStyleBackColor = false;
            提交.Click += 提交_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(dianhuaTextBox);
            panel3.Controls.Add(联系电话);
            panel3.Controls.Add(youxiangTextBox);
            panel3.Controls.Add(邮箱);
            panel3.Controls.Add(banbieTextBox);
            panel3.Controls.Add(班别);
            panel3.Controls.Add(zhuanyeTextBox);
            panel3.Controls.Add(专业);
            panel3.Controls.Add(xueyuanTextBox);
            panel3.Controls.Add(学院);
            panel3.Controls.Add(nianjiTextBox);
            panel3.Controls.Add(年级);
            panel3.Location = new Point(64, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(820, 217);
            panel3.TabIndex = 117;
            // 
            // dianhuaTextBox
            // 
            dianhuaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dianhuaTextBox.Location = new Point(556, 153);
            dianhuaTextBox.MaxLength = 11;
            dianhuaTextBox.Name = "dianhuaTextBox";
            dianhuaTextBox.Size = new Size(249, 27);
            dianhuaTextBox.TabIndex = 124;
            // 
            // 联系电话
            // 
            联系电话.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            联系电话.AutoSize = true;
            联系电话.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            联系电话.Location = new Point(458, 151);
            联系电话.Name = "联系电话";
            联系电话.Size = new Size(92, 27);
            联系电话.TabIndex = 122;
            联系电话.Text = "联系电话";
            联系电话.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // youxiangTextBox
            // 
            youxiangTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            youxiangTextBox.Location = new Point(63, 155);
            youxiangTextBox.Name = "youxiangTextBox";
            youxiangTextBox.Size = new Size(283, 27);
            youxiangTextBox.TabIndex = 121;
            youxiangTextBox.TextChanged += youxiangTextBox_TextChanged;
            // 
            // 邮箱
            // 
            邮箱.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            邮箱.AutoSize = true;
            邮箱.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            邮箱.Location = new Point(5, 155);
            邮箱.Name = "邮箱";
            邮箱.Size = new Size(52, 27);
            邮箱.TabIndex = 119;
            邮箱.Text = "邮箱";
            邮箱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // banbieTextBox
            // 
            banbieTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            banbieTextBox.Location = new Point(517, 81);
            banbieTextBox.Name = "banbieTextBox";
            banbieTextBox.ReadOnly = true;
            banbieTextBox.Size = new Size(288, 27);
            banbieTextBox.TabIndex = 118;
            // 
            // 班别
            // 
            班别.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            班别.AutoSize = true;
            班别.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            班别.Location = new Point(459, 79);
            班别.Name = "班别";
            班别.Size = new Size(52, 27);
            班别.TabIndex = 116;
            班别.Text = "班别";
            班别.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // zhuanyeTextBox
            // 
            zhuanyeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            zhuanyeTextBox.Location = new Point(63, 81);
            zhuanyeTextBox.Name = "zhuanyeTextBox";
            zhuanyeTextBox.ReadOnly = true;
            zhuanyeTextBox.Size = new Size(283, 27);
            zhuanyeTextBox.TabIndex = 115;
            zhuanyeTextBox.TextChanged += zhuanye_TextChanged;
            // 
            // 专业
            // 
            专业.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            专业.AutoSize = true;
            专业.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            专业.Location = new Point(5, 81);
            专业.Name = "专业";
            专业.Size = new Size(52, 27);
            专业.TabIndex = 113;
            专业.Text = "专业";
            专业.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // xueyuanTextBox
            // 
            xueyuanTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            xueyuanTextBox.Location = new Point(516, 11);
            xueyuanTextBox.Name = "xueyuanTextBox";
            xueyuanTextBox.ReadOnly = true;
            xueyuanTextBox.Size = new Size(289, 27);
            xueyuanTextBox.TabIndex = 106;
            // 
            // 学院
            // 
            学院.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            学院.AutoSize = true;
            学院.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            学院.Location = new Point(458, 9);
            学院.Name = "学院";
            学院.Size = new Size(52, 27);
            学院.TabIndex = 104;
            学院.Text = "学院";
            学院.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nianjiTextBox
            // 
            nianjiTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            nianjiTextBox.Location = new Point(62, 11);
            nianjiTextBox.Name = "nianjiTextBox";
            nianjiTextBox.ReadOnly = true;
            nianjiTextBox.Size = new Size(284, 27);
            nianjiTextBox.TabIndex = 103;
            nianjiTextBox.TextChanged += nianji_TextChanged;
            // 
            // 年级
            // 
            年级.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            年级.AutoSize = true;
            年级.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            年级.Location = new Point(6, 11);
            年级.Name = "年级";
            年级.Size = new Size(52, 27);
            年级.TabIndex = 101;
            年级.Text = "年级";
            年级.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(xingbieTextBox);
            panel2.Controls.Add(性别);
            panel2.Controls.Add(xingmingTextBox);
            panel2.Controls.Add(学号);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(xuehaoTextBox);
            panel2.Location = new Point(63, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(821, 59);
            panel2.TabIndex = 116;
            // 
            // xingbieTextBox
            // 
            xingbieTextBox.Anchor = AnchorStyles.Right;
            xingbieTextBox.Location = new Point(741, 16);
            xingbieTextBox.Name = "xingbieTextBox";
            xingbieTextBox.ReadOnly = true;
            xingbieTextBox.Size = new Size(66, 27);
            xingbieTextBox.TabIndex = 103;
            xingbieTextBox.TextChanged += xingbieTextBox_TextChanged;
            // 
            // 性别
            // 
            性别.Anchor = AnchorStyles.Right;
            性别.AutoSize = true;
            性别.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            性别.Location = new Point(683, 16);
            性别.Name = "性别";
            性别.Size = new Size(52, 27);
            性别.TabIndex = 101;
            性别.Text = "性别";
            性别.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // xingmingTextBox
            // 
            xingmingTextBox.Anchor = AnchorStyles.Top;
            xingmingTextBox.Location = new Point(312, 16);
            xingmingTextBox.Name = "xingmingTextBox";
            xingmingTextBox.ReadOnly = true;
            xingmingTextBox.Size = new Size(365, 27);
            xingmingTextBox.TabIndex = 100;
            xingmingTextBox.TextChanged += xingmingTextBox_TextChanged;
            // 
            // 学号
            // 
            学号.Anchor = AnchorStyles.Left;
            学号.AutoSize = true;
            学号.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            学号.Location = new Point(7, 16);
            学号.Name = "学号";
            学号.Size = new Size(52, 27);
            学号.TabIndex = 96;
            学号.Text = "学号";
            学号.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(254, 16);
            label2.Name = "label2";
            label2.Size = new Size(52, 27);
            label2.TabIndex = 98;
            label2.Text = "姓名";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // xuehaoTextBox
            // 
            xuehaoTextBox.Anchor = AnchorStyles.Left;
            xuehaoTextBox.Location = new Point(65, 16);
            xuehaoTextBox.Name = "xuehaoTextBox";
            xuehaoTextBox.ReadOnly = true;
            xuehaoTextBox.Size = new Size(172, 27);
            xuehaoTextBox.TabIndex = 97;
            xuehaoTextBox.TextChanged += xuehaoTextBox_TextChanged;
            // 
            // Personal_Information
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 541);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Personal_Information";
            Text = "Personal_Information";
            Load += Personal_Information_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private TextBox xingbieTextBox;
        private Label 性别;
        private TextBox xingmingTextBox;
        private Label label2;
        private TextBox xuehaoTextBox;
        private Label 学号;
        private Panel panel3;
        private TextBox xueyuanTextBox;
        private Label 学院;
        private TextBox nianjiTextBox;
        private Label 年级;
        private TextBox dianhuaTextBox;
        private Label 联系电话;
        private TextBox youxiangTextBox;
        private Label 邮箱;
        private TextBox banbieTextBox;
        private Label 班别;
        private TextBox zhuanyeTextBox;
        private Label 专业;
        private Panel panel4;
        private Button 联系管理员;
        private Button 提交;
    }
}