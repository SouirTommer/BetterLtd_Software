namespace BetterLtd.Purchase_tab
{
    partial class catalogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Product_View = new System.Windows.Forms.DataGridView();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.num_price = new System.Windows.Forms.NumericUpDown();
            this.li_prodtype = new System.Windows.Forms.ComboBox();
            this.li_supname = new System.Windows.Forms.ComboBox();
            this.li_brand = new System.Windows.Forms.ComboBox();
            this.pprice_label = new System.Windows.Forms.Label();
            this.ptype_label = new System.Windows.Forms.Label();
            this.pname_label = new System.Windows.Forms.Label();
            this.brand_label = new System.Windows.Forms.Label();
            this.supplier_label = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.product_lab = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Product_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_View
            // 
            resources.ApplyResources(this.Product_View, "Product_View");
            this.Product_View.AllowUserToAddRows = false;
            this.Product_View.AllowUserToDeleteRows = false;
            this.Product_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Product_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Product_View.BackgroundColor = System.Drawing.Color.Honeydew;
            this.Product_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Product_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Product_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Product_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Product_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.SupplierID,
            this.Brand,
            this.ProductType,
            this.ProductName,
            this.Price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Product_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.Product_View.Name = "Product_View";
            this.Product_View.ReadOnly = true;
            this.Product_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Product_View.RowHeadersVisible = false;
            this.Product_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Product_View.RowTemplate.Height = 24;
            this.Product_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Product_View.DoubleClick += new System.EventHandler(this.Product_View_DoubleClick);
            // 
            // txt_pname
            // 
            resources.ApplyResources(this.txt_pname, "txt_pname");
            this.txt_pname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_pname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.TextChanged += new System.EventHandler(this.txt_pname_TextChanged);
            // 
            // num_price
            // 
            resources.ApplyResources(this.num_price, "num_price");
            this.num_price.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_price.DecimalPlaces = 2;
            this.num_price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_price.Name = "num_price";
            // 
            // li_prodtype
            // 
            resources.ApplyResources(this.li_prodtype, "li_prodtype");
            this.li_prodtype.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_prodtype.FormattingEnabled = true;
            this.li_prodtype.Items.AddRange(new object[] {
            resources.GetString("li_prodtype.Items"),
            resources.GetString("li_prodtype.Items1"),
            resources.GetString("li_prodtype.Items2"),
            resources.GetString("li_prodtype.Items3"),
            resources.GetString("li_prodtype.Items4"),
            resources.GetString("li_prodtype.Items5"),
            resources.GetString("li_prodtype.Items6"),
            resources.GetString("li_prodtype.Items7")});
            this.li_prodtype.Name = "li_prodtype";
            this.li_prodtype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.li_prodtype_KeyPress);
            // 
            // li_supname
            // 
            resources.ApplyResources(this.li_supname, "li_supname");
            this.li_supname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_supname.FormattingEnabled = true;
            this.li_supname.Name = "li_supname";
            this.li_supname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.li_supname_KeyPress);
            // 
            // li_brand
            // 
            resources.ApplyResources(this.li_brand, "li_brand");
            this.li_brand.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_brand.FormattingEnabled = true;
            this.li_brand.Items.AddRange(new object[] {
            resources.GetString("li_brand.Items"),
            resources.GetString("li_brand.Items1"),
            resources.GetString("li_brand.Items2"),
            resources.GetString("li_brand.Items3"),
            resources.GetString("li_brand.Items4"),
            resources.GetString("li_brand.Items5"),
            resources.GetString("li_brand.Items6"),
            resources.GetString("li_brand.Items7"),
            resources.GetString("li_brand.Items8"),
            resources.GetString("li_brand.Items9")});
            this.li_brand.Name = "li_brand";
            this.li_brand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.li_brand_KeyPress);
            // 
            // pprice_label
            // 
            resources.ApplyResources(this.pprice_label, "pprice_label");
            this.pprice_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pprice_label.Name = "pprice_label";
            // 
            // ptype_label
            // 
            resources.ApplyResources(this.ptype_label, "ptype_label");
            this.ptype_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ptype_label.Name = "ptype_label";
            // 
            // pname_label
            // 
            resources.ApplyResources(this.pname_label, "pname_label");
            this.pname_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pname_label.Name = "pname_label";
            // 
            // brand_label
            // 
            resources.ApplyResources(this.brand_label, "brand_label");
            this.brand_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.brand_label.Name = "brand_label";
            // 
            // supplier_label
            // 
            resources.ApplyResources(this.supplier_label, "supplier_label");
            this.supplier_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.supplier_label.Name = "supplier_label";
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // product_lab
            // 
            resources.ApplyResources(this.product_lab, "product_lab");
            this.product_lab.ForeColor = System.Drawing.Color.CadetBlue;
            this.product_lab.Name = "product_lab";
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_del
            // 
            resources.ApplyResources(this.btn_del, "btn_del");
            this.btn_del.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_del.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_del.Name = "btn_del";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            resources.ApplyResources(this.btn_add, "btn_add");
            this.btn_add.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_add.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_add.Name = "btn_add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.DataPropertyName = "prodID";
            resources.ApplyResources(this.ProductID, "ProductID");
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // SupplierID
            // 
            this.SupplierID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierID.DataPropertyName = "SupID";
            resources.ApplyResources(this.SupplierID, "SupplierID");
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
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
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // catalogue
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.product_lab);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.num_price);
            this.Controls.Add(this.li_prodtype);
            this.Controls.Add(this.li_supname);
            this.Controls.Add(this.li_brand);
            this.Controls.Add(this.pprice_label);
            this.Controls.Add(this.ptype_label);
            this.Controls.Add(this.pname_label);
            this.Controls.Add(this.brand_label);
            this.Controls.Add(this.supplier_label);
            this.Controls.Add(this.Product_View);
            this.Name = "catalogue";
            this.Load += new System.EventHandler(this.catalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Product_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Product_View;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.NumericUpDown num_price;
        private System.Windows.Forms.ComboBox li_prodtype;
        private System.Windows.Forms.ComboBox li_supname;
        private System.Windows.Forms.ComboBox li_brand;
        private System.Windows.Forms.Label pprice_label;
        private System.Windows.Forms.Label ptype_label;
        private System.Windows.Forms.Label pname_label;
        private System.Windows.Forms.Label brand_label;
        private System.Windows.Forms.Label supplier_label;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label product_lab;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}