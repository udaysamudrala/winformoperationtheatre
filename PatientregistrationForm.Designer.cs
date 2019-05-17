namespace WindowsFormsApplication1
{
    partial class PatientregistrationForm
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
            this.tbx_Firstname = new System.Windows.Forms.TextBox();
            this.tbx_Lastname = new System.Windows.Forms.TextBox();
            this.tbx_age = new System.Windows.Forms.TextBox();
            this.tbx_phone = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_pno = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_Firstname
            // 
            this.tbx_Firstname.Location = new System.Drawing.Point(102, 49);
            this.tbx_Firstname.Name = "tbx_Firstname";
            this.tbx_Firstname.Size = new System.Drawing.Size(100, 20);
            this.tbx_Firstname.TabIndex = 0;
            this.tbx_Firstname.TextChanged += new System.EventHandler(this.tbx_Firstname_TextChanged);
            // 
            // tbx_Lastname
            // 
            this.tbx_Lastname.Location = new System.Drawing.Point(102, 104);
            this.tbx_Lastname.Name = "tbx_Lastname";
            this.tbx_Lastname.Size = new System.Drawing.Size(100, 20);
            this.tbx_Lastname.TabIndex = 1;
            this.tbx_Lastname.TextChanged += new System.EventHandler(this.tbx_Lastname_TextChanged);
            // 
            // tbx_age
            // 
            this.tbx_age.Location = new System.Drawing.Point(102, 206);
            this.tbx_age.Name = "tbx_age";
            this.tbx_age.Size = new System.Drawing.Size(58, 20);
            this.tbx_age.TabIndex = 3;
            this.tbx_age.TextChanged += new System.EventHandler(this.tbx_age_TextChanged);
            // 
            // tbx_phone
            // 
            this.tbx_phone.Location = new System.Drawing.Point(94, 384);
            this.tbx_phone.Name = "tbx_phone";
            this.tbx_phone.Size = new System.Drawing.Size(100, 20);
            this.tbx_phone.TabIndex = 5;
            this.tbx_phone.TextChanged += new System.EventHandler(this.tbx_phone_TextChanged);
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(11, 52);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(54, 13);
            this.lbl_fname.TabIndex = 14;
            this.lbl_fname.Text = "FirstName";
            this.lbl_fname.Click += new System.EventHandler(this.lbl_fname_Click);
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(12, 104);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(55, 13);
            this.lbl_lname.TabIndex = 15;
            this.lbl_lname.Text = "LastName";
            this.lbl_lname.Click += new System.EventHandler(this.lbl_lname_Click);
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(12, 164);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 16;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.Click += new System.EventHandler(this.lbl_gender_Click);
            // 
            // lbl_pno
            // 
            this.lbl_pno.AutoSize = true;
            this.lbl_pno.Location = new System.Drawing.Point(12, 384);
            this.lbl_pno.Name = "lbl_pno";
            this.lbl_pno.Size = new System.Drawing.Size(55, 13);
            this.lbl_pno.TabIndex = 18;
            this.lbl_pno.Text = "PhoneNo.";
            this.lbl_pno.Click += new System.EventHandler(this.lbl_pno_Click);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(12, 249);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(45, 13);
            this.lbl_address.TabIndex = 19;
            this.lbl_address.Text = "Address";
            this.lbl_address.Click += new System.EventHandler(this.lbl_address_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(11, 452);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(43, 13);
            this.lbl_email.TabIndex = 20;
            this.lbl_email.Text = "EmailID";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(12, 213);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(26, 13);
            this.lbl_age.TabIndex = 22;
            this.lbl_age.Text = "Age";
            this.lbl_age.Click += new System.EventHandler(this.lbl_age_Click);
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(102, 157);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(48, 17);
            this.rdb_male.TabIndex = 28;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "Male";
            this.rdb_male.UseVisualStyleBackColor = true;
            this.rdb_male.CheckedChanged += new System.EventHandler(this.rdb_male_CheckedChanged);
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Location = new System.Drawing.Point(102, 180);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(59, 17);
            this.rdb_female.TabIndex = 29;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "Female";
            this.rdb_female.UseVisualStyleBackColor = true;
            this.rdb_female.CheckedChanged += new System.EventHandler(this.rdb_female_CheckedChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(293, 571);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 31;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(94, 249);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 111);
            this.txt_address.TabIndex = 32;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(94, 445);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(100, 20);
            this.tbx_email.TabIndex = 13;
            this.tbx_email.TextChanged += new System.EventHandler(this.tbx_email_TextChanged);
            // 
            // PatientregistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 628);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.rdb_female);
            this.Controls.Add(this.rdb_male);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_pno);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.tbx_phone);
            this.Controls.Add(this.tbx_age);
            this.Controls.Add(this.tbx_Lastname);
            this.Controls.Add(this.tbx_Firstname);
            this.Name = "PatientregistrationForm";
            this.Text = "PatientregistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Firstname;
        private System.Windows.Forms.TextBox tbx_Lastname;
        private System.Windows.Forms.TextBox tbx_age;
        private System.Windows.Forms.TextBox tbx_phone;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_pno;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.RadioButton rdb_female;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox tbx_email;
    }
}