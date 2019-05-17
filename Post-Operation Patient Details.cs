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
    public partial class Post_Operation_Patient_Details : Form
    {
        public Post_Operation_Patient_Details()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int patientid=Convert.ToInt32(txt_patientid);
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.ConnectionString;
                con.Open();
                MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                string query1 = "select * from POST_OPERATION where PATIENT_ID=" + txt_patientid;
                cmd.CommandText = query1;


                int status = Convert.ToInt32(cmd.ExecuteScalar());
                if (status > 0)
                {
                    SqlDataAdapter DA = new SqlDataAdapter();
                    DA.SelectCommand = cmd;
                    DataSet DS = new DataSet();
                    DA.Fill(DS, "POST_OPERATION");
                    post_operation_gridview.DataSource = DS.Tables["POST_OPERATION"]; ;
                   // post_operation_gridview.DataMember = DS.Tables  "POST_OPERATION";
                    //SqlParameter param = new SqlParameter("@PATIENT_ID", SqlDbType.Int);


                    //cmd.Parameters.Add(param).Value = txt_patientid.Text;

                }

                else
                {
                    bool flag = true;
                    while (flag)
                    {
                        if (txt_patientid.TextLength == 0)
                        {
                            MessageBox.Show("Patient ID must be entered");
                            flag = false;
                        }
                        else { break; }
                    }


                }
            }

            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

        }

        private void txt_patient_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_patientid.Text = "";
        }
    }
}
