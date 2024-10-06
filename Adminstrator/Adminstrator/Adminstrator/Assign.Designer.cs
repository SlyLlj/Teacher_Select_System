namespace Adminstrator
{
    partial class Assign
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
            Groups_view = new DataGridView();
            Teachers_view = new DataGridView();
            Pairs_view = new DataGridView();
            过滤 = new Button();
            自动分配 = new Button();
            手动调整 = new Button();
            发布结果 = new Button();
            学生选择 = new Label();
            老师选择 = new Label();
            匹配得分 = new Label();
            ((System.ComponentModel.ISupportInitialize)Groups_view).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Teachers_view).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pairs_view).BeginInit();
            SuspendLayout();
            // 
            // Groups_view
            // 
            Groups_view.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Groups_view.BackgroundColor = SystemColors.GradientInactiveCaption;
            Groups_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Groups_view.Location = new Point(-1, 62);
            Groups_view.Name = "Groups_view";
            Groups_view.RowHeadersVisible = false;
            Groups_view.RowHeadersWidth = 51;
            Groups_view.RowTemplate.Height = 29;
            Groups_view.Size = new Size(671, 390);
            Groups_view.TabIndex = 9;
            Groups_view.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Teachers_view
            // 
            Teachers_view.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Teachers_view.BackgroundColor = SystemColors.GradientInactiveCaption;
            Teachers_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Teachers_view.Location = new Point(-1, 507);
            Teachers_view.Name = "Teachers_view";
            Teachers_view.RowHeadersVisible = false;
            Teachers_view.RowHeadersWidth = 51;
            Teachers_view.RowTemplate.Height = 29;
            Teachers_view.Size = new Size(671, 413);
            Teachers_view.TabIndex = 10;
            // 
            // Pairs_view
            // 
            Pairs_view.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pairs_view.BackgroundColor = SystemColors.GradientInactiveCaption;
            Pairs_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Pairs_view.Location = new Point(676, 62);
            Pairs_view.Name = "Pairs_view";
            Pairs_view.RowHeadersVisible = false;
            Pairs_view.RowHeadersWidth = 51;
            Pairs_view.RowTemplate.Height = 29;
            Pairs_view.Size = new Size(896, 858);
            Pairs_view.TabIndex = 11;
            // 
            // 过滤
            // 
            过滤.Anchor = AnchorStyles.Right;
            过滤.BackColor = SystemColors.ActiveCaption;
            过滤.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            过滤.ForeColor = SystemColors.Control;
            过滤.Location = new Point(1606, 75);
            过滤.Name = "过滤";
            过滤.Size = new Size(118, 65);
            过滤.TabIndex = 16;
            过滤.Text = "过滤";
            过滤.UseVisualStyleBackColor = false;
            过滤.Click += 过滤_Click;
            // 
            // 自动分配
            // 
            自动分配.Anchor = AnchorStyles.Right;
            自动分配.BackColor = SystemColors.ActiveCaption;
            自动分配.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            自动分配.ForeColor = SystemColors.Control;
            自动分配.Location = new Point(1606, 239);
            自动分配.Name = "自动分配";
            自动分配.Size = new Size(118, 65);
            自动分配.TabIndex = 17;
            自动分配.Text = "自动分配";
            自动分配.UseVisualStyleBackColor = false;
            自动分配.Click += 自动分配_Click;
            // 
            // 手动调整
            // 
            手动调整.Anchor = AnchorStyles.Right;
            手动调整.BackColor = SystemColors.ActiveCaption;
            手动调整.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            手动调整.ForeColor = SystemColors.Control;
            手动调整.Location = new Point(1606, 413);
            手动调整.Name = "手动调整";
            手动调整.Size = new Size(118, 65);
            手动调整.TabIndex = 18;
            手动调整.Text = "手动调整";
            手动调整.UseVisualStyleBackColor = false;
            手动调整.Click += 手动调整_Click;
            // 
            // 发布结果
            // 
            发布结果.Anchor = AnchorStyles.Right;
            发布结果.BackColor = SystemColors.ActiveCaption;
            发布结果.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            发布结果.ForeColor = SystemColors.Control;
            发布结果.Location = new Point(1606, 584);
            发布结果.Name = "发布结果";
            发布结果.Size = new Size(118, 65);
            发布结果.TabIndex = 19;
            发布结果.Text = "发布结果";
            发布结果.UseVisualStyleBackColor = false;
            发布结果.Click += 发布结果_Click;
            // 
            // 学生选择
            // 
            学生选择.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            学生选择.AutoSize = true;
            学生选择.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            学生选择.Location = new Point(276, 20);
            学生选择.Name = "学生选择";
            学生选择.Size = new Size(105, 30);
            学生选择.TabIndex = 20;
            学生选择.Text = "学生选择";
            // 
            // 老师选择
            // 
            老师选择.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            老师选择.AutoSize = true;
            老师选择.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            老师选择.Location = new Point(276, 465);
            老师选择.Name = "老师选择";
            老师选择.Size = new Size(105, 30);
            老师选择.TabIndex = 21;
            老师选择.Text = "老师选择";
            // 
            // 匹配得分
            // 
            匹配得分.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            匹配得分.AutoSize = true;
            匹配得分.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            匹配得分.Location = new Point(1068, 20);
            匹配得分.Name = "匹配得分";
            匹配得分.Size = new Size(105, 30);
            匹配得分.TabIndex = 22;
            匹配得分.Text = "匹配得分";
            // 
            // Assign
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1759, 921);
            Controls.Add(匹配得分);
            Controls.Add(老师选择);
            Controls.Add(学生选择);
            Controls.Add(发布结果);
            Controls.Add(手动调整);
            Controls.Add(自动分配);
            Controls.Add(过滤);
            Controls.Add(Pairs_view);
            Controls.Add(Teachers_view);
            Controls.Add(Groups_view);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Assign";
            Text = "Assign";
            Load += Assign_Load;
            ((System.ComponentModel.ISupportInitialize)Groups_view).EndInit();
            ((System.ComponentModel.ISupportInitialize)Teachers_view).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pairs_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView Groups_view;
        private DataGridView Teachers_view;
        private DataGridView Pairs_view;
        private Button 过滤;
        private Button 自动分配;
        private Button 手动调整;
        private Button 发布结果;
        private Label 学生选择;
        private Label 老师选择;
        private Label 匹配得分;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn teamnum;
        private DataGridViewTextBoxColumn vol1;
        private DataGridViewTextBoxColumn vol2;
        private DataGridViewTextBoxColumn vol3;
    }
}