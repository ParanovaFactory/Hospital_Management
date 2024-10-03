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
    public partial class DepartmentPanel : Form
    {
        public DepartmentPanel()
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
            SqlCommand cmd = new SqlCommand("select * from TblDepartments", conn.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDepId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtDepName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TblDepartments (departmentName) values (@p1)", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtDepName.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                list();
                MessageBox.Show("Department added sucessfully");
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
                SqlCommand cmd = new SqlCommand("update TblDepartments set departmentName = @p1 where departmentId = @p2", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtDepName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtDepId.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                list();
                MessageBox.Show("Department updated sucessfully");
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
                SqlCommand cmd = new SqlCommand("delete TblDepartments where departmentId = @p1", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtDepId.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                list();
                MessageBox.Show("Department deleted sucessfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the invalid value");

                throw;
            }

        }
    }
}
