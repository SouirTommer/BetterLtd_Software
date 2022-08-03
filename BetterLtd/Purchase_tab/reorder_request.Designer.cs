namespace BetterLtd.Purchase_tab
{
    partial class reorder_request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reorder_request));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_reordereq = new System.Windows.Forms.Label();
            this.reorderRequest_view = new System.Windows.Forms.DataGridView();
            this.btn_reject = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.li_warehouse = new System.Windows.Forms.ComboBox();
            this.txt_suppID = new System.Windows.Forms.TextBox();
            this.txt_supName = new System.Windows.Forms.TextBox();
            this.lbl_suppName = new System.Windows.Forms.Label();
            this.lbl_suppID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_suppTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_suppEmail = new System.Windows.Forms.TextBox();
            this.btn_approve = new System.Windows.Forms.Button();
            this.reordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reorderRequest_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_reordereq
            // 
            resources.ApplyResources(this.lbl_reordereq, "lbl_reordereq");
            this.lbl_reordereq.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_reordereq.Name = "lbl_reordereq";
            // 
            // reorderRequest_view
            // 
            resources.ApplyResources(this.reorderRequest_view, "reorderRequest_view");
            this.reorderRequest_view.AllowUserToAddRows = false;
            this.reorderRequest_view.AllowUserToDeleteRows = false;
            this.reorderRequest_view.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.reorderRequest_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reorderRequest_view.BackgroundColor = System.Drawing.Color.Honeydew;
            this.reorderRequest_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reorderRequest_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reorderRequest_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reorderRequest_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reorderRequest_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reorderRequest_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reordID,
            this.StaffID,
            this.warehouseID,
            this.prodID,
            this.prodName,
            this.status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reorderRequest_view.DefaultCellStyle = dataGridViewCellStyle3;
            this.reorderRequest_view.MultiSelect = false;
            this.reorderRequest_view.Name = "reorderRequest_view";
            this.reorderRequest_view.ReadOnly = true;
            this.reorderRequest_view.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reorderRequest_view.RowHeadersVisible = false;
            this.reorderRequest_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.reorderRequest_view.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.reorderRequest_view.RowTemplate.Height = 24;
            this.reorderRequest_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reorderRequest_view.DoubleClick += new System.EventHandler(this.reorderRequest_view_DoubleClick);
            // 
            // btn_reject
            // 
            resources.ApplyResources(this.btn_reject, "btn_reject");
            this.btn_reject.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_reject.FlatAppearance.BorderSize = 0;
            this.btn_reject.ForeColor = System.Drawing.Color.White;
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.UseVisualStyleBackColor = false;
            this.btn_reject.Click += new System.EventHandler(this.btn_reject_Click);
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // li_warehouse
            // 
            resources.ApplyResources(this.li_warehouse, "li_warehouse");
            this.li_warehouse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_warehouse.FormattingEnabled = true;
            this.li_warehouse.Items.AddRange(new object[] {
            resources.GetString("li_warehouse.Items")});
            this.li_warehouse.Name = "li_warehouse";
            this.li_warehouse.SelectedIndexChanged += new System.EventHandler(this.li_warehouse_SelectedIndexChanged);
            this.li_warehouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.li_warehouse_KeyPress);
            // 
            // txt_suppID
            // 
            resources.ApplyResources(this.txt_suppID, "txt_suppID");
            this.txt_suppID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_suppID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_suppID.Name = "txt_suppID";
            this.txt_suppID.ReadOnly = true;
            // 
            // txt_supName
            // 
            resources.ApplyResources(this.txt_supName, "txt_supName");
            this.txt_supName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_supName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_supName.Name = "txt_supName";
            this.txt_supName.ReadOnly = true;
            // 
            // lbl_suppName
            // 
            resources.ApplyResources(this.lbl_suppName, "lbl_suppName");
            this.lbl_suppName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_suppName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_suppName.Name = "lbl_suppName";
            // 
            // lbl_suppID
            // 
            resources.ApplyResources(this.lbl_suppID, "lbl_suppID");
            this.lbl_suppID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_suppID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_suppID.Name = "lbl_suppID";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Name = "label1";
            // 
            // txt_suppTel
            // 
            resources.ApplyResources(this.txt_suppTel, "txt_suppTel");
            this.txt_suppTel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_suppTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_suppTel.Name = "txt_suppTel";
            this.txt_suppTel.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Name = "label2";
            // 
            // txt_suppEmail
            // 
            resources.ApplyResources(this.txt_suppEmail, "txt_suppEmail");
            this.txt_suppEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_suppEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_suppEmail.Name = "txt_suppEmail";
            this.txt_suppEmail.ReadOnly = true;
            // 
            // btn_approve
            // 
            resources.ApplyResources(this.btn_approve, "btn_approve");
            this.btn_approve.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_approve.FlatAppearance.BorderSize = 0;
            this.btn_approve.ForeColor = System.Drawing.Color.White;
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.UseVisualStyleBackColor = false;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
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
            // warehouseID
            // 
            this.warehouseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.warehouseID.DataPropertyName = "warehouseID";
            resources.ApplyResources(this.warehouseID, "warehouseID");
            this.warehouseID.Name = "warehouseID";
            this.warehouseID.ReadOnly = true;
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
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // reorder_request
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_suppEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_suppTel);
            this.Controls.Add(this.lbl_suppID);
            this.Controls.Add(this.lbl_suppName);
            this.Controls.Add(this.txt_supName);
            this.Controls.Add(this.txt_suppID);
            this.Controls.Add(this.li_warehouse);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.reorderRequest_view);
            this.Controls.Add(this.lbl_reordereq);
            this.Name = "reorder_request";
            this.Load += new System.EventHandler(this.reorder_request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reorderRequest_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_reordereq;
        private System.Windows.Forms.DataGridView reorderRequest_view;
        private System.Windows.Forms.Button btn_reject;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox li_warehouse;
        private System.Windows.Forms.TextBox txt_suppID;
        private System.Windows.Forms.TextBox txt_supName;
        private System.Windows.Forms.Label lbl_suppName;
        private System.Windows.Forms.Label lbl_suppID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_suppTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_suppEmail;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.DataGridViewTextBoxColumn reordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}