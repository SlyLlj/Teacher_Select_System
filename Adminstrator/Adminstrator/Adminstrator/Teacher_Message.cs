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

namespace Adminstrator
{
    public partial class Teacher_Message : Form
    {
        public Teacher_Message()
        {
            InitializeComponent();
        }

        string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void 学号_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 导入_Click(object sender, EventArgs e)
        {

        }

        private void 研究方向_Click(object sender, EventArgs e)
        {

        }

        private void 联系电话_Click(object sender, EventArgs e)
        {

        }

        private void Teacher_Message_Load(object sender, EventArgs e)
        {

        }
        private void 导入数据_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string selectQueryTeaIn = "SELECT * FROM [6_2_T]"; // 从数据库中检索数据

                using (SqlCommand cmd = new SqlCommand(selectQueryTeaIn, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                }
            }
        }

        private void 添加信息_Click(object sender, EventArgs e)
        {

            using (SqlConnection checkConn = new SqlConnection(connString))
            {
                checkConn.Open();
                string insertQuery = "INSERT INTO [6_2_T] (t_uid, pwd, t_name, researchDir, email, tel, apart) VALUES (@t_uid, @pwd, @t_name, @researchDir, @email, @tel, @apart)";
                if (textBox3.Text != null)
                {
                    using (SqlCommand command = new SqlCommand(insertQuery, checkConn))
                    {
                        // 使用参数化查询以防止SQL注入
                        command.Parameters.AddWithValue("@t_uid", textBox3.Text);
                        command.Parameters.AddWithValue("@pwd", textBox9.Text);
                        command.Parameters.AddWithValue("@t_name", textBox4.Text);
                        command.Parameters.AddWithValue("@researchDir", textBox4.Text);
                        command.Parameters.AddWithValue("@email", textBox8.Text);
                        command.Parameters.AddWithValue("@tel", textBox7.Text);
                        command.Parameters.AddWithValue("@apart", textBox4.Text);

                        // 执行插入操作
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("已添加到数据库");
                    导入数据_Click_1(sender, e); // 调用导入数据的方法，更新 DataGridView
                }
                else
                {
                    MessageBox.Show("学号不能为空！");

                }
            }
        }

        private void 删除信息_Click(object sender, EventArgs e)
        {
            // 检查是否有选中的行
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 获取选中行的特定列的值，例如学号列
                string selectedteacherId = dataGridView1.SelectedRows[0].Cells["t_uid"].Value.ToString();

                // 执行删除操作
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // 替换成你的表名和条件
                    string deleteQuery = "DELETE FROM [6_2_T] WHERE t_uid = @SelectedteacherId";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SelectedteacherId", selectedteacherId);
                        command.ExecuteNonQuery();
                    }
                }

                // 删除完成后，重新加载数据以更新 DataGridView
                导入数据_Click_1(sender, e); // 调用导入数据的方法，更新 DataGridView
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("请先选中要删除的行！");
            }
        }

        private void 确认修改_Click(object sender, EventArgs e)
        {
            // 获取用户输入的学号
            string t_uid = textBox3.Text;
            string t_name = textBox4.Text;
            string researchDir = textBox6.Text;
            string email = textBox8.Text;
            string tel = textBox7.Text;
            string pwd = textBox9.Text;
            string apart = textBox5.Text;

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
                        string updateQuery = "UPDATE [6_2_T] " +
                        "SET t_uid = @t_uid, pwd = @pwd, t_name = @t_name, researchDir = @researchDir, " +
                        "apart = @apart, email = @email, tel = @tel ";
                        using (SqlConnection updateconn = new SqlConnection(connString))
                        {
                            updateconn.Open();

                            using (SqlCommand cmd = new SqlCommand(updateQuery, updateconn))
                            {
                                // 添加参数
                                cmd.Parameters.AddWithValue("@t_uid", t_uid);
                                cmd.Parameters.AddWithValue("@pwd", pwd);
                                cmd.Parameters.AddWithValue("@t_name", t_name);
                                cmd.Parameters.AddWithValue("@researchDir", researchDir);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@tel", tel);
                                cmd.Parameters.AddWithValue("@apart", apart);


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
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells.Count >= 7)
            {
                textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void 查询_Click(object sender, EventArgs e)
        {
            // 获取 TextBox 中的输入内容
            string t_name = textBox1.Text.Trim();
            string t_uid = textBox2.Text.Trim();

            // 进行数据库查询
            DataTable resultDataTable = PerformDatabaseSearch(t_uid);


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
                    string selectQuery = "SELECT * FROM [6_2_T] WHERE t_uid = @t_uid OR t_name = @t_name";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        // 添加参数
                        cmd.Parameters.AddWithValue("@t_name", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@t_uid", textBox2.Text.Trim());

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
