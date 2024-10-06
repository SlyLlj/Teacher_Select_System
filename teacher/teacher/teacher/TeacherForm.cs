using System.Data.SqlClient;
namespace teacher
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }
        string connString = "server=bzmtxh.top,2433;database=Assign2021;uid=stu;pwd=12344321";
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
            openChildForm(new Tea_Volunteer());
        }

        private void 个人信息_Click(object sender, EventArgs e)
        {
            openChildForm(new Personal_Information());
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void jgcx_Click(object sender, EventArgs e)
        {
            openChildForm(new result());
        }

        private void 修改密码_Click(object sender, EventArgs e)
        {
            openChildForm(new Change_Password());
        }

        private void 登出_Click(object sender, EventArgs e)
        {
            loginT login = new loginT();
            this.Hide();

            login.Show();
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 学生端_Click(object sender, EventArgs e)
        {

        }
    }
}