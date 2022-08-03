﻿using System;
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
    public partial class purchase : Form
    {
        private Button currentButton;
        private Form activeform;

        public purchase()
        {
            InitializeComponent();
        }

        private void purchase_Load(object sender, EventArgs e)
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
                    currentButton.ForeColor = Color.CadetBlue;

                }

            }

        }

        private void DisableButton()
        {
            foreach (Control previousBtn in Retail_panel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.CadetBlue;
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

        private void catalogue_tab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Purchase_tab.catalogue(), sender);
        }

        private void reorder_tab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Purchase_tab.reorder_request(), sender);
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

        private void tab_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
