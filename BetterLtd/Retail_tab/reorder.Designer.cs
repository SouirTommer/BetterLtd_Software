namespace BetterLtd.Retail_tab
{
    partial class reorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reorder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reorder_View = new System.Windows.Forms.DataGridView();
            this.re_mng_lbl = new System.Windows.Forms.Label();
            this.li_store = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.reordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reorder_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // reorder_View
            // 
            resources.ApplyResources(this.reorder_View, "reorder_View");
            this.reorder_View.AllowUserToAddRows = false;
            this.reorder_View.AllowUserToDeleteRows = false;
            this.reorder_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.reorder_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reorder_View.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.reorder_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reorder_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reorder_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reorder_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reorder_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reorder_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reordID,
            this.StaffID,
            this.prodID,
            this.prodName,
            this.status,
            this.createDate,
            this.approveDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reorder_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.reorder_View.Name = "reorder_View";
            this.reorder_View.ReadOnly = true;
            this.reorder_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reorder_View.RowHeadersVisible = false;
            this.reorder_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.reorder_View.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.reorder_View.RowTemplate.Height = 24;
            this.reorder_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reorder_View.DoubleClick += new System.EventHandler(this.reorder_View_DoubleClick);
            // 
            // re_mng_lbl
            // 
            resources.ApplyResources(this.re_mng_lbl, "re_mng_lbl");
            this.re_mng_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.re_mng_lbl.Name = "re_mng_lbl";
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Name = "label1";
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cancel_btn
            // 
            resources.ApplyResources(this.cancel_btn, "cancel_btn");
            this.cancel_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // reordID
            // 
            this.reordID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reordID.DataPropertyName = "reordID";
            resources.ApplyResources(this.reordID, "reordID");
            this.reordID.Name = "reordID";
            this.reordID.ReadOnly = true;
            // 
            // StaffID
            // 
            this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffID.DataPropertyName = "StaffID";
            resources.ApplyResources(this.StaffID, "StaffID");
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // prodID
            // 
            this.prodID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodID.DataPropertyName = "prodID";
            resources.ApplyResources(this.prodID, "prodID");
            this.prodID.Name = "prodID";
            this.prodID.ReadOnly = true;
            // 
            // prodName
            // 
            this.prodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodName.DataPropertyName = "prodName";
            resources.ApplyResources(this.prodName, "prodName");
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            resources.ApplyResources(this.status, "status");
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // createDate
            // 
            this.createDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createDate.DataPropertyName = "createDate";
            resources.ApplyResources(this.createDate, "createDate");
            this.createDate.Name = "createDate";
            this.createDate.ReadOnly = true;
            // 
            // approveDate
            // 
            this.approveDate.DataPropertyName = "approveDate";
            resources.ApplyResources(this.approveDate, "approveDate");
            this.approveDate.Name = "approveDate";
            this.approveDate.ReadOnly = true;
            // 
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // reorder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.li_store);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.re_mng_lbl);
            this.Controls.Add(this.reorder_View);
            this.Name = "reorder";
            this.Load += new System.EventHandler(this.reorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reorder_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reorder_View;
        private System.Windows.Forms.Label re_mng_lbl;
        private System.Windows.Forms.ComboBox li_store;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn approveDate;
    }
}