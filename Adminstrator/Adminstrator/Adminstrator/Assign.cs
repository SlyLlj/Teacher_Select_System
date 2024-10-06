
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;


namespace Adminstrator
{
    public partial class Assign : Form
    {

        public Assign()
        {
            InitializeComponent();
        }

        private void Assign_Load(object sender, EventArgs e)
        {
            LoadStuVolData();
            LoadTeaVolData();
        }
        string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

        private void LoadStuVolData()
        {
            // SQL query to retrieve data from 6_2_StuVol
            string queryStuVol = "SELECT teamnum, vol1, vol2, vol3 FROM [6_2_StuVol]";

            // Create a SqlConnection
            using (SqlConnection connection = new SqlConnection(connString))
            {
                // Create a SqlCommand
                using (SqlCommand cmd = new SqlCommand(queryStuVol, connection))
                {
                    // Create a DataTable to store the data
                    DataTable dataTable = new DataTable();

                    // Open the connection
                    connection.Open();

                    // Use SqlDataAdapter to fill the DataTable with the data from the query
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the DataGridView
                    Groups_view.DataSource = dataTable;
                }
            }
        }
        private void LoadTeaVolData()
        {
            // SQL query to retrieve data from 6_2_StuVol
            string queryStuVol = "SELECT t_uid, vol1, vol2, vol3, vol4, vol5 FROM [6_2_TeaVol]";

            // Create a SqlConnection
            using (SqlConnection connection = new SqlConnection(connString))
            {
                // Create a SqlCommand
                using (SqlCommand cmd = new SqlCommand(queryStuVol, connection))
                {
                    // Create a DataTable to store the data
                    DataTable dataTable = new DataTable();

                    // Open the connection
                    connection.Open();

                    // Use SqlDataAdapter to fill the DataTable with the data from the query
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the DataGridView
                    Teachers_view.DataSource = dataTable;
                }
            }
        }

        private void 手动调整_Click(object sender, EventArgs e)
        {
            Ajust form = new Ajust();
            form.ShowDialog();
        }

