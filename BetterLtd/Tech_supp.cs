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
    public partial class Tech_supp : Form
    {
        private Button currentButton;
        private Form activeform;

        public Tech_supp()
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
                currentButton.ForeColor = Color.MediumTurquoise;

            }

        }

    }

    private void DisableButton()
    {
        foreach (Control previousBtn in Tech_supp_panel.Controls)
        {
            if (previousBtn.GetType() == typeof(Button))
            {
                previousBtn.BackColor = Color.MediumTurquoise;
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

        private void installation_tab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Installation.Installorder(), sender);
        }

        private void jobs_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Installation.Installjobs(), sender);
        }

        private void btn_duty_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tech_supp_tab.duty(), sender);
        }



        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void Tech_supp_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Login.username;

            Login.check_lang();
        }

        private void Back_Login_btn_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            profile pf = new profile();
            pf.Show();
        }
    }
}
