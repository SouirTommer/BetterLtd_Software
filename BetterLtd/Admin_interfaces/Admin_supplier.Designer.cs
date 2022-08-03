namespace BetterLtd
{
    partial class Admin_supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_supplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.supname_label = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.Supp_View = new System.Windows.Forms.DataGridView();
            this.txt_supaddress = new System.Windows.Forms.RichTextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.supemail_label = new System.Windows.Forms.Label();
            this.txt_supemail = new System.Windows.Forms.TextBox();
            this.suptel_label = new System.Windows.Forms.Label();
            this.txt_suptel = new System.Windows.Forms.TextBox();
            this.supplier_lab = new System.Windows.Forms.Label();
            this.txt_supname = new System.Windows.Forms.TextBox();
            this.SupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Supp_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // supname_label
            // 
            resources.ApplyResources(this.supname_label, "supname_label");
            this.supname_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.supname_label.Name = "supname_label";
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
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // Supp_View
            // 
            resources.ApplyResources(this.Supp_View, "Supp_View");
            this.Supp_View.AllowUserToAddRows = false;
            this.Supp_View.AllowUserToDeleteRows = false;
            this.Supp_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Supp_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Supp_View.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Supp_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Supp_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Supp_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Supp_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Supp_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Supp_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupID,
            this.SuppName,
            this.SuppTel,
            this.SuppEmail,
            this.Add});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Supp_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.Supp_View.Name = "Supp_View";
            this.Supp_View.ReadOnly = true;
            this.Supp_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Supp_View.RowHeadersVisible = false;
            this.Supp_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Supp_View.RowTemplate.Height = 24;
            this.Supp_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Supp_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Supp_View_CellContentClick);
            this.Supp_View.DoubleClick += new System.EventHandler(this.Supp_View_DoubleClick);
            // 
            // txt_supaddress
            // 
            resources.ApplyResources(this.txt_supaddress, "txt_supaddress");
            this.txt_supaddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_supaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_supaddress.Name = "txt_supaddress";
            // 
            // address_label
            // 
            resources.ApplyResources(this.address_label, "address_label");
            this.address_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.address_label.Name = "address_label";
            // 
            // supemail_label
            // 
            resources.ApplyResources(this.supemail_label, "supemail_label");
            this.supemail_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.supemail_label.Name = "supemail_label";
            // 
            // txt_supemail
            // 
            resources.ApplyResources(this.txt_supemail, "txt_supemail");
            this.txt_supemail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_supemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_supemail.Name = "txt_supemail";
            this.txt_supemail.TextChanged += new System.EventHandler(this.txt_supemail_TextChanged);
            this.txt_supemail.Leave += new System.EventHandler(this.txt_supemail_Leave);
            // 
            // suptel_label
            // 
            resources.ApplyResources(this.suptel_label, "suptel_label");
            this.suptel_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.suptel_label.Name = "suptel_label";
            // 
            // txt_suptel
            // 
            resources.ApplyResources(this.txt_suptel, "txt_suptel");
            this.txt_suptel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_suptel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_suptel.Name = "txt_suptel";
            this.txt_suptel.TextChanged += new System.EventHandler(this.txt_suptel_TextChanged);
            this.txt_suptel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_suptel_KeyPress);
            // 
            // supplier_lab
            // 
            resources.ApplyResources(this.supplier_lab, "supplier_lab");
            this.supplier_lab.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.supplier_lab.Name = "supplier_lab";
            // 
            // txt_supname
            // 
            resources.ApplyResources(this.txt_supname, "txt_supname");
            this.txt_supname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_supname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_supname.Name = "txt_supname";
            // 
            // SupID
            // 
            this.SupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupID.DataPropertyName = "SupID";
            resources.ApplyResources(this.SupID, "SupID");
            this.SupID.Name = "SupID";
            this.SupID.ReadOnly = true;
            this.SupID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SuppName
            // 
            this.SuppName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SuppName.DataPropertyName = "SupName";
            resources.ApplyResources(this.SuppName, "SuppName");
            this.SuppName.Name = "SuppName";
            this.SuppName.ReadOnly = true;
            // 
            // SuppTel
            // 
            this.SuppTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SuppTel.DataPropertyName = "SupTel";
            resources.ApplyResources(this.SuppTel, "SuppTel");
            this.SuppTel.Name = "SuppTel";
            this.SuppTel.ReadOnly = true;
            // 
            // SuppEmail
            // 
            this.SuppEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SuppEmail.DataPropertyName = "Supemail";
            resources.ApplyResources(this.SuppEmail, "SuppEmail");
            this.SuppEmail.Name = "SuppEmail";
            this.SuppEmail.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Add.DataPropertyName = "Address";
            resources.ApplyResources(this.Add, "Add");
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
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
            // Admin_supplier
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.supname_label);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.Supp_View);
            this.Controls.Add(this.txt_supaddress);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.supemail_label);
            this.Controls.Add(this.txt_supemail);
            this.Controls.Add(this.suptel_label);
            this.Controls.Add(this.txt_suptel);
            this.Controls.Add(this.supplier_lab);
            this.Controls.Add(this.txt_supname);
            this.Name = "Admin_supplier";
            this.Load += new System.EventHandler(this.Admin_supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Supp_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label supname_label;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView Supp_View;
        private System.Windows.Forms.RichTextBox txt_supaddress;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label supemail_label;
        private System.Windows.Forms.TextBox txt_supemail;
        private System.Windows.Forms.Label suptel_label;
        private System.Windows.Forms.TextBox txt_suptel;
        private System.Windows.Forms.Label supplier_lab;
        private System.Windows.Forms.TextBox txt_supname;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add;
    }
}