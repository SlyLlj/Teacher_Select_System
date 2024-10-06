using Adminstrator;
using student;

namespace Adminstrator
{
    public partial class administrator : Form
    {
        public administrator()
        {
            InitializeComponent();
        }
        private void hideSubMenu()
        {
            if (panelxx.Visible == true)
            { panelxx.Visible = false; }
        }
        private void showSubMenu(Panel xx)
        {
            if (xx.Visible == false)
            {
                hideSubMenu();
                xx.Visible = true;
            }
            else
                xx.Visible = false;
        }
        /*        private void hideSubMenu()
                {
                    if (panelxtpz.Visible == true)
                    { panelxtpz.Visible = false; }
                }
                private void showSubMenu(Panel pz)
                {
                    if (pz.Visible == false)
                    {
                        hideSubMenu();
                        pz.Visible = true;
                    }
                    else
                        pz.Visible = false;
                }*/
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 教师信息_Click(object sender, EventArgs e)
        {
            openChildForm(new Teacher_Message());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 系统配置_Click(object sender, EventArgs e)
        {
            openChildForm(new System_Configuration());
        }
        /* private void 分配规则_Click(object sender, EventArgs e)
         {

         }

         private void 截止时间_Click(object sender, EventArgs e)
         {

         }
 */
        private void 分配_Click(object sender, EventArgs e)
        {
            openChildForm(new Assign());
        }

        private void panelpz_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelxx_Paint(object sender, PaintEventArgs e)
        {

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

        private void 信息导入与修改_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelxx);
        }

        private void 学生信息_Click(object sender, EventArgs e)
        {
            openChildForm(new Student_Message());
        }

        private void 管理员端_Click(object sender, EventArgs e)
        {

        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 登出_Click(object sender, EventArgs e)
        {
            LoginA login = new LoginA();
            login.Show();

            this.Hide();
        }
    }
}