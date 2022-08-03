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
    public partial class Admin_supplier : Form
    {
        supplier model = new supplier();

        public Admin_supplier()
        {
            InitializeComponent();
            btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            btn_back.BackColorChanged += (s, e) => {
                btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            };
        }

        private void Admin_supplier_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();

            Login.check_lang();
        }

        void populate_dgv()
        {
            Supp_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                Supp_View.DataSource = db.suppliers.Where(x=>x.isValid ==0).ToList<supplier>();
            }
        }

        void Clear()
        {
            btn_del.BackColor = Color.Gray;
            txt_supaddress.Text = txt_supemail.Text = txt_suptel.Text = txt_supname.Text = "";
            btn_add.Text = "Add";
            btn_del.Enabled = false;
            model.SupID = 0;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin_menu ad = new Admin_menu();
            ad.Show();
            this.Hide();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                Supp_View.DataSource = betterltd.suppliers.Where(i => i.SupID.ToString().Contains(keyword)
                                            || i.SupName.Contains(keyword)
                                            || i.SupTel.ToString().Contains(keyword)
                                            || i.Supemail.Contains(keyword)
                                            || i.Address.Contains(keyword)).ToList();

            }
        }

 

        private void txt_suptel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_supemail_Leave(object sender, EventArgs e)
        {
            if (!this.txt_supemail.Text.Contains('@') || !this.txt_supemail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //CRUD FUNCTION STARTS FROM HERE

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_supname.Text == "" || txt_suptel.Text == "" || txt_supemail.Text == "" || txt_supaddress.Text == "")
            {
                MessageBox.Show("You must enter all information");
                return;
            }
            model.SupName = txt_supname.Text.Trim();
            model.SupTel = Convert.ToInt32(txt_suptel.Text.Trim());
            model.Supemail = txt_supemail.Text.Trim();
            model.Address = txt_supaddress.Text.Trim();

            using (betterltdEntities db = new betterltdEntities())
            {
                if (model.SupID == 0)
                    db.suppliers.Add(model);
                else
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            populate_dgv();
            MessageBox.Show("Successfully Update");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
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
                        MessageBox.Show("Supplier Record Deleted Successfully");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Item Can not be deleted. Their are existing selling products of this Supplier");
                    }

                    Clear();

                    populate_dgv();
                }
        }

        private void Supp_View_DoubleClick(object sender, EventArgs e)
        {
            if (Supp_View.CurrentRow.Index != -1)
            {
                model.SupID = Convert.ToInt32(Supp_View.CurrentRow.Cells["SupID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.suppliers.Where(i => i.SupID == model.SupID).FirstOrDefault();
                    txt_supname.Text = model.SupName;
                    txt_suptel.Text = model.SupTel.ToString();
                    txt_supemail.Text = model.Supemail;
                    txt_supaddress.Text = model.Address;

                }
                btn_add.Text = "Update";
                btn_del.Enabled = true;
                btn_del.BackColor = btn_add.BackColor;

            }
        }

        private void Supp_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_suptel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_supemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
