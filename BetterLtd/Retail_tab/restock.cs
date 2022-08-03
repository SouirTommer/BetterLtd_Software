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
    public partial class restock : Form
    {
        store_stock model = new store_stock();
        store_reorder model2 = new store_reorder();
        activitylog actmodel = new activitylog();
        int StoreID;
        public restock()
        {
            InitializeComponent();
        }

        private void restock_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();
            if (Login.manager == 0)
            {
                delete_btn.Visible = false;
            }
            using (var betterltd = new betterltdEntities())
            {
                var whlist = betterltd.retailstores.Select(i => i.StoreName);

                foreach (var st in whlist)
                {
                    li_store.Items.Add(st);
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
            txt_dangerlvl.Text = "";
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
                                         join c in db.store_stock on s.prodID equals c.prodID
                                         where c.StoreID == StoreID
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

        private void li_warehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                var result = betterltd.retailstores
                                    .Where(s => s.StoreName == li_store.Text)
                                    .Select(s => new { s.StoreID }).FirstOrDefault();

                StoreID = result.StoreID;

                reorderlist_dgv.Rows.Clear();
            }
            MessageBox.Show("StoreID :" + Convert.ToString(StoreID));
            populate_dgv();

            using (var betterltd = new betterltdEntities())
            {
                string alert = "";
                var stock_alert = betterltd.store_stock
                                    .Where(d => d.StoreID == StoreID &&
                                    d.qty < d.lowlevel)
                                    .Select(d => d.prodID);
                foreach (var q in stock_alert)
                {
                    alert += q;
                    alert += "\n";
                }

                if (alert.Contains("100"))
                {
                    MessageBox.Show("Suggested replenishment items:\n------\n" + alert.ToString());
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;
                Stock_View.DataSource = (from s in betterltd.products
                                         join c in betterltd.store_stock on s.prodID equals c.prodID
                                         where
                                         (c.StoreID == StoreID)
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
            if (string.IsNullOrEmpty(li_store.Text))
            {
                MessageBox.Show("Please choose a store");
            }
            else if (string.IsNullOrEmpty(li_prod.Text))
            {
                MessageBox.Show("You must select a product");
            }
            else
            {
                using (betterltdEntities db = new betterltdEntities())
                {
                    model.StoreID = StoreID;
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

                    var checking = db.store_stock
                                    .Where(d => d.StoreID == model.StoreID &&
                                    d.prodID == model.prodID)
                                    .Select(d => new { d.prodID }).FirstOrDefault();

                    actmodel.StaffID = Int32.Parse(Login.login_user);
                    actmodel.logType = "Add item";
                    actmodel.Interface = "Retail.restock";
                    actmodel.logDate = DateTime.Now;

                    if (checking != null)
                    {
                        MessageBox.Show("This item exists");
                    }
                    else
                    {
                        db.store_stock.Add(model);
                        db.activitylogs.Add(actmodel);
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
            if (qty_text.Text == "")
            {
                MessageBox.Show("You must enter qty");
                return;
            }
            model.qty = Int32.Parse(qty_text.Text);
            actmodel.StaffID = Int32.Parse(Login.login_user);
            actmodel.logType = "Update";
            actmodel.Interface = "Retail.restock";
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

        private void Stock_View_DoubleClick(object sender, EventArgs e)
        {
            if (Stock_View.CurrentRow.Index != -1)
            {

                model.prodID = Convert.ToInt32(Stock_View.CurrentRow.Cells["ProductID"].Value);
                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.store_stock.Where(i => i.prodID == model.prodID && i.StoreID == StoreID).FirstOrDefault();
                    qty_text.Text = model.qty.ToString();
                    txt_dangerlvl.Text = model.lowlevel.ToString();

                }
                delete_btn.Enabled = true;
                btn_dangerlvl.Enabled = true;
                update_btn.Enabled = true;
                btn_dangerlvl.BackColor = additem_btn.BackColor;
                update_btn.BackColor = additem_btn.BackColor;
                delete_btn.BackColor = additem_btn.BackColor;

            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirmed to delete this item?", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (betterltdEntities db = new betterltdEntities())
                {
                    actmodel.StaffID = Int32.Parse(Login.login_user);
                    actmodel.logType = "Delete";
                    actmodel.Interface = "Retail.restock";
                    actmodel.logDate = DateTime.Now;

                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.store_stock.Attach(model);

                    db.store_stock.Remove(model);
                    db.activitylogs.Add(actmodel);
                    db.SaveChanges();
                    MessageBox.Show("Item Deleted Successfully");

                    Clear();
                    populate_dgv();
                }
            }
        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(li_store.Text))
            {
                MessageBox.Show("Please choose a store");
            }
            else
            {
                var prodID = Stock_View.SelectedRows[0].Cells[0].Value;
                var ProductName = Stock_View.SelectedRows[0].Cells[3].Value;

                var index = this.reorderlist_dgv.Rows.Add();
                this.reorderlist_dgv.Rows[index].Cells[0].Value = prodID;
                this.reorderlist_dgv.Rows[index].Cells[1].Value = ProductName;

            }
        }

        private void removeitem_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(li_store.Text))
            {
                MessageBox.Show("Please choose a store");
            }
            else
            {
                foreach (DataGridViewRow item in this.reorderlist_dgv.SelectedRows)
                {
                    reorderlist_dgv.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void send_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(li_store.Text))
            {
                MessageBox.Show("Please choose a store");
            }
            else if (reorderlist_dgv.Rows.Count == 0)
            {
                MessageBox.Show("Reorder list is null");
            }
            else
            {
                for (int i = 0; i < reorderlist_dgv.Rows.Count; i++)
                {
                    actmodel.StaffID = Int32.Parse(Login.login_user);
                    actmodel.logType = "Send ReReq";
                    actmodel.Interface = "Retail.restock";
                    actmodel.logDate = DateTime.Now;

                    model2.StaffID = Int32.Parse(Login.login_user);
                    model2.StoreID = StoreID;
                    model2.prodID = Int32.Parse(reorderlist_dgv.Rows[i].Cells[0].Value.ToString());
                    model2.prodName = reorderlist_dgv.Rows[i].Cells[1].Value.ToString();
                    model2.status = "Sent";
                    model2.createDate = System.DateTime.Now;


                    using (betterltdEntities db = new betterltdEntities())
                    {
                        db.activitylogs.Add(actmodel);
                        db.store_reorder.Add(model2);
                        db.SaveChanges();
                    }
                }

                reorderlist_dgv.Rows.Clear();
                Clear();
                populate_dgv();
                MessageBox.Show("Successfully sent");
            }
        }

        private void btn_dangerlvl_Click(object sender, EventArgs e)
        {
            if (txt_dangerlvl.Text == "")
            {
                MessageBox.Show("You must enter qty");
                return;
            }
            model.lowlevel = Int32.Parse(txt_dangerlvl.Text);
            actmodel.StaffID = Int32.Parse(Login.login_user);
            actmodel.logType = "Update";
            actmodel.Interface = "Retail.restock";
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
