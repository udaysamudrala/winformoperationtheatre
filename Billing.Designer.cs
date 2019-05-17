namespace WindowsFormsApplication1
{
    partial class Billing
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt_patientid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.patientsview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.patientsview)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(31, 194);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(177, 31);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Billing Details";
            // 
            // txt_patientid
            // 
            this.txt_patientid.Location = new System.Drawing.Point(459, 45);
            this.txt_patientid.Name = "txt_patientid";
            this.txt_patientid.Size = new System.Drawing.Size(100, 20);
            this.txt_patientid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Patient ID";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(459, 97);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // patientsview
            // 
            this.patientsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsview.Location = new System.Drawing.Point(37, 261);
            this.patientsview.Name = "patientsview";
            this.patientsview.Size = new System.Drawing.Size(655, 329);
            this.patientsview.TabIndex = 4;
            this.patientsview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsview_CellContentClick);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 681);
            this.Controls.Add(this.patientsview);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_patientid);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Billing";
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.patientsview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txt_patientid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DataGridView patientsview;
    }
}