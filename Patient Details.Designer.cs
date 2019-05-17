namespace WindowsFormsApplication1
{
    partial class Patient_Details
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
            this.link_preoperation = new System.Windows.Forms.LinkLabel();
            this.link_postoperation = new System.Windows.Forms.LinkLabel();
            this.LBL_BACK = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // link_preoperation
            // 
            this.link_preoperation.AutoSize = true;
            this.link_preoperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_preoperation.Location = new System.Drawing.Point(35, 55);
            this.link_preoperation.Name = "link_preoperation";
            this.link_preoperation.Size = new System.Drawing.Size(354, 25);
            this.link_preoperation.TabIndex = 0;
            this.link_preoperation.TabStop = true;
            this.link_preoperation.Text = "PRE-OPERATION PATIENT DETAILS";
            this.link_preoperation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_preoperation_LinkClicked);
            // 
            // link_postoperation
            // 
            this.link_postoperation.AutoSize = true;
            this.link_postoperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_postoperation.Location = new System.Drawing.Point(35, 149);
            this.link_postoperation.Name = "link_postoperation";
            this.link_postoperation.Size = new System.Drawing.Size(281, 25);
            this.link_postoperation.TabIndex = 1;
            this.link_postoperation.TabStop = true;
            this.link_postoperation.Text = "POST-OPERATION DETAILS";
            this.link_postoperation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_postoperation_LinkClicked);
            // 
            // LBL_BACK
            // 
            this.LBL_BACK.AutoSize = true;
            this.LBL_BACK.Location = new System.Drawing.Point(360, 266);
            this.LBL_BACK.Name = "LBL_BACK";
            this.LBL_BACK.Size = new System.Drawing.Size(32, 13);
            this.LBL_BACK.TabIndex = 2;
            this.LBL_BACK.TabStop = true;
            this.LBL_BACK.Text = "Back";
            this.LBL_BACK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LBL_BACK_LinkClicked);
            // 
            // Patient_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 303);
            this.Controls.Add(this.LBL_BACK);
            this.Controls.Add(this.link_postoperation);
            this.Controls.Add(this.link_preoperation);
            this.Name = "Patient_Details";
            this.Text = "Patient_Details";
            this.Load += new System.EventHandler(this.Patient_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_preoperation;
        private System.Windows.Forms.LinkLabel link_postoperation;
        private System.Windows.Forms.LinkLabel LBL_BACK;
    }
}