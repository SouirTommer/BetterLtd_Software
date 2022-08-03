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
    public partial class accounting : Form
    {

        private Button currentButton;
        private Form activeform;

        public accounting()
        {
            InitializeComponent();
        }

        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.DimGray;

                }

            }

        }

        private void DisableButton()
        {
            foreach (Control previousBtn in Retail_panel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DimGray;
                    previousBtn.ForeColor = Color.White;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnsender)
        {
            if (activeform != null)
            {
                activeform.Close();
            }

            ActivateButton(btnsender);
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.tab_panel.Controls.Add(childForm);
            this.tab_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tab_1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Accounts_tab.performance(), sender);
        }

        private void tab_2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Accounts_tab.revenue(), sender);
        }

        private void tab_sellingstat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Accounts_tab.store_compare(), sender);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btn_pro_Click(object sender, EventArgs e)
        {
            profile pf = new profile();
            pf.Show();
        }

        private void tab_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accounting_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Login.username;

            Login.check_lang();
        }

        
    }
}
