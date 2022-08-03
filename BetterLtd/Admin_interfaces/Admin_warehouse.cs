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

namespace BetterLtd.Admin_interfaces
{
    public partial class Admin_warehouse : Form
    {
        warehouse model = new warehouse();
        public Admin_warehouse()
        {
            InitializeComponent();
            btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            btn_back.BackColorChanged += (s, e) => {
                btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            };
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            Admin_menu ad = new Admin_menu();
            ad.Show();
            this.Hide();
        }

        private void Admin_warehouse_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();
            Login.check_lang();
        }

        void populate_dgv()
        {
            Warehouse_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                Warehouse_View.DataSource = db.warehouses.Where(x=> x.isValid==0).ToList<warehouse>();
            }
        }

        void Clear()
        {
            btn_del.BackColor = Color.Gray;
            txt_whname.Text = txt_city.Text = txt_region.Text = txt_whaddress.Text = "";
            btn_add.Text = "Add";
            btn_del.Enabled = false;
            model.warehouseID = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_whname.Text == "" || txt_city.Text == "" || txt_region.Text == "" || txt_whaddress.Text == "")
            {
                MessageBox.Show("You must enter all information");
                return;
            }
            model.warehouseName = txt_whname.Text.Trim();
            model.City = txt_city.Text.Trim();
            model.Region = txt_region.Text.Trim();
            model.Address = txt_whaddress.Text.Trim();

            using (betterltdEntities db = new betterltdEntities())
            {
                if (model.warehouseID == 0)
                    db.warehouses.Add(model);
                else
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }

            Clear();
            populate_dgv();
            MessageBox.Show("Successfully Update");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirmed to delete this record?", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (betterltdEntities db = new betterltdEntities())
                {
                    model.isValid = 1;
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Warehouse Record Deleted Successfully");

                    Clear();
                    populate_dgv();
                }
        }

        private void Warehouse_View_DoubleClick(object sender, EventArgs e)
        {
            if (Warehouse_View.CurrentRow.Index != -1)
            {
                model.warehouseID = Convert.ToInt32(Warehouse_View.CurrentRow.Cells["WarehouseID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.warehouses.Where(i => i.warehouseID == model.warehouseID).FirstOrDefault();
                    txt_whname.Text = model.warehouseName;
                    txt_city.Text = model.City;
                    txt_region.Text = model.Region;
                    txt_whaddress.Text = model.Address;

                }
                btn_add.Text = "Update";
                btn_del.Enabled = true;
                btn_del.BackColor = btn_add.BackColor;

            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                Warehouse_View.DataSource = betterltd.warehouses.Where(i => i.warehouseID.ToString().Contains(keyword)
                                            || i.warehouseName.Contains(keyword)
                                            || i.City.Contains(keyword)
                                            || i.Region.Contains(keyword)
                                            || i.Address.Contains(keyword)).ToList();
            }
        }
    }
}
