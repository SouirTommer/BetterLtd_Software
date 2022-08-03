namespace BetterLtd.Retail_tab
{
    partial class restock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(restock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.qty_text = new System.Windows.Forms.TextBox();
            this.li_prod = new System.Windows.Forms.ComboBox();
            this.reorder_li = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.removeitem_btn = new System.Windows.Forms.Button();
            this.additem_btn = new System.Windows.Forms.Button();
            this.reorderlist_dgv = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.li_store = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Stock_View = new System.Windows.Forms.DataGridView();
            this.re_mng_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_dangerlvl = new System.Windows.Forms.Button();
            this.txt_dangerlvl = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowlvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reorderlist_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            resources.ApplyResources(this.delete_btn, "delete_btn");
            this.delete_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            resources.ApplyResources(this.update_btn, "update_btn");
            this.update_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Name = "update_btn";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // add_btn
            // 
            resources.ApplyResources(this.add_btn, "add_btn");
            this.add_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Name = "add_btn";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // qty_text
            // 
            resources.ApplyResources(this.qty_text, "qty_text");
            this.qty_text.Name = "qty_text";
            this.qty_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qty_text_KeyPress);
            // 
            // li_prod
            // 
            resources.ApplyResources(this.li_prod, "li_prod");
            this.li_prod.FormattingEnabled = true;
            this.li_prod.Name = "li_prod";
            this.li_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.li_prod_KeyPress);
            // 
            // reorder_li
            // 
            resources.ApplyResources(this.reorder_li, "reorder_li");
            this.reorder_li.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reorder_li.Name = "reorder_li";
            // 
            // send_btn
            // 
            resources.ApplyResources(this.send_btn, "send_btn");
            this.send_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.send_btn.FlatAppearance.BorderSize = 0;
            this.send_btn.ForeColor = System.Drawing.Color.White;
            this.send_btn.Name = "send_btn";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // removeitem_btn
            // 
            resources.ApplyResources(this.removeitem_btn, "removeitem_btn");
            this.removeitem_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.removeitem_btn.FlatAppearance.BorderSize = 0;
            this.removeitem_btn.ForeColor = System.Drawing.Color.White;
            this.removeitem_btn.Name = "removeitem_btn";
            this.removeitem_btn.UseVisualStyleBackColor = false;
            this.removeitem_btn.Click += new System.EventHandler(this.removeitem_btn_Click);
            // 
            // additem_btn
            // 
            resources.ApplyResources(this.additem_btn, "additem_btn");
            this.additem_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.additem_btn.FlatAppearance.BorderSize = 0;
            this.additem_btn.ForeColor = System.Drawing.Color.White;
            this.additem_btn.Name = "additem_btn";
            this.additem_btn.UseVisualStyleBackColor = false;
            this.additem_btn.Click += new System.EventHandler(this.additem_btn_Click);
            // 
            // reorderlist_dgv
            // 
            resources.ApplyResources(this.reorderlist_dgv, "reorderlist_dgv");
            this.reorderlist_dgv.AllowUserToAddRows = false;
            this.reorderlist_dgv.AllowUserToDeleteRows = false;
            this.reorderlist_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.reorderlist_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reorderlist_dgv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.reorderlist_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reorderlist_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reorderlist_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reorderlist_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reorderlist_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reorderlist_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.PName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reorderlist_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.reorderlist_dgv.Name = "reorderlist_dgv";
            this.reorderlist_dgv.ReadOnly = true;
            this.reorderlist_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reorderlist_dgv.RowHeadersVisible = false;
            this.reorderlist_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.reorderlist_dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.reorderlist_dgv.RowTemplate.Height = 24;
            this.reorderlist_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // li_store
            // 
            resources.ApplyResources(this.li_store, "li_store");
            this.li_store.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_store.FormattingEnabled = true;
            this.li_store.Name = "li_store";
            this.li_store.SelectedIndexChanged += new System.EventHandler(this.li_warehouse_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Name = "label1";
            // 
            // Stock_View
            // 
            resources.ApplyResources(this.Stock_View, "Stock_View");
            this.Stock_View.AllowUserToAddRows = false;
            this.Stock_View.AllowUserToDeleteRows = false;
            this.Stock_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Stock_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Stock_View.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Stock_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Stock_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Stock_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stock_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Stock_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stock_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Brand,
            this.ProductType,
            this.ProductName,
            this.Price,
            this.quantity,
            this.lowlvl});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Stock_View.DefaultCellStyle = dataGridViewCellStyle7;
            this.Stock_View.MultiSelect = false;
            this.Stock_View.Name = "Stock_View";
            this.Stock_View.ReadOnly = true;
            this.Stock_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Stock_View.RowHeadersVisible = false;
            this.Stock_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Stock_View.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Stock_View.RowTemplate.Height = 24;
            this.Stock_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Stock_View.DoubleClick += new System.EventHandler(this.Stock_View_DoubleClick);
            // 
            // re_mng_lbl
            // 
            resources.ApplyResources(this.re_mng_lbl, "re_mng_lbl");
            this.re_mng_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.re_mng_lbl.Name = "re_mng_lbl";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Name = "label4";
            // 
            // btn_dangerlvl
            // 
            resources.ApplyResources(this.btn_dangerlvl, "btn_dangerlvl");
            this.btn_dangerlvl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dangerlvl.FlatAppearance.BorderSize = 0;
            this.btn_dangerlvl.ForeColor = System.Drawing.Color.White;
            this.btn_dangerlvl.Name = "btn_dangerlvl";
            this.btn_dangerlvl.UseVisualStyleBackColor = false;
            this.btn_dangerlvl.Click += new System.EventHandler(this.btn_dangerlvl_Click);
            // 
            // txt_dangerlvl
            // 
            resources.ApplyResources(this.txt_dangerlvl, "txt_dangerlvl");
            this.txt_dangerlvl.Name = "txt_dangerlvl";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "prodID";
            this.dataGridViewTextBoxColumn1.FillWeight = 111.9289F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "ProductName";
            resources.ApplyResources(this.PName, "PName");
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.DataPropertyName = "prodID";
            resources.ApplyResources(this.ProductID, "ProductID");
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brand.DataPropertyName = "Brand";
            resources.ApplyResources(this.Brand, "Brand");
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // ProductType
            // 
            this.ProductType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductType.DataPropertyName = "prodType";
            resources.ApplyResources(this.ProductType, "ProductType");
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "prodName";
            resources.ApplyResources(this.ProductName, "ProductName");
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "prodPrice";
            resources.ApplyResources(this.Price, "Price");
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "qty";
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // lowlvl
            // 
            this.lowlvl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lowlvl.DataPropertyName = "lowlevel";
            resources.ApplyResources(this.lowlvl, "lowlvl");
            this.lowlvl.Name = "lowlvl";
            this.lowlvl.ReadOnly = true;
            // 
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // restock
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_dangerlvl);
            this.Controls.Add(this.txt_dangerlvl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.re_mng_lbl);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.qty_text);
            this.Controls.Add(this.li_prod);
            this.Controls.Add(this.reorder_li);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.removeitem_btn);
            this.Controls.Add(this.additem_btn);
            this.Controls.Add(this.reorderlist_dgv);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.li_store);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stock_View);
            this.Name = "restock";
            this.Load += new System.EventHandler(this.restock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reorderlist_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox qty_text;
        private System.Windows.Forms.ComboBox li_prod;
        private System.Windows.Forms.Label reorder_li;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button removeitem_btn;
        private System.Windows.Forms.Button additem_btn;
        private System.Windows.Forms.DataGridView reorderlist_dgv;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox li_store;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Stock_View;
        private System.Windows.Forms.Label re_mng_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_dangerlvl;
        private System.Windows.Forms.TextBox txt_dangerlvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowlvl;
    }
}