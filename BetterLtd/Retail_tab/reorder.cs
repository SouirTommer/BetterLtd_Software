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
    public partial class reorder : Form
    {
        store_reorder model = new store_reorder();
        activitylog actmodel = new activitylog();
        int storeID;
        public reorder()
        {
            InitializeComponent();
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
                var whlist = betterltd.retailstores.Select(i => i.StoreName);

                foreach (var st in whlist)
                {
                    li_store.Items.Add(st);
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
                reorder_View.DataSource = db.store_reorder.Where(i => i.StoreID == storeID).ToList();

            }
        }

        private void li_store_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void li_store_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                var result = betterltd.retailstores
                                    .Where(s => s.StoreName == li_store.Text)
                                    .Select(s => new { s.StoreID }).FirstOrDefault();

                storeID = result.StoreID;
            }
            MessageBox.Show("StoreID :" + Convert.ToString(storeID));
            populate_dgv();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text;
            
            using (var betterltd = new betterltdEntities())
            {

                reorder_View.DataSource = betterltd.store_reorder.Where(i => i.reordID.ToString().Contains(keyword) && i.StoreID == storeID ||
                                                        i.StaffID.ToString().Contains(keyword) && i.StoreID == storeID ||
                                                        i.StoreID.ToString().Contains(keyword) && i.StoreID == storeID ||
                                                        i.prodID.ToString().Contains(keyword) && i.StoreID == storeID ||
                                                        i.prodName.ToString().Contains(keyword) && i.StoreID == storeID ||
                                                        i.status.ToString().Contains(keyword) && i.StoreID == storeID ||
                                                        i.createDate.ToString().Contains(keyword) && i.StoreID == storeID ||
                                                        i.approveDate.ToString().Contains(keyword) && i.StoreID == storeID
                                                                        ).ToList();
            }
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
                cancel_btn.Enabled = true;

            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirmed to delete this record?", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                model.status = "Cancelled"; actmodel.StaffID = Int32.Parse(Login.login_user);
                actmodel.logType = "Cancel";
                actmodel.Interface = "Retail.reorder";
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
    }
}
