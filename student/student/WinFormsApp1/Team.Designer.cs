namespace student
{
    partial class Team
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            组长姓名 = new Label();
            name = new Label();
            组长学号 = new Label();
            stunu = new Label();
            查询条件 = new GroupBox();
            查询 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            学号 = new Label();
            姓名 = new Label();
            dataGridView1 = new DataGridView();
            s_uid = new DataGridViewTextBoxColumn();
            s_name = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            项目名称 = new Label();
            项目简介 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            提交 = new Button();
            修改 = new Button();
            panel = new Panel();
            move = new Button();
            dataGridView2 = new DataGridView();
            查询条件.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // 组长姓名
            // 
            组长姓名.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            组长姓名.AutoSize = true;
            组长姓名.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            组长姓名.Location = new Point(64, 26);
            组长姓名.Name = "组长姓名";
            组长姓名.Size = new Size(72, 27);
            组长姓名.TabIndex = 12;
            组长姓名.Text = "组长：";
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name.AutoSize = true;
            name.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(132, 26);
            name.Name = "name";
            name.Size = new Size(65, 27);
            name.TabIndex = 13;
            name.Text = "name";
            name.Click += name_Click;
            // 
            // 组长学号
            // 
            组长学号.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            组长学号.AutoSize = true;
            组长学号.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            组长学号.Location = new Point(288, 26);
            组长学号.Name = "组长学号";
            组长学号.Size = new Size(112, 27);
            组长学号.TabIndex = 14;
            组长学号.Text = "组长学号：";
            // 
            // stunu
            // 
            stunu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            stunu.AutoSize = true;
            stunu.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stunu.Location = new Point(406, 26);
            stunu.Name = "stunu";
            stunu.Size = new Size(107, 27);
            stunu.TabIndex = 15;
            stunu.Text = "studentnu";
            // 
            // 查询条件
            // 
            查询条件.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            查询条件.Controls.Add(查询);
            查询条件.Controls.Add(textBox2);
            查询条件.Controls.Add(textBox1);
            查询条件.Controls.Add(学号);
            查询条件.Controls.Add(姓名);
            查询条件.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            查询条件.Location = new Point(54, 69);
            查询条件.Name = "查询条件";
            查询条件.Size = new Size(908, 96);
            查询条件.TabIndex = 16;
            查询条件.TabStop = false;
            查询条件.Text = "查询条件";
            // 
            // 查询
            // 
            查询.Anchor = AnchorStyles.Left;
            查询.BackColor = SystemColors.ActiveCaption;
            查询.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            查询.ForeColor = SystemColors.Control;
            查询.Location = new Point(470, 33);
            查询.Name = "查询";
            查询.Size = new Size(88, 30);
            查询.TabIndex = 4;
            查询.Text = "查询";
            查询.UseVisualStyleBackColor = false;
            查询.Click += 查询_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Location = new Point(294, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(78, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 2;
            // 
            // 学号
            // 
            学号.Anchor = AnchorStyles.Left;
            学号.AutoSize = true;
            学号.Location = new Point(234, 36);
            学号.Name = "学号";
            学号.Size = new Size(64, 24);
            学号.TabIndex = 1;
            学号.Text = "学号：";
            // 
            // 姓名
            // 
            姓名.Anchor = AnchorStyles.Left;
            姓名.AutoSize = true;
            姓名.Location = new Point(21, 36);
            姓名.Name = "姓名";
            姓名.Size = new Size(64, 24);
            姓名.TabIndex = 0;
            姓名.Text = "姓名：";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { s_uid, s_name, Column7 });
            dataGridView1.Location = new Point(54, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(400, 151);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // s_uid
            // 
            s_uid.Frozen = true;
            s_uid.HeaderText = "uid";
            s_uid.MinimumWidth = 6;
            s_uid.Name = "s_uid";
            s_uid.ReadOnly = true;
            s_uid.Width = 125;
            // 
            // s_name
            // 
            s_name.Frozen = true;
            s_name.HeaderText = "name";
            s_name.MinimumWidth = 6;
            s_name.Name = "s_name";
            s_name.ReadOnly = true;
            s_name.Width = 125;
            // 
            // Column7
            // 
            Column7.Frozen = true;
            Column7.HeaderText = "移除";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Resizable = DataGridViewTriState.True;
            Column7.Text = "移除";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 125;
            // 
            // 项目名称
            // 
            项目名称.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            项目名称.AutoSize = true;
            项目名称.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            项目名称.Location = new Point(54, 350);
            项目名称.Name = "项目名称";
            项目名称.Size = new Size(112, 27);
            项目名称.TabIndex = 18;
            项目名称.Text = "项目名称：";
            // 
            // 项目简介
            // 
            项目简介.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            项目简介.AutoSize = true;
            项目简介.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            项目简介.Location = new Point(54, 401);
            项目简介.Name = "项目简介";
            项目简介.Size = new Size(112, 27);
            项目简介.TabIndex = 19;
            项目简介.Text = "项目简介：";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(172, 350);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(662, 27);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(172, 403);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(662, 111);
            textBox4.TabIndex = 21;
            // 
            // 提交
            // 
            提交.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            提交.BackColor = SystemColors.ActiveCaption;
            提交.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            提交.ForeColor = SystemColors.Control;
            提交.Location = new Point(857, 403);
            提交.Name = "提交";
            提交.Size = new Size(105, 50);
            提交.TabIndex = 22;
            提交.Text = "提交队伍";
            提交.UseVisualStyleBackColor = false;
            提交.Click += 提交_Click;
            // 
            // 修改
            // 
            修改.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            修改.BackColor = SystemColors.ActiveCaption;
            修改.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            修改.ForeColor = SystemColors.Control;
            修改.Location = new Point(857, 464);
            修改.Name = "修改";
            修改.Size = new Size(105, 50);
            修改.TabIndex = 23;
            修改.Text = "解散队伍";
            修改.UseVisualStyleBackColor = false;
            修改.Click += 修改_Click;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.Controls.Add(move);
            panel.Controls.Add(dataGridView2);
            panel.Controls.Add(修改);
            panel.Controls.Add(提交);
            panel.Controls.Add(textBox4);
            panel.Controls.Add(textBox3);
            panel.Controls.Add(项目简介);
            panel.Controls.Add(项目名称);
            panel.Controls.Add(dataGridView1);
            panel.Controls.Add(查询条件);
            panel.Controls.Add(stunu);
            panel.Controls.Add(组长学号);
            panel.Controls.Add(name);
            panel.Controls.Add(组长姓名);
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(1016, 541);
            panel.TabIndex = 0;
            panel.Paint += panel_Paint;
            // 
            // move
            // 
            move.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            move.BackColor = SystemColors.ActiveCaption;
            move.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            move.ForeColor = SystemColors.Control;
            move.Location = new Point(460, 244);
            move.Name = "move";
            move.Size = new Size(96, 40);
            move.TabIndex = 25;
            move.Text = "添加";
            move.UseVisualStyleBackColor = false;
            move.Click += move_Click;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle2.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ImeMode = ImeMode.NoControl;
            dataGridView2.Location = new Point(562, 184);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(400, 151);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Team
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 541);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Team";
            Text = "Team";
            Load += Team_Load;
            查询条件.ResumeLayout(false);
            查询条件.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label 组长姓名;
        private Label name;
        private Label 组长学号;
        private Label stunu;
        private GroupBox 查询条件;
        private Button 查询;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label 学号;
        private Label 姓名;
        private DataGridView dataGridView1;
        private Label 项目名称;
        private Label 项目简介;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button 提交;
        private Button 修改;
        private Panel panel;
        private DataGridView dataGridView2;
        private Button move;
        private DataGridViewTextBoxColumn s_uid;
        private DataGridViewTextBoxColumn s_name;
        private DataGridViewButtonColumn Column7;
    }
}