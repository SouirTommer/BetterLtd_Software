namespace BetterLtd.Accounts_tab
{
    partial class store_compare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(store_compare));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Store_perf = new System.Windows.Forms.Label();
            this.ct_revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbx_1m = new System.Windows.Forms.RadioButton();
            this.cbx_6m = new System.Windows.Forms.RadioButton();
            this.cbx_3m = new System.Windows.Forms.RadioButton();
            this.btn_check = new System.Windows.Forms.Button();
            this.dgv_rev = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ct_revenue)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rev)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Store_perf
            // 
            resources.ApplyResources(this.lbl_Store_perf, "lbl_Store_perf");
            this.lbl_Store_perf.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Store_perf.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Store_perf.Name = "lbl_Store_perf";
            // 
            // ct_revenue
            // 
            resources.ApplyResources(this.ct_revenue, "ct_revenue");
            this.ct_revenue.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ct_revenue.ChartAreas.Add(chartArea2);
            this.ct_revenue.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.ct_revenue.Legends.Add(legend2);
            this.ct_revenue.Name = "ct_revenue";
            this.ct_revenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieLabelStyle=Disabled";
            series2.Legend = "Legend1";
            series2.Name = "Revenue";
            this.ct_revenue.Series.Add(series2);
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            title2.Name = "Title1";
            this.ct_revenue.Titles.Add(title2);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.cbx_1m);
            this.panel2.Controls.Add(this.cbx_6m);
            this.panel2.Controls.Add(this.cbx_3m);
            this.panel2.Name = "panel2";
            // 
            // cbx_1m
            // 
            resources.ApplyResources(this.cbx_1m, "cbx_1m");
            this.cbx_1m.BackColor = System.Drawing.Color.Transparent;
            this.cbx_1m.FlatAppearance.BorderSize = 0;
            this.cbx_1m.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_1m.Name = "cbx_1m";
            this.cbx_1m.UseVisualStyleBackColor = false;
            // 
            // cbx_6m
            // 
            resources.ApplyResources(this.cbx_6m, "cbx_6m");
            this.cbx_6m.BackColor = System.Drawing.Color.Transparent;
            this.cbx_6m.FlatAppearance.BorderSize = 0;
            this.cbx_6m.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_6m.Name = "cbx_6m";
            this.cbx_6m.UseVisualStyleBackColor = false;
            // 
            // cbx_3m
            // 
            resources.ApplyResources(this.cbx_3m, "cbx_3m");
            this.cbx_3m.BackColor = System.Drawing.Color.Transparent;
            this.cbx_3m.FlatAppearance.BorderSize = 0;
            this.cbx_3m.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_3m.Name = "cbx_3m";
            this.cbx_3m.UseVisualStyleBackColor = false;
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
            // dgv_rev
            // 
            resources.ApplyResources(this.dgv_rev, "dgv_rev");
            this.dgv_rev.AllowUserToAddRows = false;
            this.dgv_rev.AllowUserToDeleteRows = false;
            this.dgv_rev.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_rev.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_rev.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_rev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_rev.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_rev.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_rev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StoreName,
            this.Revenue});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rev.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_rev.MultiSelect = false;
            this.dgv_rev.Name = "dgv_rev";
            this.dgv_rev.ReadOnly = true;
            this.dgv_rev.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_rev.RowHeadersVisible = false;
            this.dgv_rev.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgv_rev.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_rev.RowTemplate.Height = 24;
            this.dgv_rev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "StaffID";
            this.ID.FillWeight = 106.599F;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // StoreName
            // 
            this.StoreName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.FillWeight = 51.7005F;
            resources.ApplyResources(this.StoreName, "StoreName");
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // Revenue
            // 
            this.Revenue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Revenue.FillWeight = 51.7005F;
            resources.ApplyResources(this.Revenue, "Revenue");
            this.Revenue.Name = "Revenue";
            this.Revenue.ReadOnly = true;
            // 
            // store_compare
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_rev);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ct_revenue);
            this.Controls.Add(this.lbl_Store_perf);
            this.Name = "store_compare";
            this.Load += new System.EventHandler(this.store_compare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ct_revenue)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Store_perf;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_revenue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton cbx_1m;
        private System.Windows.Forms.RadioButton cbx_6m;
        private System.Windows.Forms.RadioButton cbx_3m;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.DataGridView dgv_rev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revenue;
    }
}