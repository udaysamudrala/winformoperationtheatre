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
    public partial class Patient_Details : Form
    {
        public Patient_Details()
        {
            InitializeComponent();
        }

        private void Patient_Details_Load(object sender, EventArgs e)
        {

        }

        private void LBL_BACK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void link_preoperation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pre_Operation_Patient_Details pre = new Pre_Operation_Patient_Details();
            pre.Show();

        }

        private void link_postoperation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Post_Operation_Patient_Details post = new Post_Operation_Patient_Details();
            post.Show();
        }



        
    }
}
