using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class staffdetails_Form : Form
    {
        public staffdetails_Form()
        {
            InitializeComponent();
        }

       

        private void view_staff_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Show();
        }

        private void add_staff_Click(object sender, EventArgs e)
        {
            lbl_dept_name asd =new lbl_dept_name();
            asd.Show();
        }

        private void staffdetails_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
