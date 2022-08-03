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
    public partial class Login : Form
    {
        public static string login_user;
        public static string username;
        public static int staffTel;
        public static int manager=0;
        public static string password;
        public static bool staylog=false;

        public static bool ischinese = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            
            
            if (UserID_text.Text == "" || Password_text.Text == "")
            {
                MessageBox.Show("Empty UserID / Password");
                return;
            }
            try {
            using (betterltdEntities content = new betterltdEntities())
            {
                Boolean msg = true;
                int logid = int.Parse(UserID_text.Text);

                acc id = content.accs.SingleOrDefault(i => i.accid == logid && i.isValid == 0 && i.Pwd == Password_text.Text);
                staff sf = content.staffs.SingleOrDefault(i => i.StaffID == logid && i.Position == "Retail");

                if (id != null && sf != null)
                {
                    manager = sf.isManager;
                    login_user = UserID_text.Text;
                    password = Password_text.Text;
                    staffTel = sf.StaffTel;
                    username = sf.FirstName + " "+ sf.LastName;
                    msg = false;
                    retail rt = new retail();
                    rt.Show();
                    this.Hide();
                }

                sf = content.staffs.SingleOrDefault(i => i.StaffID == logid && i.Position == "Tech Support");
                if (id != null && sf != null)
                {
                    manager = sf.isManager;
                    login_user = UserID_text.Text;
                    password = Password_text.Text;
                    staffTel = sf.StaffTel;
                    username = sf.FirstName + " " + sf.LastName;
                    msg = false;
                    new Tech_supp().Show();
                    this.Hide();
                }

                sf = content.staffs.SingleOrDefault(i => i.StaffID == logid && i.Position == "Inventory");
                if (id != null && sf != null)
                {
                    manager = sf.isManager;
                    login_user = UserID_text.Text;
                    password = Password_text.Text;
                    staffTel = sf.StaffTel;
                    username = sf.FirstName + " " + sf.LastName;
                    msg = false;
                    inventory inv = new inventory();
                    inv.Show();
                    this.Hide();
                }

           
                sf = content.staffs.SingleOrDefault(i => i.StaffID == logid && i.Position == "Purchase");
                if (id != null && sf != null)
                {
                    manager = sf.isManager;
                    login_user = UserID_text.Text;
                    password = Password_text.Text;
                    staffTel = sf.StaffTel;
                    username = sf.FirstName + " "+ sf.LastName;
                    msg = false;
                    purchase pc = new purchase();
                    pc.Show();
                    this.Hide();
                }

                sf = content.staffs.SingleOrDefault(i => i.StaffID == logid && i.Position == "Accounting");
                if (id != null && sf != null)
                {
                    manager = sf.isManager;
                    login_user = UserID_text.Text;
                    password = Password_text.Text;
                    staffTel = sf.StaffTel;
                    username = sf.FirstName + " " + sf.LastName;
                    msg = false;
                    accounting pc = new accounting();
                    pc.Show();
                    this.Hide();
                }

                if (msg == true)
                {
                    MessageBox.Show("Wrong User ID / Password "); ;
                }


            }
            }catch (Exception)
            {
                MessageBox.Show("Database cannot connect");
            }
        }

        private void Admin_login_button_Click(object sender, EventArgs e)
        {
            try {
            using (betterltdEntities content = new betterltdEntities())
            {
                if (UserID_text.Text == "" || Password_text.Text == "")
                {
                    MessageBox.Show("Empty  UserID / Password");
                    return;
                }
                Boolean msg = true;
                int logid = int.Parse(UserID_text.Text);
                acc id = content.accs.SingleOrDefault(i => i.accid == logid && i.Pwd == Password_text.Text && i.isValid== 0);
                staff sf = content.staffs.SingleOrDefault(i => i.StaffID == logid && i.isAdmin == 1);

                if (id != null && sf != null)
                {
                    login_user = UserID_text.Text;
                    password = Password_text.Text;
                    staffTel = sf.StaffTel;
                    username = sf.FirstName + " " +sf.LastName;
                    msg = false;
                    Admin_menu ad = new Admin_menu();
                    ad.Show();
                    this.Hide();
                }
                if (msg == true)
                {
                    MessageBox.Show("Wrong User ID / Password ");
                }
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Database cannot connect");
            }
        }


        private void checkbox_show_pw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_show_pw.Checked)
            {
                Password_text.PasswordChar = '\0';
            }
            else
            {
                Password_text.PasswordChar = '•';
            }
        }
       

        private void UserID_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserID_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (staylog && (login_user != null))
            {
                UserID_text.Text = login_user;
                Password_text.Text = password;
            }
        }

        private void btn_retail_Click(object sender, EventArgs e)
        {
            login_user = "1000";
            username = "Admin";
            new retail().Show();
            this.Hide();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            login_user = "1000";
            username = "Admin";
            new inventory().Show();
            this.Hide();
        }

        private void btn_tech_Click(object sender, EventArgs e)
        {
            login_user = "1000";
            username = "Admin";
            new Tech_supp().Show();
            this.Hide();
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            login_user = "1000";
            username = "Admin";
            new purchase().Show();
            this.Hide();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            login_user = "1000";
            username = "Admin";
            new Admin_menu().Show();
            this.Hide();
        }

        private void cbx_staylog_CheckedChanged(object sender, EventArgs e)
        {

            if (cbx_staylog.Checked == true)
            {
                staylog = true;
            }
            else
            {
                staylog = false;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            new accounting().Show();
        }

        private void switch_lang_Click(object sender, EventArgs e)
        {
            if (ischinese)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                ischinese = false;
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
                ischinese = true;
            }
            this.Controls.Clear();
            InitializeComponent();
        }
        public static void check_lang()
        {
            if (Login.ischinese == true)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            }
        }
    }
}
