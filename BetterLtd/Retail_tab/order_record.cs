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
    public partial class order_record : Form
    {
        salesorder order = new salesorder();
        salesorder_detail details = new salesorder_detail();
        
        public order_record()
        {
            InitializeComponent();
        }

        private void order_record_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();

            Login.check_lang();
        }

        void populate_dgv()
        {
            order_record_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                order_record_View.DataSource = db.salesorders.Where(x=> x.isValid==1).Select(x => new { x.salorderID, x.StoreID, x.CustomerID,x.StaffID ,x.totalPrice, x.dateCreated }).ToList();
            }
   
        }

        void Clear()
        {
            btn_Detail.BackColor = Color.Gray;
            btn_Detail.Enabled = false;
            btn_del.BackColor = Color.Gray;
            btn_del.Enabled = false;
            txt_sid.Text = "";
        }


        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirmed to delete this record?", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (betterltdEntities db = new betterltdEntities())
                {
                    try
                    {
                        order.isValid = 0;
                        db.Entry(order).State = EntityState.Modified;
                        del_detail();
                        db.SaveChanges();
                        MessageBox.Show("Order Record Deleted Successfully");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Item Can not be deleted. Their are existing selling products of this Supplier");
                    }

                    Clear();

                    populate_dgv();
                }
        }

        private void del_detail()
        {
            int sid = Convert.ToInt32(txt_sid.Text);
            using (betterltdEntities db = new betterltdEntities())
            {
                int count = db.salesorder_detail.Where(x => x.salorderID == sid).Count();
                for (int i = 0; i < count; i++)
                {
                    details = db.salesorder_detail.Where(x => x.salorderID == sid && x.isValid == 1).FirstOrDefault();
                    details.isValid = 0;
                    db.SaveChanges();
                }

            }

        }

        private void order_record_View_DoubleClick(object sender, EventArgs e)
        {
            btn_Detail.BackColor = re_mng_lbl.ForeColor; ;
            btn_Detail.Enabled = true;
            btn_del.BackColor = re_mng_lbl.ForeColor; ;
            btn_del.Enabled = true;
            if (order_record_View.CurrentRow.Index != -1)
            {
                order.salorderID = Convert.ToInt32(order_record_View.CurrentRow.Cells[0].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    order = db.salesorders.Where(i => i.salorderID == order.salorderID).FirstOrDefault();
                    txt_sid.Text = order.salorderID.ToString();
                }
            }
               
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            order_detail od = new order_detail();

            od.storeid = order.StoreID;
            od.sid = txt_sid.Text;
            od.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            del_detail();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                order_record_View.DataSource = betterltd.salesorders.Where(i => i.salorderID.ToString().Contains(keyword) ||
                                                                        i.StaffID.ToString().Contains(keyword) ||
                                                                        i.StoreID.ToString().Contains(keyword) ||
                                                                        i.CustomerID.ToString().Contains(keyword) ||
                                                                        i.totalPrice.ToString().Contains(keyword) ||
                                                                        i.dateCreated.ToString().Contains(keyword)
                                                                        ).ToList();
            }
        }
    }
}
