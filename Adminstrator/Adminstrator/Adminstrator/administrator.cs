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

        private void ��ʦ��Ϣ_Click(object sender, EventArgs e)
        {
            openChildForm(new Teacher_Message());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ϵͳ����_Click(object sender, EventArgs e)
        {
            openChildForm(new System_Configuration());
        }
        /* private void �������_Click(object sender, EventArgs e)
         {

         }

         private void ��ֹʱ��_Click(object sender, EventArgs e)
         {

         }
 */
        private void ����_Click(object sender, EventArgs e)
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

        private void ��Ϣ�������޸�_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelxx);
        }

        private void ѧ����Ϣ_Click(object sender, EventArgs e)
        {
            openChildForm(new Student_Message());
        }

        private void ����Ա��_Click(object sender, EventArgs e)
        {

        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void �ǳ�_Click(object sender, EventArgs e)
        {
            LoginA login = new LoginA();
            login.Show();

            this.Hide();
        }
    }
}