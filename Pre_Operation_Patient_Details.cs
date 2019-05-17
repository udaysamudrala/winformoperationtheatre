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
    public partial class Pre_Operation_Patient_Details : Form
    {
        
        public Pre_Operation_Patient_Details()
        {
            InitializeComponent();
        }

        private void Pre_Operation_Patient_Details_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            int patientid = Convert.ToInt32(txt_patientid.Text);
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.ConnectionString;
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                string query1 = "select * from PRE_OPERATION where PATIENT_ID="+patientid;
                cmd.CommandText = query1;
                              
                    int status = Convert.ToInt32(cmd.ExecuteScalar()); 
                if (status > 0)
                    {
                        SqlDataAdapter DA = new SqlDataAdapter();
                        DA.SelectCommand = cmd;
                        DataSet DS = new DataSet();
                        DA.Fill(DS, "PRE_OPERATION");
                        pre_dataGridView.DataSource = DS.Tables["PRE_OPERATION"];
                        
                        //SqlParameter param = new SqlParameter("@PATIENT_ID", SqlDbType.Int);


                        //cmd.Parameters.Add(param).Value = Convert.ToString(txt_patientid.Text);

                    
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_patientid.Text = "";
        }

       
    }
}
