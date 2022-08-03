namespace BetterLtd.Retail_tab
{
    partial class choose_customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choose_customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_choosecus = new System.Windows.Forms.Label();
            this.dgv_cc = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_addnew = new System.Windows.Forms.Button();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.txt_cusid = new System.Windows.Forms.TextBox();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_choosecus
            // 
            resources.ApplyResources(this.lbl_choosecus, "lbl_choosecus");
            this.lbl_choosecus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_choosecus.Name = "lbl_choosecus";
            this.lbl_choosecus.Click += new System.EventHandler(this.lbl_choosecus_Click);
            // 
            // dgv_cc
            // 
            this.dgv_cc.AllowUserToAddRows = false;
            this.dgv_cc.AllowUserToDeleteRows = false;
            this.dgv_cc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_cc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cc.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_cc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_cc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_cc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_cc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LastName,
            this.CustomerTel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cc.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.dgv_cc, "dgv_cc");
            this.dgv_cc.MultiSelect = false;
            this.dgv_cc.Name = "dgv_cc";
            this.dgv_cc.ReadOnly = true;
            this.dgv_cc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_cc.RowHeadersVisible = false;
            this.dgv_cc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgv_cc.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_cc.RowTemplate.Height = 24;
            this.dgv_cc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cc.DoubleClick += new System.EventHandler(this.dgv_cc_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "CustomerID";
            this.ID.FillWeight = 20F;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            resources.ApplyResources(this.LastName, "LastName");
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // CustomerTel
            // 
            this.CustomerTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerTel.DataPropertyName = "CustomerTel";
            resources.ApplyResources(this.CustomerTel, "CustomerTel");
            this.CustomerTel.Name = "CustomerTel";
            this.CustomerTel.ReadOnly = true;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_addnew
            // 
            this.btn_addnew.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.btn_addnew, "btn_addnew");
            this.btn_addnew.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.UseVisualStyleBackColor = false;
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // btn_transfer
            // 
            this.btn_transfer.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.btn_transfer, "btn_transfer");
            this.btn_transfer.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.UseVisualStyleBackColor = false;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // txt_cusid
            // 
            this.txt_cusid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_cusid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_cusid, "txt_cusid");
            this.txt_cusid.Name = "txt_cusid";
            this.txt_cusid.ReadOnly = true;
            // 
            // img_search
            // 
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // choose_customer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_cusid);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.btn_addnew);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_cc);
            this.Controls.Add(this.lbl_choosecus);
            this.Name = "choose_customer";
            this.Load += new System.EventHandler(this.choose_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_choosecus;
        private System.Windows.Forms.DataGridView dgv_cc;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_addnew;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.TextBox txt_cusid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTel;
    }
}