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

namespace Adminstrator
{
    public partial class Student_Message : Form
    {
        public Student_Message()
        {
            InitializeComponent();
        }
        private void Student_Message_Load(object sender, EventArgs e)
        {

        }

        string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

        private void 导入数据_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string selectQueryTeaIn = "SELECT * FROM [6_2_S]"; // 从数据库中检索数据

                using (SqlCommand cmd = new SqlCommand(selectQueryTeaIn, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                }
            }
        }

        private void 确认修改_Click(object sender, EventArgs e)
        {
            // 获取用户输入的学号
            string s_uid = textBox3.Text;
            string s_name = textBox4.Text;
            string sex = textBox5.Text;
            string grip = textBox6.Text;
            string academy = textBox10.Text;
            string major = textBox11.Text;
            string cla = textBox12.Text;
            string email = textBox14.Text;
            string tel = textBox13.Text;
            string pwd = textBox15.Text;

            string checkQuery = "SELECT COUNT(*) FROM [6_2_S]";
            using (SqlConnection checkConn = new SqlConnection(connString))
            {
                checkConn.Open();

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, checkConn))
                {
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        // 学号已存在，可以进行更新操作
                        string updateQuery = "UPDATE [6_2_S] " +
                        "SET s_uid = @s_uid, pwd = @pwd, s_name = @s_name, sex = @sex, academy = @academy, major = @major, " +
                        "cla = @cla, grip = @grip, email = @email, tel = @tel ";
                        using (SqlConnection updateconn = new SqlConnection(connString))
                        {
                            updateconn.Open();

                            using (SqlCommand cmd = new SqlCommand(updateQuery, updateconn))
                            {
                                // 添加参数
                                cmd.Parameters.AddWithValue("@s_uid", s_uid);
                                cmd.Parameters.AddWithValue("@pwd", pwd);
                                cmd.Parameters.AddWithValue("@s_name", s_name);
                                cmd.Parameters.AddWithValue("@sex", sex);
                                cmd.Parameters.AddWithValue("@academy", academy);
                                cmd.Parameters.AddWithValue("@major", major);
                                cmd.Parameters.AddWithValue("@cla", cla);
                                cmd.Parameters.AddWithValue("@grip", grip);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@tel", tel);

                                // 执行更新操作
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("数据已成功更新！", "成功");
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells.Count >= 10)
            {
                textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox11.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox12.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox14.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox13.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox15.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void 添加信息_Click(object sender, EventArgs e)
        {

            using (SqlConnection checkConn = new SqlConnection(connString))
            {
                checkConn.Open();
                string insertQuery = "INSERT INTO [6_2_S] (s_uid, pwd, s_name, sex, academy, major, cla, grip, email, tel) VALUES (@s_uid, @pwd, @s_name, @sex, @academy, @major, @cla, @grip, @email, @tel)";
                if (textBox3.Text != null)
                {
                    using (SqlCommand command = new SqlCommand(insertQuery, checkConn))
                    {
                        // 使用参数化查询以防止SQL注入
                        command.Parameters.AddWithValue("@s_uid", textBox3.Text);
                        command.Parameters.AddWithValue("@pwd", textBox15.Text);
                        command.Parameters.AddWithValue("@s_name", textBox4.Text);
                        command.Parameters.AddWithValue("@sex", textBox5.Text);
                        command.Parameters.AddWithValue("@academy", textBox10.Text);
                        command.Parameters.AddWithValue("@major", textBox11.Text);
                        command.Parameters.AddWithValue("@cla", textBox12.Text);
                        command.Parameters.AddWithValue("@grip", textBox6.Text);
                        command.Parameters.AddWithValue("@email", textBox14.Text);
                        command.Parameters.AddWithValue("@tel", textBox13.Text);
                        // 执行插入操作
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("已添加到数据库");
                    导入数据_Click(sender, e); // 调用导入数据的方法，更新 DataGridView
                }
                else
                {
                    MessageBox.Show("学号不能为空！");

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 删除信息_Click(object sender, EventArgs e)
        {
            // 检查是否有选中的行
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 获取选中行的特定列的值，例如学号列
                string selectedStudentId = dataGridView1.SelectedRows[0].Cells["s_uid"].Value.ToString();

                // 执行删除操作
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // 替换成你的表名和条件
                    string deleteQuery = "DELETE FROM [6_2_S] WHERE s_uid = @SelectedStudentId";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SelectedStudentId", selectedStudentId);
                        command.ExecuteNonQuery();
                    }
                }

                // 删除完成后，重新加载数据以更新 DataGridView
                导入数据_Click(sender, e); // 调用导入数据的方法，更新 DataGridView
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("请先选中要删除的行！");
            }
        }

        private void 查询_Click(object sender, EventArgs e)
        {
            // 获取 TextBox 中的输入内容
            string s_name = textBox1.Text.Trim();
            string s_uid = textBox2.Text.Trim();

            // 进行数据库查询
            DataTable resultDataTable = PerformDatabaseSearch(s_uid);


            // 将保存的选中行列表作为数据源设置给 dataGridView2
            dataGridView1.DataSource = resultDataTable;
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
                    string selectQuery = "SELECT * FROM [6_2_S] WHERE s_uid = @s_uid OR s_name = @s_name";
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
    }
}
