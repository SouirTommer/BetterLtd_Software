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
    public partial class store_reorder_req : Form
    {
        int warehouseID=0;
        store_reorder model = new store_reorder();
        deliveryorder del_model = new deliveryorder();
        warehouse_stock wh_model = new warehouse_stock();
        activitylog actmodel = new activitylog();
        public store_reorder_req()
        {
            InitializeComponent();
        }

        private void store_reorder_req_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();

            using (var betterltd = new betterltdEntities())
            {
                var whlist = betterltd.warehouses.Select(i => i.warehouseName);

                foreach (var st in whlist)
                {
                    li_warehouse.Items.Add(st);
                }
            }
            Login.check_lang();
        }
        void populate_dgv()
        {
            reorder_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                reorder_View.DataSource = db.store_reorder.ToList<store_reorder>();
            }
        }
        void Clear()
        {
            ReqPeriod.SelectedItem = null;
            Req_Picker.Value = System.DateTime.Now;
            qty_text.Text = "";
            model.reordID = 0;
            delivery_btn.Enabled = false;
        }

        private void qty_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
        }

        private void delivery_btn_Click(object sender, EventArgs e)
        {
            if (qty_text.Text == "" || string.IsNullOrEmpty(li_warehouse.Text) || string.IsNullOrEmpty(ReqPeriod.Text))
            {
                MessageBox.Show("You must enter all information");
                return;
            }

            using (betterltdEntities db = new betterltdEntities())
            {
                var stock = (from p in db.warehouse_stock
                             where p.warehouseID == warehouseID
                             && p.prodID == model.prodID
                             select p).SingleOrDefault();

                stock.qty -= Convert.ToInt32(qty_text.Text);
                if (stock.qty < 0)
                {
                    MessageBox.Show("qty not enough, please try again");
                    return;
                }
                else
                {
                    del_model.reorderID = model.reordID;
                    del_model.delStatus = "No start";

                    var address = db.retailstores
                                        .Where(d => d.StoreID == model.StoreID)
                                        .Select(d => new { d.Address }).FirstOrDefault();
                    del_model.Address = address.Address;
                    del_model.isValid = 0;
                    del_model.delReqPeriod = ReqPeriod.Text;
                    del_model.delReqDate = Req_Picker.Value;
                    del_model.CreateDate = System.DateTime.Now;

                    actmodel.StaffID = Int32.Parse(Login.login_user);
                    actmodel.logType = "CreateDel";
                    actmodel.Interface = "Inv.store_rereq";
                    actmodel.logDate = System.DateTime.Now;
                    

                    model.status = "Accepted";
                    model.approveDate = System.DateTime.Now;

                    db.deliveryorders.Add(del_model);
                    db.activitylogs.Add(actmodel);
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Successfully create delivery");
                }
            }
            Clear();
            populate_dgv();

        }

        private void reorder_View_DoubleClick(object sender, EventArgs e)
        {
            if (reorder_View.CurrentRow.Index != -1)
            {
                model.reordID = Convert.ToInt32(reorder_View.CurrentRow.Cells["reordID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.store_reorder.Where(i => i.reordID == model.reordID).FirstOrDefault();
                }
                delivery_btn.Enabled = true;

                
            }


            try
            {
                using (var betterltd = new betterltdEntities())
                {
                    var labelqty = betterltd.warehouse_stock
                                        .Where(s => s.warehouseID == warehouseID &&
                                        s.prodID == model.prodID)
                                        .Select(s => new { s.qty }).FirstOrDefault();

                    label6.Text = labelqty.qty.ToString();
                }
            }
            catch (Exception)
            { }



        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                reorder_View.DataSource = betterltd.store_reorder.Where(i => i.reordID.ToString().Contains(keyword)||
                                                                        i.StaffID.ToString().Contains(keyword) ||
                                                                        i.StoreID.ToString().Contains(keyword) ||
                                                                        i.prodID.ToString().Contains(keyword) ||
                                                                        i.prodName.ToString().Contains(keyword) ||
                                                                        i.status.ToString().Contains(keyword) ||
                                                                        i.createDate.ToString().Contains(keyword)
                                                                        ).ToList();
            }
        }

        private void li_warehouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ReqPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
        }

        private void Req_Picker_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
        }

        private void qty_text_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void qty_text_MouseEnter(object sender, EventArgs e)
        {

        }

        private void qty_text_Enter(object sender, EventArgs e)
        {
            try
            {
                using (var betterltd = new betterltdEntities())
                {
                    var labelqty = betterltd.warehouse_stock
                                        .Where(s => s.warehouseID == warehouseID &&
                                        s.prodID == model.prodID)
                                        .Select(s => new { s.qty }).FirstOrDefault();

                    label6.Text = labelqty.qty.ToString();
                }
            }
            catch (Exception)
            { }
        }

        private void qty_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
