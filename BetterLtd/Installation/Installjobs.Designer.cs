namespace BetterLtd.Installation
{
    partial class Installjobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installjobs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Ins_status_com = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.print_btn = new System.Windows.Forms.Button();
            this.jobs_View = new System.Windows.Forms.DataGridView();
            this.insorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insReqPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ins_StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insReqDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.insorder_lab = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jobs_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // Ins_status_com
            // 
            this.Ins_status_com.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.Ins_status_com, "Ins_status_com");
            this.Ins_status_com.FormattingEnabled = true;
            this.Ins_status_com.Items.AddRange(new object[] {
            resources.GetString("Ins_status_com.Items"),
            resources.GetString("Ins_status_com.Items1")});
            this.Ins_status_com.Name = "Ins_status_com";
            this.Ins_status_com.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ins_status_com_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Name = "label2";
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            resources.ApplyResources(this.print_btn, "print_btn");
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Name = "print_btn";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // jobs_View
            // 
            this.jobs_View.AllowUserToAddRows = false;
            this.jobs_View.AllowUserToDeleteRows = false;
            this.jobs_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.jobs_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.jobs_View.BackgroundColor = System.Drawing.Color.Azure;
            this.jobs_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jobs_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.jobs_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobs_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.jobs_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobs_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.insorderID,
            this.insReqPeriod,
            this.insStatus,
            this.Address,
            this.ins_StaffID,
            this.insReqDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jobs_View.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.jobs_View, "jobs_View");
            this.jobs_View.Name = "jobs_View";
            this.jobs_View.ReadOnly = true;
            this.jobs_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.jobs_View.RowHeadersVisible = false;
            this.jobs_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.jobs_View.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.jobs_View.RowTemplate.Height = 24;
            this.jobs_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobs_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobs_View_CellContentClick);
            this.jobs_View.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobs_View_CellDoubleClick);
            this.jobs_View.DoubleClick += new System.EventHandler(this.jobs_View_DoubleClick);
            // 
            // insorderID
            // 
            this.insorderID.DataPropertyName = "insorderID";
            resources.ApplyResources(this.insorderID, "insorderID");
            this.insorderID.Name = "insorderID";
            this.insorderID.ReadOnly = true;
            // 
            // insReqPeriod
            // 
            this.insReqPeriod.DataPropertyName = "insReqPeriod";
            resources.ApplyResources(this.insReqPeriod, "insReqPeriod");
            this.insReqPeriod.Name = "insReqPeriod";
            this.insReqPeriod.ReadOnly = true;
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
            // ins_StaffID
            // 
            this.ins_StaffID.DataPropertyName = "ins_StaffID";
            resources.ApplyResources(this.ins_StaffID, "ins_StaffID");
            this.ins_StaffID.Name = "ins_StaffID";
            this.ins_StaffID.ReadOnly = true;
            // 
            // insReqDate
            // 
            this.insReqDate.DataPropertyName = "insReqDate";
            resources.ApplyResources(this.insReqDate, "insReqDate");
            this.insReqDate.Name = "insReqDate";
            this.insReqDate.ReadOnly = true;
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
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.MediumTurquoise;
            resources.ApplyResources(this.btn_update, "btn_update");
            this.btn_update.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_update.Name = "btn_update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // insorder_lab
            // 
            resources.ApplyResources(this.insorder_lab, "insorder_lab");
            this.insorder_lab.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.insorder_lab.Name = "insorder_lab";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // img_search
            // 
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // Installjobs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Ins_status_com);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.jobs_View);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.insorder_lab);
            this.Name = "Installjobs";
            this.Load += new System.EventHandler(this.Installjobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobs_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Ins_status_com;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.DataGridView jobs_View;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label insorder_lab;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn insorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn insReqPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn insStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ins_StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn insReqDate;
    }
}