using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient ;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
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
                string query1 = "select * from Billing_Details where PATIENT_ID=@PATIENT_ID";

                if(txt_patientid.Text=="@PATIENT_ID")
                {
                    cmd.CommandText = query1;
                    SqlParameter param1 = new SqlParameter("@PATIENT_ID", SqlDbType.Int);

                    cmd.Parameters.Add(param1).Value = txt_patientid.Text;


                    int status = Convert.ToInt32(cmd.ExecuteScalar());
                    if (status > 0)
                    {
                        SqlDataAdapter DA = new SqlDataAdapter();
                        DA.SelectCommand = cmd;
                        DataSet DS = new DataSet();
                        DA.Fill(DS, "BILLING_DETAILS");
                        patientsview.DataSource = DS;
                        patientsview.DataMember = "BILLING_DETAILS";
                        //SqlCommandBuilder doc = new SqlCommandBuilder();
                        //doc.DataAdapter = DA;
                    }
                }
            }



            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
        }

        private void patientsview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
