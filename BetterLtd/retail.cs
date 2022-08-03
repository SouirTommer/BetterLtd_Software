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
    public partial class retail : Form
    {
        private Button currentButton;
        private Form activeform;

        public retail()
        {
            InitializeComponent();
        }

        private void retail_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Login.username;

            Login.check_lang();
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
                    currentButton.ForeColor = Color.SteelBlue;

                }
            
            }

        }

        private void DisableButton()
        {
            foreach (Control previousBtn in Retail_panel.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.SteelBlue;
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

        private void create_order_tab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Retail_tab.create_order(), sender);
        }

        private void Order_record_tab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Retail_tab.order_record(), sender);
        }

        private void stock_tab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Retail_tab.restock(), sender);
        }


        private void reorder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Retail_tab.reorder(), sender);
        }

        private void Retail_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tab_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            profile pf = new profile();
            pf.Show();
        }

        private void Delivery_tab_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Retail_tab.delivery(), sender);
        }


        private void Customer_tab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Retail_tab.Customer(), sender);
        }
    }
}
