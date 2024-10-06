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
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using System.Xml.Linq;


namespace student
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
                string selectQuery = "SELECT * FROM [6_2_S] WHERE s_uid = @s_uid ";

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    // 设置参数
                    cmd.Parameters.AddWithValue("@s_uid", UserHelper.UserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 将数据从数据库加载到 Label 控件中
                            xuehaoTextBox.Text = UserHelper.UserId;
                            xingmingTextBox.Text = reader["s_name"].ToString();
                            xingbieTextBox.Text = reader["sex"].ToString();
                            nianjiTextBox.Text = reader["grip"].ToString();
                            xueyuanTextBox.Text = reader["academy"].ToString();
                            zhuanyeTextBox.Text = reader["major"].ToString();
                            banbieTextBox.Text = reader["cla"].ToString();
                            youxiangTextBox.Text = reader["email"].ToString();
                            dianhuaTextBox.Text = reader["tel"].ToString();
                            if (!(xuehaoTextBox.Text == "" || xingmingTextBox.Text == "" || xingbieTextBox.Text == "" || nianjiTextBox.Text == "" || xueyuanTextBox.Text == "" || zhuanyeTextBox.Text == "" || banbieTextBox.Text == "" || youxiangTextBox.Text == "" || dianhuaTextBox.Text == ""))
                            {

                                youxiangTextBox.ReadOnly = true;
                                dianhuaTextBox.ReadOnly = true;
                                提交.Text = "已提交";
                                提交.BackColor = Color.Gray;
                                提交.FlatAppearance.BorderColor = Color.Gray;
                                提交.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 联系管理员_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改请联系管理员\n联系电话:xxx");
        }

        private void 保存草稿_Click(object sender, EventArgs e)
        {

        }


        private void 提交_Click(object sender, EventArgs e)
        {

            // 获取用户输入的学号
            string s_uid = xuehaoTextBox.Text;
            string s_name = xingmingTextBox.Text;
            string sex = xingbieTextBox.Text;
            string grip = nianjiTextBox.Text;
            string academy = xueyuanTextBox.Text;
            string major = zhuanyeTextBox.Text;
            string cla = banbieTextBox.Text;
            string email = youxiangTextBox.Text;
            string tel = dianhuaTextBox.Text;

            // 数据库连接字符串
            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            string checkQuery = "SELECT COUNT(*) FROM [6_2_S] WHERE s_uid = @s_uid";
            using (SqlConnection checkConn = new SqlConnection(connString))
            {
                checkConn.Open();

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, checkConn))
                {
                    checkCmd.Parameters.AddWithValue("@s_uid", UserHelper.UserId);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        // 学号已存在，可以进行更新操作
                        string updateQuery = "UPDATE [6_2_S] " +
                        "SET s_name = @s_name, sex = @sex, grip = @grip, academy = @academy, major = @major, " +
                        "cla = @cla, email = @email, tel = @tel " +
                        "WHERE s_uid = @s_uid";
                        using (SqlConnection updateconn = new SqlConnection(connString))
                        {
                            updateconn.Open();

                            using (SqlCommand cmd = new SqlCommand(updateQuery, updateconn))
                            {
                                // 添加参数
                                cmd.Parameters.AddWithValue("@s_uid", s_uid);
                                cmd.Parameters.AddWithValue("@s_name", s_name);
                                cmd.Parameters.AddWithValue("@sex", sex);
                                cmd.Parameters.AddWithValue("@grip", grip);
                                cmd.Parameters.AddWithValue("@academy", academy);
                                cmd.Parameters.AddWithValue("@major", major);
                                cmd.Parameters.AddWithValue("@cla", cla);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@tel", tel);

                                // 执行更新操作
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    if (!(xuehaoTextBox.Text == "" || xingmingTextBox.Text == "" || xingbieTextBox.Text == "" || nianjiTextBox.Text == "" || xueyuanTextBox.Text == "" || zhuanyeTextBox.Text == "" || banbieTextBox.Text == "" || youxiangTextBox.Text == "" || dianhuaTextBox.Text == ""))
                                    {
                                        MessageBox.Show("数据已成功更新！", "成功");
                                        xuehaoTextBox.ReadOnly = true;
                                        xingmingTextBox.ReadOnly = true;
                                        xingbieTextBox.ReadOnly = true;
                                        nianjiTextBox.ReadOnly = true;
                                        xueyuanTextBox.ReadOnly = true;
                                        zhuanyeTextBox.ReadOnly = true;
                                        banbieTextBox.ReadOnly = true;
                                        youxiangTextBox.ReadOnly = true;
                                        dianhuaTextBox.ReadOnly = true;

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

        private void nianji_TextChanged(object sender, EventArgs e)
        {

        }

        private void zhuanye_TextChanged(object sender, EventArgs e)
        {

        }

        private void xuehaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void xingbieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void 学号_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void 性别_Click(object sender, EventArgs e)
        {
        }

        private void 学院_Click(object sender, EventArgs e)
        {
        }

        private void 年级_Click(object sender, EventArgs e)
        {
        }

        private void 专业_Click(object sender, EventArgs e)
        {
        }

        private void 邮箱_Click(object sender, EventArgs e)
        {
        }

        private void 联系电话_Click(object sender, EventArgs e)
        {
        }

        private void 班别_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void xingmingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void youxiangTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
