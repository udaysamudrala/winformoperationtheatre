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
    public partial class LoginForm : Form
    {
       public  LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_loginid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {   
            FieldValidation FV=new FieldValidation();
            if((FV.isNumber(txt_loginid.Text)))
            {
                MessageBox.Show("ENTER ONLY NUMERICS");
            }
            else
            {
                try
                {

                    if (cmbloginas.SelectedItem.ToString().Equals("Administrator"))
                    {
                        using (con = new SqlConnection())
                        {
                            con.ConnectionString = Properties.Settings.Default.ConnectionString;
                            con.Open();
                            cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandText = "select count(*) from Administrator where LoginID=@LoginID and password=@password";

                            cmd.CommandType = CommandType.Text;
                            SqlParameter param1 = new SqlParameter("@LoginID", SqlDbType.VarChar, 20);
                            SqlParameter param2 = new SqlParameter("@password", SqlDbType.VarChar, 20);
                            cmd.Parameters.Add(param1).Value = txt_loginid.Text;
                            cmd.Parameters.Add(param2).Value = txt_pwd.Text;
                            int status = Convert.ToInt32(cmd.ExecuteScalar());
                            if (status > 0)
                            {
                                AdminForm af = new AdminForm();
                                af.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password");

                            }
                            con.Close();
                        }
                    }

                    else
                        if (cmbloginas.SelectedItem.ToString().Equals("Staff"))
                        {
                            using (con = new SqlConnection())
                            {
                                con.ConnectionString = Properties.Settings.Default.ConnectionString;
                                con.Open();
                                cmd = new SqlCommand();
                                cmd.Connection = con;
                                string query = "select count(*) from LoginDetails where LoginID=@LoginID and password=@password";
                                cmd.CommandText = query;
                                cmd.CommandType = CommandType.Text;
                                SqlParameter param1 = new SqlParameter("@LoginID", SqlDbType.VarChar, 20);
                                SqlParameter param2 = new SqlParameter("@password", SqlDbType.VarChar, 20);
                                cmd.Parameters.Add(param1).Value = txt_loginid.Text;
                                cmd.Parameters.Add(param2).Value = txt_pwd.Text;
                                int status = Convert.ToInt32(cmd.ExecuteScalar());
                                if (status > 0)
                                {
                                    Staff_Home ph = new Staff_Home();
                                    GetLoginID.UserName_Role = txt_loginid.Text;
                                    ph.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Username or Password");

                                }

                            }
                        }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);


                }
            }
        }


        private void btnsignup_Click(object sender, EventArgs e)
        {
            Staff_Registration_Form srf = new Staff_Registration_Form();
            srf.Show();
        }
    }
}
