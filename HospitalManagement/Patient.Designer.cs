namespace HospitalManagement
{
    partial class Patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblMayAppId = new System.Windows.Forms.Label();
            this.LblAPPId = new System.Windows.Forms.Label();
            this.LnkUpdateInfo = new System.Windows.Forms.LinkLabel();
            this.LblUserSurname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblUserIdNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAppointment = new System.Windows.Forms.Button();
            this.RchPatientComp = new System.Windows.Forms.RichTextBox();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvMyAppointments = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvAvailableAppoinments = new System.Windows.Forms.DataGridView();
            this.BntLogOut = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMyAppointments)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAvailableAppoinments)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblMayAppId);
            this.groupBox1.Controls.Add(this.LblAPPId);
            this.groupBox1.Controls.Add(this.LnkUpdateInfo);
            this.groupBox1.Controls.Add(this.LblUserSurname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LblUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblUserIdNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(377, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // LblMayAppId
            // 
            this.LblMayAppId.AutoSize = true;
            this.LblMayAppId.Location = new System.Drawing.Point(333, 42);
            this.LblMayAppId.Name = "LblMayAppId";
            this.LblMayAppId.Size = new System.Drawing.Size(23, 20);
            this.LblMayAppId.TabIndex = 8;
            this.LblMayAppId.Text = "Id";
            // 
            // LblAPPId
            // 
            this.LblAPPId.AutoSize = true;
            this.LblAPPId.Location = new System.Drawing.Point(333, 22);
            this.LblAPPId.Name = "LblAPPId";
            this.LblAPPId.Size = new System.Drawing.Size(23, 20);
            this.LblAPPId.TabIndex = 7;
            this.LblAPPId.Text = "Id";
            // 
            // LnkUpdateInfo
            // 
            this.LnkUpdateInfo.AutoSize = true;
            this.LnkUpdateInfo.ForeColor = System.Drawing.Color.White;
            this.LnkUpdateInfo.LinkColor = System.Drawing.Color.White;
            this.LnkUpdateInfo.Location = new System.Drawing.Point(209, 84);
            this.LnkUpdateInfo.Name = "LnkUpdateInfo";
            this.LnkUpdateInfo.Size = new System.Drawing.Size(147, 20);
            this.LnkUpdateInfo.TabIndex = 6;
            this.LnkUpdateInfo.TabStop = true;
            this.LnkUpdateInfo.Text = "Update Information";
            this.LnkUpdateInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUpdateInfo_LinkClicked);
            // 
            // LblUserSurname
            // 
            this.LblUserSurname.AutoSize = true;
            this.LblUserSurname.Location = new System.Drawing.Point(175, 62);
            this.LblUserSurname.Name = "LblUserSurname";
            this.LblUserSurname.Size = new System.Drawing.Size(27, 20);
            this.LblUserSurname.TabIndex = 5;
            this.LblUserSurname.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "User Surname";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(175, 42);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(27, 20);
            this.LblUserName.TabIndex = 3;
            this.LblUserName.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // LblUserIdNo
            // 
            this.LblUserIdNo.AutoSize = true;
            this.LblUserIdNo.Location = new System.Drawing.Point(175, 22);
            this.LblUserIdNo.Name = "LblUserIdNo";
            this.LblUserIdNo.Size = new System.Drawing.Size(27, 20);
            this.LblUserIdNo.TabIndex = 1;
            this.LblUserIdNo.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Identity Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmbDepartment);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnClear);
            this.groupBox2.Controls.Add(this.BtnAppointment);
            this.groupBox2.Controls.Add(this.RchPatientComp);
            this.groupBox2.Controls.Add(this.CmbDoctor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Appointment";
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Items.AddRange(new object[] {
            ""});
            this.CmbDepartment.Location = new System.Drawing.Point(179, 23);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(174, 28);
            this.CmbDepartment.TabIndex = 1;
            this.CmbDepartment.SelectedIndexChanged += new System.EventHandler(this.CmbDepartment_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Department";
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Location = new System.Drawing.Point(198, 255);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(155, 43);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAppointment
            // 
            this.BtnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAppointment.Location = new System.Drawing.Point(10, 255);
            this.BtnAppointment.Name = "BtnAppointment";
            this.BtnAppointment.Size = new System.Drawing.Size(155, 43);
            this.BtnAppointment.TabIndex = 4;
            this.BtnAppointment.Text = "Accept";
            this.BtnAppointment.UseVisualStyleBackColor = true;
            this.BtnAppointment.Click += new System.EventHandler(this.BtnAppointment_Click);
            // 
            // RchPatientComp
            // 
            this.RchPatientComp.Location = new System.Drawing.Point(10, 104);
            this.RchPatientComp.Name = "RchPatientComp";
            this.RchPatientComp.Size = new System.Drawing.Size(343, 145);
            this.RchPatientComp.TabIndex = 3;
            this.RchPatientComp.Text = "";
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(179, 57);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(174, 28);
            this.CmbDoctor.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Patient\'s Complaint";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Doctor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvMyAppointments);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(727, 221);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "My Appointments";
            // 
            // DgvMyAppointments
            // 
            this.DgvMyAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvMyAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvMyAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMyAppointments.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMyAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMyAppointments.Location = new System.Drawing.Point(3, 22);
            this.DgvMyAppointments.Name = "DgvMyAppointments";
            this.DgvMyAppointments.Size = new System.Drawing.Size(721, 196);
            this.DgvMyAppointments.TabIndex = 0;
            this.DgvMyAppointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMyAppointments_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvAvailableAppoinments);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 551);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(727, 282);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Available Appointments";
            // 
            // DgvAvailableAppoinments
            // 
            this.DgvAvailableAppoinments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvAvailableAppoinments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvAvailableAppoinments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAvailableAppoinments.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAvailableAppoinments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAvailableAppoinments.Location = new System.Drawing.Point(3, 22);
            this.DgvAvailableAppoinments.Name = "DgvAvailableAppoinments";
            this.DgvAvailableAppoinments.Size = new System.Drawing.Size(721, 257);
            this.DgvAvailableAppoinments.TabIndex = 0;
            this.DgvAvailableAppoinments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAvailableAppoinments_CellClick);
            // 
            // BntLogOut
            // 
            this.BntLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntLogOut.Location = new System.Drawing.Point(377, 275);
            this.BntLogOut.Name = "BntLogOut";
            this.BntLogOut.Size = new System.Drawing.Size(359, 43);
            this.BntLogOut.TabIndex = 10;
            this.BntLogOut.Text = "Logout";
            this.BntLogOut.UseVisualStyleBackColor = true;
            this.BntLogOut.Click += new System.EventHandler(this.BntLogOut_Click);
            // 
            // BtnList
            // 
            this.BtnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnList.Location = new System.Drawing.Point(377, 128);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(359, 43);
            this.BtnList.TabIndex = 7;
            this.BtnList.Text = "List Appointments";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(377, 226);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(359, 43);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete Appointments";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Location = new System.Drawing.Point(377, 177);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(359, 43);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Update Appointments";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(751, 845);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.BntLogOut);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMyAppointments)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAvailableAppoinments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblUserSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblUserIdNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAppointment;
        private System.Windows.Forms.RichTextBox RchPatientComp;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DgvMyAppointments;
        private System.Windows.Forms.DataGridView DgvAvailableAppoinments;
        private System.Windows.Forms.Button BntLogOut;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.LinkLabel LnkUpdateInfo;
        private System.Windows.Forms.Label LblAPPId;
        private System.Windows.Forms.Label LblMayAppId;
    }
}