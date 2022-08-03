namespace BetterLtd
{
    partial class retail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(retail));
            this.tab_panel = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.Retail_panel = new System.Windows.Forms.Panel();
            this.Customer_tab = new System.Windows.Forms.Button();
            this.Delivery_tab = new System.Windows.Forms.Button();
            this.lbl_retail = new System.Windows.Forms.Label();
            this.reoder_btn = new System.Windows.Forms.Button();
            this.stock_tab = new System.Windows.Forms.Button();
            this.Order_record_tab = new System.Windows.Forms.Button();
            this.create_order_tab = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tab_panel.SuspendLayout();
            this.Retail_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_panel
            // 
            resources.ApplyResources(this.tab_panel, "tab_panel");
            this.tab_panel.Controls.Add(this.lbl_name);
            this.tab_panel.Controls.Add(this.label1);
            this.tab_panel.Controls.Add(this.pictureBox4);
            this.tab_panel.Controls.Add(this.Logo);
            this.tab_panel.Controls.Add(this.Retail_panel);
            this.tab_panel.Name = "tab_panel";
            this.tab_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.tab_panel_Paint);
            // 
            // lbl_name
            // 
            resources.ApplyResources(this.lbl_name, "lbl_name");
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_name.Name = "lbl_name";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Name = "label1";
            // 
            // Logo
            // 
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Logo.Name = "Logo";
            // 
            // Retail_panel
            // 
            resources.ApplyResources(this.Retail_panel, "Retail_panel");
            this.Retail_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.Retail_panel.Controls.Add(this.Customer_tab);
            this.Retail_panel.Controls.Add(this.Delivery_tab);
            this.Retail_panel.Controls.Add(this.btn_back);
            this.Retail_panel.Controls.Add(this.btn_profile);
            this.Retail_panel.Controls.Add(this.pictureBox3);
            this.Retail_panel.Controls.Add(this.lbl_retail);
            this.Retail_panel.Controls.Add(this.reoder_btn);
            this.Retail_panel.Controls.Add(this.stock_tab);
            this.Retail_panel.Controls.Add(this.Order_record_tab);
            this.Retail_panel.Controls.Add(this.create_order_tab);
            this.Retail_panel.Name = "Retail_panel";
            this.Retail_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Retail_panel_Paint);
            // 
            // Customer_tab
            // 
            resources.ApplyResources(this.Customer_tab, "Customer_tab");
            this.Customer_tab.FlatAppearance.BorderSize = 0;
            this.Customer_tab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Customer_tab.Name = "Customer_tab";
            this.Customer_tab.UseVisualStyleBackColor = true;
            this.Customer_tab.Click += new System.EventHandler(this.Customer_tab_Click);
            // 
            // Delivery_tab
            // 
            resources.ApplyResources(this.Delivery_tab, "Delivery_tab");
            this.Delivery_tab.FlatAppearance.BorderSize = 0;
            this.Delivery_tab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delivery_tab.Name = "Delivery_tab";
            this.Delivery_tab.UseVisualStyleBackColor = true;
            this.Delivery_tab.Click += new System.EventHandler(this.Delivery_tab_Click_1);
            // 
            // lbl_retail
            // 
            resources.ApplyResources(this.lbl_retail, "lbl_retail");
            this.lbl_retail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_retail.ForeColor = System.Drawing.Color.White;
            this.lbl_retail.Name = "lbl_retail";
            // 
            // reoder_btn
            // 
            resources.ApplyResources(this.reoder_btn, "reoder_btn");
            this.reoder_btn.FlatAppearance.BorderSize = 0;
            this.reoder_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reoder_btn.Name = "reoder_btn";
            this.reoder_btn.UseVisualStyleBackColor = true;
            this.reoder_btn.Click += new System.EventHandler(this.reorder_Click);
            // 
            // stock_tab
            // 
            resources.ApplyResources(this.stock_tab, "stock_tab");
            this.stock_tab.FlatAppearance.BorderSize = 0;
            this.stock_tab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stock_tab.Name = "stock_tab";
            this.stock_tab.UseVisualStyleBackColor = true;
            this.stock_tab.Click += new System.EventHandler(this.stock_tab_Click);
            // 
            // Order_record_tab
            // 
            resources.ApplyResources(this.Order_record_tab, "Order_record_tab");
            this.Order_record_tab.FlatAppearance.BorderSize = 0;
            this.Order_record_tab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Order_record_tab.Name = "Order_record_tab";
            this.Order_record_tab.UseVisualStyleBackColor = true;
            this.Order_record_tab.Click += new System.EventHandler(this.Order_record_tab_Click);
            // 
            // create_order_tab
            // 
            resources.ApplyResources(this.create_order_tab, "create_order_tab");
            this.create_order_tab.FlatAppearance.BorderSize = 0;
            this.create_order_tab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.create_order_tab.Name = "create_order_tab";
            this.create_order_tab.UseVisualStyleBackColor = true;
            this.create_order_tab.Click += new System.EventHandler(this.create_order_tab_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::BetterLtd.Properties.Resources.electronics_shop;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // btn_back
            // 
            resources.ApplyResources(this.btn_back, "btn_back");
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::BetterLtd.Properties.Resources.image;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_back.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back.Name = "btn_back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_profile
            // 
            resources.ApplyResources(this.btn_profile, "btn_profile");
            this.btn_profile.BackColor = System.Drawing.Color.Transparent;
            this.btn_profile.BackgroundImage = global::BetterLtd.Properties.Resources.image__1_1;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_profile.ForeColor = System.Drawing.Color.Transparent;
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::BetterLtd.Properties.Resources.shop_512;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // retail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tab_panel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "retail";
            this.Load += new System.EventHandler(this.retail_Load);
            this.tab_panel.ResumeLayout(false);
            this.tab_panel.PerformLayout();
            this.Retail_panel.ResumeLayout(false);
            this.Retail_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel tab_panel;
        private System.Windows.Forms.Panel Retail_panel;
        private System.Windows.Forms.Button stock_tab;
        private System.Windows.Forms.Button Order_record_tab;
        private System.Windows.Forms.Button create_order_tab;
        private System.Windows.Forms.Button reoder_btn;
        private System.Windows.Forms.Label lbl_retail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button Delivery_tab;
        private System.Windows.Forms.Button Customer_tab;
    }
}