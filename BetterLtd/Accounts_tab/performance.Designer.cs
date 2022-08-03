namespace BetterLtd.Accounts_tab
{
    partial class performance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(performance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lbl_performance = new System.Windows.Forms.Label();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.ct_revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_staffid = new System.Windows.Forms.Label();
            this.txt_staffid = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_revenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_performance
            // 
            resources.ApplyResources(this.lbl_performance, "lbl_performance");
            this.lbl_performance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_performance.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_performance.Name = "lbl_performance";
            // 
            // dgv_staff
            // 
            resources.ApplyResources(this.dgv_staff, "dgv_staff");
            this.dgv_staff.AllowUserToAddRows = false;
            this.dgv_staff.AllowUserToDeleteRows = false;
            this.dgv_staff.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_staff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_staff.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_staff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_staff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_staff.MultiSelect = false;
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.ReadOnly = true;
            this.dgv_staff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_staff.RowHeadersVisible = false;
            this.dgv_staff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgv_staff.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_staff.RowTemplate.Height = 24;
            this.dgv_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_staff.DoubleClick += new System.EventHandler(this.dgv_staff_DoubleClick);
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // ct_revenue
            // 
            resources.ApplyResources(this.ct_revenue, "ct_revenue");
            this.ct_revenue.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ct_revenue.ChartAreas.Add(chartArea1);
            this.ct_revenue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ct_revenue.Name = "ct_revenue";
            this.ct_revenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Revenue";
            this.ct_revenue.Series.Add(series1);
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            title1.Name = "Title1";
            title1.Text = "Revenue";
            this.ct_revenue.Titles.Add(title1);
            // 
            // btn_check
            // 
            resources.ApplyResources(this.btn_check, "btn_check");
            this.btn_check.BackColor = System.Drawing.Color.DimGray;
            this.btn_check.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_check.Name = "btn_check";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.BackColor = System.Drawing.Color.DimGray;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_staffid
            // 
            resources.ApplyResources(this.lbl_staffid, "lbl_staffid");
            this.lbl_staffid.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_staffid.Name = "lbl_staffid";
            // 
            // txt_staffid
            // 
            resources.ApplyResources(this.txt_staffid, "txt_staffid");
            this.txt_staffid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_staffid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_staffid.Name = "txt_staffid";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "StaffID";
            this.ID.FillWeight = 20F;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            resources.ApplyResources(this.FirstName, "FirstName");
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            resources.ApplyResources(this.LastName, "LastName");
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // performance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_staffid);
            this.Controls.Add(this.txt_staffid);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.ct_revenue);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.lbl_performance);
            this.Name = "performance";
            this.Load += new System.EventHandler(this.performance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_revenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_performance;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_revenue;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_staffid;
        private System.Windows.Forms.TextBox txt_staffid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
    }
}