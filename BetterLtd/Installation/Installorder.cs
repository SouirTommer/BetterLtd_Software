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
    public partial class Installorder : Form
    {
        installorder model = new installorder();
        activitylog actmodel = new activitylog();
        string today = System.DateTime.Now.ToString("yyyy-MM-dd");
        string month = System.DateTime.Now.ToString("yyyy-");
        public Installorder()
        {
            InitializeComponent();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (today_box.Checked == true)
            {

                using (var betterltd = new betterltdEntities())
                {
                    string keyword = txt_search.Text;

                    insorder_View.DataSource = betterltd.installorders.Where(i => i.insorderID.ToString().Contains(keyword) && i.insReqDate.ToString() == (today)
                                                || i.salorderID.ToString().Contains(keyword) && i.insReqDate.ToString() == (today)
                                                || i.ins_StaffID.ToString().Contains(keyword) && i.insReqDate.ToString() == (today)
                                                || i.insStatus.Contains(keyword) && i.insReqDate.ToString() == (today)
                                                || i.Address.Contains(keyword) && i.insReqDate.ToString() == (today)
                                                || i.insReqPeriod.Contains(keyword) && i.insReqDate.ToString() == (today)
                                                || i.CreateDate.ToString().Contains(keyword) && i.insReqDate.ToString() == (today)).ToList();
                }
            }
            else if (li_month.SelectedIndex > 0 && (today_box.Checked == false))
            {
                using (var betterltd = new betterltdEntities())
                {
                    string keyword = txt_search.Text;

                    if (Int32.Parse(li_month.Text) < 10)
                    {
                        month += 0 + li_month.Text;
                    }
                    else
                    {
                        month += li_month.Text;
                    }

                    insorder_View.DataSource = betterltd.installorders.Where(i => i.insorderID.ToString().Contains(keyword) && i.insReqDate.ToString().Contains(month)
                                                || i.salorderID.ToString().Contains(keyword) && i.insReqDate.ToString().Contains(month)
                                                || i.ins_StaffID.ToString().Contains(keyword) && i.insReqDate.ToString().Contains(month)
                                                || i.insStatus.Contains(keyword) && i.insReqDate.ToString().Contains(month)
                                                || i.Address.Contains(keyword) && i.insReqDate.ToString().Contains(month)
                                                || i.insReqPeriod.Contains(keyword) && i.insReqDate.ToString().Contains(month)
                                                || i.CreateDate.ToString().Contains(keyword) && i.insReqDate.ToString().Contains(month)).ToList();
                }
                month = System.DateTime.Now.ToString("yyyy-");
            }
            else
            {
                using (var betterltd = new betterltdEntities())
                {
                    string keyword = txt_search.Text;

                    insorder_View.DataSource = betterltd.installorders.Where(i => i.insorderID.ToString().Contains(keyword)
                                                || i.salorderID.ToString().Contains(keyword)
                                                || i.ins_StaffID.ToString().Contains(keyword)
                                                || i.insStatus.Contains(keyword)
                                                || i.Address.Contains(keyword)
                                                || i.insReqPeriod.Contains(keyword)
                                                || i.insReqDate.ToString().Contains(keyword)
                                                || i.CreateDate.ToString().Contains(keyword)).ToList();
                }
            }
        }

        private void li_staff_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        

        private void AllocateJob_Click(object sender, EventArgs e)
        {
            if (InsReq_Picker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Sorry, only Monday to Saturday can delivery");
                return;
            }

            using (var betterltd = new betterltdEntities())
            {

                if (string.IsNullOrEmpty(li_staff.Text))
                {

                    MessageBox.Show("You must select a staff");
                    return;
                }
                if (txt_address.Text == "")
                {
                    MessageBox.Show("You must enter all information");
                    return;
                }
                int int_staffid = Int32.Parse(li_staff.Text);
                int count = betterltd.installorders
                .Where(o => o.ins_StaffID == int_staffid
                && o.insReqPeriod == ReqPeriod.Text
                && o.insReqDate == InsReq_Picker.Value
                && o.isValid == 0)
                .Count();

                if (count >= 5)
                {
                    MessageBox.Show("This staff's job is full");
                    return;
                }
                else
                {
                    if (Login.manager == 0)
                    {
                        model.ins_StaffID = Int32.Parse(li_staff.Text);
                        actmodel.StaffID = Int32.Parse(Login.login_user);
                        actmodel.logType = "AllocateJob";
                        actmodel.Interface = "Installorder";
                        actmodel.logDate = DateTime.Now;
                    }
                    else
                    {
                        model.ins_StaffID = Int32.Parse(li_staff.Text);
                        model.insReqDate = InsReq_Picker.Value;
                        model.Address = txt_address.Text.Trim();
                        model.insReqDate = InsReq_Picker.Value;
                        model.insReqPeriod = ReqPeriod.Text;
                        actmodel.StaffID = Int32.Parse(Login.login_user);
                        actmodel.logType = "Modify";
                        actmodel.Interface = "Installorder";
                        actmodel.logDate = DateTime.Now;
                    }
                }
            }

            using (betterltdEntities db = new betterltdEntities())
            {
                db.Entry(model).State = EntityState.Modified;
                db.activitylogs.Add(actmodel);
                db.SaveChanges();
            }

            Clear();
            populate_dgv();
            MessageBox.Show("Successfully AllocateJob / Update data");
        }

        private void ReqPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReqPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirmed to delete this record?", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)

                model.isValid = 1;
                actmodel.StaffID = Int32.Parse(Login.login_user);
                actmodel.logType = "Delete";
                actmodel.Interface = "Installorder";
                actmodel.logDate = DateTime.Now;

            using (betterltdEntities db = new betterltdEntities())
            {
                db.Entry(model).State = EntityState.Modified;
                db.activitylogs.Add(actmodel);
                db.SaveChanges();
                MessageBox.Show("Set isvalid Successfully");

                Clear();
                populate_dgv();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        

        private void Installorder_Load(object sender, EventArgs e)
        {

            Clear();
            populate_dgv();
            Login.check_lang();

            if (Login.manager == 0)
            {
                btn_del.Visible = false;
                AllocateJob.Text = "Allocate Job";
            }

            using (var betterltd = new betterltdEntities())
            {
                var stafflist = from sf in betterltd.staffs
                                where sf.Position == "Tech Support"
                                select sf.StaffID;

                foreach (var staff in stafflist)
                {
                    li_staff.Items.Add(staff);
                }
            }
        }
        void populate_dgv()
        {
            insorder_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                insorder_View.DataSource = db.installorders.ToList<installorder>();
            }
        }
        void Clear()
        {
            li_staff.SelectedItem = null;
            ReqPeriod.SelectedItem = null;
            AllocateJob.BackColor = Color.Gray;
            AllocateJob.Enabled = false;
            btn_del.BackColor = Color.Gray;
            txt_address.Text = "";
            InsReq_Picker.Value = System.DateTime.Now;
            btn_del.Enabled = false;
            model.insorderID = 0;
        }

        private void insorder_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (insorder_View.CurrentRow.Index != -1)
            {
                model.insorderID = Convert.ToInt32(insorder_View.CurrentRow.Cells["insorderID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.installorders.Where(i => i.insorderID == model.insorderID).FirstOrDefault();
                    if (model.ins_StaffID != null)
                    {
                        li_staff.Text = model.ins_StaffID.ToString();
                    }
                    ReqPeriod.Text = model.insReqPeriod;
                    txt_address.Text = model.Address;
                    InsReq_Picker.Value = model.insReqDate;
                }
                btn_del.Enabled = true;
                btn_del.BackColor = btn_cancel.BackColor;
                AllocateJob.BackColor = btn_cancel.BackColor;
                AllocateJob.Enabled = true;

            }
        }

        private void insorder_View_DoubleClick(object sender, EventArgs e)
        {

        }

        private void today_box_CheckedChanged(object sender, EventArgs e)
        {

            if (today_box.Checked == true)
            {
                using (var betterltd = new betterltdEntities())
                {

                    li_month.Text = "All Month";
                    insorder_View.DataSource = betterltd.deliveryorders.Where(i => i.delReqDate.ToString() == (today)).ToList();
                }
                li_month.Enabled = false;
            }
            else
            {
                li_month.Enabled = true;
                populate_dgv();
            }
        }

        private void li_month_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (li_month.Text == "All Month")
            {
                populate_dgv();
            }
            else
            {
                using (var betterltd = new betterltdEntities())
                {
                    if (Int32.Parse(li_month.Text) < 10)
                    {
                        month += 0 + li_month.Text;
                    }
                    else
                    {
                        month += li_month.Text;
                    }
                    insorder_View.DataSource = betterltd.deliveryorders.Where(i => i.delReqDate.ToString().Contains(month)).ToList();
                    month = System.DateTime.Now.ToString("yyyy-");
                }
            }
        }

        private void li_month_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
