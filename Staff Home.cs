using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Staff_Home : Form
    {
        public Staff_Home()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientregistrationForm prf = new PatientregistrationForm();
            prf.Show();
        }
        private void Staff_Home_Load(object sender, EventArgs e)
        {

        }

        private void allocateResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
