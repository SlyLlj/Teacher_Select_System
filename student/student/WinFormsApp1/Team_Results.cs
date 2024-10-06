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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace student
{
    public partial class Team_Results : Form
    {
        public Team_Results()
        {
            InitializeComponent();
        }

        string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string connstuTeam = "SELECT * FROM [6_2_StuTeam] WHERE s_uid = @s_uid ";
                using (SqlCommand cmd = new SqlCommand(connstuTeam, conn))
                {
                    cmd.Parameters.AddWithValue("@s_uid", UserHelper.UserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name.Text = reader["LeaderUid"].ToString();
                        }
                    }
                }
                string LeaderUid = name.Text.ToString();

                string connS_StuTeamAll = "SELECT * FROM [6_2_StuTeam] WHERE LeaderUid = @LeaderUid";

                // 编写查询语句以检索数据
                using (SqlCommand cmd = new SqlCommand(connS_StuTeamAll, conn))
                {
                    cmd.Parameters.AddWithValue("@s_uid", UserHelper.UserId);
                    cmd.Parameters.AddWithValue("@LeaderUid", LeaderUid);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 将数据从数据库加载到 label 控件中
                            name.Text = reader["LeaderName"].ToString();
                            stunu.Text = reader["LeaderUid"].ToString();
                            textBox3.Text = reader["P_name"].ToString();
                            textBox4.Text = reader["P_brief"].ToString();
                        }

                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // 将小组成员信息绑定到 DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void Team_Results_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void 小组成员_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
