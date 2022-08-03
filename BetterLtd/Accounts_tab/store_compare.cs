using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BetterLtd.Accounts_tab
{
    public partial class store_compare : Form
    {
        int storeid;
        int storeNo;
        public store_compare()
        {
            InitializeComponent();
        }

        

        private void store_compare_Load(object sender, EventArgs e)
        {
            populatechart();
            using (var db = new betterltdEntities())
            {
                storeNo = db.retailstores.Count();


            }
            Login.check_lang();
        }

        public void populatechart()
        {

            ct_revenue.ResetAutoValues();
            ct_revenue.Series["Revenue"].Points.Clear();


        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            dgv_rev.Rows.Clear();
            populatechart();
            if (cbx_1m.Checked == false && cbx_3m.Checked == false && cbx_6m.Checked == false)
            {
                MessageBox.Show("Please Select one option");
            }
            else
            {
                if (cbx_1m.Checked == true)
                {
                    for (int i = 1; i <= storeNo; i++)
                    {
                        insertColumn(i, 1);

                    }
                }

                if (cbx_3m.Checked == true)
                {
                    for (int i = 1; i <= storeNo; i++)
                    {
                        insertColumn(i, 3);
                    }
                }

                if (cbx_6m.Checked == true)
                {
                    for (int i = 1; i <= storeNo; i++)
                    {
                        insertColumn(i, 6);
                    }
                }
            }
        }

        public void insertColumn(int storeid, int re)
        {
            string month = DateTime.Now.AddMonths(-re).Month.ToString();
            string year = DateTime.Now.AddMonths(-re).Year.ToString();
            decimal rev = 0;
            using (var db = new betterltdEntities())
            {
                for(int j = 0; j < re; j++)
                {
                    if (Convert.ToInt32(month) < 10)
                    {
                        month = "0" + month;
                    }
                    try
                    {
                        rev += db.salesorders.Where(i => i.isValid == 0 && i.StoreID == storeid && i.dateCreated.ToString().Contains(year + "-" + month))
                                         .Sum(i => i.totalPrice);
                    }
                    catch
                    {
                        rev += 0;
                    }
                    

                    if (Convert.ToInt32(month) == 12)
                    {
                        year = (Convert.ToInt32(year) + 1).ToString();
                        month = "1";
                    }
                    else
                    {
                        month = (Convert.ToInt32(month) + 1).ToString();

                    }  
                }
                rev = Convert.ToInt32(rev);
                string stname = db.retailstores.Where(i => i.StoreID == storeid).Select(i => i.StoreName).FirstOrDefault();
                dgv_rev.Rows.Add(storeid, stname, rev);
               // MessageBox.Show(rev.ToString());
                ct_revenue.Series["Revenue"].Points.AddXY(stname, rev);
                


            }
        }

        public void dgv_update()
        {

        }
    }
}
