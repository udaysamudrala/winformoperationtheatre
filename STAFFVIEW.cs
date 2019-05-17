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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void rbtn_staffid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_staffid_TextChanged(object sender, EventArgs e)
        {

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
                string query = "select * from STAFF_DETAILS where STAFF_ID=@STAFF_ID";

                if (rbtn_staffid.Checked == true)
                {
                    cmd.CommandText = query;
                    SqlParameter param = new SqlParameter("@STAFF_ID", SqlDbType.Int);

                    cmd.Parameters.Add(param).Value = Convert.ToString(txt_staffid.Text);


                    int status = Convert.ToInt32(cmd.ExecuteScalar());
                    if (status > 0)
                    {
                        SqlDataAdapter DA = new SqlDataAdapter();
                        DA.SelectCommand = cmd;
                        DataSet DS = new DataSet();
                        DA.Fill(DS, "STAFF_DETAILS");
                        gridview_staff_details.DataSource = DS;
                        gridview_staff_details.DataMember = "STAFF_DETAILS";
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_staffid.Text = " ";
        }

        private void gridview_staff_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

    }
}