        private void 发布结果_Click(object sender, EventArgs e)
        {
            Preview form = new Preview();
            form.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 过滤_Click(object sender, EventArgs e)
        {
            // 获取 Pairs_view 的数据源
            DataTable pairsDataTable = (DataTable)Pairs_view.DataSource;

            // 根据 score 列降序排序
            pairsDataTable.DefaultView.Sort = "score DESC";
            DataTable sortedDataTable = pairsDataTable.DefaultView.ToTable();

            // 创建一个字典用于存储 teamnum 对应的最大 score 值
            Dictionary<string, int> maxScoreDict = new Dictionary<string, int>();

            // 创建一个新的 DataTable 用于存储过滤后的结果
            DataTable filteredDataTable = sortedDataTable.Clone();

            // 遍历排序后的表格，保留每个 teamnum 对应的最大 score 值的行
            foreach (DataRow row in sortedDataTable.Rows)
            {
                string teamnum = row["teamnum"].ToString();
                int score = Convert.ToInt32(row["score"]);

                if (!maxScoreDict.ContainsKey(teamnum))
                {
                    maxScoreDict.Add(teamnum, score);

                    // 将第一次出现的行添加到新的 DataTable 中
                    filteredDataTable.ImportRow(row);
                }
                else
                {
                    if (score > maxScoreDict[teamnum])
                    {
                        maxScoreDict[teamnum] = score;

                        // 移除已有的行
                        DataRow[] rowsToRemove = filteredDataTable.Select($"teamnum = '{teamnum}'");
                        foreach (DataRow rowToRemove in rowsToRemove)
                        {
                            filteredDataTable.Rows.Remove(rowToRemove);
                        }

                        // 将当前行添加到新的 DataTable 中
                        filteredDataTable.ImportRow(row);
                    }
                }
            }

            // 将新的 DataTable 绑定到 Pairs_view
            Pairs_view.DataSource = filteredDataTable;

            // 将过滤后的结果保存到数据库
            SavePairsToDatabase(filteredDataTable);
        }

        private void 自动分配_Click(object sender, EventArgs e)
        {
            DataTable stuVolDataTable = (DataTable)Groups_view.DataSource;
            DataTable teaVolDataTable = (DataTable)Teachers_view.DataSource;

            DataTable pairsDataTable = new DataTable();
            pairsDataTable.Columns.Add("teamnum");
            pairsDataTable.Columns.Add("t_uid");
            pairsDataTable.Columns.Add("stuvol1", typeof(int));
            pairsDataTable.Columns.Add("stuvol2", typeof(int));
            pairsDataTable.Columns.Add("stuvol3", typeof(int));
            pairsDataTable.Columns.Add("teavol1", typeof(int));
            pairsDataTable.Columns.Add("teavol2", typeof(int));
            pairsDataTable.Columns.Add("teavol3", typeof(int));
            pairsDataTable.Columns.Add("teavol4", typeof(int));
            pairsDataTable.Columns.Add("teavol5", typeof(int));
            pairsDataTable.Columns.Add("score", typeof(int));

            foreach (DataRow stuVolRow in stuVolDataTable.Rows)
            {
                string teamnum = stuVolRow["teamnum"].ToString();

                foreach (DataRow teaVolRow in teaVolDataTable.Rows)
                {
                    string t_uid = teaVolRow["t_uid"].ToString();

                    DataRow pairsRow = pairsDataTable.NewRow();
                    pairsRow["teamnum"] = teamnum;
                    pairsRow["t_uid"] = t_uid;

                    for (int i = 1; i <= 3; i++)
                    {
                        string stuVolValue = stuVolRow["vol" + i].ToString();
                        pairsRow["stuvol" + i] = (stuVolValue == t_uid) ? 1 : 0;
                    }

                    for (int i = 1; i <= 5; i++)
                    {
                        string teaVolValue = teaVolRow["vol" + i].ToString();
                        pairsRow["teavol" + i] = (teaVolValue == teamnum) ? 1 : 0;
                    }

                    int score = (int)pairsRow["stuvol1"] * 8 +
                                (int)pairsRow["stuvol2"] * 7 +
                                (int)pairsRow["stuvol3"] * 6 +
                                (int)pairsRow["teavol1"] * 5 +
                                (int)pairsRow["teavol2"] * 4 +
                                (int)pairsRow["teavol3"] * 3 +
                                (int)pairsRow["teavol4"] * 2 +
                                (int)pairsRow["teavol5"] * 1;

                    pairsRow["score"] = score;

                    pairsDataTable.Rows.Add(pairsRow);
                }
            }

            Pairs_view.DataSource = pairsDataTable;
        }
        private void SavePairsToDatabase(DataTable pairsDataTable)
        {
            // 数据库连接字符串
            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            // SQL插入命令
            string insertCommand = "INSERT INTO [6_2_pipeidefen] (teamnum, t_uid, stuvol1, stuvol2, stuvol3, teavol1, teavol2, teavol3, teavol4, teavol5, score) " +
                                   "VALUES (@teamnum, @t_uid, @stuvol1, @stuvol2, @stuvol3, @teavol1, @teavol2, @teavol3, @teavol4, @teavol5, @score)";

            // 创建SqlConnection和SqlCommand
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(insertCommand, connection))
            {
                // 打开数据库连接
                connection.Open();

                // 添加参数
                cmd.Parameters.Add("@teamnum", SqlDbType.VarChar);
                cmd.Parameters.Add("@t_uid", SqlDbType.VarChar);
                cmd.Parameters.Add("@stuvol1", SqlDbType.Int);
                cmd.Parameters.Add("@stuvol2", SqlDbType.Int);
                cmd.Parameters.Add("@stuvol3", SqlDbType.Int);
                cmd.Parameters.Add("@teavol1", SqlDbType.Int);
                cmd.Parameters.Add("@teavol2", SqlDbType.Int);
                cmd.Parameters.Add("@teavol3", SqlDbType.Int);
                cmd.Parameters.Add("@teavol4", SqlDbType.Int);
                cmd.Parameters.Add("@teavol5", SqlDbType.Int);
                cmd.Parameters.Add("@score", SqlDbType.Int);

                // 遍历结果表中的每一行，执行插入命令
                foreach (DataRow row in pairsDataTable.Rows)
                {
                    cmd.Parameters["@teamnum"].Value = row["teamnum"];
                    cmd.Parameters["@t_uid"].Value = row["t_uid"];
                    cmd.Parameters["@stuvol1"].Value = row["stuvol1"];
                    cmd.Parameters["@stuvol2"].Value = row["stuvol2"];
                    cmd.Parameters["@stuvol3"].Value = row["stuvol3"];
                    cmd.Parameters["@teavol1"].Value = row["teavol1"];
                    cmd.Parameters["@teavol2"].Value = row["teavol2"];
                    cmd.Parameters["@teavol3"].Value = row["teavol3"];
                    cmd.Parameters["@teavol4"].Value = row["teavol4"];
                    cmd.Parameters["@teavol5"].Value = row["teavol5"];
                    cmd.Parameters["@score"].Value = row["score"];

                    // 执行SQL插入命令
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
