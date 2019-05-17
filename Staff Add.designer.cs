namespace WindowsFormsApplication1
{
    partial class lbl_dept_name
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
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_staffid = new System.Windows.Forms.TextBox();
            this.lbl_staff_id = new System.Windows.Forms.Label();
            this.txt_staffname = new System.Windows.Forms.TextBox();
            this.txt_phoneno = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_dateOfJoining = new System.Windows.Forms.TextBox();
            this.lbl_staff_name = new System.Windows.Forms.Label();
            this.lbl_phoneno = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_date_of_joining = new System.Windows.Forms.Label();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.txt_sd = new System.Windows.Forms.TextBox();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.lbl_dapartment_name = new System.Windows.Forms.Label();
            this.txt_det_name = new System.Windows.Forms.TextBox();
            this.lbl_shit_time = new System.Windows.Forms.Label();
            this.txt_shift_timings = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_resourceid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(335, 580);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_staffid
            // 
            this.txt_staffid.Location = new System.Drawing.Point(243, 89);
            this.txt_staffid.Name = "txt_staffid";
            this.txt_staffid.Size = new System.Drawing.Size(100, 20);
            this.txt_staffid.TabIndex = 1;
            this.txt_staffid.TextChanged += new System.EventHandler(this.txt_staffid_TextChanged);
            // 
            // lbl_staff_id
            // 
            this.lbl_staff_id.AutoSize = true;
            this.lbl_staff_id.Location = new System.Drawing.Point(78, 92);
            this.lbl_staff_id.Name = "lbl_staff_id";
            this.lbl_staff_id.Size = new System.Drawing.Size(43, 13);
            this.lbl_staff_id.TabIndex = 2;
            this.lbl_staff_id.Text = "Staff ID";
            this.lbl_staff_id.Click += new System.EventHandler(this.lbl_staff_id_Click);
            // 
            // txt_staffname
            // 
            this.txt_staffname.Location = new System.Drawing.Point(243, 133);
            this.txt_staffname.Name = "txt_staffname";
            this.txt_staffname.Size = new System.Drawing.Size(100, 20);
            this.txt_staffname.TabIndex = 3;
            this.txt_staffname.TextChanged += new System.EventHandler(this.txt_staffname_TextChanged);
            // 
            // txt_phoneno
            // 
            this.txt_phoneno.Location = new System.Drawing.Point(243, 185);
            this.txt_phoneno.Name = "txt_phoneno";
            this.txt_phoneno.Size = new System.Drawing.Size(100, 20);
            this.txt_phoneno.TabIndex = 4;
            this.txt_phoneno.TextChanged += new System.EventHandler(this.txt_phoneno_TextChanged);
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(243, 524);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 5;
            this.txt_age.TextChanged += new System.EventHandler(this.txt_age_TextChanged);
            // 
            // txt_dateOfJoining
            // 
            this.txt_dateOfJoining.Location = new System.Drawing.Point(243, 330);
            this.txt_dateOfJoining.Name = "txt_dateOfJoining";
            this.txt_dateOfJoining.Size = new System.Drawing.Size(100, 20);
            this.txt_dateOfJoining.TabIndex = 6;
            this.txt_dateOfJoining.TextChanged += new System.EventHandler(this.txt_dateOfJoining_TextChanged);
            // 
            // lbl_staff_name
            // 
            this.lbl_staff_name.AutoSize = true;
            this.lbl_staff_name.Location = new System.Drawing.Point(78, 136);
            this.lbl_staff_name.Name = "lbl_staff_name";
            this.lbl_staff_name.Size = new System.Drawing.Size(60, 13);
            this.lbl_staff_name.TabIndex = 7;
            this.lbl_staff_name.Text = "Staff Name";
            this.lbl_staff_name.Click += new System.EventHandler(this.lbl_staff_name_Click);
            // 
            // lbl_phoneno
            // 
            this.lbl_phoneno.AutoSize = true;
            this.lbl_phoneno.Location = new System.Drawing.Point(78, 188);
            this.lbl_phoneno.Name = "lbl_phoneno";
            this.lbl_phoneno.Size = new System.Drawing.Size(52, 13);
            this.lbl_phoneno.TabIndex = 8;
            this.lbl_phoneno.Text = "PhoneNo";
            this.lbl_phoneno.Click += new System.EventHandler(this.lbl_phoneno_Click);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(78, 531);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(26, 13);
            this.lbl_age.TabIndex = 9;
            this.lbl_age.Text = "Age";
            this.lbl_age.Click += new System.EventHandler(this.lbl_age_Click);
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(78, 479);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 10;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.Click += new System.EventHandler(this.lbl_gender_Click);
            // 
            // lbl_date_of_joining
            // 
            this.lbl_date_of_joining.AutoSize = true;
            this.lbl_date_of_joining.Location = new System.Drawing.Point(78, 337);
            this.lbl_date_of_joining.Name = "lbl_date_of_joining";
            this.lbl_date_of_joining.Size = new System.Drawing.Size(78, 13);
            this.lbl_date_of_joining.TabIndex = 11;
            this.lbl_date_of_joining.Text = "Date of Joining";
            this.lbl_date_of_joining.Click += new System.EventHandler(this.lbl_date_of_joining_Click);
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(243, 479);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(48, 17);
            this.rdb_male.TabIndex = 12;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "Male";
            this.rdb_male.UseVisualStyleBackColor = true;
            this.rdb_male.CheckedChanged += new System.EventHandler(this.rdb_male_CheckedChanged);
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Location = new System.Drawing.Point(335, 479);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(59, 17);
            this.rdb_female.TabIndex = 13;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "Female";
            this.rdb_female.UseVisualStyleBackColor = true;
            this.rdb_female.CheckedChanged += new System.EventHandler(this.rdb_female_CheckedChanged);
            // 
            // txt_sd
            // 
            this.txt_sd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sd.Location = new System.Drawing.Point(173, 12);
            this.txt_sd.Name = "txt_sd";
            this.txt_sd.Size = new System.Drawing.Size(170, 30);
            this.txt_sd.TabIndex = 14;
            this.txt_sd.Text = "STAFF DETAILS";
            this.txt_sd.TextChanged += new System.EventHandler(this.txt_sd_TextChanged);
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Location = new System.Drawing.Point(78, 386);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(36, 13);
            this.lbl_salary.TabIndex = 15;
            this.lbl_salary.Text = "Salary";
            this.lbl_salary.Click += new System.EventHandler(this.lbl_salary_Click);
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(243, 379);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(100, 20);
            this.txt_salary.TabIndex = 16;
            this.txt_salary.TextChanged += new System.EventHandler(this.txt_salary_TextChanged);
            // 
            // lbl_dapartment_name
            // 
            this.lbl_dapartment_name.AutoSize = true;
            this.lbl_dapartment_name.Location = new System.Drawing.Point(78, 244);
            this.lbl_dapartment_name.Name = "lbl_dapartment_name";
            this.lbl_dapartment_name.Size = new System.Drawing.Size(93, 13);
            this.lbl_dapartment_name.TabIndex = 17;
            this.lbl_dapartment_name.Text = "Dapartment Name";
            this.lbl_dapartment_name.Click += new System.EventHandler(this.lbl_dapartment_name_Click);
            // 
            // txt_det_name
            // 
            this.txt_det_name.Location = new System.Drawing.Point(243, 237);
            this.txt_det_name.Name = "txt_det_name";
            this.txt_det_name.Size = new System.Drawing.Size(100, 20);
            this.txt_det_name.TabIndex = 18;
            this.txt_det_name.TextChanged += new System.EventHandler(this.txt_det_name_TextChanged);
            // 
            // lbl_shit_time
            // 
            this.lbl_shit_time.AutoSize = true;
            this.lbl_shit_time.Location = new System.Drawing.Point(78, 295);
            this.lbl_shit_time.Name = "lbl_shit_time";
            this.lbl_shit_time.Size = new System.Drawing.Size(67, 13);
            this.lbl_shit_time.TabIndex = 19;
            this.lbl_shit_time.Text = "Shift Timings";
            this.lbl_shit_time.Click += new System.EventHandler(this.lbl_shit_time_Click);
            // 
            // txt_shift_timings
            // 
            this.txt_shift_timings.Location = new System.Drawing.Point(243, 288);
            this.txt_shift_timings.Name = "txt_shift_timings";
            this.txt_shift_timings.Size = new System.Drawing.Size(100, 20);
            this.txt_shift_timings.TabIndex = 20;
            this.txt_shift_timings.TextChanged += new System.EventHandler(this.txt_shift_timings_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ResourceID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_resourceid
            // 
            this.txt_resourceid.Location = new System.Drawing.Point(243, 423);
            this.txt_resourceid.Name = "txt_resourceid";
            this.txt_resourceid.Size = new System.Drawing.Size(100, 20);
            this.txt_resourceid.TabIndex = 22;
            this.txt_resourceid.TextChanged += new System.EventHandler(this.txt_resourceid_TextChanged);
            // 
            // lbl_dept_name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 615);
            this.Controls.Add(this.txt_resourceid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_shift_timings);
            this.Controls.Add(this.lbl_shit_time);
            this.Controls.Add(this.txt_det_name);
            this.Controls.Add(this.lbl_dapartment_name);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.txt_sd);
            this.Controls.Add(this.rdb_female);
            this.Controls.Add(this.rdb_male);
            this.Controls.Add(this.lbl_date_of_joining);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_phoneno);
            this.Controls.Add(this.lbl_staff_name);
            this.Controls.Add(this.txt_dateOfJoining);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_phoneno);
            this.Controls.Add(this.txt_staffname);
            this.Controls.Add(this.lbl_staff_id);
            this.Controls.Add(this.txt_staffid);
            this.Controls.Add(this.btn_add);
            this.Name = "lbl_dept_name";
            this.Text = "AddStaffDetails";
            this.Load += new System.EventHandler(this.lbl_dept_name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_staffid;
        private System.Windows.Forms.Label lbl_staff_id;
        private System.Windows.Forms.TextBox txt_staffname;
        private System.Windows.Forms.TextBox txt_phoneno;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_dateOfJoining;
        private System.Windows.Forms.Label lbl_staff_name;
        private System.Windows.Forms.Label lbl_phoneno;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_date_of_joining;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.RadioButton rdb_female;
        private System.Windows.Forms.TextBox txt_sd;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label lbl_dapartment_name;
        private System.Windows.Forms.TextBox txt_det_name;
        private System.Windows.Forms.Label lbl_shit_time;
        private System.Windows.Forms.TextBox txt_shift_timings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_resourceid;
    }
}