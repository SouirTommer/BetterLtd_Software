namespace BetterLtd.Installation
{
    partial class Installorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installorder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ReqPeriod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.li_staff = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AllocateJob = new System.Windows.Forms.Button();
            this.InsReq_Picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cusadd_label = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.delorder_lab = new System.Windows.Forms.Label();
            this.insorder_View = new System.Windows.Forms.DataGridView();
            this.insorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ins_StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insReqDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insReqPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.li_month = new System.Windows.Forms.ComboBox();
            this.today_box = new System.Windows.Forms.CheckBox();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.insorder_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // ReqPeriod
            // 
            this.ReqPeriod.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.ReqPeriod, "ReqPeriod");
            this.ReqPeriod.FormattingEnabled = true;
            this.ReqPeriod.Items.AddRange(new object[] {
            resources.GetString("ReqPeriod.Items"),
            resources.GetString("ReqPeriod.Items1"),
            resources.GetString("ReqPeriod.Items2")});
            this.ReqPeriod.Name = "ReqPeriod";
            this.ReqPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReqPeriod_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Name = "label3";
            // 
            // li_staff
            // 
            this.li_staff.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.li_staff, "li_staff");
            this.li_staff.FormattingEnabled = true;
            this.li_staff.Name = "li_staff";
            this.li_staff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.li_staff_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Name = "label2";
            // 
            // AllocateJob
            // 
            this.AllocateJob.BackColor = System.Drawing.Color.MediumTurquoise;
            resources.ApplyResources(this.AllocateJob, "AllocateJob");
            this.AllocateJob.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.AllocateJob.Name = "AllocateJob";
            this.AllocateJob.UseVisualStyleBackColor = false;
            this.AllocateJob.Click += new System.EventHandler(this.AllocateJob_Click);
            // 
            // InsReq_Picker
            // 
            this.InsReq_Picker.AllowDrop = true;
            resources.ApplyResources(this.InsReq_Picker, "InsReq_Picker");
            this.InsReq_Picker.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.InsReq_Picker.Name = "InsReq_Picker";
            this.InsReq_Picker.Value = new System.DateTime(2022, 5, 24, 0, 0, 0, 0);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Name = "label1";
            // 
            // cusadd_label
            // 
            resources.ApplyResources(this.cusadd_label, "cusadd_label");
            this.cusadd_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cusadd_label.Name = "cusadd_label";
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_address, "txt_address");
            this.txt_address.Name = "txt_address";
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.MediumTurquoise;
            resources.ApplyResources(this.btn_del, "btn_del");
            this.btn_del.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_del.Name = "btn_del";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.MediumTurquoise;
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // delorder_lab
            // 
            resources.ApplyResources(this.delorder_lab, "delorder_lab");
            this.delorder_lab.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.delorder_lab.Name = "delorder_lab";
            // 
            // insorder_View
            // 
            this.insorder_View.AllowUserToAddRows = false;
            this.insorder_View.AllowUserToDeleteRows = false;
            this.insorder_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.insorder_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.insorder_View.BackgroundColor = System.Drawing.Color.Azure;
            this.insorder_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.insorder_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.insorder_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.insorder_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.insorder_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insorder_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.insorderID,
            this.salorderID,
            this.ins_StaffID,
            this.insStatus,
            this.Address,
            this.insReqDate,
            this.insReqPeriod,
            this.CreateDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.insorder_View.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.insorder_View, "insorder_View");
            this.insorder_View.Name = "insorder_View";
            this.insorder_View.ReadOnly = true;
            this.insorder_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.insorder_View.RowHeadersVisible = false;
            this.insorder_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Empty;
            this.insorder_View.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.insorder_View.RowTemplate.Height = 24;
            this.insorder_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.insorder_View.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.insorder_View_CellDoubleClick);
            this.insorder_View.DoubleClick += new System.EventHandler(this.insorder_View_DoubleClick);
            // 
            // insorderID
            // 
            this.insorderID.DataPropertyName = "insorderID";
            resources.ApplyResources(this.insorderID, "insorderID");
            this.insorderID.Name = "insorderID";
            this.insorderID.ReadOnly = true;
            // 
            // salorderID
            // 
            this.salorderID.DataPropertyName = "salorderID";
            resources.ApplyResources(this.salorderID, "salorderID");
            this.salorderID.Name = "salorderID";
            this.salorderID.ReadOnly = true;
            // 
            // ins_StaffID
            // 
            this.ins_StaffID.DataPropertyName = "ins_StaffID";
            resources.ApplyResources(this.ins_StaffID, "ins_StaffID");
            this.ins_StaffID.Name = "ins_StaffID";
            this.ins_StaffID.ReadOnly = true;
            // 
            // insStatus
            // 
            this.insStatus.DataPropertyName = "insStatus";
            resources.ApplyResources(this.insStatus, "insStatus");
            this.insStatus.Name = "insStatus";
            this.insStatus.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            resources.ApplyResources(this.Address, "Address");
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // insReqDate
            // 
            this.insReqDate.DataPropertyName = "insReqDate";
            resources.ApplyResources(this.insReqDate, "insReqDate");
            this.insReqDate.Name = "insReqDate";
            this.insReqDate.ReadOnly = true;
            // 
            // insReqPeriod
            // 
            this.insReqPeriod.DataPropertyName = "insReqPeriod";
            resources.ApplyResources(this.insReqPeriod, "insReqPeriod");
            this.insReqPeriod.Name = "insReqPeriod";
            this.insReqPeriod.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            resources.ApplyResources(this.CreateDate, "CreateDate");
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // li_month
            // 
            this.li_month.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.li_month, "li_month");
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
            // today_box
            // 
            resources.ApplyResources(this.today_box, "today_box");
            this.today_box.BackColor = System.Drawing.Color.White;
            this.today_box.ForeColor = System.Drawing.SystemColors.Desktop;
            this.today_box.Name = "today_box";
            this.today_box.UseVisualStyleBackColor = false;
            this.today_box.CheckedChanged += new System.EventHandler(this.today_box_CheckedChanged);
            // 
            // img_search
            // 
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // Installorder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.li_month);
            this.Controls.Add(this.today_box);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.ReqPeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.li_staff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllocateJob);
            this.Controls.Add(this.InsReq_Picker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cusadd_label);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.delorder_lab);
            this.Controls.Add(this.insorder_View);
            this.Controls.Add(this.txt_search);
            this.Name = "Installorder";
            this.Load += new System.EventHandler(this.Installorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insorder_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ReqPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox li_staff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AllocateJob;
        private System.Windows.Forms.DateTimePicker InsReq_Picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cusadd_label;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label delorder_lab;
        private System.Windows.Forms.DataGridView insorder_View;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.ComboBox li_month;
        private System.Windows.Forms.CheckBox today_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn insorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn salorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ins_StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn insStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn insReqDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn insReqPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
    }
}