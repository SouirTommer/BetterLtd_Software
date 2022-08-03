namespace BetterLtd.Retail_tab
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.lbl_card = new System.Windows.Forms.Label();
            this.product_lab = new System.Windows.Forms.Label();
            this.btn_pos = new System.Windows.Forms.Button();
            this.lbl_Bill = new System.Windows.Forms.Label();
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.lbl_cash = new System.Windows.Forms.Label();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_confirmbill = new System.Windows.Forms.Button();
            this.num_paid = new System.Windows.Forms.NumericUpDown();
            this.pic_ae = new System.Windows.Forms.PictureBox();
            this.pic_visa = new System.Windows.Forms.PictureBox();
            this.pic_master = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_paid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_visa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_master)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_card
            // 
            resources.ApplyResources(this.lbl_card, "lbl_card");
            this.lbl_card.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_card.Name = "lbl_card";
            // 
            // product_lab
            // 
            resources.ApplyResources(this.product_lab, "product_lab");
            this.product_lab.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.product_lab.Name = "product_lab";
            // 
            // btn_pos
            // 
            resources.ApplyResources(this.btn_pos, "btn_pos");
            this.btn_pos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_pos.FlatAppearance.BorderSize = 0;
            this.btn_pos.ForeColor = System.Drawing.Color.White;
            this.btn_pos.Name = "btn_pos";
            this.btn_pos.UseVisualStyleBackColor = false;
            this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
            // 
            // lbl_Bill
            // 
            resources.ApplyResources(this.lbl_Bill, "lbl_Bill");
            this.lbl_Bill.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Bill.Name = "lbl_Bill";
            // 
            // txt_bill
            // 
            resources.ApplyResources(this.txt_bill, "txt_bill");
            this.txt_bill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.ReadOnly = true;
            // 
            // lbl_cash
            // 
            resources.ApplyResources(this.lbl_cash, "lbl_cash");
            this.lbl_cash.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_cash.Name = "lbl_cash";
            // 
            // txt_change
            // 
            resources.ApplyResources(this.txt_change, "txt_change");
            this.txt_change.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_change.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_change.Name = "txt_change";
            this.txt_change.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Name = "label3";
            // 
            // btn_confirmbill
            // 
            resources.ApplyResources(this.btn_confirmbill, "btn_confirmbill");
            this.btn_confirmbill.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_confirmbill.FlatAppearance.BorderSize = 0;
            this.btn_confirmbill.ForeColor = System.Drawing.Color.White;
            this.btn_confirmbill.Name = "btn_confirmbill";
            this.btn_confirmbill.UseVisualStyleBackColor = false;
            this.btn_confirmbill.Click += new System.EventHandler(this.btn_confirmbill_Click);
            // 
            // num_paid
            // 
            resources.ApplyResources(this.num_paid, "num_paid");
            this.num_paid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num_paid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_paid.DecimalPlaces = 2;
            this.num_paid.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_paid.Name = "num_paid";
            this.num_paid.ValueChanged += new System.EventHandler(this.num_paid_ValueChanged);
            // 
            // pic_ae
            // 
            resources.ApplyResources(this.pic_ae, "pic_ae");
            this.pic_ae.BackColor = System.Drawing.Color.Transparent;
            this.pic_ae.BackgroundImage = global::BetterLtd.Properties.Resources.AE;
            this.pic_ae.Name = "pic_ae";
            this.pic_ae.TabStop = false;
            // 
            // pic_visa
            // 
            resources.ApplyResources(this.pic_visa, "pic_visa");
            this.pic_visa.BackColor = System.Drawing.Color.Transparent;
            this.pic_visa.BackgroundImage = global::BetterLtd.Properties.Resources.SeekPng_com_citibank_logo_png_3364024;
            this.pic_visa.Name = "pic_visa";
            this.pic_visa.TabStop = false;
            // 
            // pic_master
            // 
            resources.ApplyResources(this.pic_master, "pic_master");
            this.pic_master.BackColor = System.Drawing.Color.Transparent;
            this.pic_master.BackgroundImage = global::BetterLtd.Properties.Resources._58482354cef1014c0b5e49c0;
            this.pic_master.Name = "pic_master";
            this.pic_master.TabStop = false;
            // 
            // payment
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.num_paid);
            this.Controls.Add(this.btn_confirmbill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_change);
            this.Controls.Add(this.lbl_cash);
            this.Controls.Add(this.lbl_Bill);
            this.Controls.Add(this.txt_bill);
            this.Controls.Add(this.btn_pos);
            this.Controls.Add(this.product_lab);
            this.Controls.Add(this.lbl_card);
            this.Controls.Add(this.pic_ae);
            this.Controls.Add(this.pic_visa);
            this.Controls.Add(this.pic_master);
            this.Name = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_paid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_visa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_master)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_master;
        private System.Windows.Forms.PictureBox pic_visa;
        private System.Windows.Forms.PictureBox pic_ae;
        private System.Windows.Forms.Label lbl_card;
        private System.Windows.Forms.Label product_lab;
        private System.Windows.Forms.Button btn_pos;
        private System.Windows.Forms.Label lbl_Bill;
        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.Label lbl_cash;
        private System.Windows.Forms.TextBox txt_change;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_confirmbill;
        private System.Windows.Forms.NumericUpDown num_paid;
    }
}