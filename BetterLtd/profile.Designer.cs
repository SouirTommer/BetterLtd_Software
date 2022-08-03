namespace BetterLtd
{
    partial class profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.pwd_text = new System.Windows.Forms.TextBox();
            this.repwd_text = new System.Windows.Forms.TextBox();
            this.tel_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // save_btn
            // 
            resources.ApplyResources(this.save_btn, "save_btn");
            this.save_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Name = "save_btn";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // pwd_text
            // 
            resources.ApplyResources(this.pwd_text, "pwd_text");
            this.pwd_text.Name = "pwd_text";
            // 
            // repwd_text
            // 
            resources.ApplyResources(this.repwd_text, "repwd_text");
            this.repwd_text.Name = "repwd_text";
            // 
            // tel_text
            // 
            resources.ApplyResources(this.tel_text, "tel_text");
            this.tel_text.Name = "tel_text";
            this.tel_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_text_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // profile
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tel_text);
            this.Controls.Add(this.repwd_text);
            this.Controls.Add(this.pwd_text);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox pwd_text;
        private System.Windows.Forms.TextBox repwd_text;
        private System.Windows.Forms.TextBox tel_text;
        private System.Windows.Forms.Label label4;
    }
}