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
    public partial class Doctors : Form
    {
        
        public Doctors()
        {          
        InitializeComponent();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            txt_doctorid.Enabled = false;
            txt_docname.Enabled = false;
            txt_specialization.Enabled = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
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
                string query1 = "select * from DOCTOR_DETAILS where doc_id=@DOC_ID";
                 string query2 = "select * from DOCTOR_DETAILS where doc_name=@DOC_Name";
                 string query3 = "select * from DOCTOR_DETAILS where doc_specialization=@DOC_Specialization";
                 if (rdb_docid.Checked)
                 {  
                     cmd.CommandText =query1;
                     SqlParameter param1 = new SqlParameter("@DOC_ID", SqlDbType.Int);
                     
                     cmd.Parameters.Add(param1).Value = txt_doctorid.Text;
                   
                    
                     int status = Convert.ToInt32(cmd.ExecuteScalar());
                     if (status > 0)
                     {
                         SqlDataAdapter DA = new SqlDataAdapter();
                         DA.SelectCommand = cmd;
                         DataSet DS = new DataSet();
                         DA.Fill(DS, "DOCTOR_DETAILS");
                         doctorsview.DataSource = DS;
                         doctorsview.DataMember = "DOCTOR_DETAILS";
                         //SqlCommandBuilder doc = new SqlCommandBuilder();
                         //doc.DataAdapter = DA;
                     }
                 }
                 else if(rdb_docname.Checked)
                 {     cmd.CommandText =query2;
                     SqlParameter param2 = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 50);
                     cmd.Parameters.Add(param2).Value = txt_docname.Text;}
                else {cmd.CommandText =query3;
                     SqlParameter param3 = new SqlParameter("@DOC_SPECIALIZATION", SqlDbType.VarChar, 50);
                     cmd.Parameters.Add(param3).Value =txt_specialization .Text ;
                }
                 }
            
    
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

        }
        private void doctorsview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_doctorid_TextChanged(object sender, EventArgs e)
        {
        }


        
       

        

        private void rdb_docname_CheckedChanged(object sender, EventArgs e)
        {
            txt_docname.Enabled = true;
            txt_doctorid.Enabled = false;
            txt_specialization.Enabled = false;
            txt_docname.Focus();

        }

        private void rdb_specialization_CheckedChanged(object sender, EventArgs e)
        {
            txt_specialization.Enabled = true;
            txt_docname.Enabled = false;
            txt_doctorid.Enabled = false;
            txt_specialization.Focus();
        }

        private void rdb_docid_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_doctorid.Enabled =true;
            txt_docname.Enabled = false;
            txt_specialization.Enabled = false;
            txt_doctorid.Focus();

        }

        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            txt_doctorid.Text = "";
            txt_docname.Text = "";
            txt_specialization.Text = "";

        }

        private void txt_doctorid_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void doctorsview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
