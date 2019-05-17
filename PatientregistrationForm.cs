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
    public partial class PatientregistrationForm : Form
    {
        public PatientregistrationForm()
        {
            InitializeComponent();
        }      
            

        private void lbl_fname_Click(object sender, EventArgs e)
        {

        }

        private void tbx_Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_Lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_lname_Click(object sender, EventArgs e)
        {

        }

        private void lbl_gender_Click(object sender, EventArgs e)
        {

        }

        private void rdb_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbx_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_age_Click(object sender, EventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_address_Click(object sender, EventArgs e)
        {

        }

        private void tbx_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_pno_Click(object sender, EventArgs e)
        {

        }

        private void tbx_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "insert into patient_registration values(@firstname,@lastname,@Gender,@Age,@Address,@phone,@emailid)";
            cmd.CommandType = CommandType.Text;
            SqlParameter param1 = new SqlParameter("@firstname", SqlDbType.VarChar, 20);
            SqlParameter param2 = new SqlParameter("@lastname", SqlDbType.VarChar, 20);
            SqlParameter param3 = new SqlParameter("@Gender", SqlDbType.VarChar,10);
            SqlParameter param4 = new SqlParameter("@Age", SqlDbType.Int);
            SqlParameter param5 = new SqlParameter("@Address", SqlDbType.VarChar, 20);
            SqlParameter param6 = new SqlParameter("@Phone", SqlDbType.VarChar, 20);
            
            SqlParameter param7 = new SqlParameter("@emailid", SqlDbType.VarChar, 20);


            cmd.Parameters.Add(param1).Value = tbx_Firstname.Text;
            cmd.Parameters.Add(param2).Value = tbx_Lastname.Text;
           
            if (rdb_male.Checked)
            {
                cmd.Parameters.Add(param3).Value = "male";
            }
            else
            {
                cmd.Parameters.Add(param3).Value ="female" ;

            }
            cmd.Parameters.Add(param4).Value = tbx_age.Text;
            cmd.Parameters.Add(param5).Value = txt_address.Text;
            cmd.Parameters.Add(param6).Value = tbx_phone.Text;           
            cmd.Parameters.Add(param7).Value = tbx_email.Text;             
            cmd.ExecuteNonQuery();

         //   MessageBox.Show("inserted sucessfully");


            con.Close();

            this.Hide();
        }
        }

        
    }
