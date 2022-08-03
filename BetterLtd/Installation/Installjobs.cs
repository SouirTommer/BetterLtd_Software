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

namespace BetterLtd.Installation
{
    public partial class Installjobs : Form
    {
        public static string ijob = "";
        installorder model = new installorder();
        activitylog actmodel = new activitylog();

        public Installjobs()
        {
            InitializeComponent();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                jobs_View.DataSource = betterltd.installorders.Where(i => i.insorderID.ToString().Contains(keyword) && i.ins_StaffID.ToString() == Login.login_user
                                                                        || i.insStatus.Contains(keyword) && i.ins_StaffID.ToString() == Login.login_user
                                                                        || i.Address.Contains(keyword) && i.ins_StaffID.ToString() == Login.login_user
                                                                        || i.insReqPeriod.Contains(keyword) && i.ins_StaffID.ToString() == Login.login_user
                                                                        || i.insReqDate.ToString().Contains(keyword) && i.ins_StaffID.ToString() == Login.login_user).ToList();
            }
        }

        private void jobs_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void Ins_status_com_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Ins_status_com.Text))
            {
                MessageBox.Show("You must enter all information");
                return;
            }
            model.insStatus = Ins_status_com.Text;
            actmodel.StaffID = Int32.Parse(Login.login_user);
            actmodel.logType = "Modify";
            actmodel.Interface = "insjobs";
            actmodel.logDate = DateTime.Now;

            using (betterltdEntities db = new betterltdEntities())
            {
                db.Entry(model).State = EntityState.Modified;
                db.activitylogs.Add(actmodel);
                db.SaveChanges();
            }

            Clear();
            populate_dgv();
            MessageBox.Show("Successfully Update");
        }

        private void print_btn_Click(object sender, EventArgs e)
        {

            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;

            DialogResult result = printDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;

            DialogResult result = printDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void Installjobs_Load(object sender, EventArgs e)
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
                jobs_View.DataSource = db.installorders.Where
                    (i => i.ins_StaffID.ToString().Contains(Login.login_user)
                       && !i.insStatus.Contains("Finished")).ToList();
            }

            using (betterltdEntities db = new betterltdEntities())
            {
                var stafflist = from sf in db.installorders
                                where sf.ins_StaffID.ToString() == Login.login_user && !sf.insStatus.Contains("Finished")
                                && sf.isValid == 0
                                select new
                                {
                                    sf.insReqPeriod,
                                    sf.insorderID,
                                    sf.Address
                                };

                foreach (var q in stafflist)
                {
                    ijob += q;
                    ijob += "\n";
                }
            }
        }

        void Clear()
        {
            Ins_status_com.SelectedItem = null;
            btn_update.BackColor = Color.Gray;
            btn_update.Enabled = false;
            model.insorderID = 0;
        }

        private void jobs_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void jobs_View_DoubleClick(object sender, EventArgs e)
        {
            if (jobs_View.CurrentRow.Index != -1)
            {
                model.insorderID = Convert.ToInt32(jobs_View.CurrentRow.Cells["insorderID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.installorders.Where(i => i.insorderID == model.insorderID).FirstOrDefault();
                    Ins_status_com.Text = model.insStatus;

                }
                btn_update.Enabled = true;
                btn_update.BackColor = btn_cancel.BackColor;

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics gf = e.Graphics;
            SizeF sf = gf.MeasureString("Installation Jobs\n Date: " + DateTime.Now.ToString("MM/dd/yyyy") + "\nStaffID: " + Login.login_user + "\n---------------\n" + ijob,
                            new Font(new FontFamily("Calibri"), 30), 800);
            gf.DrawString("Install Jobs Date:" + DateTime.Now.ToString("MM/dd/yyyy") + "\nStaffID: " + Login.login_user + "\n---\n" + ijob,
                            new Font(new FontFamily("Calibri"), 30), Brushes.Black,
                            new RectangleF(new PointF(50, 50), sf),
                            StringFormat.GenericTypographic);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
