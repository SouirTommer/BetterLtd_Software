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

namespace BetterLtd
{
    public partial class ActivityLog : Form
    {
        activitylog model = new activitylog();

        public ActivityLog()
        {
            InitializeComponent();
            btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            btn_back.BackColorChanged += (s, e) => {
                btn_back.FlatAppearance.MouseOverBackColor = btn_back.BackColor;
            };
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin_menu ad = new Admin_menu();
            ad.Show();
            this.Hide();
        }

        private void ActivityLog_Load(object sender, EventArgs e)
        {
            Clear();
            populate_dgv();
            Login.check_lang();
        }
        void populate_dgv()
        {
            log_view.AutoGenerateColumns = false;
            using (betterltdEntities db = new betterltdEntities())
            {
                log_view.DataSource = db.activitylogs.ToList<activitylog>();
            }
        }

        void Clear()
        {
            model.actlogID = 0;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                string keyword = txt_search.Text;

                log_view.DataSource = betterltd.activitylogs.Where(i => i.actlogID.ToString().Contains(keyword)
                                            || i.StaffID.ToString().Contains(keyword)
                                            || i.logType.Contains(keyword)
                                            || i.Interface.Contains(keyword)
                                            || i.logDate.ToString().Contains(keyword)).ToList();

            }
        }

        private void log_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void img_search_Click(object sender, EventArgs e)
        {

        }
    }
}
