using student;
using Student;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";

        private void hideSubMenu()
        {
            if (paneljgcx.Visible == true)
            { paneljgcx.Visible = false; }
        }
        private void showSubMenu(Panel jgcx)
        {
            if (jgcx.Visible == false)
            {
                hideSubMenu();
                jgcx.Visible = true;
            }
            else
                jgcx.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 学生端_Click(object sender, EventArgs e)
        {

        }

        private void 学生端_Click_1(object sender, EventArgs e)
        {

        }

        private void 登出_Click(object sender, EventArgs e)
        {
            loginS loginS = new loginS();
            loginS.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Team_Results());
        }

        private void 个人信息_Click(object sender, EventArgs e)
        {
            openChildForm(new Personal_Information());
        }



        private void jgcx_Click(object sender, EventArgs e)
        {
            showSubMenu(paneljgcx);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Volunteer_Results());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            openChildForm(new Team());
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelmain.Controls.Add(childForm);
            panelmain.Tag = childForm;
            childForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
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
                            string LeaderUid = reader["LeaderUid"].ToString();
                            if (UserHelper.UserId == LeaderUid)
                            {
                                openChildForm(new Stu_Volunteer());
                            }
                            else
                            {
                                MessageBox.Show("您不是组长不可填写志愿！");
                            }
                        }
                    }
                }

            }
            
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 修改密码_Click(object sender, EventArgs e)
        {
            openChildForm(new Change_Password());
        }
    }
}