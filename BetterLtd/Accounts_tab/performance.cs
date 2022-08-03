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
    public partial class performance : Form
    {
        staff staff = new staff();
        salesorder pfm = new salesorder();
        int sid;
        public performance()
        {
            InitializeComponent();
        }


        private void performance_Load(object sender, EventArgs e)
        {
            using(var db = new betterltdEntities())
            {
                dgv_staff.DataSource = db.staffs.Where(i => i.Position == "Retail")
                    .Select(i => new { i.StaffID, i.FirstName, i.LastName }).ToList();
            }
            populatechart();
            Login.check_lang();


        }

        public void populatechart()
        {

            ct_revenue.ResetAutoValues();
            ct_revenue.Series.Clear();
            ct_revenue.Series.Add("Revenue");
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var db = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                dgv_staff.DataSource = db.staffs.Where(i => i.Position == "Retail" 
                                                        &&( i.StaffID.ToString().Contains(keyword)
                                                        || i.LastName.Contains(keyword)
                                                        || i.FirstName.Contains(keyword)))
                                                        .Select(i => new { i.StaffID, i.FirstName, i.LastName }).ToList();

            }
        }

        public void insertColumn(string year, string month)
        {
            decimal rev;
            try
            {
                using (var db = new betterltdEntities())
                {
                    rev = db.salesorders.Where(i => i.dateCreated.ToString().Contains(year + "-" + month) && i.StaffID == staff.StaffID)
                                                        .Sum(i => i.totalPrice);
                }


                rev = Convert.ToInt32(rev);
                ct_revenue.Series["Revenue"].Points.AddXY(month, rev);
            }
            catch
            {
                ct_revenue.Series["Revenue"].Points.AddXY(month, 0);
            }

        }

        private void dgv_staff_DoubleClick(object sender, EventArgs e)
        {
            staff.StaffID = Convert.ToInt32(dgv_staff.CurrentRow.Cells[0].Value);

            using (betterltdEntities db = new betterltdEntities())
            {
                staff = db.staffs.Where(i => i.StaffID == staff.StaffID).FirstOrDefault();
                txt_staffid.Text = staff.StaffID.ToString();
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            populatechart();
            string month = DateTime.Now.AddMonths(-6).Month.ToString();
            string year = DateTime.Now.AddMonths(-6).Year.ToString();
            for (int i = 0; i < 6; i++)
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            populatechart();
            txt_staffid.Text = "";
            
        }
    }
}
