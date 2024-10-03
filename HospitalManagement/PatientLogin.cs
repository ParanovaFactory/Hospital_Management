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
    public partial class PatientLogin : Form
    {
        public PatientLogin()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void LlblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterPatient registerPatient = new RegisterPatient();
            registerPatient.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatientLogin_Load(object sender, EventArgs e)
        {
            MtbUserId.Focus();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select patientIdNo, patientPassword from TblPatients where patientIdNo = @p1 and patientPassword = @p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", MtbUserId.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Patient patient = new Patient();
                patient.id = MtbUserId.Text;
                patient.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User id or password wrong");
            }
            conn.connection().Close();
        }
    }
}
