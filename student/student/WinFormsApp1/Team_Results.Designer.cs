namespace student
{
    partial class Team_Results
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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            项目简介 = new Label();
            项目名称 = new Label();
            小组成员 = new Label();
            dataGridView1 = new DataGridView();
            stunu = new Label();
            组长学号 = new Label();
            name = new Label();
            组长姓名 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(项目简介);
            panel1.Controls.Add(项目名称);
            panel1.Controls.Add(小组成员);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(stunu);
            panel1.Controls.Add(组长学号);
            panel1.Controls.Add(name);
            panel1.Controls.Add(组长姓名);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 494);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(163, 145);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(506, 91);
            textBox4.TabIndex = 36;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(163, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(506, 27);
            textBox3.TabIndex = 35;
            // 
            // 项目简介
            // 
            项目简介.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            项目简介.AutoSize = true;
            项目简介.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            项目简介.Location = new Point(45, 143);
            项目简介.Name = "项目简介";
            项目简介.Size = new Size(112, 27);
            项目简介.TabIndex = 34;
            项目简介.Text = "项目简介：";
            // 
            // 项目名称
            // 
            项目名称.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            项目名称.AutoSize = true;
            项目名称.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            项目名称.Location = new Point(45, 92);
            项目名称.Name = "项目名称";
            项目名称.Size = new Size(112, 27);
            项目名称.TabIndex = 33;
            项目名称.Text = "项目名称：";
            // 
            // 小组成员
            // 
            小组成员.AutoSize = true;
            小组成员.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            小组成员.Location = new Point(45, 309);
            小组成员.Name = "小组成员";
            小组成员.Size = new Size(106, 31);
            小组成员.TabIndex = 32;
            小组成员.Text = "小组成员";
            小组成员.Click += 小组成员_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(163, 309);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(506, 151);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // stunu
            // 
            stunu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stunu.AutoSize = true;
            stunu.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stunu.Location = new Point(481, 35);
            stunu.Name = "stunu";
            stunu.Size = new Size(107, 27);
            stunu.TabIndex = 30;
            stunu.Text = "studentnu";
            // 
            // 组长学号
            // 
            组长学号.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            组长学号.AutoSize = true;
            组长学号.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            组长学号.Location = new Point(363, 35);
            组长学号.Name = "组长学号";
            组长学号.Size = new Size(112, 27);
            组长学号.TabIndex = 29;
            组长学号.Text = "组长学号：";
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            name.AutoSize = true;
            name.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(207, 35);
            name.Name = "name";
            name.Size = new Size(65, 27);
            name.TabIndex = 28;
            name.Text = "name";
            name.Click += name_Click;
            // 
            // 组长姓名
            // 
            组长姓名.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            组长姓名.AutoSize = true;
            组长姓名.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            组长姓名.Location = new Point(139, 35);
            组长姓名.Name = "组长姓名";
            组长姓名.Size = new Size(72, 27);
            组长姓名.TabIndex = 27;
            组长姓名.Text = "组长：";
            // 
            // Team_Results
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 494);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Team_Results";
            Text = "Team_Results";
            Load += Team_Results_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label 项目简介;
        private Label 项目名称;
        private Label 小组成员;
        private DataGridView dataGridView1;
        private Label stunu;
        private Label 组长学号;
        private Label name;
        private Label 组长姓名;
    }
}