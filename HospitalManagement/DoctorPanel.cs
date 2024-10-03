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
    public partial class DoctorPanel : Form
    {
        public DoctorPanel()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("select doctorId, docName, docSurname, departmentName, docIdNo, docpassword from TblDoctors inner join TblDepartments on TblDepartments.departmentId = TblDoctors.docDepartment", conn.connection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.connection().Close();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TblDoctors (docName,docSurname,docDepartment,docIdNo,docPassword) values (@p1,@p2,@p3,@p4,@p5)", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtDocName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtDocSurname.Text);
                cmd.Parameters.AddWithValue("@p3", CmbDocDepartment.SelectedIndex);
                cmd.Parameters.AddWithValue("@p4", MtbDocIdNo.Text);
                cmd.Parameters.AddWithValue("@p5", TxtDocPaaword.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Doctor added");
                list();

            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update TblDoctors set docName = @p1,docSurname = @p2,docDepartment = @p3,docIdNo = @p4 ,docPassword = @p5 where doctorId = @p6", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtDocName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtDocSurname.Text);
                cmd.Parameters.AddWithValue("@p3", CmbDocDepartment.SelectedIndex);
                cmd.Parameters.AddWithValue("@p4", MtbDocIdNo.Text);
                cmd.Parameters.AddWithValue("@p5", TxtDocPaaword.Text);
                cmd.Parameters.AddWithValue("@p6", label5.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Doctor updated");
                list();
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
                SqlCommand cmd = new SqlCommand("delete TblDoctors where doctorId = @p1", conn.connection());
                cmd.Parameters.AddWithValue("@p1", label5.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Doctor deleted");
                list();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtDocName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtDocSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CmbDocDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            MtbDocIdNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtDocPaaword.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void DoctorPanel_Load(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("select departmentName from TblDepartments", conn.connection());
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                CmbDocDepartment.Items.Add(reader4.GetString(0));
            }
        }
    }
}
