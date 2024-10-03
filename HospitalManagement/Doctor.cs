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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        public string id;

        void list()
        {
            SqlCommand cmd = new SqlCommand("select * from TblAppointments where appointmentDoctor = (select doctorId from TblDoctors where docIdNo = @p1)", conn.connection());
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DgvAppointments.DataSource = dt;
        }

        private void BtnSetInfor_Click(object sender, EventArgs e)
        {
            DoctorInfo doctorInfo = new DoctorInfo();
            doctorInfo.id = LblId.Text;
            doctorInfo.Show();
        }

        private void BtnAnouncement_Click(object sender, EventArgs e)
        {
            Anouncement anouncement = new Anouncement();
            anouncement.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select docName, docSurname, docIdNo, doctorId from TblDoctors where docIdNo = @p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LblDoctorName.Text = reader.GetString(0);
                LblDoctorSurname.Text = reader.GetString(1);
                LblDoctorIdNo.Text = reader.GetString(2);
                LblId.Text = reader.GetValue(3).ToString();
            }
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void DgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RchPatientComp.Text = DgvAppointments.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
