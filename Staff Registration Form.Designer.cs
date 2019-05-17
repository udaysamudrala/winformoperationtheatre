namespace WindowsFormsApplication1
{
    partial class Staff_Registration_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsignup = new System.Windows.Forms.Button();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_loginid = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "PhoneNo.";
            // 
            // btnsignup
            // 
            this.btnsignup.Location = new System.Drawing.Point(208, 367);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(75, 23);
            this.btnsignup.TabIndex = 8;
            this.btnsignup.Text = "SIGN UP";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(169, 59);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(144, 20);
            this.txt_firstname.TabIndex = 9;
            this.txt_firstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_loginid
            // 
            this.txt_loginid.Location = new System.Drawing.Point(169, 160);
            this.txt_loginid.Name = "txt_loginid";
            this.txt_loginid.Size = new System.Drawing.Size(144, 20);
            this.txt_loginid.TabIndex = 10;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(169, 210);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(144, 20);
            this.txt_pwd.TabIndex = 11;
            this.txt_pwd.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Location = new System.Drawing.Point(169, 113);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(144, 20);
            this.txt_Lastname.TabIndex = 12;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(169, 256);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(144, 20);
            this.txt_email.TabIndex = 13;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(169, 302);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(144, 20);
            this.txt_phone.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(142, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(290, 30);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "STAFF REGISTRATION FORM";
            // 
            // Staff_Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 493);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_loginid);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Staff_Registration_Form";
            this.Text = "Staff_Registration_Form";
            this.Load += new System.EventHandler(this.Staff_Registration_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_loginid;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox textBox7;
    }
}