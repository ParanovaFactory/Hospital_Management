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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select appointmentId,appointmentDate,departmentName, docName + ' ' + docSurname as 'Doctor', appointmentPatient, appointmentComlaint, appointmentStatus from TblAppointments                                           inner join TblDoctors on TblDoctors.doctorId = TblAppointments.appointmentDoctor  inner join TblDepartments on TblDepartments.departmentId = TblAppointments.appointmentDepartment", conn.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
