namespace BetterLtd
{
    partial class ActivityLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityLog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.log_lab = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.log_view = new System.Windows.Forms.DataGridView();
            this.actlogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.log_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // log_lab
            // 
            resources.ApplyResources(this.log_lab, "log_lab");
            this.log_lab.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.log_lab.Name = "log_lab";
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // log_view
            // 
            resources.ApplyResources(this.log_view, "log_view");
            this.log_view.AllowUserToAddRows = false;
            this.log_view.AllowUserToDeleteRows = false;
            this.log_view.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.log_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.log_view.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.log_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.log_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.log_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.log_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.log_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.log_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actlogID,
            this.StaffID,
            this.logType,
            this.Interface,
            this.logDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.log_view.DefaultCellStyle = dataGridViewCellStyle3;
            this.log_view.Name = "log_view";
            this.log_view.ReadOnly = true;
            this.log_view.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.log_view.RowHeadersVisible = false;
            this.log_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.log_view.RowTemplate.Height = 24;
            this.log_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.log_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.log_view_CellContentClick);
            // 
            // actlogID
            // 
            this.actlogID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.actlogID.DataPropertyName = "actlogID";
            resources.ApplyResources(this.actlogID, "actlogID");
            this.actlogID.Name = "actlogID";
            this.actlogID.ReadOnly = true;
            // 
            // StaffID
            // 
            this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffID.DataPropertyName = "StaffID";
            resources.ApplyResources(this.StaffID, "StaffID");
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // logType
            // 
            this.logType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.logType.DataPropertyName = "logType";
            resources.ApplyResources(this.logType, "logType");
            this.logType.Name = "logType";
            this.logType.ReadOnly = true;
            // 
            // Interface
            // 
            this.Interface.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Interface.DataPropertyName = "Interface";
            resources.ApplyResources(this.Interface, "Interface");
            this.Interface.Name = "Interface";
            this.Interface.ReadOnly = true;
            // 
            // logDate
            // 
            this.logDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.logDate.DataPropertyName = "logDate";
            resources.ApplyResources(this.logDate, "logDate");
            this.logDate.Name = "logDate";
            this.logDate.ReadOnly = true;
            // 
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            this.img_search.Click += new System.EventHandler(this.img_search_Click);
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
            // ActivityLog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.log_view);
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.log_lab);
            this.Name = "ActivityLog";
            this.Load += new System.EventHandler(this.ActivityLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.log_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label log_lab;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView log_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn actlogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn logType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interface;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDate;
    }
}