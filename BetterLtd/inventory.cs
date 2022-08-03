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
    public partial class inventory : Form
    {
        private Button currentButton;
        private Form activeform;

        public inventory()
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
                currentButton.ForeColor = Color.Orange;

            }

        }

    }

    private void DisableButton()
    {
        foreach (Control previousBtn in Inventory_panel.Controls)
        {
            if (previousBtn.GetType() == typeof(Button))
            {
                previousBtn.BackColor = Color.Orange;
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

        private void i_stock_tab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory_tab.whstock(), sender);

        }

        private void i_delivery_tab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Delivery.Delorder(), sender);
        }

        private void Back_Login_btn_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Inventory_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void job_tab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Delivery.Deljobs(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory_tab.store_reorder_req(), sender);
        }

        private void whr_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory_tab.reorder(), sender);
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            profile pf = new profile();
            pf.Show();
        }

        private void tab_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inventory_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Login.username;

            Login.check_lang();
        }

        private void tab_inward_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory_tab.update_inward(), sender);
        }
    }
}
