namespace HospitalManagement
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblId = new System.Windows.Forms.Label();
            this.LblDoctorSurname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblDoctorName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDoctorIdNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RchPatientComp = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvAppointments = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnSetInfor = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAnouncement = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointments)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Controls.Add(this.LblDoctorSurname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LblDoctorName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblDoctorIdNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(377, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(329, 23);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(27, 20);
            this.LblId.TabIndex = 6;
            this.LblId.Text = "00";
            this.LblId.Visible = false;
            // 
            // LblDoctorSurname
            // 
            this.LblDoctorSurname.AutoSize = true;
            this.LblDoctorSurname.Location = new System.Drawing.Point(175, 62);
            this.LblDoctorSurname.Name = "LblDoctorSurname";
            this.LblDoctorSurname.Size = new System.Drawing.Size(27, 20);
            this.LblDoctorSurname.TabIndex = 5;
            this.LblDoctorSurname.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doctor Surname";
            // 
            // LblDoctorName
            // 
            this.LblDoctorName.AutoSize = true;
            this.LblDoctorName.Location = new System.Drawing.Point(175, 42);
            this.LblDoctorName.Name = "LblDoctorName";
            this.LblDoctorName.Size = new System.Drawing.Size(27, 20);
            this.LblDoctorName.TabIndex = 3;
            this.LblDoctorName.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor Name";
            // 
            // LblDoctorIdNo
            // 
            this.LblDoctorIdNo.AutoSize = true;
            this.LblDoctorIdNo.Location = new System.Drawing.Point(175, 22);
            this.LblDoctorIdNo.Name = "LblDoctorIdNo";
            this.LblDoctorIdNo.Size = new System.Drawing.Size(27, 20);
            this.LblDoctorIdNo.TabIndex = 1;
            this.LblDoctorIdNo.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Identity Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RchPatientComp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 255);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Details";
            // 
            // RchPatientComp
            // 
            this.RchPatientComp.Location = new System.Drawing.Point(10, 45);
            this.RchPatientComp.Name = "RchPatientComp";
            this.RchPatientComp.Size = new System.Drawing.Size(331, 194);
            this.RchPatientComp.TabIndex = 1;
            this.RchPatientComp.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Patient\'s Complaint";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvAppointments);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(13, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 562);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointments List";
            // 
            // DgvAppointments
            // 
            this.DgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAppointments.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAppointments.Location = new System.Drawing.Point(3, 22);
            this.DgvAppointments.Name = "DgvAppointments";
            this.DgvAppointments.Size = new System.Drawing.Size(720, 537);
            this.DgvAppointments.TabIndex = 0;
            this.DgvAppointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAppointments_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnList);
            this.groupBox4.Controls.Add(this.BtnSetInfor);
            this.groupBox4.Controls.Add(this.BtnExit);
            this.groupBox4.Controls.Add(this.BtnAnouncement);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(377, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 153);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doctor Information";
            // 
            // BtnList
            // 
            this.BtnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnList.Location = new System.Drawing.Point(10, 81);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(158, 49);
            this.BtnList.TabIndex = 4;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnSetInfor
            // 
            this.BtnSetInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetInfor.Location = new System.Drawing.Point(198, 25);
            this.BtnSetInfor.Name = "BtnSetInfor";
            this.BtnSetInfor.Size = new System.Drawing.Size(158, 50);
            this.BtnSetInfor.TabIndex = 3;
            this.BtnSetInfor.Text = "Set Informations";
            this.BtnSetInfor.UseVisualStyleBackColor = true;
            this.BtnSetInfor.Click += new System.EventHandler(this.BtnSetInfor_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(198, 81);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(158, 49);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAnouncement
            // 
            this.BtnAnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnouncement.Location = new System.Drawing.Point(10, 26);
            this.BtnAnouncement.Name = "BtnAnouncement";
            this.BtnAnouncement.Size = new System.Drawing.Size(158, 49);
            this.BtnAnouncement.TabIndex = 2;
            this.BtnAnouncement.Text = "Anouncements";
            this.BtnAnouncement.UseVisualStyleBackColor = true;
            this.BtnAnouncement.Click += new System.EventHandler(this.BtnAnouncement_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(751, 848);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointments)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblDoctorSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblDoctorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDoctorIdNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox RchPatientComp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAnouncement;
        private System.Windows.Forms.Button BtnSetInfor;
        private System.Windows.Forms.DataGridView DgvAppointments;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Label LblId;
    }
}