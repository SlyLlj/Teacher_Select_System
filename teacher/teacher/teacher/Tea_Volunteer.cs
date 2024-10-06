using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teacher
{
    public partial class Tea_Volunteer : Form
    {
        // 在类的顶部声明连接字符串
        private string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

        public Tea_Volunteer()
        {
            InitializeComponent();
        }

        private void Tea_Volunteer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // 在方法内部使用连接字符串
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string selectQueryTeaIn = "SELECT * FROM [6_2_StuVol]"; // 从数据库中检索数据

                using (SqlCommand cmd = new SqlCommand(selectQueryTeaIn, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }

                string selectQueryStuVol = "SELECT * FROM [6_2_StuVol] WHERE s_uid = @s_uid ";

                // 编写查询语句以检索数据
                using (SqlCommand cmd = new SqlCommand(selectQueryStuVol, conn))
                {
                    // 设置参数
                    cmd.Parameters.AddWithValue("@s_uid", UserHelper.UserId);

                    // 使用SqlDataReader获取查询结果
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 将数据从数据库加载到 textbox 控件中
                            string briefIntroduction = reader["brief_introduction"].ToString();
                            textBox2.Text = briefIntroduction;
                            string teaname = reader["t_name"].ToString();
                            textBox1.Text = teaname;
                        }
                    }
                }

                // 关闭连接
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            // 当用户选择行时显示 brief_introduction 列的内容
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string P_name = dataGridView1.Rows[a].Cells["P_name"].Value.ToString();
                textBox1.Text = P_name;
                string P_brief = dataGridView1.Rows[a].Cells["P_brief"].Value.ToString();
                textBox2.Text = P_brief;
            }
            // 检查是否选中的是有效的单元格
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                // 获取选中行的 teamnum 值
                string selectedTeamNum = dataGridView1.Rows[e.RowIndex].Cells["teamnum"].Value.ToString();

                // 根据 teamnum 值检索表 6_2_StuTeam
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string selectQueryStuTeam = "SELECT * FROM [6_2_StuTeam] WHERE teamnum = @teamnum";

                    using (SqlCommand cmd = new SqlCommand(selectQueryStuTeam, conn))
                    {
                        cmd.Parameters.AddWithValue("@teamnum", selectedTeamNum);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        // 将检索到的数据显示在 dataGridView3 中
                        dataGridView3.DataSource = dataTable;
                    }

                    conn.Close();
                }
            }
        }

        private void 提交_Click(object sender, EventArgs e)
        {
            // 获取当前时间
            DateTime currentTime = DateTime.Now;

            // 查询 teaddl 时间
            DateTime teaddlTime;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string selectQueryTime = "SELECT teaddl FROM [6_2_Time]";

                using (SqlCommand cmd = new SqlCommand(selectQueryTime, conn))
                {
                    teaddlTime = (DateTime)cmd.ExecuteScalar();
                }

                conn.Close();
            }

            // 检查是否超出截止时间
            if (currentTime > teaddlTime)
            {
                MessageBox.Show("已超出截止时间");
                return;
            }

            // 遍历 dataGridView2 中的每一行
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                // 获取 teamnum 的值
                string teamnum = row.Cells["teamnum"].Value?.ToString();

                if (!string.IsNullOrEmpty(teamnum))
                {
                    // 查询 t_uid 是否存在
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();

                        string selectQueryTUid = "SELECT t_uid FROM [6_2_TeaVol] WHERE t_uid = @t_uid";

                        using (SqlCommand cmd = new SqlCommand(selectQueryTUid, conn))
                        {
                            cmd.Parameters.AddWithValue("@t_uid", UserHelper.UserId);

                            // 检查是否存在对应的 t_uid
                            object result = cmd.ExecuteScalar();

                            if (result == null)
                            {
                                // 如果不存在，则新增行
                                string insertQuery = "INSERT INTO [6_2_TeaVol] ( vol1, vol2, vol3, vol4, vol5,t_uid) " +
                                                     "VALUES ( @vol1, @vol2, @vol3, @vol4, @vol5, @t_uid)";

                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("@vol1", teamnum);
                                    insertCmd.Parameters.AddWithValue("@vol2", teamnum);
                                    insertCmd.Parameters.AddWithValue("@vol3", teamnum);
                                    insertCmd.Parameters.AddWithValue("@vol4", teamnum);
                                    insertCmd.Parameters.AddWithValue("@vol5", teamnum);
                                    insertCmd.Parameters.AddWithValue("@t_uid", UserHelper.UserId);

                                    insertCmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // 如果存在，则更新对应的列
                                string updateQuery = "UPDATE [6_2_TeaVol] " +
                                                     "SET vol1 = @vol1, vol2 = @vol2, vol3 = @vol3, vol4 = @vol4, vol5 = @vol5 " +
                                                     "WHERE t_uid = @t_uid";

                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@t_uid", UserHelper.UserId);
                                    updateCmd.Parameters.AddWithValue("@vol1", teamnum);
                                    updateCmd.Parameters.AddWithValue("@vol2", teamnum);
                                    updateCmd.Parameters.AddWithValue("@vol3", teamnum);
                                    updateCmd.Parameters.AddWithValue("@vol4", teamnum);
                                    updateCmd.Parameters.AddWithValue("@vol5", teamnum);

                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                        }

                        conn.Close();
                    }
                }
            }

            MessageBox.Show("提交成功");
        }



        private void 添加_Click(object sender, EventArgs e)
        {
            // Get the index of the selected row in dataGridView1
            int selectedIndex = dataGridView1.CurrentRow.Index;

            // Get values from selected row in dataGridView1
            string teamnum = dataGridView1.Rows[selectedIndex].Cells["teamnum"].Value.ToString();
            string P_name = dataGridView1.Rows[selectedIndex].Cells["P_name"].Value.ToString();
            string P_brief = dataGridView1.Rows[selectedIndex].Cells["P_brief"].Value.ToString();

            // Add values to dataGridView2
            dataGridView2.Rows.Add(teamnum, P_name, P_brief);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the first column
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                // Check if the "teamnum" cell is not null
                if (dataGridView2.Rows[e.RowIndex].Cells["teamnum"].Value != null)
                {
                    // Remove the clicked row from dataGridView2
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

    }
}
