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
    public partial class Admin_interface : Form
    {
        public Admin_interface()
        {
            InitializeComponent();
        }

        private void btn_retail_Click(object sender, EventArgs e)
        {
            Login.manager = 1;
            new retail().Show();
            this.Hide();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            Login.manager = 1;
            new inventory().Show();
            this.Hide();
        }

        private void btn_tech_Click(object sender, EventArgs e)
        {
            Login.manager = 1;
            new Tech_supp().Show();
            this.Hide();
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            Login.manager = 1;
            new purchase().Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new Admin_menu().Show();
            this.Hide();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            new accounting().Show();
            this.Hide();
        }

        private void Admin_interface_Load(object sender, EventArgs e)
        {
            Login.check_lang();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
