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

namespace BetterLtd.Retail_tab
{
    public partial class create_order : Form
    {
        store_stock model = new store_stock();

        string brand;
        string type;
        int storeid = 1;
        Boolean deposit = false;

        public create_order()
        {
            InitializeComponent();
            
        }

        private void create_order_Load(object sender, EventArgs e)
        {
            deposit = false;
            Clear();
            populate_dgv();

            using (var betterltd = new betterltdEntities())
            {
                var brandlist = betterltd.products.Where(x => x.isValid==0).Select(i => i.Brand).Distinct();


                foreach (var br in brandlist)
                {
                    li_brand.Items.Add(br);
                }
            }

            using (var betterltd = new betterltdEntities())
            {
                var typelist = betterltd.products.Where(x => x.isValid==0).Select(i => i.prodType).Distinct();


                foreach (var ty in typelist)
                {
                    li_type.Items.Add(ty);
                }
            }

            using (var betterltd = new betterltdEntities())
            {
                var storelist = betterltd.retailstores.Where(x=> x.isValid==0).Select(i => i.StoreName);

                foreach (var st in storelist)
                {
                    li_store.Items.Add(st);
                }
            }

            Login.check_lang();
        }

        void Clear()
        {

        }

        void populate_dgv()
        {
            //Stock_View.AutoGenerateColumns = false;
            //using (betterltdEntities db = new betterltdEntities())
            //{
            //    Stock_View.DataSource = (from s in db.products
            //                             join c in db.store_stock on s.prodID equals c.prodID
            //                             where c.StoreID == storeid
                                         //&& s.isValid == 0
            //                             orderby s.Brand ascending
            //                             select new
            //                             {
            //                                 s.prodID,
            //                                 s.Brand,
            //                                 s.prodType,
            //                                 s.prodName,
            //                                 s.prodPrice,
            //                                 c.qty
            //                             }).ToList();

            //}
        }

        void update_total()
        {
            int sum = 0;
            for (int i = 0; i < itemlist_dgv.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(itemlist_dgv.Rows[i].Cells[1].Value);
            }
            txt_totalprice.Text = "Total Price : " + sum.ToString();
        }

        private void li_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_search_TextChanged(sender, e);
        }

