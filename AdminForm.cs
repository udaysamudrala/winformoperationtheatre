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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Doctors doctor = new Doctors();
            doctor.Show();

            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

      

        
        private void billing_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Billing b = new Billing();
            b.Show();
        }

        private void logout_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();

        }

        private void patient_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Patient_Details PD = new Patient_Details();
            PD.Show();
        }

        private void ADMINISTRATOR_TextChanged(object sender, EventArgs e)
        {

        }

        private void staff_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            staffdetails_Form s = new staffdetails_Form();
            s.Show();

        }

           }
}
