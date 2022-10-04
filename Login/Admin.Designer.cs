namespace Login
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.button1 = new System.Windows.Forms.Button();
            this.title_admin = new System.Windows.Forms.Label();
            this.createUser_button = new System.Windows.Forms.Button();
            this.createUser_email = new System.Windows.Forms.TextBox();
            this.createUser_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createUser_radioAdmin = new System.Windows.Forms.RadioButton();
            this.createUser_radioStudent = new System.Windows.Forms.RadioButton();
            this.createUser_radioProfessor = new System.Windows.Forms.RadioButton();
            this.students_names = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.student_subjects = new System.Windows.Forms.DataGridView();
            this.student_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.user_register_section = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.subject_status_section = new System.Windows.Forms.GroupBox();
            this.subject_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subjects_view = new System.Windows.Forms.DataGridView();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.create_subject_correlative = new System.Windows.Forms.ComboBox();
            this.create_subject_secondQuarter = new System.Windows.Forms.RadioButton();
            this.create_subject_button = new System.Windows.Forms.Button();
            this.create_subject_firstQuarter = new System.Windows.Forms.RadioButton();
            this.create_subject_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.create_subject_title = new System.Windows.Forms.Label();
            this.to_assign_section = new System.Windows.Forms.GroupBox();
            this.to_assign_assign = new System.Windows.Forms.Button();
            this.to_assign_subject = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.to_assign_professor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.students_names)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_subjects)).BeginInit();
            this.user_register_section.SuspendLayout();
            this.subject_status_section.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_view)).BeginInit();
            this.to_assign_section.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title_admin
            // 
            this.title_admin.AutoSize = true;
            this.title_admin.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_admin.Location = new System.Drawing.Point(327, 9);
            this.title_admin.Name = "title_admin";
            this.title_admin.Size = new System.Drawing.Size(82, 42);
            this.title_admin.TabIndex = 2;
            this.title_admin.Text = "Hola";
            // 
            // createUser_button
            // 
            this.createUser_button.Location = new System.Drawing.Point(192, 195);
            this.createUser_button.Name = "createUser_button";
            this.createUser_button.Size = new System.Drawing.Size(75, 23);
            this.createUser_button.TabIndex = 3;
            this.createUser_button.Text = "Crear";
            this.createUser_button.UseVisualStyleBackColor = true;
            this.createUser_button.Click += new System.EventHandler(this.createUser_button_Click);
            // 
            // createUser_email
            // 
            this.createUser_email.Location = new System.Drawing.Point(120, 77);
            this.createUser_email.Name = "createUser_email";
            this.createUser_email.Size = new System.Drawing.Size(222, 23);
            this.createUser_email.TabIndex = 4;
            // 
            // createUser_password
            // 
            this.createUser_password.Location = new System.Drawing.Point(120, 129);
            this.createUser_password.Name = "createUser_password";
            this.createUser_password.PasswordChar = '*';
            this.createUser_password.Size = new System.Drawing.Size(222, 23);
            this.createUser_password.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // createUser_radioAdmin
            // 
            this.createUser_radioAdmin.AutoSize = true;
            this.createUser_radioAdmin.Location = new System.Drawing.Point(120, 158);
            this.createUser_radioAdmin.Name = "createUser_radioAdmin";
            this.createUser_radioAdmin.Size = new System.Drawing.Size(61, 19);
            this.createUser_radioAdmin.TabIndex = 8;
            this.createUser_radioAdmin.TabStop = true;
            this.createUser_radioAdmin.Text = "Admin";
            this.createUser_radioAdmin.UseVisualStyleBackColor = true;
            // 
            // createUser_radioStudent
            // 
            this.createUser_radioStudent.AutoSize = true;
            this.createUser_radioStudent.Location = new System.Drawing.Point(187, 158);
            this.createUser_radioStudent.Name = "createUser_radioStudent";
            this.createUser_radioStudent.Size = new System.Drawing.Size(80, 19);
            this.createUser_radioStudent.TabIndex = 9;
            this.createUser_radioStudent.TabStop = true;
            this.createUser_radioStudent.Text = "Estudiante";
            this.createUser_radioStudent.UseVisualStyleBackColor = true;
            // 
            // createUser_radioProfessor
            // 
            this.createUser_radioProfessor.AutoSize = true;
            this.createUser_radioProfessor.Location = new System.Drawing.Point(273, 158);
            this.createUser_radioProfessor.Name = "createUser_radioProfessor";
            this.createUser_radioProfessor.Size = new System.Drawing.Size(69, 19);
            this.createUser_radioProfessor.TabIndex = 10;
            this.createUser_radioProfessor.TabStop = true;
            this.createUser_radioProfessor.Text = "Profesor";
            this.createUser_radioProfessor.UseVisualStyleBackColor = true;
            // 
            // students_names
            // 
            this.students_names.AllowUserToDeleteRows = false;
            this.students_names.AllowUserToOrderColumns = true;
            this.students_names.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students_names.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email});
            this.students_names.Location = new System.Drawing.Point(19, 75);
            this.students_names.Name = "students_names";
            this.students_names.ReadOnly = true;
            this.students_names.RowTemplate.Height = 25;
            this.students_names.RowTemplate.ReadOnly = true;
            this.students_names.Size = new System.Drawing.Size(359, 150);
            this.students_names.TabIndex = 11;
            this.students_names.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.students_names_CellContentClick);
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cambiar estado de materias";
            // 
            // student_subjects
            // 
            this.student_subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_subjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_email,
            this.subjects,
            this.subject_status});
            this.student_subjects.Location = new System.Drawing.Point(19, 75);
            this.student_subjects.Name = "student_subjects";
            this.student_subjects.RowTemplate.Height = 25;
            this.student_subjects.Size = new System.Drawing.Size(359, 150);
            this.student_subjects.TabIndex = 13;
            this.student_subjects.Visible = false;
            this.student_subjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_subjects_CellContentClick_1);
            // 
            // student_email
            // 
            this.student_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.student_email.HeaderText = "Email de estudiante";
            this.student_email.Name = "student_email";
            this.student_email.Width = 124;
            // 
            // subjects
            // 
            this.subjects.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.subjects.HeaderText = "Materias";
            this.subjects.Name = "subjects";
            this.subjects.Width = 77;
            // 
            // subject_status
            // 
            this.subject_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.subject_status.HeaderText = "Estado de materia";
            this.subject_status.Name = "subject_status";
            this.subject_status.Width = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "(Presiona la materia que desea modificar)";
            // 
            // user_register_section
            // 
            this.user_register_section.Controls.Add(this.label6);
            this.user_register_section.Controls.Add(this.createUser_button);
            this.user_register_section.Controls.Add(this.createUser_email);
            this.user_register_section.Controls.Add(this.createUser_password);
            this.user_register_section.Controls.Add(this.label1);
            this.user_register_section.Controls.Add(this.createUser_radioProfessor);
            this.user_register_section.Controls.Add(this.label2);
            this.user_register_section.Controls.Add(this.createUser_radioStudent);
            this.user_register_section.Controls.Add(this.createUser_radioAdmin);
            this.user_register_section.Location = new System.Drawing.Point(428, 64);
            this.user_register_section.Name = "user_register_section";
            this.user_register_section.Size = new System.Drawing.Size(425, 236);
            this.user_register_section.TabIndex = 15;
            this.user_register_section.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Crear usuario";
            // 
            // subject_status_section
            // 
            this.subject_status_section.Controls.Add(this.subject_back);
            this.subject_status_section.Controls.Add(this.students_names);
            this.subject_status_section.Controls.Add(this.student_subjects);
            this.subject_status_section.Controls.Add(this.label4);
            this.subject_status_section.Controls.Add(this.label3);
            this.subject_status_section.Location = new System.Drawing.Point(12, 64);
            this.subject_status_section.Name = "subject_status_section";
            this.subject_status_section.Size = new System.Drawing.Size(397, 236);
            this.subject_status_section.TabIndex = 16;
            this.subject_status_section.TabStop = false;
            // 
            // subject_back
            // 
            this.subject_back.Location = new System.Drawing.Point(19, 39);
            this.subject_back.Name = "subject_back";
            this.subject_back.Size = new System.Drawing.Size(75, 23);
            this.subject_back.TabIndex = 15;
            this.subject_back.Text = "Volver";
            this.subject_back.UseVisualStyleBackColor = true;
            this.subject_back.Visible = false;
            this.subject_back.Click += new System.EventHandler(this.subject_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subjects_view);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.create_subject_correlative);
            this.groupBox1.Controls.Add(this.create_subject_secondQuarter);
            this.groupBox1.Controls.Add(this.create_subject_button);
            this.groupBox1.Controls.Add(this.create_subject_firstQuarter);
            this.groupBox1.Controls.Add(this.create_subject_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.create_subject_title);
            this.groupBox1.Location = new System.Drawing.Point(12, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 242);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // subjects_view
            // 
            this.subjects_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjects_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_id,
            this.subject_name});
            this.subjects_view.Location = new System.Drawing.Point(170, 60);
            this.subjects_view.Name = "subjects_view";
            this.subjects_view.RowTemplate.Height = 25;
            this.subjects_view.Size = new System.Drawing.Size(294, 165);
            this.subjects_view.TabIndex = 24;
            // 
            // subject_id
            // 
            this.subject_id.HeaderText = "ID";
            this.subject_id.Name = "subject_id";
            // 
            // subject_name
            // 
            this.subject_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject_name.HeaderText = "Nombre";
            this.subject_name.Name = "subject_name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cuatrimestre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID Materia correlativa";
            // 
            // create_subject_correlative
            // 
            this.create_subject_correlative.FormattingEnabled = true;
            this.create_subject_correlative.Location = new System.Drawing.Point(6, 125);
            this.create_subject_correlative.Name = "create_subject_correlative";
            this.create_subject_correlative.Size = new System.Drawing.Size(145, 23);
            this.create_subject_correlative.TabIndex = 19;
            // 
            // create_subject_secondQuarter
            // 
            this.create_subject_secondQuarter.AutoSize = true;
            this.create_subject_secondQuarter.Location = new System.Drawing.Point(80, 177);
            this.create_subject_secondQuarter.Name = "create_subject_secondQuarter";
            this.create_subject_secondQuarter.Size = new System.Drawing.Size(31, 19);
            this.create_subject_secondQuarter.TabIndex = 22;
            this.create_subject_secondQuarter.TabStop = true;
            this.create_subject_secondQuarter.Text = "2";
            this.create_subject_secondQuarter.UseVisualStyleBackColor = true;
            // 
            // create_subject_button
            // 
            this.create_subject_button.Location = new System.Drawing.Point(36, 202);
            this.create_subject_button.Name = "create_subject_button";
            this.create_subject_button.Size = new System.Drawing.Size(75, 23);
            this.create_subject_button.TabIndex = 11;
            this.create_subject_button.Text = "Crear";
            this.create_subject_button.UseVisualStyleBackColor = true;
            this.create_subject_button.Click += new System.EventHandler(this.create_subject_button_Click);
            // 
            // create_subject_firstQuarter
            // 
            this.create_subject_firstQuarter.AutoSize = true;
            this.create_subject_firstQuarter.Location = new System.Drawing.Point(40, 177);
            this.create_subject_firstQuarter.Name = "create_subject_firstQuarter";
            this.create_subject_firstQuarter.Size = new System.Drawing.Size(31, 19);
            this.create_subject_firstQuarter.TabIndex = 21;
            this.create_subject_firstQuarter.TabStop = true;
            this.create_subject_firstQuarter.Text = "1";
            this.create_subject_firstQuarter.UseVisualStyleBackColor = true;
            // 
            // create_subject_name
            // 
            this.create_subject_name.Location = new System.Drawing.Point(6, 78);
            this.create_subject_name.Name = "create_subject_name";
            this.create_subject_name.Size = new System.Drawing.Size(145, 23);
            this.create_subject_name.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre";
            // 
            // create_subject_title
            // 
            this.create_subject_title.AutoSize = true;
            this.create_subject_title.Location = new System.Drawing.Point(157, 28);
            this.create_subject_title.Name = "create_subject_title";
            this.create_subject_title.Size = new System.Drawing.Size(78, 15);
            this.create_subject_title.TabIndex = 0;
            this.create_subject_title.Text = "Crear materia";
            // 
            // to_assign_section
            // 
            this.to_assign_section.Controls.Add(this.to_assign_assign);
            this.to_assign_section.Controls.Add(this.to_assign_subject);
            this.to_assign_section.Controls.Add(this.label11);
            this.to_assign_section.Controls.Add(this.label10);
            this.to_assign_section.Controls.Add(this.to_assign_professor);
            this.to_assign_section.Controls.Add(this.label5);
            this.to_assign_section.Location = new System.Drawing.Point(511, 316);
            this.to_assign_section.Name = "to_assign_section";
            this.to_assign_section.Size = new System.Drawing.Size(342, 232);
            this.to_assign_section.TabIndex = 18;
            this.to_assign_section.TabStop = false;
            // 
            // to_assign_assign
            // 
            this.to_assign_assign.Location = new System.Drawing.Point(109, 192);
            this.to_assign_assign.Name = "to_assign_assign";
            this.to_assign_assign.Size = new System.Drawing.Size(121, 23);
            this.to_assign_assign.TabIndex = 5;
            this.to_assign_assign.Text = "Asignar";
            this.to_assign_assign.UseVisualStyleBackColor = true;
            this.to_assign_assign.Click += new System.EventHandler(this.to_assign_assign_Click);
            // 
            // to_assign_subject
            // 
            this.to_assign_subject.FormattingEnabled = true;
            this.to_assign_subject.Location = new System.Drawing.Point(109, 149);
            this.to_assign_subject.Name = "to_assign_subject";
            this.to_assign_subject.Size = new System.Drawing.Size(121, 23);
            this.to_assign_subject.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Materia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Profesor";
            // 
            // to_assign_professor
            // 
            this.to_assign_professor.FormattingEnabled = true;
            this.to_assign_professor.Location = new System.Drawing.Point(109, 79);
            this.to_assign_professor.Name = "to_assign_professor";
            this.to_assign_professor.Size = new System.Drawing.Size(121, 23);
            this.to_assign_professor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Asignar profesor a materia";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 560);
            this.Controls.Add(this.to_assign_section);
            this.Controls.Add(this.title_admin);
            this.Controls.Add(this.user_register_section);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.subject_status_section);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.students_names)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_subjects)).EndInit();
            this.user_register_section.ResumeLayout(false);
            this.user_register_section.PerformLayout();
            this.subject_status_section.ResumeLayout(false);
            this.subject_status_section.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_view)).EndInit();
            this.to_assign_section.ResumeLayout(false);
            this.to_assign_section.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title_admin;
        private System.Windows.Forms.Button createUser_button;
        private System.Windows.Forms.TextBox createUser_email;
        private System.Windows.Forms.TextBox createUser_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton createUser_radioAdmin;
        private System.Windows.Forms.RadioButton createUser_radioStudent;
        private System.Windows.Forms.RadioButton createUser_radioProfessor;
        private System.Windows.Forms.DataGridView students_names;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView student_subjects;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox user_register_section;
        private System.Windows.Forms.GroupBox subject_status_section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_status;
        private System.Windows.Forms.Button subject_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label create_subject_title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton create_subject_secondQuarter;
        private System.Windows.Forms.RadioButton create_subject_firstQuarter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox create_subject_correlative;
        private System.Windows.Forms.Button create_subject_button;
        private System.Windows.Forms.TextBox create_subject_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView subjects_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
        private System.Windows.Forms.GroupBox to_assign_section;
        private System.Windows.Forms.Button to_assign_assign;
        private System.Windows.Forms.ComboBox to_assign_subject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox to_assign_professor;
        private System.Windows.Forms.Label label5;
    }
}