        private void li_store_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var betterltd = new betterltdEntities())
            {
                var result = betterltd.retailstores
                                    .Where(s => s.StoreName == li_store.Text)
                                    .Select(s => new { s.StoreID }).FirstOrDefault();

                storeid = result.StoreID;
            }

            txt_search_TextChanged(sender, e);
        }

        private void li_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_search_TextChanged(sender, e);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            brand = li_brand.Text;
            type = li_type.Text;

            if (brand == "All" && type == "All")
            {
                using (var betterltd = new betterltdEntities())
                {
                    string keyword = txt_search.Text;
                    Stock_View.DataSource = (from s in betterltd.products
                                             join c in betterltd.store_stock on s.prodID equals c.prodID
                                             where
                                             (c.StoreID == storeid && s.isValid ==0)
                                             &&
                                             (s.prodID.ToString().Contains(keyword)
                                             || s.prodName.Contains(keyword)
                                             || s.prodType.Contains(keyword)
                                             || s.prodPrice.ToString().Contains(keyword)
                                             || s.Brand.Contains(keyword)
                                             || c.qty.ToString().Contains(keyword))
                                             orderby s.Brand ascending
                                             select new
                                             {
                                                 s.prodID,
                                                 s.Brand,
                                                 s.prodType,
                                                 s.prodName,
                                                 s.prodPrice,
                                                 c.qty
                                             }).ToList();
                }
            }
            if (type != "All" && brand != "All")
            {
                using (var betterltd = new betterltdEntities())
                {
                    string keyword = txt_search.Text;
                    Stock_View.DataSource = (from s in betterltd.products
                                             join c in betterltd.store_stock on s.prodID equals c.prodID
                                             where
                                             (s.prodPrice.ToString().Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.Brand == li_brand.Text
                                             && s.prodType == li_type.Text
                                             && s.isValid == 0)
                                             ||
                                             (s.prodName.Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.Brand == li_brand.Text
                                             && s.prodType == li_type.Text
                                             && s.isValid == 0)
                                             ||
                                             (c.qty.ToString().Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.Brand == li_brand.Text
                                             && s.prodType == li_type.Text
                                             && s.isValid == 0)
                                             ||
                                             (s.prodID.ToString().Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.Brand == li_brand.Text
                                             && s.prodType == li_type.Text
                                             && s.isValid == 0)
                                             orderby s.Brand ascending
                                             select new
                                             {
                                                 s.prodID,
                                                 s.Brand,
                                                 s.prodType,
                                                 s.prodName,
                                                 s.prodPrice,
                                                 c.qty
                                             }).ToList();
                }
            }
            if (type != "All" && brand == "All")
            {
                using (var betterltd = new betterltdEntities())
                {
                    string keyword = txt_search.Text;
                    Stock_View.DataSource = (from s in betterltd.products
                                             join c in betterltd.store_stock on s.prodID equals c.prodID
                                             where
                                             (s.prodPrice.ToString().Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.prodType == type
                                             && s.isValid == 0)
                                             ||
                                             (s.prodName.Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.prodType == type
                                             && s.isValid == 0)
                                             ||
                                             (c.qty.ToString().Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.prodType == type
                                             && s.isValid == 0)
                                             ||
                                             (s.prodID.ToString().Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.prodType == type
                                             && s.isValid == 0)
                                             ||
                                             (s.Brand.Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.prodType == type
                                             && s.isValid == 0)
                                             orderby s.Brand ascending
                                             select new
                                             {
                                                 s.prodID,
                                                 s.Brand,
                                                 s.prodType,
                                                 s.prodName,
                                                 s.prodPrice,
                                                 c.qty
                                             }).ToList();
                }
            }
            if (type == "All" && brand != "All")
            {
                using (var betterltd = new betterltdEntities())
                {
                    string keyword = txt_search.Text;
                    Stock_View.DataSource = (from s in betterltd.products
                                             join c in betterltd.store_stock on s.prodID equals c.prodID
                                             where
                                             (s.prodPrice.ToString().Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.Brand == brand
                                             && s.isValid == 0)
                                             ||
                                             (s.prodName.Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.Brand == brand
                                             && s.isValid == 0)
                                             ||
                                             (c.qty.ToString().Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.Brand == brand
                                             && s.isValid == 0)
                                             ||
                                             (s.prodID.ToString().Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.Brand == brand
                                             && s.isValid == 0)
                                             ||
                                             (s.prodType.Contains(keyword)
                                             && c.StoreID == storeid
                                             && s.Brand == brand
                                             && s.isValid == 0)
                                             orderby s.Brand ascending
                                             select new
                                             {
                                                 s.prodID,
                                                 s.Brand,
                                                 s.prodType,
                                                 s.prodName,
                                                 s.prodPrice,
                                                 c.qty
                                             }).ToList();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (deposit == false)
                {


                    if (Convert.ToInt32(Stock_View.CurrentRow.Cells[5].Value) == 0)
                    {
                        if (MessageBox.Show(" Switch to deposit mode ?", null, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Deposit_mode.BackColor = Color.Green;
                            this.itemlist_dgv.Rows.Clear();
                            update_total();
                        }
                        return;

                    }
                    if (qtycheck() == 0)
                    {
                        var prodID = Stock_View.SelectedRows[0].Cells[0].Value;
                        var price = Stock_View.SelectedRows[0].Cells[4].Value;

                        var index = this.itemlist_dgv.Rows.Add();
                        this.itemlist_dgv.Rows[index].Cells[0].Value = prodID;
                        this.itemlist_dgv.Rows[index].Cells[1].Value = price;
                        update_total();
                    }
                    else
                    {
                        return;
                    }
                }
                if (deposit == true)
                {
                    if(Convert.ToInt32(Stock_View.CurrentRow.Cells[5].Value) == 0)
                    {
                        var prodID = Stock_View.SelectedRows[0].Cells[0].Value;
                        var price = Convert.ToInt32(Stock_View.SelectedRows[0].Cells[4].Value) * (0.2);

                        var index = this.itemlist_dgv.Rows.Add();
                        this.itemlist_dgv.Rows[index].Cells[0].Value = prodID;
                        this.itemlist_dgv.Rows[index].Cells[1].Value = price;
                        update_total();
                    }
                    else
                    {
                        MessageBox.Show("Please choose an unavailable item");
                    }
                    
                }
 
                
            } catch (Exception)
            {
                MessageBox.Show("Please select correct item first");
            }
        }

        public int qtycheck()
        {
            string pid = Stock_View.CurrentRow.Cells[0].Value.ToString();

            int count = 0;

            for(int i = 0; i<itemlist_dgv.RowCount; i++)
            {
                if (itemlist_dgv.Rows[i].Cells[0].Value.ToString() == pid)
                {
                    count++;
                }
                
            }
            
            if(Convert.ToInt32(Stock_View.CurrentRow.Cells[5].Value) == count)
            {
                MessageBox.Show("Not enough Stock");
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.itemlist_dgv.SelectedRows)
            {
                itemlist_dgv.Rows.RemoveAt(item.Index);
            }
            update_total();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select all choices first");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.itemlist_dgv.Rows.Clear();
            update_total();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            string[] receipt = new string[itemlist_dgv.RowCount];

            foreach (DataGridViewRow row in itemlist_dgv.Rows)
            {
                receipt[row.Index] = row.Cells[0].Value.ToString();
            }

            if (itemlist_dgv.Rows.Count >= 1)
            {
                confirm_order co = new confirm_order();
                co.receipt = receipt;
                co.storeid = storeid;
                co.isPending = deposit;
                co.Show();
            }
            else
            {
                MessageBox.Show("Please add product first");
            }
        }

        private void re_mng_lbl_Click(object sender, EventArgs e)
        {

        }

        private void li_store_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void li_brand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void li_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Deposit_mode_Click(object sender, EventArgs e)
        {
            if(Deposit_mode.BackColor == Color.Green)
            {
                Deposit_mode.BackColor = Color.Red;
                deposit = false;
                this.itemlist_dgv.Rows.Clear();
                update_total();
                MessageBox.Show("Swiched to Normal Order Mode");

            }
            else
            {
                Deposit_mode.BackColor = Color.Green;
                deposit = true;
                this.itemlist_dgv.Rows.Clear();
                update_total();
                MessageBox.Show("Swiched to Deposit Order Mode");
            }
        }
    }
}
