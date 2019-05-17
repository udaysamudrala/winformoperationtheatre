namespace WindowsFormsApplication1
{
    partial class Staff_Home
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
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Register = new System.Windows.Forms.ToolStripMenuItem();
            this.view = new System.Windows.Forms.ToolStripMenuItem();
            this.allocateresources = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surgeonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nursingStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ananesthistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.resourcesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Register,
            this.view,
            this.allocateresources});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // Register
            // 
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(176, 22);
            this.Register.Text = "Register";
            this.Register.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // view
            // 
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(176, 22);
            this.view.Text = "View";
            this.view.Click += new System.EventHandler(this.allocateResourcesToolStripMenuItem_Click);
            // 
            // allocateresources
            // 
            this.allocateresources.Name = "allocateresources";
            this.allocateresources.Size = new System.Drawing.Size(176, 22);
            this.allocateresources.Text = "Allocate Resources";
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.surgeonsToolStripMenuItem,
            this.nursingStaffToolStripMenuItem,
            this.ananesthistToolStripMenuItem});
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.resourcesToolStripMenuItem.Text = "Resources";
            // 
            // surgeonsToolStripMenuItem
            // 
            this.surgeonsToolStripMenuItem.Name = "surgeonsToolStripMenuItem";
            this.surgeonsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.surgeonsToolStripMenuItem.Text = "Surgeons";
            // 
            // nursingStaffToolStripMenuItem
            // 
            this.nursingStaffToolStripMenuItem.Name = "nursingStaffToolStripMenuItem";
            this.nursingStaffToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nursingStaffToolStripMenuItem.Text = "Nursing Staff";
            // 
            // ananesthistToolStripMenuItem
            // 
            this.ananesthistToolStripMenuItem.Name = "ananesthistToolStripMenuItem";
            this.ananesthistToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ananesthistToolStripMenuItem.Text = "Anesthesist";
            // 
            // Staff_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Staff_Home";
            this.Text = "Staff_Home";
            this.Load += new System.EventHandler(this.Staff_Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Register;
        private System.Windows.Forms.ToolStripMenuItem view;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surgeonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nursingStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ananesthistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocateresources;
    }
}