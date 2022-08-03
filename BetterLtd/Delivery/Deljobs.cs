using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.Entity;
using System.Threading;

namespace BetterLtd.Delivery
{
    public partial class Deljobs : Form
    {
        public static string djob = "";
        deliveryorder model = new deliveryorder();
        installorder insorder = new installorder();
        activitylog actmodel = new activitylog();

        public Deljobs()
        {
            InitializeComponent();
        }

        private void Deljobs_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();
            Login.check_lang();
        }
        void populate_dgv()
        {
            jobs_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                jobs_View.DataSource = db.deliveryorders.Where
                    (i => i.del_StaffID.ToString().Contains(Login.login_user)
                       && !i.delStatus.Contains("Finished")).ToList();
            }

            using (betterltdEntities db = new betterltdEntities())
            {
                var stafflist = from sf in db.deliveryorders
                                where sf.del_StaffID.ToString() == Login.login_user && !sf.delStatus.Contains("Finished")
                                && sf.isValid == 0
                                select new
                                {
                                    sf.delReqPeriod,
                                    sf.delorderID,
                                    sf.Address
                                };

                foreach (var q in stafflist)
                {
                    djob += q;
                    djob += "\n";
                }
            }
        }
        void Clear()
        {
            Del_status_com.SelectedItem = null;
            btn_update.BackColor = Color.Gray;
            btn_update.Enabled = false;
            model.delorderID = 0;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                jobs_View.DataSource = betterltd.deliveryorders.Where(i => i.delorderID.ToString().Contains(keyword) && i.del_StaffID.ToString() == Login.login_user
                                                                        || i.delStatus.Contains(keyword) && i.del_StaffID.ToString() == Login.login_user
                                                                        || i.Address.Contains(keyword) && i.del_StaffID.ToString() == Login.login_user
                                                                        || i.delReqPeriod.Contains(keyword) && i.del_StaffID.ToString() == Login.login_user
                                                                        || i.delReqDate.ToString().Contains(keyword) && i.del_StaffID.ToString() == Login.login_user).ToList();
            }
        }

        private void Del_status_com_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Del_status_com.Text))
            {
                MessageBox.Show("You must enter all information");
                return;
            }



            model.delStatus = Del_status_com.Text;
            actmodel.StaffID = Int32.Parse(Login.login_user);
            actmodel.logType = "Modify";
            actmodel.Interface = "Deljobs";
            actmodel.logDate = DateTime.Now;

            using (betterltdEntities db = new betterltdEntities())
            {
                if (Del_status_com.SelectedIndex == 2)
                {
                    
                    var needIns = (from p in db.installorders
                                       where p.salorderID == model.salorderID
                                       select p).SingleOrDefault();
                        if (needIns != null)
                        {
                            insorder = needIns;
                            insorder.insStatus = "Wait for ins";
                            db.Entry(insorder).State = EntityState.Modified;
                        }
                }

                db.Entry(model).State = EntityState.Modified;
                db.activitylogs.Add(actmodel);
                db.SaveChanges();
            }

            Clear();
            populate_dgv();
            MessageBox.Show("Successfully Update");
        }

        private void delorder_View_DoubleClick(object sender, EventArgs e)
        {
            if (jobs_View.CurrentRow.Index != -1)
            {
                model.delorderID = Convert.ToInt32(jobs_View.CurrentRow.Cells["delorderID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.deliveryorders.Where(i => i.delorderID == model.delorderID).FirstOrDefault();
                    Del_status_com.Text = model.delStatus;

                }
                btn_update.Enabled = true;
                btn_update.BackColor = btn_cancel.BackColor;

            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            
        PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;

            DialogResult result = printDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics gf = e.Graphics;
            SizeF sf = gf.MeasureString("Delivery Jobs\n Date: " + DateTime.Now.ToString("MM/dd/yyyy") + "\nStaffID: " + Login.login_user + "\n---------------\n" + djob,
                            new Font(new FontFamily("Calibri"), 30), 800);
            gf.DrawString("Delivery Jobs Date:" + DateTime.Now.ToString("MM/dd/yyyy") + "\nStaffID: " + Login.login_user + "\n---\n" + djob,
                            new Font(new FontFamily("Calibri"), 30), Brushes.Black,
                            new RectangleF(new PointF(50, 50), sf),
                            StringFormat.GenericTypographic);
            

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
