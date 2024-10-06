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

namespace teacher
{
    public partial class Personal_Information : Form
    {
        public Personal_Information()
        {
            InitializeComponent();
        }
        private void Personal_Information_Load(object sender, EventArgs e)
        {
            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // 编写查询语句以检索数据
                string selectQuery = "SELECT * FROM [6_2_T] WHERE t_uid = @t_uid ";

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    // 设置参数
                    cmd.Parameters.AddWithValue("@t_uid", UserHelper.UserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 将数据从数据库加载到 Label 控件中
                            gonghao.Text = UserHelper.UserId;
                            xingming.Text = reader["t_name"].ToString();
                            bumen.Text = reader["apart"].ToString();
                            yanjiufangxiang.Text = reader["researchDir"].ToString();
                            youxiang.Text = reader["email"].ToString();
                            dianhua.Text = reader["tel"].ToString();

                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 提交_Click(object sender, EventArgs e)
        {
            // 获取用户输入的学号
            string t_uid = gonghao.Text;
            string t_name = xingming.Text;
            string apart = bumen.Text;
            string researchDir = yanjiufangxiang.Text;
            string email = youxiang.Text;
            string tel = dianhua.Text;

            // 数据库连接字符串
            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            string checkQuery = "SELECT COUNT(*) FROM [6_2_T] WHERE t_uid = @t_uid";
            using (SqlConnection checkConn = new SqlConnection(connString))
            {
                checkConn.Open();

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, checkConn))
                {
                    checkCmd.Parameters.AddWithValue("@t_uid", UserHelper.UserId);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        // 工号已存在，可以进行更新操作
                        string updateQuery = "UPDATE [6_2_T] " +
                        "SET t_name = @t_name, researchDir = @researchDir, apart = @apart, " +
                        "email = @email, tel = @tel " +
                        "WHERE t_uid = @t_uid";
                        using (SqlConnection updateconn = new SqlConnection(connString))
                        {
                            updateconn.Open();

                            using (SqlCommand cmd = new SqlCommand(updateQuery, updateconn))
                            {
                                // 添加参数
                                cmd.Parameters.AddWithValue("@t_uid", t_uid);
                                cmd.Parameters.AddWithValue("@t_name", t_name);
                                cmd.Parameters.AddWithValue("@researchDir", researchDir);
                                cmd.Parameters.AddWithValue("@apart", apart);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@tel", tel);

                                // 执行更新操作
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    if (!(gonghao.Text == "" || xingming.Text == "" || bumen.Text == "" || yanjiufangxiang.Text == "" || youxiang.Text == "" || dianhua.Text == ""))
                                    {
                                        MessageBox.Show("数据已成功更新！", "成功");
                                        gonghao.ReadOnly = true;
                                        xingming.ReadOnly = true;
                                        bumen.ReadOnly = true;
                                        yanjiufangxiang.ReadOnly = true;
                                        youxiang.ReadOnly = true;
                                        dianhua.ReadOnly = true;


                                        提交.Text = "已提交";
                                        提交.BackColor = Color.Gray;
                                        提交.FlatAppearance.BorderColor = Color.Gray;
                                        提交.Enabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("内容不能为空！");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("更新数据时发生错误！", "错误");
                                }
                            }
                        }
                    }
                }

            }
        }

        private void 联系管理员_Click(object sender, EventArgs e)
        {
            // 获取用户输入的学号
            string t_uid = gonghao.Text;
            string t_name = xingming.Text;
            string apart = bumen.Text;
            string researchDir = yanjiufangxiang.Text;
            string email = youxiang.Text;
            string tel = dianhua.Text;

            // 数据库连接字符串
            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            string checkQuery = "SELECT COUNT(*) FROM [6_2_T] WHERE t_uid = @t_uid";
            using (SqlConnection checkConn = new SqlConnection(connString))
            {
                checkConn.Open();

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, checkConn))
                {
                    checkCmd.Parameters.AddWithValue("@t_uid", UserHelper.UserId);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        // 工号已存在，可以进行更新操作
                        string updateQuery = "UPDATE [6_2_T] " +
                        "SET t_name = @t_name, researchDir = @researchDir, apart = @apart, " +
                        "email = @email, tel = @tel " +
                        "WHERE t_uid = @t_uid";
                        using (SqlConnection updateconn = new SqlConnection(connString))
                        {
                            updateconn.Open();

                            using (SqlCommand cmd = new SqlCommand(updateQuery, updateconn))
                            {
                                // 添加参数
                                cmd.Parameters.AddWithValue("@t_uid", t_uid);
                                cmd.Parameters.AddWithValue("@t_name", t_name);
                                cmd.Parameters.AddWithValue("@researchDir", researchDir);
                                cmd.Parameters.AddWithValue("@apart", apart);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@tel", tel);

                                // 执行更新操作
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    if (!(gonghao.Text == "" || xingming.Text == "" || bumen.Text == "" || yanjiufangxiang.Text == "" || youxiang.Text == "" || dianhua.Text == ""))
                                    {
                                        MessageBox.Show("数据已成功更新！", "成功");
                                        gonghao.ReadOnly = true;
                                        xingming.ReadOnly = true;
                                        bumen.ReadOnly = true;
                                        yanjiufangxiang.ReadOnly = true;
                                        youxiang.ReadOnly = true;
                                        dianhua.ReadOnly = true;
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("更新数据时发生错误！", "错误");
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
