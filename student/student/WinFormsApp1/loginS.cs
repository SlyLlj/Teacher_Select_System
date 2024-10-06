using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using System.Data.SqlClient;
using Student;

namespace student
{
    public partial class loginS : Form
    {
        public loginS()
        {
            InitializeComponent();
        }

        private void loginS_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (UidTextBox.Text.Trim() == "" || pwdTextBox.Text.Trim() == "")
            {
                Console.WriteLine("用户名或密码为空");
                MessageBox.Show("用户名或密码不能为空！");
                UidTextBox.Focus();
                return;
            }

            string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

            string sqlStr = string.Format("select * from [6_2_S] where s_uid='{0}' and pwd='{1}'", UidTextBox.Text.Trim(), pwdTextBox.Text.Trim());

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
                            UserHelper.UserId = UidTextBox.Text.Trim();
                            UserHelper.Passward = pwdTextBox.Text.Trim();
                            this.Hide();
                            StudentForm student = new StudentForm();
                            student.Show();
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误,请重新输入!", "错误");
                            UidTextBox.Text = "";
                            pwdTextBox.Text = "";
                            UidTextBox.Focus();
                        }
                    }
                }
            }


        }



        private void UidTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
