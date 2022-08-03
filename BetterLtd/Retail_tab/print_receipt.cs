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
    public partial class print_receipt : Form
    {
        public string pid;
        public string pName;
        public string pPrice;
        public string Qty;
        public string subTotal;
        public string salorderid;
        public string staffid;
        public string storeid;
        public string total;
        public Boolean isPending;
        
        public List<print_receipt> pr_dgv;

        public print_receipt()
        {
            InitializeComponent();
        }

        private void print_receipt_Load(object sender, EventArgs e)
        {
            lbl_deposit.Hide();
            populatedgv();
            if(isPending == true)
            {
                lbl_deposit.Show();
            }
        }

        public void populatedgv()
        {
            txt_storeid.Text = storeid;
            txt_staffid.Text = staffid;
            txt_rno.Text = salorderid;
            txt_date.Text = DateTime.Now.ToString();
            for(int i=0; i<pr_dgv.Count; i++)
            {
                txt_pid.Text += pr_dgv[i].pid+"\n";
                txt_pid.AppendText(Environment.NewLine);
                txt_pid.AppendText(Environment.NewLine);
                txt_name.Text += pr_dgv[i].pName+"\n";
                txt_name.AppendText(Environment.NewLine);
                txt_name.AppendText(Environment.NewLine);
                txt_price.Text += pr_dgv[i].pPrice + "\n";
                txt_price.AppendText(Environment.NewLine);
                txt_price.AppendText(Environment.NewLine);
                txt_qty.Text += pr_dgv[i].Qty + "\n";
                txt_qty.AppendText(Environment.NewLine);
                txt_qty.AppendText(Environment.NewLine);
                txt_subtotal.Text += pr_dgv[i].subTotal + "\n";
                txt_subtotal.AppendText(Environment.NewLine);
                txt_subtotal.AppendText(Environment.NewLine);
            }
            txt_subtotal.Text += total;
            txt_qty.Text += "Total :";
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
