namespace teacher
{
    partial class result
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
            dataGridView2 = new DataGridView();
            成员 = new Label();
            dataGridView3 = new DataGridView();
            指导的队伍 = new Label();
            添加 = new Button();
            队伍详情 = new GroupBox();
            textBox2 = new TextBox();
            项目简介 = new Label();
            textBox1 = new TextBox();
            项目名称 = new Label();
            工号 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            队伍详情.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(210, 190);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(647, 236);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // 成员
            // 
            成员.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            成员.AutoSize = true;
            成员.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            成员.Location = new Point(210, 494);
            成员.Name = "成员";
            成员.Size = new Size(59, 30);
            成员.TabIndex = 9;
            成员.Text = "成员";
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.Location = new Point(210, 538);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(647, 218);
            dataGridView3.TabIndex = 8;
            // 
            // 指导的队伍
            // 
            指导的队伍.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            指导的队伍.AutoSize = true;
            指导的队伍.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            指导的队伍.Location = new Point(210, 148);
            指导的队伍.Name = "指导的队伍";
            指导的队伍.Size = new Size(151, 30);
            指导的队伍.TabIndex = 10;
            指导的队伍.Text = "您指导的队伍";
            // 
            // 添加
            // 
            添加.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            添加.BackColor = SystemColors.ActiveCaption;
            添加.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            添加.ForeColor = SystemColors.Control;
            添加.Location = new Point(266, 1282);
            添加.Name = "添加";
            添加.Size = new Size(509, 48);
            添加.TabIndex = 122;
            添加.Text = "添加";
            添加.UseVisualStyleBackColor = false;
            // 
            // 队伍详情
            // 
            队伍详情.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            队伍详情.Controls.Add(添加);
            队伍详情.Controls.Add(textBox2);
            队伍详情.Controls.Add(项目简介);
            队伍详情.Controls.Add(textBox1);
            队伍详情.Controls.Add(项目名称);
            队伍详情.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            队伍详情.Location = new Point(931, 190);
            队伍详情.Name = "队伍详情";
            队伍详情.Size = new Size(612, 588);
            队伍详情.TabIndex = 6;
            队伍详情.TabStop = false;
            队伍详情.Text = "队伍详情";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(68, 337);
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
            项目简介.Location = new Point(68, 304);
            项目简介.Name = "项目简介";
            项目简介.Size = new Size(105, 30);
            项目简介.TabIndex = 6;
            项目简介.Text = "项目简介";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(68, 118);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(484, 88);
            textBox1.TabIndex = 5;
            // 
            // 项目名称
            // 
            项目名称.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            项目名称.AutoSize = true;
            项目名称.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            项目名称.Location = new Point(68, 69);
            项目名称.Name = "项目名称";
            项目名称.Size = new Size(105, 30);
            项目名称.TabIndex = 4;
            项目名称.Text = "项目名称";
            // 
            // 工号
            // 
            工号.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            工号.AutoSize = true;
            工号.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            工号.Location = new Point(463, 73);
            工号.Name = "工号";
            工号.Size = new Size(82, 30);
            工号.TabIndex = 13;
            工号.Text = "工号：";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(530, 73);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 14;
            label1.Text = "teachnu";
            // 
            // result
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1720, 864);
            Controls.Add(label1);
            Controls.Add(工号);
            Controls.Add(指导的队伍);
            Controls.Add(队伍详情);
            Controls.Add(成员);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "result";
            Text = "result";
            Load += result_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            队伍详情.ResumeLayout(false);
            队伍详情.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private Label 成员;
        private DataGridView dataGridView3;
        private Label 指导的队伍;
        private Button 添加;
        private GroupBox 队伍详情;
        private TextBox textBox2;
        private Label 项目简介;
        private TextBox textBox1;
        private Label 项目名称;
        private Label 工号;
        private Label label1;
    }
}