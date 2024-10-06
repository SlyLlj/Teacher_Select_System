namespace student
{
    partial class Stu_Volunteer
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            研究方向 = new Label();
            导师姓名 = new Label();
            panel3 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox5 = new TextBox();
            第三志愿 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            第二志愿 = new Label();
            第一志愿 = new Label();
            panel4 = new Panel();
            删除志愿 = new Button();
            提交志愿 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 559);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(418, 559);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(研究方向);
            panel2.Controls.Add(导师姓名);
            panel2.Location = new Point(473, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(511, 224);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 50);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(394, 151);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 4;
            // 
            // 研究方向
            // 
            研究方向.AutoSize = true;
            研究方向.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            研究方向.Location = new Point(13, 50);
            研究方向.Name = "研究方向";
            研究方向.Size = new Size(82, 24);
            研究方向.TabIndex = 3;
            研究方向.Text = "个人简介";
            研究方向.Click += 研究方向_Click;
            // 
            // 导师姓名
            // 
            导师姓名.AutoSize = true;
            导师姓名.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            导师姓名.Location = new Point(13, 11);
            导师姓名.Name = "导师姓名";
            导师姓名.Size = new Size(82, 24);
            导师姓名.TabIndex = 2;
            导师姓名.Text = "导师姓名";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Controls.Add(radioButton3);
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton1);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(第三志愿);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(第二志愿);
            panel3.Controls.Add(第一志愿);
            panel3.Location = new Point(574, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 169);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(328, 121);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(17, 16);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(328, 76);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(17, 16);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(328, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(101, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 7;
            // 
            // 第三志愿
            // 
            第三志愿.AutoSize = true;
            第三志愿.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            第三志愿.Location = new Point(13, 116);
            第三志愿.Name = "第三志愿";
            第三志愿.Size = new Size(82, 24);
            第三志愿.TabIndex = 6;
            第三志愿.Text = "第三志愿";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(101, 71);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 27);
            textBox4.TabIndex = 4;
            // 
            // 第二志愿
            // 
            第二志愿.AutoSize = true;
            第二志愿.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            第二志愿.Location = new Point(13, 71);
            第二志愿.Name = "第二志愿";
            第二志愿.Size = new Size(82, 24);
            第二志愿.TabIndex = 3;
            第二志愿.Text = "第二志愿";
            // 
            // 第一志愿
            // 
            第一志愿.AutoSize = true;
            第一志愿.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            第一志愿.Location = new Point(13, 26);
            第一志愿.Name = "第一志愿";
            第一志愿.Size = new Size(82, 24);
            第一志愿.TabIndex = 2;
            第一志愿.Text = "第一志愿";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.Controls.Add(删除志愿);
            panel4.Controls.Add(提交志愿);
            panel4.Location = new Point(653, 480);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 45);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // 删除志愿
            // 
            删除志愿.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            删除志愿.BackColor = SystemColors.ActiveCaption;
            删除志愿.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            删除志愿.ForeColor = SystemColors.Control;
            删除志愿.Location = new Point(193, 3);
            删除志愿.Name = "删除志愿";
            删除志愿.Size = new Size(109, 38);
            删除志愿.TabIndex = 117;
            删除志愿.Text = "删除志愿";
            删除志愿.UseVisualStyleBackColor = false;
            删除志愿.Click += 删除志愿_Click;
            // 
            // 提交志愿
            // 
            提交志愿.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            提交志愿.BackColor = SystemColors.ActiveCaption;
            提交志愿.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            提交志愿.ForeColor = SystemColors.Control;
            提交志愿.Location = new Point(29, 3);
            提交志愿.Name = "提交志愿";
            提交志愿.Size = new Size(109, 38);
            提交志愿.TabIndex = 116;
            提交志愿.Text = "提交志愿";
            提交志愿.UseVisualStyleBackColor = false;
            提交志愿.Click += 提交志愿_Click;
            // 
            // Stu_Volunteer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 559);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stu_Volunteer";
            RightToLeftLayout = true;
            Text = "Stu_Volunteer";
            Load += Stu_Volunteer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label 导师姓名;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label 研究方向;
        private Panel panel3;
        private TextBox textBox4;
        private Label 第二志愿;
        private Label 第一志愿;
        private TextBox textBox5;
        private Label 第三志愿;
        private TextBox textBox3;
        private Panel panel4;
        private Button 删除志愿;
        private Button 提交志愿;
        private DataGridView dataGridView1;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
    }
}