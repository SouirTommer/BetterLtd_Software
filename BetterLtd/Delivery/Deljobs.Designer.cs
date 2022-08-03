namespace BetterLtd.Delivery
{
    partial class Deljobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deljobs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delorder_lab = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.jobs_View = new System.Windows.Forms.DataGridView();
            this.print_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Del_status_com = new System.Windows.Forms.ComboBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.delorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delReqPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delReqDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jobs_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // delorder_lab
            // 
            resources.ApplyResources(this.delorder_lab, "delorder_lab");
            this.delorder_lab.ForeColor = System.Drawing.Color.Orange;
            this.delorder_lab.Name = "delorder_lab";
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_update
            // 
            resources.ApplyResources(this.btn_update, "btn_update");
            this.btn_update.BackColor = System.Drawing.Color.Orange;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Name = "btn_update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.BackColor = System.Drawing.Color.Orange;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // jobs_View
            // 
            resources.ApplyResources(this.jobs_View, "jobs_View");
            this.jobs_View.AllowUserToAddRows = false;
            this.jobs_View.AllowUserToDeleteRows = false;
            this.jobs_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.jobs_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.jobs_View.BackgroundColor = System.Drawing.Color.SeaShell;
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
            this.delorderID,
            this.delReqPeriod,
            this.delStatus,
            this.Address,
            this.DEL_StaffID,
            this.delReqDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jobs_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.jobs_View.Name = "jobs_View";
            this.jobs_View.ReadOnly = true;
            this.jobs_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.jobs_View.RowHeadersVisible = false;
            this.jobs_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.jobs_View.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.jobs_View.RowTemplate.Height = 24;
            this.jobs_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobs_View.DoubleClick += new System.EventHandler(this.delorder_View_DoubleClick);
            // 
            // print_btn
            // 
            resources.ApplyResources(this.print_btn, "print_btn");
            this.print_btn.BackColor = System.Drawing.Color.Orange;
            this.print_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.print_btn.Name = "print_btn";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Name = "label2";
            // 
            // Del_status_com
            // 
            resources.ApplyResources(this.Del_status_com, "Del_status_com");
            this.Del_status_com.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Del_status_com.FormattingEnabled = true;
            this.Del_status_com.Items.AddRange(new object[] {
            resources.GetString("Del_status_com.Items"),
            resources.GetString("Del_status_com.Items1"),
            resources.GetString("Del_status_com.Items2")});
            this.Del_status_com.Name = "Del_status_com";
            this.Del_status_com.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Del_status_com_KeyPress);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // delorderID
            // 
            this.delorderID.DataPropertyName = "delorderID";
            resources.ApplyResources(this.delorderID, "delorderID");
            this.delorderID.Name = "delorderID";
            this.delorderID.ReadOnly = true;
            // 
            // delReqPeriod
            // 
            this.delReqPeriod.DataPropertyName = "delReqPeriod";
            resources.ApplyResources(this.delReqPeriod, "delReqPeriod");
            this.delReqPeriod.Name = "delReqPeriod";
            this.delReqPeriod.ReadOnly = true;
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
            // DEL_StaffID
            // 
            this.DEL_StaffID.DataPropertyName = "DEL_StaffID";
            resources.ApplyResources(this.DEL_StaffID, "DEL_StaffID");
            this.DEL_StaffID.Name = "DEL_StaffID";
            this.DEL_StaffID.ReadOnly = true;
            // 
            // delReqDate
            // 
            this.delReqDate.DataPropertyName = "delReqDate";
            resources.ApplyResources(this.delReqDate, "delReqDate");
            this.delReqDate.Name = "delReqDate";
            this.delReqDate.ReadOnly = true;
            // 
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // Deljobs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Del_status_com);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.jobs_View);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.delorder_lab);
            this.Name = "Deljobs";
            this.Load += new System.EventHandler(this.Deljobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobs_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label delorder_lab;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView jobs_View;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Del_status_com;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.DataGridViewTextBoxColumn delorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn delReqPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn delStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn delReqDate;
    }
}