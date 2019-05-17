namespace WindowsFormsApplication1
{
    partial class staffdetails_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.view_staff = new System.Windows.Forms.ToolStripMenuItem();
            this.add_staff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_staff,
            this.add_staff});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // view_staff
            // 
            this.view_staff.Name = "view_staff";
            this.view_staff.Size = new System.Drawing.Size(45, 20);
            this.view_staff.Text = "VIEW";
            this.view_staff.Click += new System.EventHandler(this.view_staff_Click);
            // 
            // add_staff
            // 
            this.add_staff.Name = "add_staff";
            this.add_staff.Size = new System.Drawing.Size(40, 20);
            this.add_staff.Text = "ADD";
            this.add_staff.Click += new System.EventHandler(this.add_staff_Click);
            // 
            // staffdetails_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.Name = "staffdetails_Form";
            this.Text = "staffdetails_Form";
            this.Load += new System.EventHandler(this.staffdetails_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem view_staff;
        private System.Windows.Forms.ToolStripMenuItem add_staff;

    }
}