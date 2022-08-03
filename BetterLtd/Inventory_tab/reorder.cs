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
    public partial class reorder : Form
    {
        warehouse_reorder model = new warehouse_reorder();
        activitylog actmodel = new activitylog();
        int warehouse_ID;
        public reorder()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirmed to delete this record?", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                model.status = "Cancelled";
                actmodel.StaffID = Int32.Parse(Login.login_user);
                actmodel.logType = "Delete";
                actmodel.Interface = "Inv.Reorder";
                actmodel.logDate = DateTime.Now;

                using (betterltdEntities db = new betterltdEntities())
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.activitylogs.Add(actmodel);
                    db.SaveChanges();
                }

                Clear();
                populate_dgv();
                MessageBox.Show("Successfully Cancel");
            }
        }

        private void li_warehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                var result = betterltd.warehouses
                                    .Where(s => s.warehouseName == li_warehouse.Text)
                                    .Select(s => new { s.warehouseID }).FirstOrDefault();

                warehouse_ID = result.warehouseID;
            }
            MessageBox.Show("StoreID :" + Convert.ToString(warehouse_ID));
            populate_dgv();
        }

        private void reorder_View_DoubleClick(object sender, EventArgs e)
        {
            if (reorder_View.CurrentRow.Index != -1)
            {
                model.reordID = Convert.ToInt32(reorder_View.CurrentRow.Cells["reordID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.warehouse_reorder.Where(i => i.reordID == model.reordID).FirstOrDefault();
                }
                cancel_btn.Enabled = true;

            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            string keyword = txt_search.Text;
            using (var betterltd = new betterltdEntities())
            {

                reorder_View.DataSource = betterltd.warehouse_reorder.Where(i => i.reordID.ToString().Contains(keyword) && i.warehouseID == warehouse_ID ||
                                                        i.StaffID.ToString().Contains(keyword) && i.warehouseID == warehouse_ID ||
                                                        i.warehouseID.ToString().Contains(keyword) && i.warehouseID == warehouse_ID ||
                                                        i.prodID.ToString().Contains(keyword) && i.warehouseID == warehouse_ID ||
                                                        i.prodName.ToString().Contains(keyword) && i.warehouseID == warehouse_ID ||
                                                        i.status.ToString().Contains(keyword) && i.warehouseID == warehouse_ID ||
                                                        i.createDate.ToString().Contains(keyword) && i.warehouseID == warehouse_ID ||
                                                        i.approveDate.ToString().Contains(keyword) && i.warehouseID == warehouse_ID ||
                                                        i.inward_status.ToString().Contains(keyword) && i.warehouseID == warehouse_ID
                                                                        ).ToList();
            }
        }

        private void reorder_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();

            if (Login.manager == 0)
            {
                cancel_btn.Visible = false;
            }

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
        void Clear()
        {
            cancel_btn.Enabled = false;
        }
        void populate_dgv()
        {
            reorder_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                reorder_View.DataSource = db.warehouse_reorder.Where(i => i.warehouseID == warehouse_ID).ToList();

            }
        }

        private void li_warehouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
