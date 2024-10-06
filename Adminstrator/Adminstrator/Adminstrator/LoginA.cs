using Adminstrator;
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
using Adminstrator;

namespace student
{
    public partial class LoginA : Form
    {
        public LoginA()
        {
            InitializeComponent();
        }

        private void 学生端登录页面_Click(object sender, EventArgs e)
        {

        }

        private void 登录_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                Console.WriteLine("用户名或密码为空");
                MessageBox.Show("用户名或密码不能为空！");
                textBox1.Focus();
                return;
            }

            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            string sqlStr = string.Format("select * from [6_2_A] where a_uid='{0}' and pwd='{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            Console.WriteLine("登录成功");
                            UserHelper.UserId = textBox1.Text.Trim();
                            UserHelper.Passward = textBox2.Text.Trim();
                            this.Hide();
                            administrator Administrator = new administrator();
                            Administrator.Show();
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误,请重新输入!", "错误");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox1.Focus();
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
