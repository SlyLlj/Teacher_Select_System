using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace teacher
{
    public partial class result : Form
    {
        private string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

        public result()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e)
        {
            // 将 UserHelper.UserId 的值传递给 label1
            label1.Text = UserHelper.UserId;

            // 查询表 6_2_Result 中的数据并加载到 dataGridView2
            LoadResultData();
        }

        private void LoadResultData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // 查询表 6_2_Result 中 t_uid 为 UserHelper.UserId 的行
                string selectQueryResult = "SELECT teamnum, P_name, P_brief FROM [6_2_Result] WHERE t_uid = @t_uid";

                using (SqlCommand cmd = new SqlCommand(selectQueryResult, conn))
                {
                    cmd.Parameters.AddWithValue("@t_uid", UserHelper.UserId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // 将查询到的数据加载到 dataGridView2
                    dataGridView2.DataSource = dataTable;
                }

                conn.Close();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string selectedTeamNum = dataGridView2.Rows[e.RowIndex].Cells["teamnum"].Value.ToString();

                LoadStuTeamData(selectedTeamNum);
            }
        }

        private void LoadStuTeamData(string teamNum)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string selectQueryStuTeam = "SELECT * FROM [6_2_StuTeam] WHERE teamnum = @teamnum";

                using (SqlCommand cmd = new SqlCommand(selectQueryStuTeam, conn))
                {
                    cmd.Parameters.AddWithValue("@teamnum", teamNum);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView3.DataSource = dataTable;

                    if (dataTable.Rows.Count > 0)
                    {
                        textBox1.Text = dataTable.Rows[0]["P_name"].ToString();
                        textBox2.Text = dataTable.Rows[0]["P_brief"].ToString();
                    }
                    else
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }

                conn.Close();
            }
        }

    }
}
