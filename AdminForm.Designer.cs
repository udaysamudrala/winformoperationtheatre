namespace WindowsFormsApplication1
{
    partial class AdminForm
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
            this.ADMINISTRATOR = new System.Windows.Forms.TextBox();
            this.doc_link = new System.Windows.Forms.LinkLabel();
            this.staff_link = new System.Windows.Forms.LinkLabel();
            this.patient_link = new System.Windows.Forms.LinkLabel();
            this.billing_link = new System.Windows.Forms.LinkLabel();
            this.patientreports_link = new System.Windows.Forms.LinkLabel();
            this.logout_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ADMINISTRATOR
            // 
            this.ADMINISTRATOR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.ADMINISTRATOR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ADMINISTRATOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMINISTRATOR.Location = new System.Drawing.Point(179, 27);
            this.ADMINISTRATOR.Name = "ADMINISTRATOR";
            this.ADMINISTRATOR.Size = new System.Drawing.Size(235, 38);
            this.ADMINISTRATOR.TabIndex = 0;
            this.ADMINISTRATOR.Text = "ADMINISTRATOR";
            this.ADMINISTRATOR.TextChanged += new System.EventHandler(this.ADMINISTRATOR_TextChanged);
            // 
            // doc_link
            // 
            this.doc_link.AutoSize = true;
            this.doc_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_link.Location = new System.Drawing.Point(81, 110);
            this.doc_link.Name = "doc_link";
            this.doc_link.Size = new System.Drawing.Size(113, 25);
            this.doc_link.TabIndex = 1;
            this.doc_link.TabStop = true;
            this.doc_link.Text = "DOCTORS";
            this.doc_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // staff_link
            // 
            this.staff_link.AutoSize = true;
            this.staff_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_link.Location = new System.Drawing.Point(83, 191);
            this.staff_link.Name = "staff_link";
            this.staff_link.Size = new System.Drawing.Size(77, 25);
            this.staff_link.TabIndex = 2;
            this.staff_link.TabStop = true;
            this.staff_link.Text = "STAFF";
            this.staff_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.staff_link_LinkClicked);
            // 
            // patient_link
            // 
            this.patient_link.AutoSize = true;
            this.patient_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_link.Location = new System.Drawing.Point(85, 273);
            this.patient_link.Name = "patient_link";
            this.patient_link.Size = new System.Drawing.Size(111, 25);
            this.patient_link.TabIndex = 3;
            this.patient_link.TabStop = true;
            this.patient_link.Text = "PATIENTS";
            this.patient_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.patient_link_LinkClicked);
            // 
            // billing_link
            // 
            this.billing_link.AutoSize = true;
            this.billing_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing_link.Location = new System.Drawing.Point(87, 340);
            this.billing_link.Name = "billing_link";
            this.billing_link.Size = new System.Drawing.Size(91, 25);
            this.billing_link.TabIndex = 4;
            this.billing_link.TabStop = true;
            this.billing_link.Text = "BILLING ";
            this.billing_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.billing_link_LinkClicked);
            // 
            // patientreports_link
            // 
            this.patientreports_link.AutoSize = true;
            this.patientreports_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientreports_link.Location = new System.Drawing.Point(89, 411);
            this.patientreports_link.Name = "patientreports_link";
            this.patientreports_link.Size = new System.Drawing.Size(197, 25);
            this.patientreports_link.TabIndex = 5;
            this.patientreports_link.TabStop = true;
            this.patientreports_link.Text = "PATIENT REPORTS";
            // 
            // logout_link
            // 
            this.logout_link.AutoSize = true;
            this.logout_link.Location = new System.Drawing.Point(575, 27);
            this.logout_link.Name = "logout_link";
            this.logout_link.Size = new System.Drawing.Size(36, 13);
            this.logout_link.TabIndex = 6;
            this.logout_link.TabStop = true;
            this.logout_link.Text = "logout";
            this.logout_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_link_LinkClicked);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 528);
            this.Controls.Add(this.logout_link);
            this.Controls.Add(this.patientreports_link);
            this.Controls.Add(this.billing_link);
            this.Controls.Add(this.patient_link);
            this.Controls.Add(this.staff_link);
            this.Controls.Add(this.doc_link);
            this.Controls.Add(this.ADMINISTRATOR);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ADMINISTRATOR;
        private System.Windows.Forms.LinkLabel doc_link;
        private System.Windows.Forms.LinkLabel staff_link;
        private System.Windows.Forms.LinkLabel patient_link;
        private System.Windows.Forms.LinkLabel billing_link;
        private System.Windows.Forms.LinkLabel patientreports_link;
        private System.Windows.Forms.LinkLabel logout_link;
    }
}