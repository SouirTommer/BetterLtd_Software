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
    public partial class confirm_order : Form
    {
        salesorder model = new salesorder();
        store_stock stock = new store_stock();

        public int cusid { get; set; }
        public int storeid;
        public string[] receipt { get; set; }
        public int staffid;
        public Boolean isPending;
   
        public confirm_order()
        {
            InitializeComponent();
        }

        private void confirm_order_Load_1(object sender, EventArgs e)
        {
            var index = 0;
            int qty = 0;
            int total = 0;
            txt_staffid.Text = Login.login_user;
            foreach (string element in receipt.Select(x => x).Distinct())
            {
                index = co_view.Rows.Add();
                co_view.Rows[index].Cells[0].Value = element;
                qty = Convert.ToInt32(co_view.Rows[index].Cells[4].Value);
                qty++;
                co_view.Rows[index].Cells[4].Value = qty.ToString();
            }

            foreach (DataGridViewRow row in co_view.Rows)
            {
                qty = duplicate_item(row.Cells[0].Value.ToString());
                row.Cells[4].Value = qty.ToString();
            }

            if(isPending == false)
            {
                foreach (DataGridViewRow row in co_view.Rows)
                {
                    using (var betterltd = new betterltdEntities())
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        row.Cells[1].Value = betterltd.products.Where(x => x.prodID == id).Select(x => x.Brand).FirstOrDefault();
                        row.Cells[2].Value = betterltd.products.Where(x => x.prodID == id).Select(x => x.prodName).FirstOrDefault();
                        row.Cells[3].Value = betterltd.products.Where(x => x.prodID == id).Select(x => x.prodPrice).FirstOrDefault();
                    }
                    row.Cells[5].Value = Convert.ToInt32(row.Cells[3].Value) * Convert.ToInt32(row.Cells[4].Value);
                }
            }
            else if (isPending == true)
            {
                foreach (DataGridViewRow row in co_view.Rows)
                {
                    using (var betterltd = new betterltdEntities())
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        decimal d_price;
                        row.Cells[1].Value = betterltd.products.Where(x => x.prodID == id).Select(x => x.Brand).FirstOrDefault();
                        row.Cells[2].Value = betterltd.products.Where(x => x.prodID == id).Select(x => x.prodName).FirstOrDefault();
                        d_price = betterltd.products.Where(x => x.prodID == id).Select(x => x.prodPrice).FirstOrDefault() * Convert.ToDecimal(0.2);
                        row.Cells[3].Value = d_price;
                    }
                    row.Cells[5].Value = Convert.ToInt32(row.Cells[3].Value) * Convert.ToInt32(row.Cells[4].Value);
                }
            }


            foreach (DataGridViewRow row in co_view.Rows)
            {
                total += Convert.ToInt32(row.Cells[5].Value);
            }

            txt_total.Text = total.ToString();
            using (var db = new betterltdEntities())
            {
                txt_salesid.Text = db.salesorders.Max(x => x.salorderID + 1).ToString();
            }

            txt_storeid.Text = storeid.ToString();

            Login.check_lang();
        }

        private int duplicate_item(string id)
        {
            int count = 0;
            for (int i = 0; i < receipt.Length; i++)
            {
                if (id == receipt[i])
                {
                    count++;
                }
            }
            return count;
        }

        List<payment> salesorder_detail = new List<payment>();

        private void btn_next_Click(object sender, EventArgs e)
        {

                if (txt_cusid.Text == "> Click to Select")
                {
                    MessageBox.Show("Please select a customer!");
                    return;
                }
                if (Convert.ToInt32(txt_cusid.Text)==0)
                {
                    MessageBox.Show("Sorry, customerID is invalid!");
                    return;
                }




            payment py = new payment();

            if (cbx_delivery.Checked == true)
            {
                py.n_delivery = 1;
            }
            else
            {
                py.n_delivery = 0;
            }

            if (cbx_install.Checked == true)
            {
                py.n_installation = 1;
            }
            else
            {
                py.n_installation = 0;
            }


            py.bill = Convert.ToDouble(txt_total.Text);
            py.custid = txt_cusid.Text;
            py.staffid = txt_staffid.Text;
            py.storeid = storeid;
            if(isPending == true) { py.Pending = 1; }
            if(isPending == false) { py.Pending = 0; }


            py.stock_arr = new string[co_view.RowCount,2];
            for (int i = 0; i < co_view.RowCount; i++)
            {
                py.stock_arr[i,0] = co_view.Rows[i].Cells[0].Value.ToString();
                py.stock_arr[i,1] = co_view.Rows[i].Cells[4].Value.ToString();
            }


            for (int i = 0; i < co_view.RowCount; i++)
            {

                salesorder_detail.Add(new payment()
                {
                    pid = co_view.Rows[i].Cells[0].Value.ToString(),
                    pName = co_view.Rows[i].Cells[2].Value.ToString(),
                    pPrice = Convert.ToInt32(co_view.Rows[i].Cells[3].Value),
                    Qty = co_view.Rows[i].Cells[4].Value.ToString(),
                    subTotal = co_view.Rows[i].Cells[5].Value.ToString()
                });
            }

            py.pr_dgv = salesorder_detail;
            py.salorderid = txt_salesid.Text;
            py.Show();
            
            
        }

        public void closeform()
        {
            this.Hide();
        }




        List<print_receipt> receiptprint = new List<print_receipt>();

        private void btn_print_Click(object sender, EventArgs e)
        {
            receiptprint.Clear();
            for (int i = 0; i < co_view.RowCount; i ++)
            {

                receiptprint.Add(new print_receipt() { pid = co_view.Rows[i].Cells[0].Value.ToString(),
                                                  pName = co_view.Rows[i].Cells[2].Value.ToString(),
                                                  pPrice = co_view.Rows[i].Cells[3].Value.ToString(),
                                                  Qty = co_view.Rows[i].Cells[4].Value.ToString(),
                                                  subTotal = co_view.Rows[i].Cells[5].Value.ToString()}); 
            }
            testprint();


            print_receipt pr = new print_receipt();
            pr.staffid = txt_staffid.Text;
            pr.storeid = txt_storeid.Text ;
            pr.salorderid = txt_salesid.Text;
            pr.total = txt_total.Text;
            pr.pr_dgv = receiptprint;
            pr.isPending = isPending;


            pr.Show();
        }

        void testprint()
        {
            string abc = "";
            foreach (print_receipt item in receiptprint)
            {

                abc += item.pid + " " + item.pName + " " + item.pPrice + " " + item.Qty + " " + item.subTotal + "\n";

            }
            MessageBox.Show(abc);
        }

        private void txt_cusid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cusid_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbx_install_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_install.Checked)
            {
                cbx_delivery.Checked = true;
                cbx_delivery.Enabled = false;
            }
            else
            {
                cbx_delivery.Checked = false;
                cbx_delivery.Enabled = true;
            }
        }

        private void img_search_Click(object sender, EventArgs e)
        {
            choose_customer cc = new choose_customer();
            cc.Show();
        }

        public string TextBoxValue
        {
            get { return txt_cusid.Text; }
            set { txt_cusid.Text = value; }
        }

        private void txt_cusid_MouseClick(object sender, MouseEventArgs e)
        {
            choose_customer cc = new choose_customer();
            cc.Show();
        }
    }
}
