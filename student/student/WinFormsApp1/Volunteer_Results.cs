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

namespace student
{
    public partial class Volunteer_Results : Form
    {
        public Volunteer_Results()
        {
            InitializeComponent();
        }

        string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {

                conn.Open();

                string connStuTeam = "SELECT * FROM [6_2_StuTeam] WHERE s_uid = @s_uid ";
                using (SqlCommand cmd = new SqlCommand(connStuTeam, conn))
                {
                    cmd.Parameters.AddWithValue("@s_uid", UserHelper.UserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name.Text = reader["LeaderUid"].ToString();
                            label2.Text = reader["teamnum"].ToString();

                        }
                    }
                }
                string LeaderUid = name.Text.ToString();
                string teamnum = label2.Text.ToString();

                string connS_StuTeam = "SELECT * FROM [6_2_StuTeam] WHERE LeaderUid = @LeaderUid";

                // 编写查询语句以检索数据
                using (SqlCommand cmd = new SqlCommand(connS_StuTeam, conn))
                {
                    cmd.Parameters.AddWithValue("@LeaderUid", LeaderUid);


                    // 编写查询语句以检索数据
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 将数据从数据库加载到 label 控件中
                            textBox3.Text = reader["P_name"].ToString();
                            name.Text = reader["LeaderName"].ToString();
                            stunu.Text = reader["LeaderUid"].ToString();
                        }
                    }

                }
                string connResult = "SELECT * FROM [6_2_Result] WHERE teamnum = @teamnum ";
                using (SqlCommand cmd = new SqlCommand(connResult, conn))
                {
                    cmd.Parameters.AddWithValue("@teamnum", teamnum);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox6.Text = reader["t_uid"].ToString();
                        }
                    }
                }
                string t_uid = textBox6.Text;

                string connT = "SELECT * FROM [6_2_T] WHERE t_uid = @t_uid";
                // 编写查询语句以检索数据
                using (SqlCommand cmd = new SqlCommand(connT, conn))
                {
                    cmd.Parameters.AddWithValue("@t_uid", t_uid);

                    // 编写查询语句以检索数据
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 将数据从数据库加载到 label 控件中
                            textBox1.Text = reader["t_name"].ToString();
                            textBox2.Text = reader["researchDir"].ToString();
                            textBox4.Text = reader["email"].ToString();
                            textBox5.Text = reader["tel"].ToString();

                        }
                    }

                }

            }
        }
        private void Volunteer_Results_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != null)
            {
                textBox3.ReadOnly = true;
            }
        }

        private void 导师姓名_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 指导老师_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Volunteer_Results_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.ReadOnly = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                textBox2.ReadOnly = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != null)
            {
                textBox4.ReadOnly = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != null)
            {
                textBox5.ReadOnly = true;
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void 组长学号_Click(object sender, EventArgs e)
        {

        }

        private void stunu_Click(object sender, EventArgs e)
        {
        }
    }
}
