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
    public partial class Admin_retail : Form
    {
        retailstore model = new retailstore();

        public Admin_retail()
        {
            InitializeComponent();
            btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            btn_back.BackColorChanged += (s, e) => {
                btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            };
        }

        private void Admin_retail_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();
            Login.check_lang();
        }

        void populate_dgv()
        {
            Store_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                Store_View.DataSource = db.retailstores.Where(x=> x.isValid ==0).ToList<retailstore>();
            }
        }

        void Clear()
        {
            btn_del.BackColor = Color.Gray;
            txt_storename.Text =txt_city.Text = txt_region.Text = txt_storeaddress.Text = "";
            btn_add.Text = "Add";
            btn_del.Enabled = false;
            model.StoreID = 0;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin_menu ad = new Admin_menu();
            ad.Show();
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }


        //CRUD FUNCTION STARTS FROM HERE

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_storename.Text == "" || txt_city.Text == "" || txt_region.Text == "" || txt_storeaddress.Text == "")
            {
                MessageBox.Show("You must enter all information");
                return;
            }
            model.StoreName = txt_storename.Text.Trim();
            model.City = txt_city.Text.Trim();
            model.Region = txt_region.Text.Trim();
            model.Address = txt_storeaddress.Text.Trim();

            using (betterltdEntities db = new betterltdEntities())
            {
                if (model.StoreID == 0)
                    db.retailstores.Add(model);
                else
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }

            Clear();
            populate_dgv();
            MessageBox.Show("Successfully Update");
        }


        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                Store_View.DataSource = betterltd.retailstores.Where(i => i.StoreID.ToString().Contains(keyword)
                                            || i.StoreName.Contains(keyword)
                                            || i.City.Contains(keyword)
                                            || i.Region.Contains(keyword)
                                            || i.Address.Contains(keyword)).ToList();
            }
        }

        private void Store_View_DoubleClick(object sender, EventArgs e)
        {
            if (Store_View.CurrentRow.Index != -1)
            {
                model.StoreID = Convert.ToInt32(Store_View.CurrentRow.Cells["StoreID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.retailstores.Where(i => i.StoreID == model.StoreID).FirstOrDefault();
                    txt_storename.Text = model.StoreName;
                    txt_city.Text = model.City;
                    txt_region.Text = model.Region;
                    txt_storeaddress.Text = model.Address;

                }
                btn_add.Text = "Update";
                btn_del.Enabled = true;
                btn_del.BackColor = btn_add.BackColor;

            }
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
                        MessageBox.Show("Retail Store Record Deleted Successfully");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Item Can not be deleted.");
                    }

                    Clear();
                    populate_dgv();
                }
        }
    }
}
