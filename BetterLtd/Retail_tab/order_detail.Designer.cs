namespace BetterLtd.Retail_tab
{
    partial class order_detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_detail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_odetail = new System.Windows.Forms.Label();
            this.od_dgv = new System.Windows.Forms.DataGridView();
            this.lbl_sid = new System.Windows.Forms.Label();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.lbl_pid = new System.Windows.Forms.Label();
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.lbl_pName = new System.Windows.Forms.Label();
            this.txt_pName = new System.Windows.Forms.TextBox();
            this.lbl_return_qty = new System.Windows.Forms.Label();
            this.num_return_qty = new System.Windows.Forms.NumericUpDown();
            this.lbl_currentStock = new System.Windows.Forms.Label();
            this.txt_currentstock = new System.Windows.Forms.TextBox();
            this.lbl_storeId = new System.Windows.Forms.Label();
            this.txt_StoreId = new System.Windows.Forms.TextBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.od_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_return_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_odetail
            // 
            resources.ApplyResources(this.lbl_odetail, "lbl_odetail");
            this.lbl_odetail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_odetail.Name = "lbl_odetail";
            // 
            // od_dgv
            // 
            resources.ApplyResources(this.od_dgv, "od_dgv");
            this.od_dgv.AllowUserToAddRows = false;
            this.od_dgv.AllowUserToDeleteRows = false;
            this.od_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.od_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.od_dgv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.od_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.od_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.od_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.od_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.od_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.od_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Price,
            this.quantity,
            this.Total});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.od_dgv.DefaultCellStyle = dataGridViewCellStyle7;
            this.od_dgv.MultiSelect = false;
            this.od_dgv.Name = "od_dgv";
            this.od_dgv.ReadOnly = true;
            this.od_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.od_dgv.RowHeadersVisible = false;
            this.od_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.od_dgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.od_dgv.RowTemplate.Height = 24;
            this.od_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.od_dgv.DoubleClick += new System.EventHandler(this.od_dgv_DoubleClick);
            // 
            // lbl_sid
            // 
            resources.ApplyResources(this.lbl_sid, "lbl_sid");
            this.lbl_sid.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_sid.Name = "lbl_sid";
            // 
            // txt_sid
            // 
            resources.ApplyResources(this.txt_sid, "txt_sid");
            this.txt_sid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_sid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.ReadOnly = true;
            // 
            // lbl_pid
            // 
            resources.ApplyResources(this.lbl_pid, "lbl_pid");
            this.lbl_pid.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_pid.Name = "lbl_pid";
            // 
            // txt_pid
            // 
            resources.ApplyResources(this.txt_pid, "txt_pid");
            this.txt_pid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_pid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.ReadOnly = true;
            // 
            // lbl_pName
            // 
            resources.ApplyResources(this.lbl_pName, "lbl_pName");
            this.lbl_pName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_pName.Name = "lbl_pName";
            // 
            // txt_pName
            // 
            resources.ApplyResources(this.txt_pName, "txt_pName");
            this.txt_pName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_pName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pName.Name = "txt_pName";
            this.txt_pName.ReadOnly = true;
            // 
            // lbl_return_qty
            // 
            resources.ApplyResources(this.lbl_return_qty, "lbl_return_qty");
            this.lbl_return_qty.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_return_qty.Name = "lbl_return_qty";
            // 
            // num_return_qty
            // 
            resources.ApplyResources(this.num_return_qty, "num_return_qty");
            this.num_return_qty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num_return_qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_return_qty.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.num_return_qty.Name = "num_return_qty";
            // 
            // lbl_currentStock
            // 
            resources.ApplyResources(this.lbl_currentStock, "lbl_currentStock");
            this.lbl_currentStock.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_currentStock.Name = "lbl_currentStock";
            // 
            // txt_currentstock
            // 
            resources.ApplyResources(this.txt_currentstock, "txt_currentstock");
            this.txt_currentstock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_currentstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_currentstock.Name = "txt_currentstock";
            this.txt_currentstock.ReadOnly = true;
            // 
            // lbl_storeId
            // 
            resources.ApplyResources(this.lbl_storeId, "lbl_storeId");
            this.lbl_storeId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_storeId.Name = "lbl_storeId";
            // 
            // txt_StoreId
            // 
            resources.ApplyResources(this.txt_StoreId, "txt_StoreId");
            this.txt_StoreId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_StoreId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_StoreId.Name = "txt_StoreId";
            this.txt_StoreId.ReadOnly = true;
            // 
            // btn_return
            // 
            resources.ApplyResources(this.btn_return, "btn_return");
            this.btn_return.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_return.FlatAppearance.BorderSize = 0;
            this.btn_return.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_return.Name = "btn_return";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.DataPropertyName = "prodID";
            resources.ApplyResources(this.ProductID, "ProductID");
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
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
            this.Price.DataPropertyName = "price";
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
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "Total";
            resources.ApplyResources(this.Total, "Total");
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // order_detail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lbl_storeId);
            this.Controls.Add(this.txt_StoreId);
            this.Controls.Add(this.lbl_currentStock);
            this.Controls.Add(this.txt_currentstock);
            this.Controls.Add(this.num_return_qty);
            this.Controls.Add(this.lbl_return_qty);
            this.Controls.Add(this.lbl_pName);
            this.Controls.Add(this.txt_pName);
            this.Controls.Add(this.lbl_pid);
            this.Controls.Add(this.txt_pid);
            this.Controls.Add(this.lbl_sid);
            this.Controls.Add(this.txt_sid);
            this.Controls.Add(this.od_dgv);
            this.Controls.Add(this.lbl_odetail);
            this.Name = "order_detail";
            this.Load += new System.EventHandler(this.order_detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.od_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_return_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_odetail;
        private System.Windows.Forms.DataGridView od_dgv;
        private System.Windows.Forms.Label lbl_sid;
        private System.Windows.Forms.TextBox txt_sid;
        private System.Windows.Forms.Label lbl_pid;
        private System.Windows.Forms.TextBox txt_pid;
        private System.Windows.Forms.Label lbl_pName;
        private System.Windows.Forms.TextBox txt_pName;
        private System.Windows.Forms.Label lbl_return_qty;
        private System.Windows.Forms.NumericUpDown num_return_qty;
        private System.Windows.Forms.Label lbl_currentStock;
        private System.Windows.Forms.TextBox txt_currentstock;
        private System.Windows.Forms.Label lbl_storeId;
        private System.Windows.Forms.TextBox txt_StoreId;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}