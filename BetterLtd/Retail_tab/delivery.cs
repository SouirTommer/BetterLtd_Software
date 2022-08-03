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
    public partial class delivery : Form
    {
        customer model = new customer();
        deliveryorder delorder = new deliveryorder();
        installorder insorder = new installorder();
        salesorder salorder = new salesorder();
        public delivery()
        {
            InitializeComponent();
        }

        private void delivery_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();

            Login.check_lang();
        }

        void populate_dgv()
        {
            cust_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                cust_View.DataSource = db.customers.Where(x => x.isValid == 0).ToList<customer>();
            }
        }

        void Clear()
        {
            txt_custfname.Text = txt_custlname.Text = txt_custtel.Text = txt_cusaddress.Text = "";
            cbx_M.Checked = cbx_A.Checked = cbx_E.Checked = false;
            dtp_date.Text = "";
            txt_sid.Clear();


            model.CustomerID = 0;
        }


        private void cust_View_DoubleClick(object sender, EventArgs e)
        {
            if (cust_View.CurrentRow.Index != -1)
            {
                model.CustomerID = Convert.ToInt32(cust_View.CurrentRow.Cells["ID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.customers.Where(i => i.CustomerID == model.CustomerID).FirstOrDefault();
                    txt_custfname.Text = model.FirstName;
                    txt_custlname.Text = model.LastName;
                    txt_custtel.Text = model.CustomerTel.ToString();
                    txt_cusaddress.Text = model.Address;

                }
                salesorder_dgv(model.CustomerID);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                cust_View.DataSource = betterltd.customers.Where(i => i.CustomerID.ToString().Contains(keyword)
                                            || i.LastName.Contains(keyword)
                                            || i.CustomerTel.ToString().Contains(keyword)).ToList();

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (dtp_date.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Sorry, only Monday to Saturday can delivery and installation");
                return;
            }

            if (txt_cusaddress.Text == ""|| txt_sid.Text == "" || (cbx_M.Checked == false && cbx_A.Checked == false && cbx_E.Checked == false))
            {
                MessageBox.Show("You must enter all information");
                return;
            }


            int salorderID = Convert.ToInt32(txt_sid.Text);


            insorder.salorderID = salorderID;
            insorder.insStatus = "Wait for del";
            insorder.CreateDate = DateTime.Today;
            insorder.insReqDate = dtp_date.Value;
            insorder.Address = txt_cusaddress.Text;
            insorder.isValid = 0;

            delorder.salorderID = salorderID;
            delorder.delStatus = "No start";
            delorder.CreateDate = DateTime.Today;
            delorder.delReqDate = dtp_date.Value;
            delorder.Address = txt_cusaddress.Text;
            delorder.isValid = 0;
            if (cbx_M.Checked == true) {
                delorder.delReqPeriod = "M";
                insorder.insReqPeriod = "M";
            }
            if (cbx_A.Checked == true) {
                delorder.delReqPeriod = "A";
                insorder.insReqPeriod = "A";
            }
            if (cbx_E.Checked == true) {
                delorder.delReqPeriod = "E";
                insorder.insReqPeriod = "E";
            }

            using (var db = new betterltdEntities())
            {

                var isIns = (from p in db.salesorders
                             where p.salorderID == salorderID
                             && p.NeedInstall == 1
                             select p).SingleOrDefault();

                db.deliveryorders.Add(delorder);

                if (isIns != null)
                {
                     db.installorders.Add(insorder);
                     MessageBox.Show("Delivery and Installation Arranged");
                }
                else
                {
                    MessageBox.Show("Delivery Arranged");
                }

                db.SaveChanges();


            }

            using (var db = new betterltdEntities())
            {
                salorder = db.salesorders.Where(x => x.salorderID.ToString() == txt_sid.Text).FirstOrDefault();
                salorder.isArranged = 1;
                db.Entry(salorder).State = EntityState.Modified;
                db.SaveChanges();
            }
                

            Clear();
            populate_dgv();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            salesorder_dgv(0);
            Clear();
            populate_dgv();
        }

        private void cust_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void salesorder_dgv(int id)
        {
            cust_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                salesorder_view.DataSource = db.salesorders.Where(x => x.CustomerID == id && x.isArranged == 0 && x.NeedDelivery == 1)
                                                            .Select(x => new { x.salorderID, x.dateCreated }).ToList();

            }
        }

        private void salesorder_view_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_sid.Text = salesorder_view.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select customer first / this customer not order");
            }
        }
    }
}
