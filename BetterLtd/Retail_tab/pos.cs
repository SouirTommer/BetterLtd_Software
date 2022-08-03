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

namespace BetterLtd.Retail_tab
{
    public partial class pos : Form
    {
        
        public pos()
        {
            InitializeComponent();
            
        }

        private void pos_Load(object sender, EventArgs e)
        {

            Login.check_lang();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
