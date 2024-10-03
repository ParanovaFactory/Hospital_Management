using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Modules : Form
    {
        public Modules()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorLogin doctorLogin = new DoctorLogin();
            doctorLogin.Show();
        }

        private void BtnSecretary_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecretaryLogin secretaryLogin = new SecretaryLogin();
            secretaryLogin.Show();
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientLogin patientLogin = new PatientLogin();
            patientLogin.Show();
        }
    }
}
