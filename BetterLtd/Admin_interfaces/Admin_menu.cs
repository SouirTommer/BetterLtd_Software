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
    public partial class Admin_menu : Form
    {
        public Admin_menu()
        {
            InitializeComponent();
        }

        private void Account_btn_Click(object sender, EventArgs e)
        {
            Admin_acc acc = new Admin_acc();
            acc.Show();
            this.Hide();
        }

        private void RetailStore_btn_Click(object sender, EventArgs e)
        {
            Admin_retail retail = new Admin_retail();
            retail.Show();
            this.Hide();
        }

        private void Product_btn_Click(object sender, EventArgs e)
        {
            Admin_product product = new Admin_product();
            product.Show();
            this.Hide();
        }

        private void Customer_btn_Click(object sender, EventArgs e)
        {
            gender_label cus = new gender_label();
            cus.Show();
            this.Hide();
        }



        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void Interface_btn_Click(object sender, EventArgs e)
        {
            Admin_interface ai = new Admin_interface();
            ai.Show();
            this.Hide();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            Admin_supplier sup = new Admin_supplier();
            sup.Show();
            this.Hide();
        }

        private void ActivityLog_btn_Click(object sender, EventArgs e)
        {
            ActivityLog al = new ActivityLog();
            al.Show();
            this.Hide();
        }

        private void Admin_menu_Load(object sender, EventArgs e)
        {
            label7.Text = Login.username;
            Login.check_lang();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            profile pf = new profile();
            pf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_interfaces.Admin_warehouse wh = new Admin_interfaces.Admin_warehouse();
            wh.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
