using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;

namespace student
{
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();

            // 将事件处理程序附加到 SelectionChanged 事件
        }
        string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";
        private void Team_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadTeamMembers(); // 在加载窗体时同时加载队伍成员
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                // 查询显示
                string connStuTeam = "SELECT s_uid,s_name FROM [6_2_S] WHERE s_uid = @s_uid ";
                using (SqlCommand cmd = new SqlCommand(connStuTeam, conn))
                {
                    cmd.Parameters.AddWithValue("@s_uid", UserHelper.UserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name.Text = reader["s_name"].ToString();
                            stunu.Text = reader["s_uid"].ToString();
                        }
                    }

                }

                string connStuTeamAll = "SELECT s_uid,s_name FROM [6_2_S]";

                using (SqlCommand cmd = new SqlCommand(connStuTeamAll, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;
                }
            }

        }
        private void LoadTeamMembers()
        {
            // 连接数据库
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // 查询队伍成员
                string query = "SELECT s_uid, s_name FROM [6_2_StuTeam] WHERE LeaderUid = @LeaderUid";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LeaderUid", UserHelper.UserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 添加队伍成员到 dataGridView1
                            dataGridView1.Rows.Add(reader["s_uid"].ToString(), reader["s_name"].ToString());
                        }
                    }
                }
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void 查询_Click(object sender, EventArgs e)
        {
            // 获取 TextBox 中的输入内容
            string s_name = textBox1.Text.Trim();
            string s_uid = textBox2.Text.Trim();

            // 进行数据库查询
            DataTable resultDataTable = PerformDatabaseSearch(s_uid);


            // 将保存的选中行列表作为数据源设置给 dataGridView2
            dataGridView2.DataSource = resultDataTable;


        }
        private DataTable PerformDatabaseSearch(string searchText)
        {
            DataTable resultDataTable = new DataTable();

            try
            {
                string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // 使用参数化查询构造 SQL 语句
                    string selectQuery = "SELECT s_uid,s_name FROM [6_2_S] WHERE s_uid = @s_uid OR s_name = @s_name";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        // 添加参数
                        cmd.Parameters.AddWithValue("@s_name", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@s_uid", textBox2.Text.Trim());

                        // 使用 SqlDataAdapter 填充 DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(resultDataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 处理异常，例如记录日志或显示错误消息
                MessageBox.Show($"发生错误：{ex.Message}", "错误");
            }

            return resultDataTable;
        }
        private void 提交_Click(object sender, EventArgs e)
        {
            // 检查 dataGridView1 中是否有数据
            if (dataGridView1.Rows.Count > 0)
            {
                // 连接数据库
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    bool exist = false;

                    // 获取最大的 teamnum
                    int maxTeamNum = GetMaxTeamNum(conn);

                    // 遍历 dataGridView1 中的每一行
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // 从每一行中获取数据
                        object s_uidObject = row.Cells["s_uid"].Value;
                        object s_nameObject = row.Cells["s_name"].Value;

                        if (s_uidObject != null && s_nameObject != null)
                        {
                            string s_uid = s_uidObject.ToString();
                            string s_name = s_nameObject.ToString();
                            string P_name = textBox3.Text.ToString();
                            string P_brief = textBox4.Text.ToString();
                            string LeaderName = name.Text.ToString();
                            string LeaderUid = stunu.Text.ToString();


                            // 构造查询是否存在的 SQL 语句
                            string checkExistStuTeam = "SELECT COUNT(*) FROM [6_2_StuTeam] WHERE s_uid = @s_uid OR s_name = @s_name";

                            // 使用 SqlCommand 执行查询
                            using (SqlCommand checkExistCmd = new SqlCommand(checkExistStuTeam, conn))
                            {
                                // 添加参数
                                checkExistCmd.Parameters.AddWithValue("@s_uid", s_uid);
                                checkExistCmd.Parameters.AddWithValue("@s_name", s_name);

                                // 执行查询
                                int count = Convert.ToInt32(checkExistCmd.ExecuteScalar());

                                // 判断是否存在记录
                                if (count == 0)
                                {
                                    // 构造插入数据的 SQL 语句
                                    string insertStuTeam = "INSERT INTO [6_2_StuTeam] (s_uid, s_name, P_name, P_brief, LeaderName, LeaderUid, teamnum ) VALUES (@s_uid, @s_name, @P_name, @P_brief, @LeaderName, @LeaderUid, @teamnum)";

                                    // 使用 SqlCommand 执行插入操作
                                    using (SqlCommand insertCmd = new SqlCommand(insertStuTeam, conn))
                                    {
                                        // 添加参数
                                        insertCmd.Parameters.AddWithValue("@s_uid", s_uid);
                                        insertCmd.Parameters.AddWithValue("@s_name", s_name);
                                        insertCmd.Parameters.AddWithValue("@P_name", P_name);
                                        insertCmd.Parameters.AddWithValue("@P_brief", P_brief);
                                        insertCmd.Parameters.AddWithValue("@LeaderName", LeaderName);
                                        insertCmd.Parameters.AddWithValue("@LeaderUid", LeaderUid);
                                        insertCmd.Parameters.AddWithValue("@teamnum", maxTeamNum + 1); // 自增

                                        // 执行插入操作
                                        insertCmd.ExecuteNonQuery();
                                    }
                                    
                                }
                                else
                                {
                                    exist = true;
                                }
                            }
                        }
                    }
                    if (exist)
                    {
                        MessageBox.Show("队中已有成员已组队，组队失败", "失败");
                    }
                    else
                    {
                        MessageBox.Show("已自动成为组长！\n提交队伍成功！", "成功");
                        提交.Text = "编辑队伍";

                    }
                }
            }
            else
            {
                MessageBox.Show("未选择队员！", "提示");
            }
        }
        // 获取 teamnum 的最大值
        private int GetMaxTeamNum(SqlConnection conn)
        {
            string query = "SELECT MAX(teamnum) FROM [6_2_StuTeam]";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    // 处理结果为空的情况，例如返回默认值
                    return 0;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 检查点击的是否是第三列，并且确保点击的是单元格而不是列标题
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                // 获取要移除的行
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // 从 dataGridView1 移除该行
                dataGridView1.Rows.Remove(selectedRow);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void move_Click(object sender, EventArgs e)
        {
            // 获取 dataGridView2 中所有选中的行
            DataGridViewSelectedRowCollection selectedRows = dataGridView2.SelectedRows;

            // 检查是否有选中的行
            if (selectedRows.Count > 0)
            {
                // 遍历选中的行
                foreach (DataGridViewRow row in selectedRows)
                {
                    // 获取选中行的 uid 值
                    object selectedUidObject = row.Cells["s_uid"].Value;

                    // 检查 uid 值是否为 null
                    if (selectedUidObject != null)
                    {
                        string selectedUid = selectedUidObject.ToString();

                        // 检查 dataGridView1 中是否已存在相同 uid 的行
                        bool alreadyExists = false;
                        foreach (DataGridViewRow existingRow in dataGridView1.Rows)
                        {
                            // 获取现有行的 uid 值
                            object existingUidObject = existingRow.Cells["s_uid"].Value;

                            // 检查现有 uid 值是否为 null
                            if (existingUidObject != null)
                            {
                                string existingUid = existingUidObject.ToString();

                                if (existingUid == selectedUid)
                                {
                                    alreadyExists = true;
                                    MessageBox.Show("已有该组员!");
                                    break;
                                }
                            }
                        }

                        // 如果不存在相同 uid 的行，则将选中行添加到 dataGridView1
                        if (!alreadyExists)
                        {
                            DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                newRow.Cells[cell.ColumnIndex].Value = cell.Value;
                            }
                            dataGridView1.Rows.Add(newRow);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要添加的行！", "提示");
            }
        }

        //解散队伍
        private void 修改_Click(object sender, EventArgs e)
        {
            // 连接数据库
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // 构造删除队伍的 SQL 语句
                string deleteStuTeam = "DELETE FROM [6_2_StuTeam] WHERE LeaderUid = @LeaderUid";

                // 使用 SqlCommand 执行删除操作
                using (SqlCommand deleteCmd = new SqlCommand(deleteStuTeam, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@LeaderUid", UserHelper.UserId);

                    // 执行删除操作
                    deleteCmd.ExecuteNonQuery();
                }
            }

            // 在编辑队伍时调用加载队伍成员的方法
            LoadTeamMembers();

            MessageBox.Show("队伍已从数据库中删除，并重新加载队伍成员！", "提示");
        }
        
    }
}
