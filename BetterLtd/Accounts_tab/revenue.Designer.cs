namespace BetterLtd.Accounts_tab
{
    partial class revenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(revenue));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.li_month = new System.Windows.Forms.ComboBox();
            this.fname_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.li_year = new System.Windows.Forms.ComboBox();
            this.cbx_3m = new System.Windows.Forms.RadioButton();
            this.cbx_6m = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ct_revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_storeid = new System.Windows.Forms.Label();
            this.li_store = new System.Windows.Forms.ComboBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.re_mng_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_revenue)).BeginInit();
            this.SuspendLayout();
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
            resources.GetString("li_month.Items11")});
            this.li_month.Name = "li_month";
            this.li_month.Click += new System.EventHandler(this.panel1_Click);
            // 
            // fname_label
            // 
            resources.ApplyResources(this.fname_label, "fname_label");
            this.fname_label.BackColor = System.Drawing.Color.Transparent;
            this.fname_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fname_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.fname_label.Name = "fname_label";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Name = "label1";
            // 
            // li_year
            // 
            resources.ApplyResources(this.li_year, "li_year");
            this.li_year.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_year.FormattingEnabled = true;
            this.li_year.Items.AddRange(new object[] {
            resources.GetString("li_year.Items")});
            this.li_year.Name = "li_year";
            this.li_year.Click += new System.EventHandler(this.panel1_Click);
            // 
            // cbx_3m
            // 
            resources.ApplyResources(this.cbx_3m, "cbx_3m");
            this.cbx_3m.BackColor = System.Drawing.Color.Transparent;
            this.cbx_3m.FlatAppearance.BorderSize = 0;
            this.cbx_3m.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_3m.Name = "cbx_3m";
            this.cbx_3m.UseVisualStyleBackColor = false;
            this.cbx_3m.Click += new System.EventHandler(this.panel2_Click);
            // 
            // cbx_6m
            // 
            resources.ApplyResources(this.cbx_6m, "cbx_6m");
            this.cbx_6m.BackColor = System.Drawing.Color.Transparent;
            this.cbx_6m.FlatAppearance.BorderSize = 0;
            this.cbx_6m.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_6m.Name = "cbx_6m";
            this.cbx_6m.UseVisualStyleBackColor = false;
            this.cbx_6m.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fname_label);
            this.panel1.Controls.Add(this.li_year);
            this.panel1.Controls.Add(this.li_month);
            this.panel1.Name = "panel1";
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.cbx_6m);
            this.panel2.Controls.Add(this.cbx_3m);
            this.panel2.Name = "panel2";
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // ct_revenue
            // 
            resources.ApplyResources(this.ct_revenue, "ct_revenue");
            this.ct_revenue.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.ct_revenue.ChartAreas.Add(chartArea3);
            this.ct_revenue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ct_revenue.Name = "ct_revenue";
            this.ct_revenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.Name = "Revenue";
            this.ct_revenue.Series.Add(series3);
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            title3.Name = "Title1";
            title3.Text = "Revenue";
            this.ct_revenue.Titles.Add(title3);
            // 
            // lbl_storeid
            // 
            resources.ApplyResources(this.lbl_storeid, "lbl_storeid");
            this.lbl_storeid.BackColor = System.Drawing.Color.Transparent;
            this.lbl_storeid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_storeid.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_storeid.Name = "lbl_storeid";
            this.lbl_storeid.Click += new System.EventHandler(this.lbl_storeid_Click);
            // 
            // li_store
            // 
            resources.ApplyResources(this.li_store, "li_store");
            this.li_store.BackColor = System.Drawing.SystemColors.ControlLight;
            this.li_store.FormattingEnabled = true;
            this.li_store.Items.AddRange(new object[] {
            resources.GetString("li_store.Items")});
            this.li_store.Name = "li_store";
            this.li_store.SelectedIndexChanged += new System.EventHandler(this.li_store_SelectedIndexChanged);
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
            // re_mng_lbl
            // 
            resources.ApplyResources(this.re_mng_lbl, "re_mng_lbl");
            this.re_mng_lbl.BackColor = System.Drawing.Color.Transparent;
            this.re_mng_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.re_mng_lbl.Name = "re_mng_lbl";
            // 
            // revenue
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_storeid);
            this.Controls.Add(this.li_store);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.ct_revenue);
            this.Controls.Add(this.re_mng_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "revenue";
            this.Load += new System.EventHandler(this.revenue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_revenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox li_month;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox li_year;
        private System.Windows.Forms.RadioButton cbx_3m;
        private System.Windows.Forms.RadioButton cbx_6m;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_revenue;
        private System.Windows.Forms.Label lbl_storeid;
        private System.Windows.Forms.ComboBox li_store;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label re_mng_lbl;
    }
}