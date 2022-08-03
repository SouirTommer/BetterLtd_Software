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

namespace BetterLtd.Inventory_tab
{
    public partial class whstock : Form
    {
        warehouse_stock model = new warehouse_stock();
        warehouse_reorder model2 = new warehouse_reorder();
        activitylog actmodel = new activitylog();
        int warehouseID;
        public whstock()
        {
            InitializeComponent();
        }

        private void stock_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();
            if (Login.manager == 0)
            {
                delete_btn.Visible = false;
            }

            using (var betterltd = new betterltdEntities())
            {
                var whlist = betterltd.warehouses.Select(i => i.warehouseName);

                foreach (var st in whlist)
                {
                    li_warehouse.Items.Add(st);
                }
            }
            using (var betterltd = new betterltdEntities())
            {
                var whlist = betterltd.products.OrderBy(i => i.prodID).Select(i => i.prodID);

                foreach (var st in whlist)
                {
                    li_prod.Items.Add(st);
                }
            }
            Login.check_lang();

        }
        void Clear()
        {
            li_prod.SelectedItem = null;
            qty_text.Text = "";
            txt_dangelvl.Text = "";
            delete_btn.Enabled = false;
            update_btn.Enabled = false;
            btn_dangerlvl.Enabled = false;
            btn_dangerlvl.BackColor = Color.Gray;
            update_btn.BackColor = Color.Gray;
            delete_btn.BackColor = Color.Gray;
        }
        void populate_dgv()
        {
            Stock_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                Stock_View.DataSource = (from s in db.products
                                         join c in db.warehouse_stock on s.prodID equals c.prodID
                                         where c.warehouseID == warehouseID
                                         select new
                                         {
                                             s.prodID,
                                             s.Brand,
                                             s.prodType,
                                             s.prodName,
                                             s.prodPrice,
                                             c.lowlevel,                                             c.qty
                                         }).ToList();

            }
        }

        private void li_warehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                var result = betterltd.warehouses
                                    .Where(s => s.warehouseName == li_warehouse.Text)
                                    .Select(s => new { s.warehouseID }).FirstOrDefault();

                warehouseID = result.warehouseID;
            }
            MessageBox.Show("WarehouseID :" + Convert.ToString(warehouseID));
            populate_dgv();

            using (var betterltd = new betterltdEntities())
            {
                string alert ="";
                var stock_alert = betterltd.warehouse_stock
                                    .Where(d => d.warehouseID == warehouseID &&
                                    d.qty < d.lowlevel)
                                    .Select(d => d.prodID );
                    foreach (var q in stock_alert)
                    {
                        alert += q;
                        alert += "\n";
                    }

                if (alert.Contains("100"))
                {
                    MessageBox.Show("Suggested replenishment items:\n------\n"+ alert.ToString());
                }
            }
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
                using (var betterltd = new betterltdEntities())
                {
                    string keyword = txt_search.Text;
                    Stock_View.DataSource = (from s in betterltd.products
                                             join c in betterltd.warehouse_stock on s.prodID equals c.prodID
                                             where
                                             (c.warehouseID == warehouseID)
                                             &&
                                             (s.prodID.ToString().Contains(keyword)
                                             || s.prodName.Contains(keyword)
                                             || s.prodType.Contains(keyword)
                                             || s.prodPrice.ToString().Contains(keyword)
                                             || s.Brand.Contains(keyword)
                                             || c.qty.ToString().Contains(keyword))
                                             orderby s.prodID ascending
                                             select new
                                             {
                                                 s.prodID,
                                                 s.Brand,
                                                 s.prodType,
                                                 s.prodName,
                                                 s.prodPrice,
                                                 c.lowlevel,
                                                 c.qty
                                             }).ToList();
                }
        }
        

        private void li_prod_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
        }

        private void qty_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(li_warehouse.Text))
            {
                MessageBox.Show("Please choose a warehouse");
            }
            else if (string.IsNullOrEmpty(li_prod.Text))
            {
                MessageBox.Show("You must select a product");
            }
            else
            {
                using (betterltdEntities db = new betterltdEntities())
                {
                    model.warehouseID = warehouseID;
                    model.prodID = Int32.Parse(li_prod.Text);
                    model.qty = 0;

                    var category = db.products
                                    .Where(s => s.prodID == model.prodID)
                                    .Select(s => new { s.prodType }).FirstOrDefault();
                    model.category = category.prodType;
                    var brand = db.products
                                    .Where(d => d.prodID == model.prodID)
                                    .Select(d => new { d.Brand }).FirstOrDefault();
                    model.brand = brand.Brand;
                    actmodel.StaffID = Int32.Parse(Login.login_user);
                    actmodel.logType = "Add Item";
                    actmodel.Interface = "Inv.whstock";
                    actmodel.logDate = DateTime.Now;


                    var checking = db.warehouse_stock
                                    .Where(d => d.warehouseID == model.warehouseID &&
                                    d.prodID == model.prodID)
                                    .Select(d => new { d.prodID }).FirstOrDefault();


                    if (checking != null)
                    {
                        MessageBox.Show("This item exists");
                    }
                    else
                    {
                        db.activitylogs.Add(actmodel);
                        db.warehouse_stock.Add(model);
                        db.SaveChanges();
                        Clear();
                        populate_dgv();
                        MessageBox.Show("Successfully Update");
                    }

                }
            }

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {

            if (qty_text.Text == "")
            {
                MessageBox.Show("You must enter qty");
                return;
            }

            //if (model.qty < Int32.Parse(qty_text.Text))
            //{
            //    reStockmodel.StaffID = Int32.Parse(Login.login_user);
            //    reStockmodel.warehouseID = warehouseID;
            //    reStockmodel.prodID = model.prodID;
            //    reStockmodel.rece_qty = Int32.Parse(qty_text.Text) - model.qty;
            //    reStockmodel.dateCreated = DateTime.Now;


            //    using (betterltdEntities db = new betterltdEntities())
            //    {
            //        db.receiving_records.Add(reStockmodel);
            //        db.SaveChanges();
            //    }

            //}

            model.qty = Int32.Parse(qty_text.Text);
            actmodel.StaffID = Int32.Parse(Login.login_user);
            actmodel.logType = "Update";
            actmodel.Interface = "Inv.whstock";
            actmodel.logDate = DateTime.Now;

            using (betterltdEntities db = new betterltdEntities())
            {
                db.activitylogs.Add(actmodel);
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }

            Clear();
            populate_dgv();
            MessageBox.Show("Successfully Update");
            }catch (Exception)
            {
                MessageBox.Show("Sorry, your input is wrong");
            }

        }

        private void Stock_View_DoubleClick(object sender, EventArgs e)
        {
            if (Stock_View.CurrentRow.Index != -1)
            {

                model.prodID = Convert.ToInt32(Stock_View.CurrentRow.Cells["ProductID"].Value);
                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.warehouse_stock.Where(i => i.prodID == model.prodID && i.warehouseID == warehouseID).FirstOrDefault();
                    qty_text.Text = model.qty.ToString();
                    txt_dangelvl.Text = model.lowlevel.ToString();

                }
                btn_dangerlvl.Enabled = true;
                delete_btn.Enabled = true;
                update_btn.Enabled = true;
                btn_dangerlvl.BackColor = Color.Orange;
                update_btn.BackColor = Color.Orange;
                delete_btn.BackColor = Color.Orange;

            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirmed to delete this item?", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (betterltdEntities db = new betterltdEntities())
                {
                    actmodel.StaffID = Int32.Parse(Login.login_user);
                    actmodel.logType = "Delete";
                    actmodel.Interface = "Inv.whstock";
                    actmodel.logDate = DateTime.Now;


                    var entry = db.Entry(model);
                    db.activitylogs.Add(actmodel);
                    if (entry.State == EntityState.Detached)
                        db.warehouse_stock.Attach(model);
                    db.warehouse_stock.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Item Deleted Successfully");

                    Clear();
                    populate_dgv();
                }
        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var prodID = Stock_View.SelectedRows[0].Cells[0].Value;
                var ProductName = Stock_View.SelectedRows[0].Cells[3].Value;

                var index = this.reorderlist_dgv.Rows.Add();
                this.reorderlist_dgv.Rows[index].Cells[0].Value = prodID;
                this.reorderlist_dgv.Rows[index].Cells[1].Value = ProductName;
            }
            catch (Exception)
            {
                MessageBox.Show("Please select choice first");
            }
        }

        private void removeitem_btn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.reorderlist_dgv.SelectedRows)
                {
                    reorderlist_dgv.Rows.RemoveAt(item.Index);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select choice first");
            }
        }

        private void Stock_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void send_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(li_warehouse.Text))
            {
                MessageBox.Show("Please choose a warehouse");
            }
            else if (reorderlist_dgv.Rows.Count == 0)
            {
                MessageBox.Show("Reorder list is null");
            }
            else
            {
                for (int i = 0; i < reorderlist_dgv.Rows.Count; i++)
                {
                    model2.StaffID = Int32.Parse(Login.login_user);
                    model2.warehouseID = warehouseID;
                    model2.prodID = Int32.Parse(reorderlist_dgv.Rows[i].Cells[0].Value.ToString());
                    model2.prodName = reorderlist_dgv.Rows[i].Cells[1].Value.ToString();
                    model2.status = "Pending";
                    model2.createDate = System.DateTime.Now;

                    actmodel.StaffID = Int32.Parse(Login.login_user);
                    actmodel.logType = "Send reorder Req";
                    actmodel.Interface = "Inv.whstock";
                    actmodel.logDate = DateTime.Now;


                    using (betterltdEntities db = new betterltdEntities())
                    {
                        db.activitylogs.Add(actmodel);
                        db.warehouse_reorder.Add(model2);
                        db.SaveChanges();
                    }
                }
                reorderlist_dgv.Rows.Clear();
                Clear();
                populate_dgv();
                MessageBox.Show("Successfully sent");
            }
        }

        private void li_warehouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_dangerlvl_Click(object sender, EventArgs e)
        {
            if (btn_dangerlvl.Text == "")
            {
                MessageBox.Show("You must enter qty");
                return;
            }
            model.lowlevel = Int32.Parse(txt_dangelvl.Text);
            actmodel.StaffID = Int32.Parse(Login.login_user);
            actmodel.logType = "Update";
            actmodel.Interface = "Inv.whstock";
            actmodel.logDate = DateTime.Now;

            using (betterltdEntities db = new betterltdEntities())
            {
                db.activitylogs.Add(actmodel);
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }

            Clear();
            populate_dgv();
            MessageBox.Show("Successfully Update");
        }
    }
}
