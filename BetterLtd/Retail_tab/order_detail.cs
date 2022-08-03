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

namespace BetterLtd.Retail_tab
{
    public partial class order_detail : Form
    {
        public string sid;
        public int storeid;
        salesorder_detail details = new salesorder_detail();
        salesorder order = new salesorder();
        store_stock stock = new store_stock();

        public order_detail()
        {
            InitializeComponent();
        }


        void populate_dgv()
        {
            od_dgv.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                od_dgv.DataSource = db.salesorder_detail.Where(x => x.isValid == 1 && x.salorderID.ToString() == sid).ToList<salesorder_detail>();
            }
        }

        private void order_detail_Load(object sender, EventArgs e)
        {
            txt_StoreId.Text = storeid.ToString();
            txt_sid.Text = sid;
            populate_dgv();

            Login.check_lang();
        }

        private void od_dgv_DoubleClick(object sender, EventArgs e)
        {
            if (od_dgv.CurrentRow.Index != -1)
            {
                details.prodID = Convert.ToInt32(od_dgv.CurrentRow.Cells[0].Value);
                int salid = Convert.ToInt32(sid);
                using (betterltdEntities db = new betterltdEntities())
                {

                    details = db.salesorder_detail.Where(i => i.prodID == details.prodID && i.salorderID == salid).FirstOrDefault();
                    txt_pid.Text = details.prodID.ToString();
                    txt_pName.Text = details.prodName.ToString();
                    num_return_qty.Maximum = details.qty;
                    txt_currentstock.Text = db.store_stock.Where(i => i.StoreID == storeid && i.prodID == details.prodID).Select(i => i.qty).FirstOrDefault().ToString();
                }
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_currentstock.Text) < Convert.ToInt32(num_return_qty.Value))
            {
                MessageBox.Show("You Do Not have enough Stock for return");
            }
            else
            {
                if (MessageBox.Show("Are you confirmed to Return this unit", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    using (betterltdEntities db = new betterltdEntities())
                    {
                        stock = db.store_stock.Where(i => i.StoreID == storeid && i.prodID == details.prodID).FirstOrDefault();

                        stock.qty--;
                        db.Entry(stock).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Return procedure Success");
                    }
            }
        }
    }
    }
