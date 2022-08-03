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

namespace BetterLtd.Retail_tab
{
    public partial class choose_customer : Form
    {

        customer cus = new customer();

        public choose_customer()
        {
            InitializeComponent();
        }

        private void choose_customer_Load(object sender, EventArgs e)
        {
            using (var db = new betterltdEntities())
            {
                dgv_cc.DataSource = db.customers.Where(i => i.isValid == 0)
                                                .Select(i => new {i.CustomerID, i.LastName , i.CustomerTel }).ToList();
            }
            Login.check_lang();
        }

        private void dgv_cc_DoubleClick(object sender, EventArgs e)
        {
            cus.CustomerID = Convert.ToInt32(dgv_cc.CurrentRow.Cells[0].Value);

            using (var db = new betterltdEntities())
            {
                cus = db.customers.Where(i => i.CustomerID == cus.CustomerID).FirstOrDefault();
                txt_cusid.Text = db.customers.Where(i => i.CustomerID == cus.CustomerID).Select(i => i.CustomerID.ToString()).FirstOrDefault();
            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                dgv_cc.DataSource = betterltd.customers.Where(i => i.CustomerID.ToString().Contains(keyword)
                                            || i.LastName.Contains(keyword)
                                            || i.CustomerTel.ToString().Contains(keyword))
                                            .Select(i => new { i.CustomerID, i.LastName, i.CustomerTel }).ToList();

            }
        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer cus = new Customer();
            cus.Show();
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            confirm_order co = (confirm_order)Application.OpenForms["confirm_order"];
            TextBox tb = (TextBox)co.Controls["txt_cusid"];
            tb.Text = cus.CustomerID.ToString();
            this.Hide();
        }

        private void lbl_choosecus_Click(object sender, EventArgs e)
        {

        }
    }
}
