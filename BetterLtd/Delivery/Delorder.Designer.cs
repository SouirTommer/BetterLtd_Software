namespace BetterLtd.Delivery
{
    partial class Delorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delorder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.delorder_View = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.delorder_lab = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.cusadd_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DelReq_Picker = new System.Windows.Forms.DateTimePicker();
            this.AllocateJob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.li_staff = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReqPeriod = new System.Windows.Forms.ComboBox();
            this.today_box = new System.Windows.Forms.CheckBox();
            this.li_month = new System.Windows.Forms.ComboBox();
            this.delorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del_StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delReqPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delReqDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.delorder_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged_1);
            // 
            // delorder_View
            // 
            resources.ApplyResources(this.delorder_View, "delorder_View");
            this.delorder_View.AllowUserToAddRows = false;
            this.delorder_View.AllowUserToDeleteRows = false;
            this.delorder_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.delorder_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.delorder_View.BackgroundColor = System.Drawing.Color.SeaShell;
            this.delorder_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.delorder_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.delorder_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.delorder_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.delorder_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delorder_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delorderID,
            this.salorderID,
            this.reorderID,
            this.del_StaffID,
            this.delStatus,
            this.Address,
            this.delReqPeriod,
            this.delReqDate,
            this.CreateDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.delorder_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.delorder_View.Name = "delorder_View";
            this.delorder_View.ReadOnly = true;
            this.delorder_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.delorder_View.RowHeadersVisible = false;
            this.delorder_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.delorder_View.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.delorder_View.RowTemplate.Height = 24;
            this.delorder_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.delorder_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.delorder_View_CellContentClick);
            this.delorder_View.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.delorder_View_CellDoubleClick);
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.BackColor = System.Drawing.Color.Orange;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // delorder_lab
            // 
            resources.ApplyResources(this.delorder_lab, "delorder_lab");
            this.delorder_lab.ForeColor = System.Drawing.Color.Orange;
            this.delorder_lab.Name = "delorder_lab";
            // 
            // btn_del
            // 
            resources.ApplyResources(this.btn_del, "btn_del");
            this.btn_del.BackColor = System.Drawing.Color.Orange;
            this.btn_del.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_del.Name = "btn_del";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click_1);
            // 
            // txt_address
            // 
            resources.ApplyResources(this.txt_address, "txt_address");
            this.txt_address.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Name = "txt_address";
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // cusadd_label
            // 
            resources.ApplyResources(this.cusadd_label, "cusadd_label");
            this.cusadd_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cusadd_label.Name = "cusadd_label";
            this.cusadd_label.Click += new System.EventHandler(this.cusadd_label_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Name = "label1";
            // 
            // DelReq_Picker
            // 
            resources.ApplyResources(this.DelReq_Picker, "DelReq_Picker");
            this.DelReq_Picker.AllowDrop = true;
            this.DelReq_Picker.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DelReq_Picker.Name = "DelReq_Picker";
            this.DelReq_Picker.Value = new System.DateTime(2022, 5, 24, 0, 0, 0, 0);
            this.DelReq_Picker.ValueChanged += new System.EventHandler(this.DelReq_Picker_ValueChanged);
            // 
            // AllocateJob
            // 
            resources.ApplyResources(this.AllocateJob, "AllocateJob");
            this.AllocateJob.BackColor = System.Drawing.Color.Orange;
            this.AllocateJob.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.AllocateJob.Name = "AllocateJob";
            this.AllocateJob.UseVisualStyleBackColor = false;
            this.AllocateJob.Click += new System.EventHandler(this.AllocateJob_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Name = "label2";
            // 
            // li_staff
            // 
            resources.ApplyResources(this.li_staff, "li_staff");
            this.li_staff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_staff.FormattingEnabled = true;
            this.li_staff.Name = "li_staff";
            this.li_staff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.li_staff_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Name = "label3";
            // 
            // ReqPeriod
            // 
            resources.ApplyResources(this.ReqPeriod, "ReqPeriod");
            this.ReqPeriod.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReqPeriod.FormattingEnabled = true;
            this.ReqPeriod.Items.AddRange(new object[] {
            resources.GetString("ReqPeriod.Items"),
            resources.GetString("ReqPeriod.Items1"),
            resources.GetString("ReqPeriod.Items2")});
            this.ReqPeriod.Name = "ReqPeriod";
            this.ReqPeriod.SelectedIndexChanged += new System.EventHandler(this.ReqPeriod_SelectedIndexChanged);
            this.ReqPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReqPeriod_KeyPress);
            // 
            // today_box
            // 
            resources.ApplyResources(this.today_box, "today_box");
            this.today_box.BackColor = System.Drawing.Color.White;
            this.today_box.ForeColor = System.Drawing.SystemColors.Desktop;
            this.today_box.Name = "today_box";
            this.today_box.UseVisualStyleBackColor = false;
            this.today_box.CheckedChanged += new System.EventHandler(this.today_box_CheckedChanged);
            // 
            // li_month
            // 
            resources.ApplyResources(this.li_month, "li_month");
            this.li_month.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_month.FormattingEnabled = true;
            this.li_month.Items.AddRange(new object[] {
            resources.GetString("li_month.Items"),
            resources.GetString("li_month.Items1"),
            resources.GetString("li_month.Items2"),
            resources.GetString("li_month.Items3"),
            resources.GetString("li_month.Items4"),
            resources.GetString("li_month.Items5"),
            resources.GetString("li_month.Items6"),
            resources.GetString("li_month.Items7"),
            resources.GetString("li_month.Items8"),
            resources.GetString("li_month.Items9"),
            resources.GetString("li_month.Items10"),
            resources.GetString("li_month.Items11"),
            resources.GetString("li_month.Items12")});
            this.li_month.Name = "li_month";
            this.li_month.SelectedIndexChanged += new System.EventHandler(this.li_month_SelectedIndexChanged);
            this.li_month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.li_month_KeyPress);
            // 
            // delorderID
            // 
            this.delorderID.DataPropertyName = "delorderID";
            resources.ApplyResources(this.delorderID, "delorderID");
            this.delorderID.Name = "delorderID";
            this.delorderID.ReadOnly = true;
            // 
            // salorderID
            // 
            this.salorderID.DataPropertyName = "salorderID";
            resources.ApplyResources(this.salorderID, "salorderID");
            this.salorderID.Name = "salorderID";
            this.salorderID.ReadOnly = true;
            // 
            // reorderID
            // 
            this.reorderID.DataPropertyName = "reorderID";
            resources.ApplyResources(this.reorderID, "reorderID");
            this.reorderID.Name = "reorderID";
            this.reorderID.ReadOnly = true;
            // 
            // del_StaffID
            // 
            this.del_StaffID.DataPropertyName = "del_StaffID";
            resources.ApplyResources(this.del_StaffID, "del_StaffID");
            this.del_StaffID.Name = "del_StaffID";
            this.del_StaffID.ReadOnly = true;
            // 
            // delStatus
            // 
            this.delStatus.DataPropertyName = "delStatus";
            resources.ApplyResources(this.delStatus, "delStatus");
            this.delStatus.Name = "delStatus";
            this.delStatus.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            resources.ApplyResources(this.Address, "Address");
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // delReqPeriod
            // 
            this.delReqPeriod.DataPropertyName = "delReqPeriod";
            resources.ApplyResources(this.delReqPeriod, "delReqPeriod");
            this.delReqPeriod.Name = "delReqPeriod";
            this.delReqPeriod.ReadOnly = true;
            // 
            // delReqDate
            // 
            this.delReqDate.DataPropertyName = "delReqDate";
            resources.ApplyResources(this.delReqDate, "delReqDate");
            this.delReqDate.Name = "delReqDate";
            this.delReqDate.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            resources.ApplyResources(this.CreateDate, "CreateDate");
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // Delorder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.li_month);
            this.Controls.Add(this.today_box);
            this.Controls.Add(this.ReqPeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.li_staff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllocateJob);
            this.Controls.Add(this.DelReq_Picker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cusadd_label);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.delorder_lab);
            this.Controls.Add(this.delorder_View);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Name = "Delorder";
            this.Load += new System.EventHandler(this.Delorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delorder_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.DataGridView delorder_View;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label delorder_lab;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.Label cusadd_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DelReq_Picker;
        private System.Windows.Forms.Button AllocateJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox li_staff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ReqPeriod;
        private System.Windows.Forms.CheckBox today_box;
        private System.Windows.Forms.ComboBox li_month;
        private System.Windows.Forms.DataGridViewTextBoxColumn delorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn salorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn del_StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn delStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn delReqPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn delReqDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
    }
}