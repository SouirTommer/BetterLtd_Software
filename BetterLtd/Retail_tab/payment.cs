using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Threading;

namespace BetterLtd.Retail_tab
{
    public partial class payment : Form
    {
        salesorder model = new salesorder();
        store_stock stock = new store_stock();
        salesorder_detail details = new salesorder_detail();
        public string[,] stock_arr;
        public double bill;
        public int n_delivery;
        public int n_installation;
        public int Pending;
        public string custid;
        public string staffid;
        public int storeid;
        
        public List<payment> pr_dgv;
        public string pid;
        public string pName;
        public int pPrice;
        public string Qty;
        public string subTotal;
        public string salorderid;

        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {
            txt_bill.Text = bill.ToString();


            Login.check_lang();
        }


        public void record_salesorder()
        {
            using (var db = new betterltdEntities())
            {
                model.isValid = 1;
                model.NeedInstall = n_installation;
                model.isPanding = Pending;
                model.StoreID = storeid;
                model.NeedDelivery = n_delivery;
                model.totalPrice = Convert.ToInt32(bill);
                model.CustomerID = Convert.ToInt32(custid);
                model.StaffID = Convert.ToInt32(staffid);
                model.dateCreated = System.DateTime.Now;

                db.salesorders.Add(model);
                db.SaveChanges();
            }
            
        }

        public void update_stock()
        {
            using (var db = new betterltdEntities())
            {
                int id;
                for (int i =0; i<(stock_arr.Length/2);i++)
                {
                    id = Convert.ToInt32(stock_arr[i,0]);
                    var stock = (from p in db.store_stock
                                 where p.StoreID == storeid
                                 && p.prodID == id
                                 select p).SingleOrDefault();

                    stock.qty -= Convert.ToInt32(stock_arr[i,1]);
                }
                db.SaveChanges();
            }
        }

        private void btn_confirmbill_Click(object sender, EventArgs e)
        {
            //try
            //{
                int check = Convert.ToInt32(txt_change.Text);
                if (check < 0)
                {
                    MessageBox.Show("Money is not enoungh");
                    return;
                }
                record_salesorder();
                Add_detail();
                update_stock();
                MessageBox.Show("Transaction Finished");
                this.Hide();
                confirm_order obj = (confirm_order)Application.OpenForms["confirm_order"];
                obj.Close();
            //} catch (Exception)
            //{
                
            //    MessageBox.Show("Enter paid first");
            //}
        }

        private void num_paid_ValueChanged(object sender, EventArgs e)
        {
            txt_change.Text = (Convert.ToDouble(num_paid.Value) - bill).ToString();
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            pos pos = new pos();
            pos.Show();
        }

        private void Add_detail()
        {
            using (var db = new betterltdEntities())
            {
                for(int i = 0; i <pr_dgv.Count; i++)
                {
                    details.salorderID = Convert.ToInt32(salorderid);
                    details.prodID = Convert.ToInt32(pr_dgv[i].pid);
                    details.prodName = pr_dgv[i].pName;
                    details.price = Convert.ToInt32(pr_dgv[i].pPrice);
                    details.qty = Convert.ToInt32(pr_dgv[i].Qty);
                    details.Total = Convert.ToInt32(pr_dgv[i].subTotal);
                    details.isValid = 1;

                    db.salesorder_detail.Add(details);
                    db.SaveChanges();

                }
                
            }
        }
        

        void testprint()
        {
            string abc = "";
            foreach (payment item in pr_dgv)
            {

                abc += salorderid +" "+item.pid + " " + item.pName + " " + item.pPrice + " " + item.Qty + " " + item.subTotal + "\n";

            }
            MessageBox.Show(abc);
        }
    }
}
