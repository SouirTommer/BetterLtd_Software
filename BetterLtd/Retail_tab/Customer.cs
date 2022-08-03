using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Threading;

namespace BetterLtd.Retail_tab
{
    public partial class Customer : Form
    {
        customer model = new customer();
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();

            Login.check_lang();
        }

        void populate_dgv()
        {
            Customer_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                Customer_View.DataSource = db.customers.Where(x => x.isValid == 0).ToList<customer>();
            }
        }

        void Clear()
        {
            txt_fname.Text = txt_lname.Text = txt_custel.Text = txt_cusaddress.Text = "";
            cbx_M.Checked = cbx_F.Checked = false;
            btn_add.Text = "Add";
            model.CustomerID = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text == "" || txt_lname.Text == "" || txt_custel.Text == "" || txt_cusaddress.Text == "" || (cbx_M.Checked == false && cbx_F.Checked == false))
            {
                MessageBox.Show("You must enter all information");
                return;
            }
            model.FirstName = txt_fname.Text.Trim();
            model.LastName = txt_lname.Text.Trim();
            model.CustomerTel = Convert.ToInt32(txt_custel.Text.Trim());
            model.Address = txt_cusaddress.Text.Trim();
            model.RegDate = DateTime.Today;

            if (cbx_M.Checked == true)
            {
                model.Gender = "M";
            }
            else
            {
                model.Gender = "F";
            }

            try
            {
                using (betterltdEntities db = new betterltdEntities())
                {
                    if (model.CustomerID == 0)
                        db.customers.Add(model);
                    else
                        db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }
                MessageBox.Show("Successfully Update");
            }
            catch (Exception)
            {
                MessageBox.Show("Date input invalid");
            }
            finally
            {
                Clear();
                populate_dgv();
            }
        }

        private void Customer_View_DoubleClick(object sender, EventArgs e)
        {
            if (Customer_View.CurrentRow.Index != -1)
            {
                model.CustomerID = Convert.ToInt32(Customer_View.CurrentRow.Cells["CustomerID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.customers.Where(i => i.CustomerID == model.CustomerID).FirstOrDefault();
                    txt_fname.Text = model.FirstName;
                    txt_lname.Text = model.LastName;
                    txt_custel.Text = model.CustomerTel.ToString();
                    txt_cusaddress.Text = model.Address;

                    if (model.Gender == "M")
                    {
                        cbx_M.Checked = true;
                    }
                    else
                    {
                        cbx_F.Checked = true;
                    }

                }
                btn_add.Text = "Update";
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            string keyword = txt_search.Text;

            using (var betterltd = new betterltdEntities())
            {

                Customer_View.DataSource = betterltd.customers.Where(i => i.CustomerID.ToString().Contains(keyword)
                                            || i.FirstName.Contains(keyword)
                                            || i.LastName.Contains(keyword)
                                            || i.Gender.Contains(keyword)
                                            || i.CustomerTel.ToString().Contains(keyword)
                                            || i.Address.Contains(keyword)
                                            || i.RegDate.ToString().Contains(keyword)).ToList();

            }
        }
    }
}

