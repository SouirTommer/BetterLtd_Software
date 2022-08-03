using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BetterLtd.Accounts_tab
{
    public partial class revenue : Form
    {
        salesorder money = new salesorder();
        int storeid;
        public revenue()
        {
            InitializeComponent();
        }

        private void revenue_Load(object sender, EventArgs e)
        {
            populatechart();

            using (var db = new betterltdEntities())
            {
                var suplist = db.retailstores.Where(i => i.isValid == 0).Select(i => i.StoreName);

                foreach (var sup in suplist)
                {
                    li_store.Items.Add(sup);
                }

            }
            Login.check_lang();

        }

        public void populatechart()
        {

            ct_revenue.ResetAutoValues();
            ct_revenue.Series.Clear();
            ct_revenue.Series.Add("Revenue");
        }

        public void insertColumn(string year, string month)
        {
            decimal rev;
            try
            {
                if (storeid == 0)
                {
                    using (var db = new betterltdEntities())
                    {
                        rev = db.salesorders.Where(i => i.dateCreated.ToString().Contains(year + "-" + month))
                                                            .Sum(i => i.totalPrice);
                    }
                }
                else
                {
                    using (var db = new betterltdEntities())
                    {
                        rev = db.salesorders.Where(i => i.dateCreated.ToString().Contains(year + "-" + month) && i.StoreID == storeid)
                                                            .Sum(i => i.totalPrice);
                    }
                }
                
                rev = Convert.ToInt32(rev);
                ct_revenue.Series["Revenue"].Points.AddXY(month, rev);
            }
            catch
            {
                ct_revenue.Series["Revenue"].Points.AddXY(month, 0);
            }

        }


        private void btn_check_Click(object sender, EventArgs e)
        {
            
            populatechart();
            string year;
            string month;

            if (li_month.Text != "" && li_year.Text != "" && li_store.Text != "")
            {
                
                year = li_year.Text;
                month = li_month.Text;
                insertColumn(year, month);

            }
            else if (cbx_3m.Checked == true && li_store.Text != "")
            {
                
                month = DateTime.Now.AddMonths(-3).Month.ToString();
                year = DateTime.Now.AddMonths(-3).Year.ToString();
                for (int i = 0; i < 3; i++)
                {
                    if (Convert.ToInt32(month) < 10)
                    {
                        month = "0" + month;
                    }
                    insertColumn(year, month);
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

            }
            else if (cbx_6m.Checked == true && li_store.Text != "")
            {
                
                month = DateTime.Now.AddMonths(-6).Month.ToString();
                year = DateTime.Now.AddMonths(-6).Year.ToString();
                for(int i =0; i <6; i++)
                {
                    if(Convert.ToInt32(month) < 10)
                    {
                        month = "0" + month;
                    }
                    insertColumn(year, month);
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

            }
            else
            {
                MessageBox.Show("Please select atleast one options");
            }



        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.DarkGray;
            li_month.Enabled = true;
            li_year.Enabled = true;
            cbx_3m.Enabled = false;
            cbx_6m.Enabled = false;
            cbx_3m.Checked = false;
            cbx_6m.Checked = false;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.WhiteSmoke;
            panel1.BackColor = Color.DarkGray;
            cbx_3m.Enabled = true;
            cbx_6m.Enabled = true;
            li_month.Enabled = false;
            li_year.Enabled = false;
            li_month.Text = "";
            li_year.Text = "";
        }

        private void li_store_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new betterltdEntities())
            {
                storeid = db.retailstores.Where(i => i.StoreName == li_store.Text).Select(i => i.StoreID).FirstOrDefault();
            }
        }

        private void lbl_storeid_Click(object sender, EventArgs e)
        {

        }

        
    }
}
