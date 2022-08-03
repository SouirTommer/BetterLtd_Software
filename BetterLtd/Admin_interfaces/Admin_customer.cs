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

namespace BetterLtd
{
    public partial class gender_label : Form
    {
        customer model = new customer();

        public gender_label()
        {
            InitializeComponent();
            btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            btn_back.BackColorChanged += (s, e) =>
            {
                btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            };
        }

        private void Admin_customer_Load(object sender, EventArgs e)
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
                Customer_View.DataSource = db.customers.Where(x=> x.isValid==0).ToList<customer>();
            }
        }

        void Clear()
        {
            btn_del.BackColor = Color.Gray;
            txt_fname.Text = txt_lname.Text = txt_custel.Text = txt_cusaddress.Text = "";
            cbx_M.Checked = cbx_F.Checked = false;
            btn_add.Text = "Add";
            btn_del.Enabled = false;
            model.CustomerID = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text == "" || txt_lname.Text == "" || txt_custel.Text == "" || txt_cusaddress.Text == "" || (cbx_M.Checked == false && cbx_F.Checked ==false))
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

            using (betterltdEntities db = new betterltdEntities())
            {
                if (model.CustomerID == 0)
                    db.customers.Add(model);
                else
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            populate_dgv();
            MessageBox.Show("Successfully Update");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin_menu ad = new Admin_menu();
            ad.Show();
            this.Hide();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirmed to delete this record?", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (betterltdEntities db = new betterltdEntities())
                {
                    try
                    {
                        model.isValid = 1;
                        db.Entry(model).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Customer Record Deleted Successfully");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Item Can not be deleted. Their are existing selling products of this Supplier");
                    }

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

                    if(model.Gender == "M")
                    {
                        cbx_M.Checked = true;
                    }
                    else
                    {
                        cbx_F.Checked = true;
                    }

                }
                btn_add.Text = "Update";
                btn_del.Enabled = true;
                btn_del.BackColor = btn_add.BackColor;

            }
        }

       

        private void txt_custel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                Customer_View.DataSource = betterltd.customers.Where(i => i.CustomerID.ToString().Contains(keyword)
                                            || i.FirstName.Contains(keyword)
                                            || i.LastName.Contains(keyword)
                                            || i.Gender.Contains(keyword)
                                            || i.CustomerTel.ToString().Contains(keyword)
                                            || i.Address.Contains(keyword)
                                            || i.RegDate.ToString().Contains(keyword)).ToList();

            }
        }

        private void img_search_Click(object sender, EventArgs e)
        {

        }
    }
}
