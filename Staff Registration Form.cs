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
    public partial class Staff_Registration_Form : Form
    {
        public Staff_Registration_Form()
        {
            InitializeComponent();
        }

        private void Staff_Registration_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "insert into staff_registration values(@firstname,@lastname,@loginid,@password,@email,@phoneno)";
            cmd.CommandType = CommandType.Text;
            SqlParameter param1 = new SqlParameter("@firstname", SqlDbType.VarChar, 20);
            SqlParameter param2 = new SqlParameter("@lastname", SqlDbType.VarChar, 20);
            SqlParameter param3 = new SqlParameter("@loginid", SqlDbType.Int);
            SqlParameter param4 = new SqlParameter("@password", SqlDbType.VarChar, 100);
            SqlParameter param5 = new SqlParameter("@email", SqlDbType.VarChar, 20);
            SqlParameter param6 = new SqlParameter("@phoneno", SqlDbType.VarChar, 20);


            cmd.Parameters.Add(param1).Value = txt_firstname.Text;
            cmd.Parameters.Add(param2).Value = txt_Lastname.Text;
            cmd.Parameters.Add(param3).Value = Convert.ToInt16(txt_loginid.Text);
            cmd.Parameters.Add(param4).Value = txt_pwd.Text;
            cmd.Parameters.Add(param5).Value = txt_email.Text;
            cmd.Parameters.Add(param6).Value = txt_phone.Text;

            cmd.ExecuteNonQuery();

            MessageBox.Show("inserted sucessfully");


            con.Close();

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
