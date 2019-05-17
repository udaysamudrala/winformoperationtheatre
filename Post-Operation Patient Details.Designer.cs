namespace WindowsFormsApplication1
{
    partial class Post_Operation_Patient_Details
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
            this.txt_patientid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.post_operation_gridview = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.post_operation_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_patientid
            // 
            this.txt_patientid.Location = new System.Drawing.Point(487, 51);
            this.txt_patientid.Name = "txt_patientid";
            this.txt_patientid.Size = new System.Drawing.Size(100, 20);
            this.txt_patientid.TabIndex = 0;
            this.txt_patientid.TextChanged += new System.EventHandler(this.txt_patient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " Patient ID";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(407, 168);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(525, 168);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(35, 227);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(190, 31);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Patient Details";
            // 
            // post_operation_gridview
            // 
            this.post_operation_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.post_operation_gridview.Location = new System.Drawing.Point(41, 261);
            this.post_operation_gridview.Name = "post_operation_gridview";
            this.post_operation_gridview.Size = new System.Drawing.Size(639, 290);
            this.post_operation_gridview.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(256, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 30);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "POST-OPERATION";
            // 
            // Post_Operation_Patient_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(709, 570);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.post_operation_gridview);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_patientid);
            this.Name = "Post_Operation_Patient_Details";
            this.Text = "Post_Operation_Patient_Details";
            ((System.ComponentModel.ISupportInitialize)(this.post_operation_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_patientid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView post_operation_gridview;
        private System.Windows.Forms.TextBox textBox3;
    }
}