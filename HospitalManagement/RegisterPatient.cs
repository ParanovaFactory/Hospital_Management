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
    public partial class RegisterPatient : Form
    {
        public RegisterPatient()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegisterPatient_Load(object sender, EventArgs e)
        {
            TxtName.Focus();
        }

        SQLConnection conn = new SQLConnection();

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TblPatients (patientName, patientSurname, patientIdNo, patientPhoneNo, patientPassword, patientGender) values(@p1,@p2,@p3,@p4,@p5,@p6)", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
                cmd.Parameters.AddWithValue("@p3", MtbUserId.Text);
                cmd.Parameters.AddWithValue("@p4", MtbPhoneNo.Text);
                cmd.Parameters.AddWithValue("@p5", TxtPassword.Text);
                cmd.Parameters.AddWithValue("@p6", CmbGender.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Sucessfully Registered");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
            
        }

        private void LnklLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PatientLogin patientLogin = new PatientLogin();
            patientLogin.Show();
        }
    }
}
