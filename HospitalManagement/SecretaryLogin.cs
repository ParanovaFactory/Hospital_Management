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
    public partial class SecretaryLogin : Form
    {
        public SecretaryLogin()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void SecretaryLogin_Load(object sender, EventArgs e)
        {
            MtbSecId.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select secIdNo, secPassword from TblSecretaries where secIdNo = @p1 and secPassword = @p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", MtbSecId.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Secretary secretary = new Secretary();
                secretary.id = MtbSecId.Text;
                secretary.Show();
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
