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
    public partial class lbl_dept_name : Form
    {
        public lbl_dept_name()
        {
            InitializeComponent();
        }

     
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.ConnectionString;
                con.Open();
                // MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into STAFF_DETAILS VALUES('@STAFF_ID','@STAFF_NAME','@PHONE_NO','@DEPARTMENT_NAME','@SHIFT_TIMINGS','@JOINING_DATE','@SALARY','@RESOURCE_ID','@GENDER','@AGE')";

                SqlParameter param1 = new SqlParameter("@STAFF_ID", SqlDbType.Int);
                SqlParameter param2 = new SqlParameter("@STAFF_NAME", SqlDbType.VarChar, 20);
                SqlParameter param3 = new SqlParameter("@PHONE_NO", SqlDbType.VarChar, 10);
                SqlParameter param4 = new SqlParameter("@DEPARTMENT_NAME", SqlDbType.VarChar, 20);
                SqlParameter param5 = new SqlParameter("@SHIFT_TIMINGS", SqlDbType.VarChar, 20);
                SqlParameter param6 = new SqlParameter("@JOINING_DATE", SqlDbType.DateTime);
                SqlParameter param7 = new SqlParameter("@SALARY", SqlDbType.SmallMoney);
                SqlParameter param8 = new SqlParameter("@RESOURCE_ID", SqlDbType.Int);
                
                SqlParameter param9 = new SqlParameter("@GENDER", SqlDbType.VarChar, 20);
                SqlParameter param10 = new SqlParameter("@AGE", SqlDbType.Int);

                
                
                


                cmd.Parameters.Add(param1).Value = Convert.ToString(txt_staffid.Text);
                cmd.Parameters.Add(param2).Value = txt_staffname.Text;
                cmd.Parameters.Add(param3).Value = txt_phoneno.Text;
                cmd.Parameters.Add(param4).Value = txt_det_name.Text;
                cmd.Parameters.Add(param5).Value = txt_shift_timings.Text;
                cmd.Parameters.Add(param6).Value = txt_dateOfJoining.Text;
                cmd.Parameters.Add(param7).Value = txt_salary;
                cmd.Parameters.Add(param8).Value = Convert.ToString(txt_resourceid.Text);
                
               // cmd.ExecuteNonQuery();
                
                if (rdb_male.Checked)
                {
                    cmd.Parameters.Add(param9).Value = "male";
                }
                else
                {
                    cmd.Parameters.Add(param9).Value = "female";

                }
                cmd.Parameters.Add(param10).Value = Convert.ToString(txt_age.Text);
                
                
               
                
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("inserted sucessfully");


                con.Close();

                this.Hide();
            }




            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

            
        }

        private void txt_sd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_staff_id_Click(object sender, EventArgs e)
        {

        }

        private void txt_staffid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_staff_name_Click(object sender, EventArgs e)
        {

        }

        private void txt_staffname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_phoneno_Click(object sender, EventArgs e)
        {

        }

        private void txt_phoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_age_Click(object sender, EventArgs e)
        {

        }

        private void txt_age_TextChanged(object sender, EventArgs e)
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

        private void lbl_dept_name_Load(object sender, EventArgs e)
        {

        }

        private void lbl_date_of_joining_Click(object sender, EventArgs e)
        {

        }

        private void txt_dateOfJoining_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_salary_Click(object sender, EventArgs e)
        {

        }

        private void txt_salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_dapartment_name_Click(object sender, EventArgs e)
        {

        }

        private void txt_det_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_shit_time_Click(object sender, EventArgs e)
        {

        }

        private void txt_shift_timings_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_resourceid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        }
}
