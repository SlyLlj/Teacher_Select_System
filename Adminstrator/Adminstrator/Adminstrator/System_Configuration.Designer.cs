namespace Adminstrator
{
    partial class System_Configuration
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
            任务时间配置 = new Label();
            年级 = new Label();
            专业 = new Label();
            学生端截止时间 = new Label();
            教师端截止时间 = new Label();
            textBox1 = new TextBox();
            专业选择 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            提交日期 = new Button();
            SuspendLayout();
            // 
            // 任务时间配置
            // 
            任务时间配置.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            任务时间配置.AutoSize = true;
            任务时间配置.Font = new Font("Microsoft YaHei UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            任务时间配置.ForeColor = SystemColors.Highlight;
            任务时间配置.Location = new Point(789, 92);
            任务时间配置.Margin = new Padding(6, 0, 6, 0);
            任务时间配置.Name = "任务时间配置";
            任务时间配置.Size = new Size(289, 58);
            任务时间配置.TabIndex = 0;
            任务时间配置.Text = "任务时间配置";
            // 
            // 年级
            // 
            年级.AutoSize = true;
            年级.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            年级.ForeColor = SystemColors.ActiveCaptionText;
            年级.Location = new Point(659, 226);
            年级.Name = "年级";
            年级.Size = new Size(107, 39);
            年级.TabIndex = 1;
            年级.Text = "年级：";
            // 
            // 专业
            // 
            专业.AutoSize = true;
            专业.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            专业.ForeColor = SystemColors.ActiveCaptionText;
            专业.Location = new Point(659, 362);
            专业.Name = "专业";
            专业.Size = new Size(107, 39);
            专业.TabIndex = 2;
            专业.Text = "专业：";
            // 
            // 学生端截止时间
            // 
            学生端截止时间.AutoSize = true;
            学生端截止时间.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            学生端截止时间.ForeColor = SystemColors.ActiveCaptionText;
            学生端截止时间.Location = new Point(509, 503);
            学生端截止时间.Name = "学生端截止时间";
            学生端截止时间.Size = new Size(257, 39);
            学生端截止时间.TabIndex = 3;
            学生端截止时间.Text = "学生端截止时间：";
            // 
            // 教师端截止时间
            // 
            教师端截止时间.AutoSize = true;
            教师端截止时间.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            教师端截止时间.ForeColor = SystemColors.ActiveCaptionText;
            教师端截止时间.Location = new Point(509, 655);
            教师端截止时间.Name = "教师端截止时间";
            教师端截止时间.Size = new Size(257, 39);
            教师端截止时间.TabIndex = 4;
            教师端截止时间.Text = "教师端截止时间：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(762, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 46);
            textBox1.TabIndex = 5;
            // 
            // 专业选择
            // 
            专业选择.FormattingEnabled = true;
            专业选择.Items.AddRange(new object[] { "信息管理与信息系统", "信息资源管理", "生物医学工程", "智能医学工程", "数据科学与大数据技术" });
            专业选择.Location = new Point(762, 358);
            专业选择.Name = "专业选择";
            专业选择.Size = new Size(382, 48);
            专业选择.TabIndex = 6;
            专业选择.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(762, 497);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(382, 46);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(762, 648);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(382, 46);
            dateTimePicker2.TabIndex = 9;
            // 
            // 提交日期
            // 
            提交日期.BackColor = SystemColors.ActiveCaption;
            提交日期.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            提交日期.ForeColor = SystemColors.Control;
            提交日期.Location = new Point(875, 790);
            提交日期.Name = "提交日期";
            提交日期.Size = new Size(132, 73);
            提交日期.TabIndex = 20;
            提交日期.Text = "提交日期";
            提交日期.UseVisualStyleBackColor = false;
            提交日期.Click += 提交日期_Click;
            // 
            // System_Configuration
            // 
            AcceptButton = 提交日期;
            AutoScaleDimensions = new SizeF(19F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1924, 1055);
            Controls.Add(提交日期);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(专业选择);
            Controls.Add(textBox1);
            Controls.Add(教师端截止时间);
            Controls.Add(学生端截止时间);
            Controls.Add(专业);
            Controls.Add(年级);
            Controls.Add(任务时间配置);
            Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "System_Configuration";
            Text = "System_Configuration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label 任务时间配置;
        private Label 年级;
        private Label 专业;
        private Label 学生端截止时间;
        private Label 教师端截止时间;
        private TextBox textBox1;
        private ComboBox 专业选择;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button 提交日期;
    }
}