namespace teacher
{
    partial class Tea_Volunteer
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            你的志愿 = new Label();
            队伍信息 = new Label();
            项目名称 = new Label();
            队伍详情 = new GroupBox();
            添加 = new Button();
            成员 = new Label();
            dataGridView3 = new DataGridView();
            textBox2 = new TextBox();
            项目简介 = new Label();
            textBox1 = new TextBox();
            提交 = new Button();
            修改 = new Button();
            teamnum = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            队伍详情.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 585);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { teamnum, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column7 });
            dataGridView2.Location = new Point(68, 663);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RightToLeft = RightToLeft.No;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(800, 236);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // 你的志愿
            // 
            你的志愿.AutoSize = true;
            你的志愿.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            你的志愿.Location = new Point(68, 630);
            你的志愿.Name = "你的志愿";
            你的志愿.Size = new Size(105, 30);
            你的志愿.TabIndex = 2;
            你的志愿.Text = "你的志愿";
            // 
            // 队伍信息
            // 
            队伍信息.AutoSize = true;
            队伍信息.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            队伍信息.Location = new Point(68, 9);
            队伍信息.Name = "队伍信息";
            队伍信息.Size = new Size(105, 30);
            队伍信息.TabIndex = 3;
            队伍信息.Text = "队伍信息";
            // 
            // 项目名称
            // 
            项目名称.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            项目名称.AutoSize = true;
            项目名称.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            项目名称.Location = new Point(68, 63);
            项目名称.Name = "项目名称";
            项目名称.Size = new Size(105, 30);
            项目名称.TabIndex = 4;
            项目名称.Text = "项目名称";
            // 
            // 队伍详情
            // 
            队伍详情.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            队伍详情.Controls.Add(添加);
            队伍详情.Controls.Add(成员);
            队伍详情.Controls.Add(dataGridView3);
            队伍详情.Controls.Add(textBox2);
            队伍详情.Controls.Add(项目简介);
            队伍详情.Controls.Add(textBox1);
            队伍详情.Controls.Add(项目名称);
            队伍详情.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            队伍详情.Location = new Point(959, 42);
            队伍详情.Name = "队伍详情";
            队伍详情.Size = new Size(615, 857);
            队伍详情.TabIndex = 5;
            队伍详情.TabStop = false;
            队伍详情.Text = "队伍详情";
            // 
            // 添加
            // 
            添加.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            添加.BackColor = SystemColors.ActiveCaption;
            添加.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            添加.ForeColor = SystemColors.Control;
            添加.Location = new Point(266, 794);
            添加.Name = "添加";
            添加.Size = new Size(97, 48);
            添加.TabIndex = 122;
            添加.Text = "添加";
            添加.UseVisualStyleBackColor = false;
            添加.Click += 添加_Click;
            // 
            // 成员
            // 
            成员.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            成员.AutoSize = true;
            成员.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            成员.Location = new Point(68, 518);
            成员.Name = "成员";
            成员.Size = new Size(59, 30);
            成员.TabIndex = 9;
            成员.Text = "成员";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(68, 560);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(484, 218);
            dataGridView3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(68, 286);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(484, 206);
            textBox2.TabIndex = 7;
            // 
            // 项目简介
            // 
            项目简介.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            项目简介.AutoSize = true;
            项目简介.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            项目简介.Location = new Point(68, 243);
            项目简介.Name = "项目简介";
            项目简介.Size = new Size(105, 30);
            项目简介.TabIndex = 6;
            项目简介.Text = "项目简介";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(68, 106);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(484, 88);
            textBox1.TabIndex = 5;
            // 
            // 提交
            // 
            提交.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            提交.BackColor = SystemColors.ActiveCaption;
            提交.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            提交.ForeColor = SystemColors.Control;
            提交.Location = new Point(1597, 321);
            提交.Name = "提交";
            提交.Size = new Size(117, 48);
            提交.TabIndex = 123;
            提交.Text = "提交";
            提交.UseVisualStyleBackColor = false;
            提交.Click += 提交_Click;
            // 
            // 修改
            // 
            修改.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            修改.BackColor = SystemColors.ActiveCaption;
            修改.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            修改.ForeColor = SystemColors.Control;
            修改.Location = new Point(1597, 486);
            修改.Name = "修改";
            修改.Size = new Size(117, 48);
            修改.TabIndex = 124;
            修改.Text = "修改";
            修改.UseVisualStyleBackColor = false;
            // 
            // teamnum
            // 
            teamnum.HeaderText = "teamnum";
            teamnum.MinimumWidth = 6;
            teamnum.Name = "teamnum";
            teamnum.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "P_name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "P_brief";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "移除";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Tea_Volunteer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1738, 911);
            Controls.Add(修改);
            Controls.Add(提交);
            Controls.Add(队伍详情);
            Controls.Add(队伍信息);
            Controls.Add(你的志愿);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tea_Volunteer";
            Text = "Tea_Volunteer";
            Load += Tea_Volunteer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            队伍详情.ResumeLayout(false);
            队伍详情.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label 你的志愿;
        private Label 队伍信息;
        private Label 项目名称;
        private GroupBox 队伍详情;
        private Label 成员;
        private DataGridView dataGridView3;
        private TextBox textBox2;
        private Label 项目简介;
        private TextBox textBox1;
        private Button 添加;
        private Button 提交;
        private Button 修改;
        private DataGridViewButtonColumn Column7;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn teamnum;
    }
}