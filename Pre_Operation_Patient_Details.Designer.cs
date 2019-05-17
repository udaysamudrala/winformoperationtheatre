namespace WindowsFormsApplication1
{
    partial class Pre_Operation_Patient_Details
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_patientid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pre_dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pre_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(629, 125);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_patientid
            // 
            this.txt_patientid.Location = new System.Drawing.Point(711, 75);
            this.txt_patientid.Name = "txt_patientid";
            this.txt_patientid.Size = new System.Drawing.Size(100, 20);
            this.txt_patientid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter PatientID";
            // 
            // pre_dataGridView
            // 
            this.pre_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pre_dataGridView.Location = new System.Drawing.Point(12, 188);
            this.pre_dataGridView.Name = "pre_dataGridView";
            this.pre_dataGridView.Size = new System.Drawing.Size(896, 182);
            this.pre_dataGridView.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "PATIENT_DETAILS";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(337, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 30);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "PRE_OPERATION_DETAILS";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(736, 125);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Pre_Operation_Patient_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 451);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pre_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_patientid);
            this.Controls.Add(this.btn_submit);
            this.Name = "Pre_Operation_Patient_Details";
            this.Text = "Pre_Operation_Patient_Details";
            this.Load += new System.EventHandler(this.Pre_Operation_Patient_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pre_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_patientid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pre_dataGridView;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_reset;
    }
}