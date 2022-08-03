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

namespace BetterLtd
{
    public partial class Admin_acc : Form
    {
        acc model = new acc();
        staff model2 = new staff();

        public Admin_acc()
        {
            InitializeComponent();
            btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            btn_back.BackColorChanged += (s, e) => {
                btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            };
        }

        private void Admin_acc_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();
            Login.check_lang();
        }
        void populate_dgv()
        {
            acc_View.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                acc_View.DataSource = (from s in db.accs
                                       join c in db.staffs on s.accid equals c.StaffID                          
                                       select new
                                       {
                                           s.accid,
                                           c.StaffID,
                                           c.FirstName,
                                           c.LastName,
                                           s.Pwd,
                                           c.Gender,
                                           c.Position,
                                           c.StaffTel,
                                           c.Salary,
                                           s.isValid,
                                           c.isManager,
                                           c.isAdmin,
                                           s.RegDate
                                       }).ToList();
            }
        }
        void Clear()
        {
            btn_del.BackColor = Color.Gray;
            Firstname_text.Text = StaffTel_text.Text = Lastname_text.Text = Password_text.Text = "";
            gender_m.Checked = Gender_F.Checked = false;
            Position_list.Text = "";
            isManager_check.Checked = isAdmin_check.Checked = false;
            Salary_numeric.Value = 0;
            btn_add.Text = "Add";
            btn_del.Enabled = false;
            model.accid = 0;
        }
        private void StaffTel_text_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(StaffTel_text.Text, "  ^ [0-9]"))
            {
                StaffTel_text.Text = "";
            }
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {

            Admin_menu ad = new Admin_menu();
            ad.Show();
            this.Hide();
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void acc_View_DoubleClick_1(object sender, EventArgs e)
        {
            if (acc_View.CurrentRow.Index != -1)
            {
                model.accid = Convert.ToInt32(acc_View.CurrentRow.Cells["accid"].Value);
                model2.StaffID = Convert.ToInt32(acc_View.CurrentRow.Cells["StaffID"].Value);

                using (betterltdEntities db = new betterltdEntities())
                {
                    model = db.accs.Where(i => i.accid == model.accid).FirstOrDefault();
                    model2 = db.staffs.Where(i => i.StaffID == model.accid).FirstOrDefault();

                    Password_text.Text = model.Pwd;
                    Firstname_text.Text = model2.FirstName;
                    Lastname_text.Text = model2.LastName;
                    StaffTel_text.Text = model2.StaffTel.ToString();
                    Salary_numeric.Value = model2.Salary;
                    Position_list.Text = model2.Position;


                    if (model2.isManager == 1)
                    {
                        isManager_check.Checked = true;
                    }
                    if (model2.isAdmin == 1)
                    {
                        isAdmin_check.Checked = true;
                    }


                    if (model2.Gender == "M")
                    {
                        gender_m.Checked = true;
                    }

                    if (model2.Gender == "M")
                    {
                        gender_m.Checked = true;
                    }

                }
                btn_add.Text = "Update";
                btn_del.Enabled = true;
                btn_del.BackColor = btn_add.BackColor;

            }
        }

        private void StaffTel_text_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Salary_numeric_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as NumericUpDown).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Position_list_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you confirmed to block this record?", "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)

                model.isValid = 1;

                using (betterltdEntities db = new betterltdEntities())
                {
                        db.Entry(model).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Account Record Blocked Successfully");

                    Clear();
                    populate_dgv();
                }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Firstname_text.Text == "" || Position_list.Text == "" || Lastname_text.Text == "" || StaffTel_text.Text == "" || Password_text.Text == "" || (gender_m.Checked == false && Gender_F.Checked == false))
            {
                MessageBox.Show("You must enter all information");
                return;
            }
            model2.FirstName = Firstname_text.Text.Trim();
            model2.LastName = Lastname_text.Text.Trim();
            model2.StaffTel = Convert.ToInt32(StaffTel_text.Text.Trim());
            model2.Salary = Salary_numeric.Value;
            model.RegDate = DateTime.Now;
            model.Pwd = Password_text.Text.Trim();
            model2.Position = Position_list.Text;

            if (gender_m.Checked == true)
            {
                model2.Gender = "M";
            }
            else
            {
                model2.Gender = "F";
            }

            if (isManager_check.Checked == true)
            {
                model2.isManager = 1;
            }
            else
            {
                model2.isManager = 0;
            }

            if (isAdmin_check.Checked == true)
            {
                model2.isAdmin = 1;
            }
            else
            {
                model2.isAdmin = 0;
            }

            using (betterltdEntities db = new betterltdEntities())
            {
                if (model.accid == 0)
                {
                    db.accs.Add(model);
                    db.staffs.Add(model2);
                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.Entry(model2).State = EntityState.Modified;
                }
                db.SaveChanges();
            }

            Clear();
            populate_dgv();
            MessageBox.Show("Successfully Update");
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                acc_View.DataSource  = (from a in betterltd.accs
                                        join c in betterltd.staffs on a.accid equals c.StaffID
                                        where a.accid.ToString().Contains(keyword)
                                          || a.Pwd.Contains(keyword)
                                          || a.isValid.ToString().Contains(keyword)
                                          || a.RegDate.ToString().Contains(keyword)
                                          || c.StaffID.ToString().Contains(keyword)
                                          || c.Position.Contains(keyword)
                                          || c.FirstName.Contains(keyword)
                                          || c.LastName.Contains(keyword)
                                          || c.Gender.Contains(keyword)
                                          || c.StaffTel.ToString().Contains(keyword)
                                          || c.Salary.ToString().Contains(keyword)
                                          || c.isManager.ToString().Contains(keyword)
                                          || c.isAdmin.ToString().Contains(keyword)
                                        select new
                                        {
                                            a.accid,
                                            c.StaffID,
                                            c.FirstName,
                                            c.LastName,
                                            a.Pwd,
                                            c.Gender,
                                            c.Position,
                                            c.StaffTel,
                                            c.Salary,
                                            a.isValid,
                                            c.isManager,
                                            c.isAdmin,
                                            a.RegDate
                                        }
                                        ).ToList();

            }
        }

        private void StaffTel_text_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
