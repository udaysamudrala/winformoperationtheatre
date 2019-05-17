namespace WindowsFormsApplication1
{
    partial class LoginForm
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
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_loginid = new System.Windows.Forms.TextBox();
            this.cmbloginas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(443, 316);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_loginid
            // 
            this.txt_loginid.Location = new System.Drawing.Point(547, 199);
            this.txt_loginid.Name = "txt_loginid";
            this.txt_loginid.Size = new System.Drawing.Size(100, 20);
            this.txt_loginid.TabIndex = 1;
            this.txt_loginid.TextChanged += new System.EventHandler(this.txt_loginid_TextChanged);
            // 
            // cmbloginas
            // 
            this.cmbloginas.FormattingEnabled = true;
            this.cmbloginas.Items.AddRange(new object[] {
            "Staff",
            "Administrator"});
            this.cmbloginas.Location = new System.Drawing.Point(547, 148);
            this.cmbloginas.Name = "cmbloginas";
            this.cmbloginas.Size = new System.Drawing.Size(121, 21);
            this.cmbloginas.TabIndex = 2;
            this.cmbloginas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "LoginAs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LoginID";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(547, 251);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(100, 20);
            this.txt_pwd.TabIndex = 5;
            this.txt_pwd.TextChanged += new System.EventHandler(this.txt_pwd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "APOLLO HOSPITAL\r\n";
            // 
            // btnsignup
            // 
            this.btnsignup.Location = new System.Drawing.Point(577, 315);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(75, 23);
            this.btnsignup.TabIndex = 11;
            this.btnsignup.Text = "SignUp";
            this.btnsignup.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 405);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbloginas);
            this.Controls.Add(this.txt_loginid);
            this.Controls.Add(this.btn_login);
            this.IsMdiContainer = true;
            this.Name = "LoginForm";
            this.Text = "LOGIN FORM";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_loginid;
        private System.Windows.Forms.ComboBox cmbloginas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsignup;
    }
}

