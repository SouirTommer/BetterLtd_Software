namespace BetterLtd.Admin_interfaces
{
    partial class Admin_warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_warehouse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Warehouse_View = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.storename_label = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_whaddress = new System.Windows.Forms.RichTextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.region_label = new System.Windows.Forms.Label();
            this.txt_region = new System.Windows.Forms.TextBox();
            this.city_label = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_whname = new System.Windows.Forms.TextBox();
            this.warehouse_lab = new System.Windows.Forms.Label();
            this.warehouseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // Warehouse_View
            // 
            resources.ApplyResources(this.Warehouse_View, "Warehouse_View");
            this.Warehouse_View.AllowUserToAddRows = false;
            this.Warehouse_View.AllowUserToDeleteRows = false;
            this.Warehouse_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Warehouse_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Warehouse_View.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Warehouse_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Warehouse_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Warehouse_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Warehouse_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Warehouse_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Warehouse_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehouseID,
            this.warehouseName,
            this.City,
            this.Region,
            this.Address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Warehouse_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.Warehouse_View.Name = "Warehouse_View";
            this.Warehouse_View.ReadOnly = true;
            this.Warehouse_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Warehouse_View.RowHeadersVisible = false;
            this.Warehouse_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Warehouse_View.RowTemplate.Height = 24;
            this.Warehouse_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Warehouse_View.DoubleClick += new System.EventHandler(this.Warehouse_View_DoubleClick);
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // storename_label
            // 
            resources.ApplyResources(this.storename_label, "storename_label");
            this.storename_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.storename_label.Name = "storename_label";
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_del
            // 
            resources.ApplyResources(this.btn_del, "btn_del");
            this.btn_del.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_del.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_del.Name = "btn_del";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
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
            // txt_whaddress
            // 
            resources.ApplyResources(this.txt_whaddress, "txt_whaddress");
            this.txt_whaddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_whaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_whaddress.Name = "txt_whaddress";
            // 
            // address_label
            // 
            resources.ApplyResources(this.address_label, "address_label");
            this.address_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.address_label.Name = "address_label";
            // 
            // region_label
            // 
            resources.ApplyResources(this.region_label, "region_label");
            this.region_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.region_label.Name = "region_label";
            // 
            // txt_region
            // 
            resources.ApplyResources(this.txt_region, "txt_region");
            this.txt_region.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_region.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_region.Name = "txt_region";
            // 
            // city_label
            // 
            resources.ApplyResources(this.city_label, "city_label");
            this.city_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.city_label.Name = "city_label";
            // 
            // txt_city
            // 
            resources.ApplyResources(this.txt_city, "txt_city");
            this.txt_city.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_city.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_city.Name = "txt_city";
            // 
            // txt_whname
            // 
            resources.ApplyResources(this.txt_whname, "txt_whname");
            this.txt_whname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_whname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_whname.Name = "txt_whname";
            // 
            // warehouse_lab
            // 
            resources.ApplyResources(this.warehouse_lab, "warehouse_lab");
            this.warehouse_lab.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.warehouse_lab.Name = "warehouse_lab";
            // 
            // warehouseID
            // 
            this.warehouseID.DataPropertyName = "warehouseID";
            resources.ApplyResources(this.warehouseID, "warehouseID");
            this.warehouseID.Name = "warehouseID";
            this.warehouseID.ReadOnly = true;
            // 
            // warehouseName
            // 
            this.warehouseName.DataPropertyName = "warehouseName";
            resources.ApplyResources(this.warehouseName, "warehouseName");
            this.warehouseName.Name = "warehouseName";
            this.warehouseName.ReadOnly = true;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.City.DataPropertyName = "City";
            resources.ApplyResources(this.City, "City");
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Region
            // 
            this.Region.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Region.DataPropertyName = "Region";
            resources.ApplyResources(this.Region, "Region");
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            resources.ApplyResources(this.Address, "Address");
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // btn_back
            // 
            resources.ApplyResources(this.btn_back, "btn_back");
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::BetterLtd.Properties.Resources.backpng;
            this.btn_back.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back.Name = "btn_back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Admin_warehouse
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.Warehouse_View);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.storename_label);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_whaddress);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.region_label);
            this.Controls.Add(this.txt_region);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_whname);
            this.Controls.Add(this.warehouse_lab);
            this.Name = "Admin_warehouse";
            this.Load += new System.EventHandler(this.Admin_warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Warehouse_View;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label storename_label;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.RichTextBox txt_whaddress;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label region_label;
        private System.Windows.Forms.TextBox txt_region;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_whname;
        private System.Windows.Forms.Label warehouse_lab;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}