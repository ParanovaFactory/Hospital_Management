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
    public partial class Secretary : Form
    {
        public Secretary()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        public string id;

        private void BtnCreateApponitment_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TblAppointments (appointmentDate, appointmentHour, appointmentDepartment, appointmentDoctor, appointmentStatus) values(@p1,@p2,@p3,@p4,@p5)", conn.connection());
                cmd.Parameters.AddWithValue("@p1", MtbAppointmentDate.Text);
                cmd.Parameters.AddWithValue("@p2", MtbAppointmentHour.Text);
                cmd.Parameters.AddWithValue("@p3", CmbAppointmentDepartment.SelectedIndex);
                cmd.Parameters.AddWithValue("@p4", CmbAppointmentDoctor.Text);
                cmd.Parameters.AddWithValue("@p5", ChcAppointmentStatus.Checked);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Appointement created succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
        }

        private void BtnUpdateApointment_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update TblAppointments set appointmentDate = @p1, appointmentHour = @p2, appointmentDepartment = @p3, appointmentDoctor = @p4, appointmentStatus = @p5 where appointmentId = @p6", conn.connection());
                cmd.Parameters.AddWithValue("@p1", MtbAppointmentDate.Text);
                cmd.Parameters.AddWithValue("@p2", MtbAppointmentHour.Text);
                cmd.Parameters.AddWithValue("@p3", CmbAppointmentDepartment.SelectedIndex);
                cmd.Parameters.AddWithValue("@p4", CmbAppointmentDoctor.Text);
                cmd.Parameters.AddWithValue("@p5", ChcAppointmentStatus.Checked);
                cmd.Parameters.AddWithValue("@p6", TxtAppointmentId.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Appointement updated succesfully");

            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
        }

        private void BtnDocPanel_Click(object sender, EventArgs e)
        {
            DoctorPanel doctorPanel = new DoctorPanel();
            doctorPanel.Show();
        }

        private void BtnDepPanel_Click(object sender, EventArgs e)
        {
            DepartmentPanel departmentPanel = new DepartmentPanel();
            departmentPanel.Show();
        }

        private void BtnAppointList_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Secretary_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select secName, secSurname, secIdNo from TblSecretaries where secIdNo = @p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", 11111111111);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LblSecretaryName.Text = reader.GetString(0);
                LblSecretarySurname.Text = reader.GetString(1);
                LblSecretaryIdNo.Text = reader.GetString(2);
            }

            SqlCommand cmd2 = new SqlCommand("select * from TblDepartments",conn.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd3 = new SqlCommand("select doctorId, docName, docSurname, departmentName, docIdNo, docPassword from TblDoctors inner join TblDepartments on TblDepartments.departmentId = TblDoctors.docDepartment", conn.connection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd3);
            DataTable dt2 = new DataTable();
            sqlDataAdapter.Fill(dt2);
            dataGridView2.DataSource = dt2;

            SqlCommand cmd4 = new SqlCommand("select departmentName from TblDepartments",conn.connection());
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                CmbAppointmentDepartment.Items.Add(reader4.GetString(0));
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sql = new SqlCommand("insert into TblAnouncement (anouncementText) values (@p1)", conn.connection());
                sql.Parameters.AddWithValue("@p1", RchAnouncementText.Text);
                sql.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("acouncement created");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
        }

        private void CmbAppointmentDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbAppointmentDoctor.Items.Clear();
            SqlCommand sql = new SqlCommand("select doctorId from TblDoctors where docDepartment = @p1", conn.connection());
            sql.Parameters.AddWithValue("@p1", CmbAppointmentDepartment.SelectedIndex);
            SqlDataReader r = sql.ExecuteReader();
            while (r.Read())
            {
                CmbAppointmentDoctor.Items.Add(r[0]);
            }
            conn.connection().Close();
        }
    }
}


