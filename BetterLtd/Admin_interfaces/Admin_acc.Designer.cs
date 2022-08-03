namespace BetterLtd
{
    partial class Admin_acc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_acc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Acc_mng_lbl = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.isAdmin_check = new System.Windows.Forms.CheckBox();
            this.Password_text = new System.Windows.Forms.TextBox();
            this.Salary_numeric = new System.Windows.Forms.NumericUpDown();
            this.Department_lab = new System.Windows.Forms.Label();
            this.Position_list = new System.Windows.Forms.ComboBox();
            this.isManager_check = new System.Windows.Forms.CheckBox();
            this.Gender_F = new System.Windows.Forms.RadioButton();
            this.gender_m = new System.Windows.Forms.RadioButton();
            this.StaffTel_text = new System.Windows.Forms.TextBox();
            this.Lastname_text = new System.Windows.Forms.TextBox();
            this.Firstname_text = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.isAdmin_label = new System.Windows.Forms.Label();
            this.isManagel_label = new System.Windows.Forms.Label();
            this.Salary_label = new System.Windows.Forms.Label();
            this.StaffTel_label = new System.Windows.Forms.Label();
            this.Gender_label = new System.Windows.Forms.Label();
            this.Lastname_label = new System.Windows.Forms.Label();
            this.Firstname_label = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.acc_View = new System.Windows.Forms.DataGridView();
            this.accid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_search = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Salary_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).BeginInit();
            this.SuspendLayout();
            // 
            // Acc_mng_lbl
            // 
            resources.ApplyResources(this.Acc_mng_lbl, "Acc_mng_lbl");
            this.Acc_mng_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Acc_mng_lbl.Name = "Acc_mng_lbl";
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_add
            // 
            resources.ApplyResources(this.btn_add, "btn_add");
            this.btn_add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_add.Name = "btn_add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // isAdmin_check
            // 
            resources.ApplyResources(this.isAdmin_check, "isAdmin_check");
            this.isAdmin_check.Name = "isAdmin_check";
            this.isAdmin_check.UseVisualStyleBackColor = true;
            // 
            // Password_text
            // 
            resources.ApplyResources(this.Password_text, "Password_text");
            this.Password_text.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Password_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_text.Name = "Password_text";
            // 
            // Salary_numeric
            // 
            resources.ApplyResources(this.Salary_numeric, "Salary_numeric");
            this.Salary_numeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Salary_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Salary_numeric.DecimalPlaces = 2;
            this.Salary_numeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Salary_numeric.Name = "Salary_numeric";
            this.Salary_numeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Salary_numeric_KeyPress_1);
            // 
            // Department_lab
            // 
            resources.ApplyResources(this.Department_lab, "Department_lab");
            this.Department_lab.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Department_lab.Name = "Department_lab";
            // 
            // Position_list
            // 
            resources.ApplyResources(this.Position_list, "Position_list");
            this.Position_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Position_list.FormattingEnabled = true;
            this.Position_list.Items.AddRange(new object[] {
            resources.GetString("Position_list.Items"),
            resources.GetString("Position_list.Items1"),
            resources.GetString("Position_list.Items2"),
            resources.GetString("Position_list.Items3"),
            resources.GetString("Position_list.Items4")});
            this.Position_list.Name = "Position_list";
            this.Position_list.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Position_list_KeyPress);
            // 
            // isManager_check
            // 
            resources.ApplyResources(this.isManager_check, "isManager_check");
            this.isManager_check.Name = "isManager_check";
            this.isManager_check.UseVisualStyleBackColor = true;
            // 
            // Gender_F
            // 
            resources.ApplyResources(this.Gender_F, "Gender_F");
            this.Gender_F.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Gender_F.Name = "Gender_F";
            this.Gender_F.UseVisualStyleBackColor = true;
            // 
            // gender_m
            // 
            resources.ApplyResources(this.gender_m, "gender_m");
            this.gender_m.FlatAppearance.BorderSize = 0;
            this.gender_m.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gender_m.Name = "gender_m";
            this.gender_m.UseVisualStyleBackColor = true;
            // 
            // StaffTel_text
            // 
            resources.ApplyResources(this.StaffTel_text, "StaffTel_text");
            this.StaffTel_text.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StaffTel_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffTel_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StaffTel_text.Name = "StaffTel_text";
            this.StaffTel_text.TextChanged += new System.EventHandler(this.StaffTel_text_TextChanged_1);
            this.StaffTel_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StaffTel_text_KeyPress_1);
            // 
            // Lastname_text
            // 
            resources.ApplyResources(this.Lastname_text, "Lastname_text");
            this.Lastname_text.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Lastname_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lastname_text.Name = "Lastname_text";
            // 
            // Firstname_text
            // 
            resources.ApplyResources(this.Firstname_text, "Firstname_text");
            this.Firstname_text.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Firstname_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Firstname_text.Name = "Firstname_text";
            // 
            // Password_label
            // 
            resources.ApplyResources(this.Password_label, "Password_label");
            this.Password_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Password_label.Name = "Password_label";
            // 
            // isAdmin_label
            // 
            resources.ApplyResources(this.isAdmin_label, "isAdmin_label");
            this.isAdmin_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.isAdmin_label.Name = "isAdmin_label";
            // 
            // isManagel_label
            // 
            resources.ApplyResources(this.isManagel_label, "isManagel_label");
            this.isManagel_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.isManagel_label.Name = "isManagel_label";
            // 
            // Salary_label
            // 
            resources.ApplyResources(this.Salary_label, "Salary_label");
            this.Salary_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Salary_label.Name = "Salary_label";
            // 
            // StaffTel_label
            // 
            resources.ApplyResources(this.StaffTel_label, "StaffTel_label");
            this.StaffTel_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StaffTel_label.Name = "StaffTel_label";
            // 
            // Gender_label
            // 
            resources.ApplyResources(this.Gender_label, "Gender_label");
            this.Gender_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Gender_label.Name = "Gender_label";
            // 
            // Lastname_label
            // 
            resources.ApplyResources(this.Lastname_label, "Lastname_label");
            this.Lastname_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Lastname_label.Name = "Lastname_label";
            // 
            // Firstname_label
            // 
            resources.ApplyResources(this.Firstname_label, "Firstname_label");
            this.Firstname_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Firstname_label.Name = "Firstname_label";
            // 
            // btn_del
            // 
            resources.ApplyResources(this.btn_del, "btn_del");
            this.btn_del.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_del.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_del.Name = "btn_del";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // acc_View
            // 
            resources.ApplyResources(this.acc_View, "acc_View");
            this.acc_View.AllowUserToAddRows = false;
            this.acc_View.AllowUserToDeleteRows = false;
            this.acc_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.acc_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.acc_View.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.acc_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.acc_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.acc_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.acc_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.acc_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acc_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accid,
            this.StaffID,
            this.FirstName,
            this.LastName,
            this.Pwd,
            this.Gender,
            this.Position,
            this.StaffTel,
            this.Salary,
            this.isValid,
            this.isManager,
            this.isAdmin,
            this.RegDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.acc_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.acc_View.Name = "acc_View";
            this.acc_View.ReadOnly = true;
            this.acc_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.acc_View.RowHeadersVisible = false;
            this.acc_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.acc_View.RowTemplate.Height = 24;
            this.acc_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.acc_View.DoubleClick += new System.EventHandler(this.acc_View_DoubleClick_1);
            // 
            // accid
            // 
            this.accid.DataPropertyName = "accid";
            resources.ApplyResources(this.accid, "accid");
            this.accid.Name = "accid";
            this.accid.ReadOnly = true;
            // 
            // StaffID
            // 
            this.StaffID.DataPropertyName = "StaffID";
            resources.ApplyResources(this.StaffID, "StaffID");
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            resources.ApplyResources(this.FirstName, "FirstName");
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            resources.ApplyResources(this.LastName, "LastName");
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Pwd
            // 
            this.Pwd.DataPropertyName = "Pwd";
            resources.ApplyResources(this.Pwd, "Pwd");
            this.Pwd.Name = "Pwd";
            this.Pwd.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            resources.ApplyResources(this.Gender, "Gender");
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            resources.ApplyResources(this.Position, "Position");
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // StaffTel
            // 
            this.StaffTel.DataPropertyName = "StaffTel";
            resources.ApplyResources(this.StaffTel, "StaffTel");
            this.StaffTel.Name = "StaffTel";
            this.StaffTel.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            resources.ApplyResources(this.Salary, "Salary");
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // isValid
            // 
            this.isValid.DataPropertyName = "isValid";
            resources.ApplyResources(this.isValid, "isValid");
            this.isValid.Name = "isValid";
            this.isValid.ReadOnly = true;
            // 
            // isManager
            // 
            this.isManager.DataPropertyName = "isManager";
            resources.ApplyResources(this.isManager, "isManager");
            this.isManager.Name = "isManager";
            this.isManager.ReadOnly = true;
            // 
            // isAdmin
            // 
            this.isAdmin.DataPropertyName = "isAdmin";
            resources.ApplyResources(this.isAdmin, "isAdmin");
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.ReadOnly = true;
            // 
            // RegDate
            // 
            this.RegDate.DataPropertyName = "RegDate";
            resources.ApplyResources(this.RegDate, "RegDate");
            this.RegDate.Name = "RegDate";
            this.RegDate.ReadOnly = true;
            // 
            // img_search
            // 
            resources.ApplyResources(this.img_search, "img_search");
            this.img_search.BackColor = System.Drawing.Color.Transparent;
            this.img_search.BackgroundImage = global::BetterLtd.Properties.Resources.search;
            this.img_search.Name = "img_search";
            this.img_search.TabStop = false;
            // 
            // btn_back
            // 
            resources.ApplyResources(this.btn_back, "btn_back");
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::BetterLtd.Properties.Resources.backpng;
            this.btn_back.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back.Name = "btn_back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // Admin_acc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.img_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.acc_View);
            this.Controls.Add(this.isAdmin_check);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.Salary_numeric);
            this.Controls.Add(this.Department_lab);
            this.Controls.Add(this.Position_list);
            this.Controls.Add(this.isManager_check);
            this.Controls.Add(this.Gender_F);
            this.Controls.Add(this.gender_m);
            this.Controls.Add(this.StaffTel_text);
            this.Controls.Add(this.Lastname_text);
            this.Controls.Add(this.Firstname_text);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.isAdmin_label);
            this.Controls.Add(this.isManagel_label);
            this.Controls.Add(this.Salary_label);
            this.Controls.Add(this.StaffTel_label);
            this.Controls.Add(this.Gender_label);
            this.Controls.Add(this.Lastname_label);
            this.Controls.Add(this.Firstname_label);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.Acc_mng_lbl);
            this.Name = "Admin_acc";
            this.Load += new System.EventHandler(this.Admin_acc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Salary_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Acc_mng_lbl;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.CheckBox isAdmin_check;
        private System.Windows.Forms.TextBox Password_text;
        private System.Windows.Forms.NumericUpDown Salary_numeric;
        private System.Windows.Forms.Label Department_lab;
        private System.Windows.Forms.ComboBox Position_list;
        private System.Windows.Forms.CheckBox isManager_check;
        private System.Windows.Forms.RadioButton Gender_F;
        private System.Windows.Forms.RadioButton gender_m;
        private System.Windows.Forms.TextBox StaffTel_text;
        private System.Windows.Forms.TextBox Lastname_text;
        private System.Windows.Forms.TextBox Firstname_text;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label isAdmin_label;
        private System.Windows.Forms.Label isManagel_label;
        private System.Windows.Forms.Label Salary_label;
        private System.Windows.Forms.Label StaffTel_label;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.Label Lastname_label;
        private System.Windows.Forms.Label Firstname_label;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.PictureBox img_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView acc_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn accid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn isValid;
        private System.Windows.Forms.DataGridViewTextBoxColumn isManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegDate;
    }
}