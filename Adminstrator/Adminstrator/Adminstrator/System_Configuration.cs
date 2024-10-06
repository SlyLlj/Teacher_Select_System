using System;
using System.CodeDom.Compiler;
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
    public partial class System_Configuration : Form
    {
        public System_Configuration()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void 提交日期_Click(object sender, EventArgs e)
        {
            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            // 获取 TextBox 和 DateTimePicker 中的数据
            string grade = textBox1.Text.Trim();
            string major = 专业选择.Text.Trim();
            DateTime studdl = dateTimePicker1.Value;
            DateTime teaddl = dateTimePicker2.Value;

            // 连接数据库
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // 构造查询是否存在的 SQL 语句
                string checkExistQuery = "SELECT COUNT(*) FROM [6_2_Time] WHERE grip = @grade AND major = @major";

                // 使用 SqlCommand 执行查询
                using (SqlCommand checkExistCmd = new SqlCommand(checkExistQuery, conn))
                {
                    // 添加参数
                    checkExistCmd.Parameters.AddWithValue("@grade", grade);
                    checkExistCmd.Parameters.AddWithValue("@major", major);

                    // 执行查询
                    int count = Convert.ToInt32(checkExistCmd.ExecuteScalar());
                    if (grade != null && major != null)
                    {
                        // 判断是否存在记录
                        if (count > 0)
                        {
                            // 如果记录存在，构造更新数据的 SQL 语句
                            string updateQuery = "UPDATE [6_2_Time] SET studdl = @studdl, teaddl = @teaddl WHERE grip = @grade AND major = @major";

                            // 使用 SqlCommand 执行更新操作
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                // 添加参数
                                updateCmd.Parameters.AddWithValue("@grade", grade);
                                updateCmd.Parameters.AddWithValue("@major", major);
                                updateCmd.Parameters.AddWithValue("@studdl", studdl);
                                updateCmd.Parameters.AddWithValue("@teaddl", teaddl);

                                // 执行更新操作
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // 如果记录不存在，构造插入数据的 SQL 语句
                            string insertQuery = "INSERT INTO [6_2_Time] (grip, major, studdl, teaddl) VALUES (@grade, @major, @studdl, @teaddl)";

                            // 使用 SqlCommand 执行插入操作
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                            {
                                // 添加参数
                                insertCmd.Parameters.AddWithValue("@grade", grade);
                                insertCmd.Parameters.AddWithValue("@major", major);
                                insertCmd.Parameters.AddWithValue("@studdl", studdl);
                                insertCmd.Parameters.AddWithValue("@teaddl", teaddl);

                                // 执行插入操作
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            MessageBox.Show("日期设置成功！", "成功");
        }
    }
}
