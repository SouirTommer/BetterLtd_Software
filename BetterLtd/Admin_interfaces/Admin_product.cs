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
    public partial class Admin_product : Form
    {
        product model = new product();

        public Admin_product()
        {
            InitializeComponent();
            btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            btn_back.BackColorChanged += (s, e) =>
            {
                btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            };
        }

        private void Admin_product_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();

            using (var betterltd = new betterltdEntities())
            {
                var suplist = betterltd.suppliers.Where(i => i.isValid == 0).Select(i => i.SupName);

                foreach (var sup in suplist)
                {
                    li_supname.Items.Add(sup);
                }
            }
            Login.check_lang();
        }

        void Clear()
        {
            btn_del.BackColor = Color.Gray;
            txt_pname.Text = li_brand.Text = li_prodtype.Text = li_supname.Text = "";
            num_price.Value = 0;
            btn_add.Text = "Add";
            btn_del.Enabled = false;
            model.prodID = 0;
        }

        void populate_dgv()
        {
            Product_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                Product_View.DataSource = db.products.Where(x=> x.isValid==0).ToList<product>();
            }
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

                Product_View.DataSource = betterltd.products.Where(i => i.prodID.ToString().Contains(keyword)
                                            || i.prodName.Contains(keyword)
                                            || i.SupID.ToString().Contains(keyword)
                                            || i.prodType.Contains(keyword)
                                            || i.Brand.Contains(keyword)
                                            || i.prodPrice.ToString().Contains(keyword)).ToList();

            }
        }

        //save
        private void price_numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as NumericUpDown).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (li_brand.Text == "" || li_supname.Text == "" || li_prodtype.Text == "" || txt_pname.Text == "" || num_price == null)
            {
                MessageBox.Show("You must enter all information");
                return;
            }
            model.Brand = li_brand.Text;
            model.prodName = txt_pname.Text.Trim();
            model.prodPrice = num_price.Value;
            model.prodType = li_prodtype.Text;
            var supname = li_supname.Text;


            using (betterltdEntities db = new betterltdEntities())
            {
                model.SupID = db.suppliers.Where(i => i.SupName.Contains(supname)).Select(i => i.SupID).FirstOrDefault();

                if (model.prodID == 0)
                    db.products.Add(model);
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
                        MessageBox.Show("Products Record Deleted Successfully");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Item Can not be deleted");
                    }

                    Clear();
                    populate_dgv();
                }
        }

        private void Product_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product_View_DoubleClick(object sender, EventArgs e)
        {

            if (Product_View.CurrentRow.Index != -1)
            {
                model.prodID = Convert.ToInt32(Product_View.CurrentRow.Cells["ProductID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.products.Where(i => i.prodID == model.prodID).FirstOrDefault();
                    li_supname.Text = db.suppliers.Where(i => i.SupID == model.SupID).Select(i => i.SupName).FirstOrDefault();
                    li_brand.Text = model.Brand;
                    li_prodtype.Text = model.prodType;
                    txt_pname.Text = model.prodName;
                    num_price.Value = model.prodPrice;

                }
                btn_add.Text = "Update";
                btn_del.Enabled = true;
                btn_del.BackColor = btn_add.BackColor;
            }
        }

        private void li_brand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void li_supname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void li_prodtype_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void num_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as NumericUpDown).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void li_supname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void li_brand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

