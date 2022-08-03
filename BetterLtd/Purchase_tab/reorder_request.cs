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

namespace BetterLtd.Purchase_tab
{
    public partial class reorder_request : Form
    {
        warehouse_reorder model = new warehouse_reorder();
        int wid;
        public reorder_request()
        {
            InitializeComponent();


            
        }

        private void reorder_request_Load(object sender, EventArgs e)
        {
            populate_dgv();
            clear();

            using (var betterltd = new betterltdEntities())
            {
                var dataset = betterltd.warehouses.Select(i => i.warehouseName);


                foreach (var data in dataset)
                {
                    li_warehouse.Items.Add(data);
                }
            }
            Login.check_lang();
        }
        
        public void Offbutton()
        {
            btn_reject.Enabled = false;
            btn_approve.Enabled = false;
            btn_approve.BackColor = Color.Gray;
            btn_reject.BackColor = Color.Gray;

        }

        public void Onbutton()
        {
            btn_reject.Enabled = true;
            btn_approve.Enabled = true;
            btn_approve.BackColor = Color.CadetBlue;
            btn_reject.BackColor = Color.CadetBlue;
        }

        public void clear()
        {
            li_warehouse.Text = "- - -Warehouse - - -";
            txt_search.Text = "";
            txt_supName.Text = "";
            txt_suppEmail.Text = "";
            txt_suppID.Text = "";
            txt_suppTel.Text = "";
            Offbutton();
            
        }
        public void populate_dgv()
        {
            reorderRequest_view.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                reorderRequest_view.DataSource = db.warehouse_reorder.Where(x=> x.status =="pending").ToList<warehouse_reorder>();
            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                if (li_warehouse.Text == "All" || li_warehouse.Text == "- - -Warehouse - - -")
                {
                    reorderRequest_view.DataSource = betterltd.warehouse_reorder
               .Where(i => i.status == "pending"
                   && (i.reordID.ToString().Contains(keyword)
                   || i.StaffID.ToString().Contains(keyword)
                   || i.warehouseID.ToString().Contains(keyword)
                   || i.prodID.ToString().Contains(keyword)
                   || i.prodName.Contains(keyword))).ToList();
                }
                
                else
                {
                    reorderRequest_view.DataSource = betterltd.warehouse_reorder
                    .Where(i => i.status == "pending" && i.warehouseID == wid && (i.StaffID.ToString().Contains(keyword)
                   || (i.status == "pending" && i.warehouseID == wid && i.prodID.ToString().Contains(keyword))
                   || (i.status == "pending" && i.warehouseID == wid && i.prodName.Contains(keyword))
                   || (i.status == "pending" && i.warehouseID == wid && i.reordID.ToString().Contains(keyword)))).ToList();
                }
                 
            }
        }

        private void reorderRequest_view_DoubleClick(object sender, EventArgs e)
        {
            Onbutton();
            

            int supid;
            int prodid = Convert.ToInt32(reorderRequest_view.CurrentRow.Cells[3].Value);
            using (var db = new betterltdEntities())
            {
                var prod_result = db.products.Where(x => x.prodID == prodid)
                                    .Select(x=> new { x.SupID }).FirstOrDefault();
                supid = Convert.ToInt32(prod_result.SupID);
                txt_suppID.Text = supid.ToString();

                var sup_result = db.suppliers.Where(x => x.SupID == supid)
                                          .Select(x=> new { x.SupName,x.SupTel,x.Supemail}).FirstOrDefault();

                txt_supName.Text = sup_result.SupName;
                txt_suppTel.Text = sup_result.SupTel.ToString();
                txt_suppEmail.Text = sup_result.Supemail;

            }
        }

        private void li_warehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(li_warehouse.Text != "All" && li_warehouse.Text != "- - -Warehouse - - -")
            {
                using (var db = new betterltdEntities())
                {
                    var result = db.warehouses.Where(x => x.warehouseName == li_warehouse.Text)
                                                         .Select(x => new { x.warehouseID }).FirstOrDefault();
                    wid = result.warehouseID;
                }
            }
            txt_search_TextChanged(sender, e);
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {

            try
            {
                int rid = Convert.ToInt32(reorderRequest_view.CurrentRow.Cells[0].Value);
                using (var db = new betterltdEntities())
                {
                    var result = db.warehouse_reorder.Where(x => x.reordID == rid)
                                                     .Select(x => x).FirstOrDefault();

                    result.status = "rejected";
                    db.SaveChanges();
                }
                MessageBox.Show("Rejected");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                clear();
                populate_dgv();
            }
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            try
            {
                int rid = Convert.ToInt32(reorderRequest_view.CurrentRow.Cells[0].Value);
                using (var db = new betterltdEntities())
                {
                    var result = db.warehouse_reorder.Where(x => x.reordID == rid)
                                                     .Select(x => x).FirstOrDefault();

                    result.status = "approved";
                    result.inward_status = "processing";
                    result.approveDate = DateTime.Now;
                    db.SaveChanges();
                }
                MessageBox.Show("Approved");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                clear();
                populate_dgv();
            }
  

        }

        private void li_warehouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
