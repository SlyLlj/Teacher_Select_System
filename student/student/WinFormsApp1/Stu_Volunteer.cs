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
using System.Xml.Linq;

namespace student
{
    public partial class Stu_Volunteer : Form
    {
        public Stu_Volunteer()
        {
            InitializeComponent();
        }

        string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

        private void Stu_Volunteer_Load(object sender, EventArgs e)
        {

            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string selectQueryTeaIn = "SELECT * FROM [6_2_StuVol_TeaIn]"; // 从数据库中检索数据

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

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 将数据从数据库加载到 textbox 控件中
                            textBox3.Text = reader["vol1"].ToString();
                            textBox4.Text = reader["vol2"].ToString();
                            textBox5.Text = reader["vol3"].ToString();

                            if (textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                            {

                                提交志愿.Text = "已提交";
                                提交志愿.BackColor = Color.Gray;
                                提交志愿.FlatAppearance.BorderColor = Color.Gray;
                                提交志愿.Enabled = false;
                            }
                        }
                    }
                }

                
            }




        }





        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            // 当用户选择行时显示 brief_introduction 列的内容
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string briefIntroduction = dataGridView1.Rows[a].Cells["brief_introduction"].Value.ToString();
                textBox2.Text = briefIntroduction;
                string teaname = dataGridView1.Rows[a].Cells["t_name"].Value.ToString();
                textBox1.Text = teaname;
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 研究方向_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 提交志愿_Click(object sender, EventArgs e)
        {
            string s_uid = UserHelper.UserId;
            string vol1 = textBox3.Text;
            string vol2 = textBox4.Text;
            string vol3 = textBox5.Text;

            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            // 获取当前登录个人的专业和年级
            string major, grip;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string selectUserInfoQuery = "SELECT major, grip FROM [6_2_S] WHERE s_uid = @s_uid";

                using (SqlCommand cmd = new SqlCommand(selectUserInfoQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@s_uid", UserHelper.UserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            major = reader["major"].ToString();
                            grip = reader["grip"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("无法获取当前登录用户的专业和年级信息");
                            return;
                        }
                    }
                }
            }

            // 查询截止时间
            DateTime deadline;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string selectDeadlineQuery = "SELECT studdl FROM [6_2_Time] WHERE major = @major AND grip = @grip";

                using (SqlCommand cmd = new SqlCommand(selectDeadlineQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@major", major);
                    cmd.Parameters.AddWithValue("@grip", grip);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            deadline = Convert.ToDateTime(reader["studdl"]);
                        }
                        else
                        {
                            MessageBox.Show("无法获取当前登录用户所在专业和年级的截止时间");
                            return;
                        }
                    }
                }
            }
            // 检查是否超过截止时间
            if (DateTime.Now <= deadline)
            {
                // 截止时间未到，可以提交志愿
                string checkStuVol = "SELECT COUNT(*) FROM [6_2_StuVol] WHERE s_uid = @s_uid";
                using (SqlConnection checkConn = new SqlConnection(connString))
                {
                    checkConn.Open();

                    using (SqlCommand checkCmd = new SqlCommand(checkStuVol, checkConn))
                    {
                        checkCmd.Parameters.AddWithValue("@s_uid", UserHelper.UserId);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            if (vol1 != null && vol2 != null && vol3 != null)
                            {
                                // 学号已存在，可以进行更新操作
                                string updateQuery = "UPDATE [6_2_StuVol] " +
                                "SET vol1 = @vol1,vol2 = @vol2,vol3 = @vol3  " + "WHERE s_uid = @s_uid";// 数据改一下
                                using (SqlConnection updateconn = new SqlConnection(connString))
                                {
                                    updateconn.Open();
                                    using (SqlCommand cmd = new SqlCommand(updateQuery, updateconn))
                                    {
                                        cmd.Parameters.AddWithValue("@s_uid", s_uid);
                                        cmd.Parameters.AddWithValue("@vol1", vol1);
                                        cmd.Parameters.AddWithValue("@vol2", vol2);
                                        cmd.Parameters.AddWithValue("@vol3", vol3);
                                        提交志愿.Text = "已提交";
                                        提交志愿.BackColor = Color.Gray;
                                        提交志愿.FlatAppearance.BorderColor = Color.Gray;
                                        提交志愿.Enabled = false;
                                        int rowsAffected = cmd.ExecuteNonQuery();
                                        MessageBox.Show("提交成功");
                                    }
                                }
                            }
                            else
                            {
                                提交志愿.Text = "已提交";
                                提交志愿.BackColor = Color.Gray;
                                提交志愿.FlatAppearance.BorderColor = Color.Gray;
                                提交志愿.Enabled = false;
                            }
                        }
                        else
                        {
                            // s_uid 不存在，执行插入操作
                            // 获取 teamnum 的最大值
                            int teamNum = GetMaxTeamNum();

                            // 插入新行
                            string insertQuery = "INSERT INTO [6_2_StuVol] (s_uid, vol1, vol2, vol3, teamnum) VALUES (@s_uid, @vol1, @vol2, @vol3, @teamnum)";
                            using (SqlConnection insertConn = new SqlConnection(connString))
                            {
                                insertConn.Open();

                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, insertConn))
                                {
                                    insertCmd.Parameters.AddWithValue("@s_uid", s_uid);
                                    insertCmd.Parameters.AddWithValue("@vol1", vol1);
                                    insertCmd.Parameters.AddWithValue("@vol2", vol2);
                                    insertCmd.Parameters.AddWithValue("@vol3", vol3);
                                    insertCmd.Parameters.AddWithValue("@teamnum", teamNum + 1); // 自增
                                    insertCmd.ExecuteNonQuery();
                                }
                            }

                            string selectQueryStuVol = "SELECT P_name, P_brief FROM [6_2_StuTeam] WHERE s_uid = @s_uid";

                            string volP_name = "";
                            string volP_brief = "";

                            using (SqlConnection conn = new SqlConnection(connString))
                            {
                                conn.Open();
                                using (SqlCommand cmd = new SqlCommand(selectQueryStuVol, conn))
                                {
                                    cmd.Parameters.AddWithValue("@s_uid", s_uid);
                                    using (SqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            // 读取并存储 P_name 和 P_brief 列的值
                                            volP_name = reader["P_name"].ToString();
                                            volP_brief = reader["P_brief"].ToString();
                                        }
                                    }
                                }
                            }

                            // 插入到表 6_2_StuTeam 中对应 s_uid 行的 P_name 和 P_brief 列
                            string updateQueryStuTeam = "UPDATE [6_2_StuVol] SET P_name = @P_name, P_brief = @P_brief WHERE s_uid = @s_uid";

                            using (SqlConnection updateConn = new SqlConnection(connString))
                            {
                                updateConn.Open();
                                using (SqlCommand updateCmd = new SqlCommand(updateQueryStuTeam, updateConn))
                                {
                                    updateCmd.Parameters.AddWithValue("@s_uid", s_uid);
                                    updateCmd.Parameters.AddWithValue("@P_name", volP_name);
                                    updateCmd.Parameters.AddWithValue("@P_brief", volP_brief);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("提交成功");
                        }
                    }
                }
                MessageBox.Show("提交成功");
            }
            else
            {
                // 截止时间已过，不允许提交志愿
                MessageBox.Show("已经超出截止时间");
            }
        }
        // 获取 teamnum 的最大值
        private int GetMaxTeamNum()
        {
            string query = "SELECT MAX(teamnum) FROM [6_2_StuVol]";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
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
        }




        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Focus();
                int a = dataGridView1.CurrentRow.Index;
                string teaname = dataGridView1.Rows[a].Cells["t_uid"].Value.ToString();
                textBox3.Text = teaname;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox4.Focus();
                int a = dataGridView1.CurrentRow.Index;
                string teaname = dataGridView1.Rows[a].Cells["t_uid"].Value.ToString();
                textBox4.Text = teaname;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox5.Focus();
                int a = dataGridView1.CurrentRow.Index;
                string teaname = dataGridView1.Rows[a].Cells["t_uid"].Value.ToString();
                textBox5.Text = teaname;
            }
        }

        private void 删除志愿_Click(object sender, EventArgs e)
        {

            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            string checkQuery = "SELECT COUNT(*) FROM [6_2_StuVol] WHERE s_uid = @s_uid ";
            using (SqlConnection checkConn = new SqlConnection(connString))
            {
                checkConn.Open();

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, checkConn))
                {
                    checkCmd.Parameters.AddWithValue("@s_uid", UserHelper.UserId);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0 && !(提交志愿.Enabled))
                    {
                        // 学号已存在，可以进行更新操作
                        string updateQuery = "UPDATE [6_2_StuVol] " +
                        "SET vol1 = @vol1,vol2 = @vol2,vol3 = @vol3 " + "WHERE s_uid = @s_uid";// 数据改一下
                        using (SqlConnection updateconn = new SqlConnection(connString))
                        {
                            updateconn.Open();
                            using (SqlCommand cmd = new SqlCommand(updateQuery, updateconn))
                            {
                                cmd.Parameters.AddWithValue("@s_uid", UserHelper.UserId);
                                cmd.Parameters.AddWithValue("@vol1", "");
                                cmd.Parameters.AddWithValue("@vol2", "");
                                cmd.Parameters.AddWithValue("@vol3", "");
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";
                                提交志愿.Text = "提交志愿";
                                提交志愿.BackColor = SystemColors.ActiveCaption;
                                提交志愿.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
                                提交志愿.Enabled = true;
                                int rowsAffected = cmd.ExecuteNonQuery();
                                MessageBox.Show("删除成功");
                            }

                        }

                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
