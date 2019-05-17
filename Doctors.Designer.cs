namespace WindowsFormsApplication1
{
    partial class Doctors
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
            this.rdb_docid = new System.Windows.Forms.RadioButton();
            this.rdb_docname = new System.Windows.Forms.RadioButton();
            this.rdb_specialization = new System.Windows.Forms.RadioButton();
            this.txt_doctorid = new System.Windows.Forms.TextBox();
            this.txt_docname = new System.Windows.Forms.TextBox();
            this.txt_specialization = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.doctorsview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsview)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_docid
            // 
            this.rdb_docid.AutoSize = true;
            this.rdb_docid.Location = new System.Drawing.Point(368, 64);
            this.rdb_docid.Name = "rdb_docid";
            this.rdb_docid.Size = new System.Drawing.Size(68, 17);
            this.rdb_docid.TabIndex = 1;
            this.rdb_docid.TabStop = true;
            this.rdb_docid.Text = "DoctorID";
            this.rdb_docid.UseVisualStyleBackColor = true;
            this.rdb_docid.CheckedChanged += new System.EventHandler(this.rdb_docid_CheckedChanged_1);
            // 
            // rdb_docname
            // 
            this.rdb_docname.AutoSize = true;
            this.rdb_docname.Location = new System.Drawing.Point(368, 117);
            this.rdb_docname.Name = "rdb_docname";
            this.rdb_docname.Size = new System.Drawing.Size(85, 17);
            this.rdb_docname.TabIndex = 2;
            this.rdb_docname.TabStop = true;
            this.rdb_docname.Text = "DoctorName";
            this.rdb_docname.UseVisualStyleBackColor = true;
            this.rdb_docname.CheckedChanged += new System.EventHandler(this.rdb_docname_CheckedChanged);
            // 
            // rdb_specialization
            // 
            this.rdb_specialization.AutoSize = true;
            this.rdb_specialization.Location = new System.Drawing.Point(368, 166);
            this.rdb_specialization.Name = "rdb_specialization";
            this.rdb_specialization.Size = new System.Drawing.Size(90, 17);
            this.rdb_specialization.TabIndex = 3;
            this.rdb_specialization.TabStop = true;
            this.rdb_specialization.Text = "Specialization";
            this.rdb_specialization.UseVisualStyleBackColor = true;
            this.rdb_specialization.CheckedChanged += new System.EventHandler(this.rdb_specialization_CheckedChanged);
            // 
            // txt_doctorid
            // 
            this.txt_doctorid.Location = new System.Drawing.Point(489, 63);
            this.txt_doctorid.Name = "txt_doctorid";
            this.txt_doctorid.Size = new System.Drawing.Size(100, 20);
            this.txt_doctorid.TabIndex = 4;
            this.txt_doctorid.TextChanged += new System.EventHandler(this.txt_doctorid_TextChanged_1);
            // 
            // txt_docname
            // 
            this.txt_docname.Location = new System.Drawing.Point(489, 114);
            this.txt_docname.Name = "txt_docname";
            this.txt_docname.Size = new System.Drawing.Size(100, 20);
            this.txt_docname.TabIndex = 5;
            // 
            // txt_specialization
            // 
            this.txt_specialization.Location = new System.Drawing.Point(489, 163);
            this.txt_specialization.Name = "txt_specialization";
            this.txt_specialization.Size = new System.Drawing.Size(100, 20);
            this.txt_specialization.TabIndex = 6;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(489, 237);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(596, 237);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(40, 304);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(186, 31);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Doctor Details";
            // 
            // doctorsview
            // 
            this.doctorsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsview.Location = new System.Drawing.Point(46, 338);
            this.doctorsview.Name = "doctorsview";
            this.doctorsview.Size = new System.Drawing.Size(668, 223);
            this.doctorsview.TabIndex = 10;
            this.doctorsview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorsview_CellContentClick_1);
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 584);
            this.Controls.Add(this.doctorsview);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_specialization);
            this.Controls.Add(this.txt_docname);
            this.Controls.Add(this.txt_doctorid);
            this.Controls.Add(this.rdb_specialization);
            this.Controls.Add(this.rdb_docname);
            this.Controls.Add(this.rdb_docid);
            this.Name = "Doctors";
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.Doctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_docid;
        private System.Windows.Forms.RadioButton rdb_docname;
        private System.Windows.Forms.RadioButton rdb_specialization;
        private System.Windows.Forms.TextBox txt_doctorid;
        private System.Windows.Forms.TextBox txt_docname;
        private System.Windows.Forms.TextBox txt_specialization;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView doctorsview;

    }
}