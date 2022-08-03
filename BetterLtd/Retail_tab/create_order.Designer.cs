namespace BetterLtd.Retail_tab
{
    partial class create_order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_order));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.li_store = new System.Windows.Forms.ComboBox();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.itemlist_dgv = new System.Windows.Forms.DataGridView();
            this.li_type = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.Stock_View = new System.Windows.Forms.DataGridView();
            this.li_brand = new System.Windows.Forms.ComboBox();
            this.re_mng_lbl = new System.Windows.Forms.Label();
            this.Deposit_mode = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemlist_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // li_store
            // 
            resources.ApplyResources(this.li_store, "li_store");
            this.li_store.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_store.FormattingEnabled = true;
            this.li_store.Name = "li_store";
            this.li_store.SelectedIndexChanged += new System.EventHandler(this.li_store_SelectedIndexChanged);
            this.li_store.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.li_store_KeyPress);
            // 
            // txt_totalprice
            // 
            resources.ApplyResources(this.txt_totalprice, "txt_totalprice");
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.ReadOnly = true;
            // 
            // btn_next
            // 
            resources.ApplyResources(this.btn_next, "btn_next");
            this.btn_next.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_next.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_next.Name = "btn_next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_clear
            // 
            resources.ApplyResources(this.btn_clear, "btn_clear");
            this.btn_clear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Remove
            // 
            resources.ApplyResources(this.Remove, "Remove");
            this.Remove.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Remove.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Remove.Name = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btn_add
            // 
            resources.ApplyResources(this.btn_add, "btn_add");
            this.btn_add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_add.Name = "btn_add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // itemlist_dgv
            // 
            resources.ApplyResources(this.itemlist_dgv, "itemlist_dgv");
            this.itemlist_dgv.AllowUserToAddRows = false;
            this.itemlist_dgv.AllowUserToDeleteRows = false;
            this.itemlist_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.itemlist_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemlist_dgv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.itemlist_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemlist_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.itemlist_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemlist_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.itemlist_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemlist_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemlist_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemlist_dgv.Name = "itemlist_dgv";
            this.itemlist_dgv.ReadOnly = true;
            this.itemlist_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.itemlist_dgv.RowHeadersVisible = false;
            this.itemlist_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.itemlist_dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.itemlist_dgv.RowTemplate.Height = 24;
            this.itemlist_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // li_type
            // 
            resources.ApplyResources(this.li_type, "li_type");
            this.li_type.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_type.FormattingEnabled = true;
            this.li_type.Items.AddRange(new object[] {
            resources.GetString("li_type.Items")});
            this.li_type.Name = "li_type";
            this.li_type.SelectedIndexChanged += new System.EventHandler(this.li_type_SelectedIndexChanged);
            this.li_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.li_type_KeyPress);
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
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
            this.ProductType,
            this.ProductName,
            this.Price,
            this.quantity});
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
            // 
            // li_brand
            // 
            resources.ApplyResources(this.li_brand, "li_brand");
            this.li_brand.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_brand.FormattingEnabled = true;
            this.li_brand.Items.AddRange(new object[] {
            resources.GetString("li_brand.Items")});
            this.li_brand.Name = "li_brand";
            this.li_brand.SelectedIndexChanged += new System.EventHandler(this.li_brand_SelectedIndexChanged);
            this.li_brand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.li_brand_KeyPress);
            // 
            // re_mng_lbl
            // 
            resources.ApplyResources(this.re_mng_lbl, "re_mng_lbl");
            this.re_mng_lbl.BackColor = System.Drawing.Color.Transparent;
            this.re_mng_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.re_mng_lbl.Name = "re_mng_lbl";
            // 
            // Deposit_mode
            // 
            resources.ApplyResources(this.Deposit_mode, "Deposit_mode");
            this.Deposit_mode.BackColor = System.Drawing.Color.Red;
            this.Deposit_mode.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Deposit_mode.Name = "Deposit_mode";
            this.Deposit_mode.UseVisualStyleBackColor = false;
            this.Deposit_mode.Click += new System.EventHandler(this.Deposit_mode_Click);
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "prodPrice";
            this.dataGridViewTextBoxColumn6.FillWeight = 111.9289F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.DataPropertyName = "prodID";
            resources.ApplyResources(this.ProductID, "ProductID");
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
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
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // create_order
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Deposit_mode);
            this.Controls.Add(this.re_mng_lbl);
            this.Controls.Add(this.li_store);
            this.Controls.Add(this.txt_totalprice);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.itemlist_dgv);
            this.Controls.Add(this.li_type);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.Stock_View);
            this.Controls.Add(this.li_brand);
            this.Name = "create_order";
            this.Load += new System.EventHandler(this.create_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemlist_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox li_store;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView itemlist_dgv;
        private System.Windows.Forms.ComboBox li_type;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView Stock_View;
        private System.Windows.Forms.ComboBox li_brand;
        private System.Windows.Forms.Label re_mng_lbl;
        private System.Windows.Forms.Button Deposit_mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}