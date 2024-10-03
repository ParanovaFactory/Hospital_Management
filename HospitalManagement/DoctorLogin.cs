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
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void DoctorLogin_Load(object sender, EventArgs e)
        {
            MtbDocId.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select docIdNo, docPassword from TblDoctors where docIdNo = @p1 and docPassword = @p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", MtbDocId.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Doctor doctor = new Doctor();
                doctor.id = MtbDocId.Text;
                doctor.Show();
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
