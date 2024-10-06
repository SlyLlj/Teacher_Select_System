namespace Adminstrator
{
    partial class Preview
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
            该教师指导的组 = new Label();
            dataGridView4 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            teamnum = new DataGridViewTextBoxColumn();
            教师 = new Label();
            dataGridView3 = new DataGridView();
            小组成员 = new Label();
            dataGridView1 = new DataGridView();
            学生组 = new Label();
            dataGridView2 = new DataGridView();
            确认发布 = new Button();
            取消 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // 该教师指导的组
            // 
            该教师指导的组.AutoSize = true;
            该教师指导的组.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            该教师指导的组.ForeColor = SystemColors.Highlight;
            该教师指导的组.Location = new Point(54, 660);
            该教师指导的组.Name = "该教师指导的组";
            该教师指导的组.Size = new Size(152, 27);
            该教师指导的组.TabIndex = 25;
            该教师指导的组.Text = "该教师指导的组";
            // 
            // dataGridView4
            // 
            dataGridView4.Anchor = AnchorStyles.Bottom;
            dataGridView4.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { Column4, teamnum });
            dataGridView4.Location = new Point(3, 690);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(274, 205);
            dataGridView4.TabIndex = 24;
            dataGridView4.CellClick += dataGridView4_CellClick;
            // 
            // Column4
            // 
            Column4.HeaderText = "指导老师";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // teamnum
            // 
            teamnum.HeaderText = "teamnum";
            teamnum.MinimumWidth = 6;
            teamnum.Name = "teamnum";
            teamnum.ReadOnly = true;
            teamnum.Width = 125;
            // 
            // 教师
            // 
            教师.AutoSize = true;
            教师.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            教师.ForeColor = SystemColors.Highlight;
            教师.Location = new Point(225, 9);
            教师.Name = "教师";
            教师.Size = new Size(52, 27);
            教师.TabIndex = 23;
            教师.Text = "教师";
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top;
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 39);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(508, 605);
            dataGridView3.TabIndex = 22;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // 小组成员
            // 
            小组成员.AutoSize = true;
            小组成员.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            小组成员.ForeColor = SystemColors.Highlight;
            小组成员.Location = new Point(644, 660);
            小组成员.Name = "小组成员";
            小组成员.Size = new Size(92, 27);
            小组成员.TabIndex = 21;
            小组成员.Text = "小组成员";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(318, 689);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(771, 205);
            dataGridView1.TabIndex = 20;
            // 
            // 学生组
            // 
            学生组.AutoSize = true;
            学生组.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            学生组.ForeColor = SystemColors.Highlight;
            学生组.Location = new Point(763, 9);
            学生组.Name = "学生组";
            学生组.Size = new Size(72, 27);
            学生组.TabIndex = 19;
            学生组.Text = "学生组";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top;
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(550, 39);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(537, 605);
            dataGridView2.TabIndex = 18;
            // 
            // 确认发布
            // 
            确认发布.Anchor = AnchorStyles.None;
            确认发布.BackColor = SystemColors.ActiveCaption;
            确认发布.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            确认发布.ForeColor = SystemColors.Control;
            确认发布.Location = new Point(1132, 122);
            确认发布.Name = "确认发布";
            确认发布.Size = new Size(50, 156);
            确认发布.TabIndex = 26;
            确认发布.Text = "确认发布";
            确认发布.UseVisualStyleBackColor = false;
            确认发布.Click += 确认发布_Click;
            // 
            // 取消
            // 
            取消.Anchor = AnchorStyles.None;
            取消.BackColor = SystemColors.ActiveCaption;
            取消.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            取消.ForeColor = SystemColors.Control;
            取消.Location = new Point(1132, 447);
            取消.Name = "取消";
            取消.Size = new Size(50, 103);
            取消.TabIndex = 27;
            取消.Text = "取消";
            取消.UseVisualStyleBackColor = false;
            // 
            // Preview
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 890);
            Controls.Add(取消);
            Controls.Add(确认发布);
            Controls.Add(该教师指导的组);
            Controls.Add(dataGridView4);
            Controls.Add(教师);
            Controls.Add(dataGridView3);
            Controls.Add(小组成员);
            Controls.Add(dataGridView1);
            Controls.Add(学生组);
            Controls.Add(dataGridView2);
            Name = "Preview";
            Text = "Preview";
            Load += Preview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label 该教师指导的组;
        private DataGridView dataGridView4;
        private Label 教师;
        private DataGridView dataGridView3;
        private Label 小组成员;
        private DataGridView dataGridView1;
        private Label 学生组;
        private DataGridView dataGridView2;
        private Button 确认发布;
        private Button 取消;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn teamnum;
    }
}