namespace WindowsFormsApplication1
{
    partial class Staff
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
            this.rbtn_staffid = new System.Windows.Forms.RadioButton();
            this.txt_staffid = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gridview_staff_details = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_staff_details)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(387, 110);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // rbtn_staffid
            // 
            this.rbtn_staffid.AutoSize = true;
            this.rbtn_staffid.Location = new System.Drawing.Point(370, 38);
            this.rbtn_staffid.Name = "rbtn_staffid";
            this.rbtn_staffid.Size = new System.Drawing.Size(61, 17);
            this.rbtn_staffid.TabIndex = 2;
            this.rbtn_staffid.TabStop = true;
            this.rbtn_staffid.Text = "Staff ID";
            this.rbtn_staffid.UseVisualStyleBackColor = true;
            this.rbtn_staffid.CheckedChanged += new System.EventHandler(this.rbtn_staffid_CheckedChanged);
            // 
            // txt_staffid
            // 
            this.txt_staffid.Location = new System.Drawing.Point(493, 38);
            this.txt_staffid.Name = "txt_staffid";
            this.txt_staffid.Size = new System.Drawing.Size(100, 20);
            this.txt_staffid.TabIndex = 6;
            this.txt_staffid.TextChanged += new System.EventHandler(this.txt_staffid_TextChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(518, 110);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(45, 301);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(162, 31);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Staff Details";
            // 
            // gridview_staff_details
            // 
            this.gridview_staff_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_staff_details.Location = new System.Drawing.Point(51, 351);
            this.gridview_staff_details.Name = "gridview_staff_details";
            this.gridview_staff_details.Size = new System.Drawing.Size(583, 210);
            this.gridview_staff_details.TabIndex = 9;
            this.gridview_staff_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_staff_details_CellContentClick);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 583);
            this.Controls.Add(this.gridview_staff_details);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_staffid);
            this.Controls.Add(this.rbtn_staffid);
            this.Controls.Add(this.btn_submit);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_staff_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.RadioButton rbtn_staffid;
        private System.Windows.Forms.TextBox txt_staffid;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView gridview_staff_details;
    }
}