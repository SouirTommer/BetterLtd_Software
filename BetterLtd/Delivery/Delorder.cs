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

namespace BetterLtd.Delivery
{
    public partial class Delorder : Form
    {
        deliveryorder model = new deliveryorder();
        activitylog actmodel = new activitylog();
        string today = System.DateTime.Now.ToString("yyyy-MM-dd");
        string month = System.DateTime.Now.ToString("yyyy-");

        public Delorder()
        {
            InitializeComponent();
        }

        private void Delorder_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();

            if (Login.manager == 0)
            {
                btn_del.Visible = false;
                AllocateJob.Text = "Allocate Job";
            }


            using (var betterltd = new betterltdEntities())
            {
                var stafflist = from sf in betterltd.staffs
                                where sf.Position == "Inventory"
                                select sf.StaffID;

                foreach (var staff in stafflist)
                {
                    li_staff.Items.Add(staff);
                }
            }
            Login.check_lang();

        }

        void populate_dgv()
        {
            delorder_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                delorder_View.DataSource = db.deliveryorders.ToList<deliveryorder>();
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
            DelReq_Picker.Value = System.DateTime.Now;
            btn_del.Enabled = false;
            model.delorderID = 0;
        }

        private void DelReq_Picker_ValueChanged(object sender, EventArgs e)
        {

        }
        
       

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void delorder_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (delorder_View.CurrentRow.Index != -1)
            {
                model.delorderID = Convert.ToInt32(delorder_View.CurrentRow.Cells["delorderID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.deliveryorders.Where(i => i.delorderID == model.delorderID).FirstOrDefault();
                    if(model.del_StaffID != null)
                    {
                        li_staff.Text = model.del_StaffID.ToString();
                    }
                    ReqPeriod.Text = model.delReqPeriod;
                    txt_address.Text = model.Address;
                    DelReq_Picker.Value = model.delReqDate;
                }
                btn_del.Enabled = true;
                btn_del.BackColor = btn_cancel.BackColor;
                AllocateJob.BackColor = btn_cancel.BackColor;
                AllocateJob.Enabled = true;

            }
        }

        private void btn_del_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you confirmed to delete this record?", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)

                model.isValid = 1;
                actmodel.StaffID = Int32.Parse(Login.login_user);
                actmodel.logType = "Delete";
                actmodel.Interface = "Delorder";
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

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {
            if (today_box.Checked == true)
            {
                using (var betterltd = new betterltdEntities())
                {
                    string keyword = txt_search.Text;

                    delorder_View.DataSource = betterltd.deliveryorders.Where(i => i.delorderID.ToString().Contains(keyword) && i.delReqDate.ToString() == (today)
                                                || i.salorderID.ToString().Contains(keyword) && i.delReqDate.ToString() == (today)
                                                || i.reorderID.ToString().Contains(keyword) && i.delReqDate.ToString() == (today)
                                                || i.del_StaffID.ToString().Contains(keyword) && i.delReqDate.ToString() == (today)
                                                || i.delStatus.Contains(keyword) && i.delReqDate.ToString() == (today)
                                                || i.Address.Contains(keyword) && i.delReqDate.ToString() == (today)
                                                || i.CreateDate.ToString().Contains(keyword) && i.delReqDate.ToString() == (today)).ToList();
                }
            }
            else if (li_month.SelectedIndex>0 && (today_box.Checked == false))
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

                    delorder_View.DataSource = betterltd.deliveryorders.Where(i => i.delorderID.ToString().Contains(keyword) && i.delReqDate.ToString().Contains(month)
                                                || i.salorderID.ToString().Contains(keyword) && i.delReqDate.ToString().Contains(month)
                                                || i.reorderID.ToString().Contains(keyword) && i.delReqDate.ToString().Contains(month)
                                                || i.del_StaffID.ToString().Contains(keyword) && i.delReqDate.ToString().Contains(month)
                                                || i.delStatus.Contains(keyword) && i.delReqDate.ToString().Contains(month)
                                                || i.Address.Contains(keyword) && i.delReqDate.ToString().Contains(month)
                                                || i.delReqPeriod.Contains(keyword) && i.delReqDate.ToString().Contains(month)
                                                || i.CreateDate.ToString().Contains(keyword) && i.delReqDate.ToString().Contains(month)).ToList();
                }
                month = System.DateTime.Now.ToString("yyyy-");
            }
            else {
                using (var betterltd = new betterltdEntities())
                {
                    string keyword = txt_search.Text;

                    delorder_View.DataSource = betterltd.deliveryorders.Where(i => i.delorderID.ToString().Contains(keyword)
                                                || i.salorderID.ToString().Contains(keyword)
                                                || i.reorderID.ToString().Contains(keyword)
                                                || i.del_StaffID.ToString().Contains(keyword)
                                                || i.delStatus.Contains(keyword)
                                                || i.Address.Contains(keyword)
                                                || i.delReqPeriod.Contains(keyword)
                                                || i.delReqDate.ToString().Contains(keyword)
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
            if (DelReq_Picker.Value.DayOfWeek == DayOfWeek.Sunday)
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
                int int_del_StaffID = Int32.Parse(li_staff.Text);
                int count = betterltd.deliveryorders
                .Where(o => o.del_StaffID == int_del_StaffID
                && o.delReqPeriod == ReqPeriod.Text
                && o.delReqDate == DelReq_Picker.Value
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
                        model.del_StaffID = Int32.Parse(li_staff.Text);
                        actmodel.StaffID = Int32.Parse(Login.login_user);
                        actmodel.logType = "AllocateJob";
                        actmodel.Interface = "Delorder";
                        actmodel.logDate = DateTime.Now;
                    }
                    else
                    {
                        model.del_StaffID = Int32.Parse(li_staff.Text);
                        model.delReqDate = DelReq_Picker.Value;
                        model.Address = txt_address.Text.Trim();
                        model.delReqDate = DelReq_Picker.Value;
                        model.delReqPeriod = ReqPeriod.Text;
                        actmodel.StaffID = Int32.Parse(Login.login_user);
                        actmodel.logType = "Modify";
                        actmodel.Interface = "Delorder";
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

        private void delorder_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void today_box_CheckedChanged(object sender, EventArgs e)
        {
            if (today_box.Checked == true)
            {
                using (var betterltd = new betterltdEntities())
                {

                    li_month.Text = "All Month";
                    delorder_View.DataSource = betterltd.deliveryorders.Where(i => i.delReqDate.ToString()==(today)).ToList();
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
                    if (Int32.Parse(li_month.Text) <10)
                    {
                        month += 0+li_month.Text;
                    }
                    else
                    {
                        month += li_month.Text;
                    }
                    delorder_View.DataSource = betterltd.deliveryorders.Where(i => i.delReqDate.ToString().Contains(month)).ToList();
                    month = System.DateTime.Now.ToString("yyyy-");
                }
            }
        }

        private void li_month_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cusadd_label_Click(object sender, EventArgs e)
        {

        }
    }
}
