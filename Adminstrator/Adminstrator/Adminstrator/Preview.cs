using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adminstrator
{
    public partial class Preview : Form
    {
        // 将 selectedTUid 定义在类的级别
        private string selectedTUid;

        public Preview()
        {
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            LoadTeaIn();
            LoadpipeidefenData();

        }

        private void LoadTeaIn()
        {
            // 数据库连接字符串
            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            // SQL查询命令
            string queryCommand = "SELECT * FROM [6_2_StuVol_TeaIn]";

            // 创建SqlConnection和SqlCommand
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(queryCommand, connection))
            {
                // 创建DataTable用于存储查询结果
                DataTable dataTable = new DataTable();

                // 打开数据库连接
                connection.Open();

                // 使用SqlDataAdapter填充DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }

                // 将DataTable绑定到DataGridView
                dataGridView3.DataSource = dataTable;
            }
        }
        private void LoadpipeidefenData()
        {
            // 数据库连接字符串
            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            // SQL查询命令
            string queryCommand = "SELECT [6_2_pipeidefen].teamnum, [6_2_pipeidefen].t_uid, [6_2_StuVol].P_name, [6_2_StuVol].P_brief " +
                                  "FROM [6_2_pipeidefen] " +
                                  "JOIN [6_2_StuVol] ON [6_2_pipeidefen].teamnum = [6_2_StuVol].teamnum";

            // 创建SqlConnection和SqlCommand
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(queryCommand, connection))
            {
                // 创建DataTable用于存储查询结果
                DataTable dataTable = new DataTable();

                // 打开数据库连接
                connection.Open();

                // 使用SqlDataAdapter填充DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }

                // 将DataTable绑定到DataGridView2
                dataGridView2.DataSource = dataTable;

                SaveDataGridView2ToDatabase(dataTable);
            }
        }
        private void 确认发布_Click(object sender, EventArgs e)
        {
            // 在此处添加确认发布的逻辑
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 清空 dataGridView4 中的数据
            dataGridView4.Rows.Clear();

            // 获取选中行的 t_uid
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView3.Rows.Count)
            {
                selectedTUid = dataGridView3.Rows[e.RowIndex].Cells["t_uid"].Value.ToString();

                // 将选中行的 t_uid 显示在 dataGridView4 的第一列中
                dataGridView4.Rows.Add(selectedTUid);

                // 根据选中的 t_uid 查询 6_2_pipeidefen 表，将对应行的 teamnum 值显示在 dataGridView4 的第二列中
                LoadTeamNumsToDataGridView4(selectedTUid);
            }
        }

        private void LoadTeamNumsToDataGridView4(string tUid)
        {
            // 数据库连接字符串
            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            // SQL查询命令
            string queryCommand = $"SELECT teamnum, score FROM [6_2_pipeidefen] WHERE t_uid = @tUid ORDER BY score DESC";

            // 创建SqlConnection和SqlCommand
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(queryCommand, connection))
            {
                // 添加参数
                cmd.Parameters.AddWithValue("@tUid", tUid);

                // 打开数据库连接
                connection.Open();

                // 读取数据
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int count = 0;

                    // 将查询结果显示在 dataGridView4 的第二列中
                    while (reader.Read() && count < 5) // 限制为前五行
                    {
                        dataGridView4.Rows.Add(tUid, reader["teamnum"].ToString());
                        count++;
                    }
                }
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取选中的单元格的值
            if (e.RowIndex >= 0 && e.ColumnIndex == 1) // 假设值在第二列
            {
                string selectedTeamNum = dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // 根据选中的 teamnum 查询 6_2_StuTeam 表，将匹配的行加载到 dataGridView1 中
                LoadStuTeamToDataGridView1(selectedTeamNum);
            }
        }

        private void LoadStuTeamToDataGridView1(string teamNum)
        {
            // 数据库连接字符串
            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            // SQL查询命令
            string queryCommand = $"SELECT * FROM [6_2_StuTeam] WHERE teamnum = @teamNum";

            // 创建SqlConnection和SqlCommand
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(queryCommand, connection))
            {
                // 添加参数
                cmd.Parameters.AddWithValue("@teamNum", teamNum);

                // 创建DataTable用于存储查询结果
                DataTable dataTable = new DataTable();

                // 打开数据库连接
                connection.Open();

                // 使用SqlDataAdapter填充DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }

                // 将DataTable绑定到DataGridView1
                dataGridView1.DataSource = dataTable;
            }
        }

        private void SaveDataGridView2ToDatabase(DataTable dataGridView2)
        {
            // 数据库连接字符串
            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            // SQL插入命令
            string insertCommand = "INSERT INTO [6_2_Result] (teamnum, t_uid, P_name, P_brief ) " +
                                   "VALUES (@teamnum, @t_uid, @P_name, @P_brief)";

            // 创建SqlConnection和SqlCommand
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(insertCommand, connection))
            {
                // 打开数据库连接
                connection.Open();

                // 添加参数
                cmd.Parameters.Add("@teamnum", SqlDbType.VarChar);
                cmd.Parameters.Add("@t_uid", SqlDbType.VarChar);
                cmd.Parameters.Add("@P_name", SqlDbType.Int);
                cmd.Parameters.Add("@P_brief", SqlDbType.Int);

                // 遍历结果表中的每一行，执行插入命令
                foreach (DataRow row in dataGridView2.Rows)
                {
                    cmd.Parameters["@teamnum"].Value = row["teamnum"];
                    cmd.Parameters["@t_uid"].Value = row["t_uid"];
                    cmd.Parameters["@P_name"].Value = row["P_name"];
                    cmd.Parameters["@P_brief"].Value = row["P_brief"];

                    // 执行SQL插入命令
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}