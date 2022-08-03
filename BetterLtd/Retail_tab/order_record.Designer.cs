namespace BetterLtd.Retail_tab
{
    partial class order_record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_record));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.order_record_View = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.re_mng_lbl = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.lbl_sid = new System.Windows.Forms.Label();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.salorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.order_record_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // order_record_View
            // 
            resources.ApplyResources(this.order_record_View, "order_record_View");
            this.order_record_View.AllowUserToAddRows = false;
            this.order_record_View.AllowUserToDeleteRows = false;
            this.order_record_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.order_record_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.order_record_View.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.order_record_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.order_record_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.order_record_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.order_record_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.order_record_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_record_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salorderID,
            this.storeid,
            this.StaffID,
            this.CustomerID,
            this.TotalPrice,
            this.dateCreated});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.order_record_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.order_record_View.MultiSelect = false;
            this.order_record_View.Name = "order_record_View";
            this.order_record_View.ReadOnly = true;
            this.order_record_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.order_record_View.RowHeadersVisible = false;
            this.order_record_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.order_record_View.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.order_record_View.RowTemplate.Height = 24;
            this.order_record_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.order_record_View.DoubleClick += new System.EventHandler(this.order_record_View_DoubleClick);
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // re_mng_lbl
            // 
            resources.ApplyResources(this.re_mng_lbl, "re_mng_lbl");
            this.re_mng_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.re_mng_lbl.Name = "re_mng_lbl";
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
            // btn_Detail
            // 
            resources.ApplyResources(this.btn_Detail, "btn_Detail");
            this.btn_Detail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Detail.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.UseVisualStyleBackColor = false;
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
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
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // salorderID
            // 
            this.salorderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salorderID.DataPropertyName = "salorderID";
            resources.ApplyResources(this.salorderID, "salorderID");
            this.salorderID.Name = "salorderID";
            this.salorderID.ReadOnly = true;
            // 
            // storeid
            // 
            this.storeid.DataPropertyName = "StoreID";
            resources.ApplyResources(this.storeid, "storeid");
            this.storeid.Name = "storeid";
            this.storeid.ReadOnly = true;
            // 
            // StaffID
            // 
            this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffID.DataPropertyName = "StaffID";
            resources.ApplyResources(this.StaffID, "StaffID");
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerID.DataPropertyName = "CustomerID";
            resources.ApplyResources(this.CustomerID, "CustomerID");
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.DataPropertyName = "totalPrice";
            resources.ApplyResources(this.TotalPrice, "TotalPrice");
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // dateCreated
            // 
            this.dateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateCreated.DataPropertyName = "dateCreated";
            resources.ApplyResources(this.dateCreated, "dateCreated");
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.ReadOnly = true;
            // 
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // order_record
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_sid);
            this.Controls.Add(this.txt_sid);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.re_mng_lbl);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.order_record_View);
            this.Name = "order_record";
            this.Load += new System.EventHandler(this.order_record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_record_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView order_record_View;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label re_mng_lbl;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.Label lbl_sid;
        private System.Windows.Forms.TextBox txt_sid;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn salorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated;
    }
}