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
    public partial class DoctorInfo : Form
    {
        public DoctorInfo()
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
                SqlCommand cmd = new SqlCommand("update TblDoctors set docname=@p1,docSurname=@p2,docDepartment=@p3,docIdNo=@p4,docPassword=@p5 where doctorId = @p6", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
                cmd.Parameters.AddWithValue("@p3", CmbDepartment.SelectedIndex);
                cmd.Parameters.AddWithValue("@p4", MtbDoctorId.Text);
                cmd.Parameters.AddWithValue("@p5", TxtPassword.Text);
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

        private void DoctorInfo_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select doctorId,docName,docSurname,departmentName,docIdNo,docPassword from TblDoctors inner join TblDepartments on TblDepartments.departmentId = TblDoctors.docDepartment where doctorId = @p1", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                TxtName.Text = reader.GetString(1);
                TxtSurname.Text = reader.GetString(2);
                CmbDepartment.Text = reader.GetString(3);
                MtbDoctorId.Text = reader.GetString(4);
                TxtPassword.Text = reader.GetString(5);
            }

            SqlCommand sqlCommand1 = new SqlCommand("select departmentName from TblDepartments", conn.connection());
            SqlDataReader reader1 = sqlCommand1.ExecuteReader();
            while (reader1.Read())
            {
                CmbDepartment.Items.Add(reader1.GetString(0));
            }
        }
    }
}
