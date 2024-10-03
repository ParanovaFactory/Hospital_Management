using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class PatientInfo : Form
    {
        public PatientInfo()
        {
            InitializeComponent();
        }
        SQLConnection conn = new SQLConnection();

        public string id;

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update TblPatients set patientName=@p1,patientSurname=@p2,patientPhoneNo=@p3,patientPassword=@p4,patientGender=@p5 where patientIdNo = @p6", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
                cmd.Parameters.AddWithValue("@p3", MtbPhoneNo.Text);
                cmd.Parameters.AddWithValue("@p4", TxtPassword.Text);
                cmd.Parameters.AddWithValue("@p5", CmbGender.Text);
                cmd.Parameters.AddWithValue("@p6", id);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Information updated sucessfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
           
        }

        private void PatientInfo_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from Tblpatients where patientIdNo = @p1", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                TxtName.Text = reader.GetString(1);
                TxtSurname.Text = reader.GetString(2);
                MtbUserId.Text = reader.GetString(3);
                MtbPhoneNo.Text = reader.GetString(4);
                TxtPassword.Text = reader.GetString(5);
                CmbGender.Text = reader.GetString(6);
            }
            conn.connection().Close();
        }
    }
}
