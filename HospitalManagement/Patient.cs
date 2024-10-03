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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();
        public string id;

        void Mylist()
        {
            SqlCommand cmd = new SqlCommand("select * from TblAppointments where appointmentPatient = @p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", LblUserName.Text + " " + LblUserSurname.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DgvMyAppointments.DataSource = dt;
            adapter.Dispose();
        }

        void Alllist()
        {
            SqlCommand cmd2 = new SqlCommand("select * from TblAppointments where appointmentStatus = 1", conn.connection());
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            DgvAvailableAppoinments.DataSource = dt2;
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            Mylist();
            Alllist();
        }

        private void BntLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LnkUpdateInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientInfo patientInfo = new PatientInfo();
            patientInfo.id = id;
            patientInfo.Show();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select patientName,patientSurname,patientIdNo from Tblpatients where patientIdNo = @p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                LblUserName.Text = reader.GetString(0);
                LblUserSurname.Text = reader.GetString(1);
                LblUserIdNo.Text = reader.GetString(2);
            }
            SqlCommand cmd2 = new SqlCommand("select departmentName from TblDepartments", conn.connection());
            cmd2.Parameters.AddWithValue("@p1", id);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                CmbDepartment.Items.Add(reader2.GetString(0));
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql1 = new SqlCommand("update TblAppointments set appointmentComlaint = @p1 where appointmentId = @p2", conn.connection());
                sql1.Parameters.AddWithValue("@p1", RchPatientComp.Text);
                sql1.Parameters.AddWithValue("@p2", LblMayAppId.Text);
                sql1.ExecuteNonQuery();
                Mylist();
                Alllist();
                MessageBox.Show("Appointment updated succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
        }

        private void CmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();
            SqlCommand sql = new SqlCommand("select docName, docSurname from TblDoctors where docDepartment = @p1",conn.connection());
            sql.Parameters.AddWithValue("@p1", CmbDepartment.SelectedIndex);
            SqlDataReader r = sql.ExecuteReader();
            while (r.Read())
            {
                CmbDoctor.Items.Add(r[0] + " " + r[1]);
            }
            conn.connection().Close();
        }

        private void DgvAvailableAppoinments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LblAPPId.Text = DgvAvailableAppoinments.Rows[e.RowIndex].Cells[0].Value.ToString();
            CmbDepartment.Text = DgvAvailableAppoinments.Rows[e.RowIndex].Cells[3].Value.ToString();
            CmbDoctor.Text = DgvAvailableAppoinments.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand sql = new SqlCommand("update TblAppointments set appointmentPatien = @p1, appointmentComlaint=@p2, appointmentStatus = 0 where appointmentId = @p3", conn.connection());
                sql.Parameters.AddWithValue("@p1", LblUserName.Text + " " + LblUserSurname.Text);
                sql.Parameters.AddWithValue("@p2", RchPatientComp.Text);
                sql.Parameters.AddWithValue("@p3", LblAPPId.Text);
                sql.ExecuteNonQuery();
                conn.connection().Close();
                Mylist();
                Alllist();
                MessageBox.Show("Appointment updated succesfully");

            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql1 = new SqlCommand("update TblAppointments set appointmentPatien = ' ', appointmentComlaint=' ', appointmentStatus = 1 where appointmentId = @p3", conn.connection());
                sql1.Parameters.AddWithValue("@p3", LblMayAppId.Text);
                sql1.ExecuteNonQuery();
                Mylist();
                Alllist();
                MessageBox.Show("Appointment deleted succesfully");

            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
        }

        private void DgvMyAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LblMayAppId.Text = DgvMyAppointments.Rows[e.RowIndex].Cells[0].Value.ToString();
            CmbDepartment.Text = DgvMyAppointments.Rows[e.RowIndex].Cells[3].Value.ToString();
            CmbDoctor.Text = DgvMyAppointments.Rows[e.RowIndex].Cells[4].Value.ToString();
            RchPatientComp.Text = DgvMyAppointments.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CmbDepartment.SelectedIndex = 0;
            RchPatientComp.Text = " ";
        }
    }
}
