using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BetterLtd.Inventory_tab
{
    public partial class update_inward : Form
    {
        warehouse_reorder model = new warehouse_reorder();
        activitylog actmodel = new activitylog();
        int warehouse_ID;
        

        public update_inward()
        {
            InitializeComponent();
        }

        private void update_inward_Load(object sender, EventArgs e)
        {
            Clear();
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
                    txt_reid.Text = model.reordID.ToString();
                }

                btn_update.BackColor = btn_cancel.BackColor;
                btn_update.Enabled = true;
            }
        }

        void Clear()
        {
            btn_update.BackColor = Color.Gray;
            btn_update.Enabled = false;
            txt_reid.Text = "";
        }

        void populate_dgv()
        {
            reorder_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                reorder_View.DataSource = db.warehouse_reorder.Where(i => i.warehouseID == warehouse_ID && i.status == "approved" && i.inward_status == "processing").ToList();

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirmed to Update this record?", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                model.inward_status= "received";
                actmodel.StaffID = Int32.Parse(Login.login_user);
                actmodel.logType = "Update";
                actmodel.Interface = "Inv.inward";
                actmodel.logDate = DateTime.Now;

                using (betterltdEntities db = new betterltdEntities())
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.activitylogs.Add(actmodel);
                    db.SaveChanges();
                }

                Clear();
                populate_dgv();
                MessageBox.Show("Successfully Update");
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text;
            using (var betterltd = new betterltdEntities())
            {

                reorder_View.DataSource = betterltd.warehouse_reorder.Where(i => i.reordID.ToString().Contains(keyword) && i.warehouseID == warehouse_ID && i.inward_status == "processing" ||
                                                        i.StaffID.ToString().Contains(keyword) && i.warehouseID == warehouse_ID && i.inward_status == "processing" ||
                                                        i.warehouseID.ToString().Contains(keyword) && i.warehouseID == warehouse_ID && i.inward_status == "processing" ||
                                                        i.prodID.ToString().Contains(keyword) && i.warehouseID == warehouse_ID && i.inward_status == "processing" ||
                                                        i.prodName.ToString().Contains(keyword) && i.warehouseID == warehouse_ID && i.inward_status == "processing" ||
                                                        i.status.ToString().Contains(keyword) && i.warehouseID == warehouse_ID && i.inward_status == "processing" ||
                                                        i.createDate.ToString().Contains(keyword) && i.warehouseID == warehouse_ID && i.inward_status == "processing"
                                                                        ).ToList();
            }
        }
    }
}
