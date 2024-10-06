using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 忘记密码_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员\n电话号码：xxx");
        }
    }
}
