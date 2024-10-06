using student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Student
{
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }
        string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";


        private void Change_Password_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员，\n电话号码：xxx");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string connS = "SELECT * FROM [6_2_S] WHERE uid = @uid ";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(connS, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", UserHelper.UserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (textBox1.Text == reader["pwd"].ToString())
                            {
                                pwdwrong.Visible = false;
                            }
                            else
                            {
                                pwdwrong.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void pwdwrong_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员\n电话号码：xxx");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void 确认_Click(object sender, EventArgs e)
        {
            string checkS = "SELECT COUNT(*) FROM [6_2_S] WHERE uid = @uid";

            string pwd = textBox2.Text;
            if (textBox2.Text == textBox3.Text)
            {
                label1.Visible = false;
                using (SqlConnection checkConn = new SqlConnection(connString))
                {
                    checkConn.Open();

                    using (SqlCommand checkCmd = new SqlCommand(checkS, checkConn))
                    {
                        checkCmd.Parameters.AddWithValue("@uid", UserHelper.UserId);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            // 学号已存在，可以进行更新操作
                            string updateQuery = "UPDATE [6_2_S] " +
                            "SET pwd = @pwd " + "WHERE uid = @uid";
                            using (SqlConnection updateconn = new SqlConnection(connString))
                            {
                                updateconn.Open();

                                using (SqlCommand cmd = new SqlCommand(updateQuery, updateconn))
                                {
                                    // 添加参数
                                    cmd.Parameters.AddWithValue("@pwd", pwd);
                                    cmd.Parameters.AddWithValue("@uid", UserHelper.UserId);


                                    // 执行更新操作
                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        if (textBox2.Text != null && textBox3.Text != null)
                                        {
                                            MessageBox.Show("密码修改成功！", "成功");
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
            else
            {
                label1.Visible = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
