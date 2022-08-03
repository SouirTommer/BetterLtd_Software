using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BetterLtd
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void profile_Load(object sender, EventArgs e)
        {
            label4.Text = Login.username + "'s profile \n userid:"+Login.login_user;
            pwd_text.Text = Login.password;
            tel_text.Text = Login.staffTel.ToString();
            Login.check_lang();

        }

        private void tel_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (pwd_text.Text == "" || repwd_text.Text == "" || tel_text.Text == "")
            {
                MessageBox.Show("You must enter all information");
                return;
            }
            if (pwd_text.Text != repwd_text.Text)
            {
                MessageBox.Show("Password not match!");
                return;
            }

            using (betterltdEntities content = new betterltdEntities())
            {
                int logid = Convert.ToInt32(Login.login_user);
                acc a = content.accs.SingleOrDefault(i => i.accid == logid);
                staff b = content.staffs.SingleOrDefault(i => i.StaffID == logid);
                if (a != null && b != null)
                {
                    a.Pwd = pwd_text.Text;
                    b.StaffTel = Convert.ToInt32(tel_text.Text);
                    content.SaveChanges();
                }
            }
            MessageBox.Show("Successfully Save");
        }
    }
}
