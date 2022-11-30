namespace Login
{
    partial class ProfessorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.assigned_subjects_grid = new System.Windows.Forms.DataGridView();
            this.assigned_subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor_form_greeting = new System.Windows.Forms.Label();
            this.create_exam_datePicker = new System.Windows.Forms.DateTimePicker();
            this.create_exam_grid = new System.Windows.Forms.GroupBox();
            this.create_exam_cancel = new System.Windows.Forms.Button();
            this.create_exam_label = new System.Windows.Forms.Label();
            this.create_exam_button = new System.Windows.Forms.Button();
            this.create_exam_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.change_calification_grid = new System.Windows.Forms.DataGridView();
            this.califications_grid_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.califications_grid_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.change_calification_cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.change_calification_search = new System.Windows.Forms.Button();
            this.change_calification_gb = new System.Windows.Forms.GroupBox();
            this.change_calification_back = new System.Windows.Forms.Button();
            this.change_calification_subject = new System.Windows.Forms.Label();
            this.change_califications_exams_grid = new System.Windows.Forms.DataGridView();
            this.student_exams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_califications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change_calification_student = new System.Windows.Forms.Label();
            this.exam_changing_calification = new System.Windows.Forms.GroupBox();
            this.change_exam_cancel = new System.Windows.Forms.Button();
            this.exam_changing_califications_cb = new System.Windows.Forms.ComboBox();
            this.change_exam_button = new System.Windows.Forms.Button();
            this.exam_changing_calification_name = new System.Windows.Forms.Label();
            this.professor_form_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assigned_subjects_grid)).BeginInit();
            this.create_exam_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change_calification_grid)).BeginInit();
            this.change_calification_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change_califications_exams_grid)).BeginInit();
            this.exam_changing_calification.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear exámenes";
            // 
            // assigned_subjects_grid
            // 
            this.assigned_subjects_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assigned_subjects_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assigned_subject_name});
            this.assigned_subjects_grid.Location = new System.Drawing.Point(50, 151);
            this.assigned_subjects_grid.Name = "assigned_subjects_grid";
            this.assigned_subjects_grid.RowTemplate.Height = 25;
            this.assigned_subjects_grid.Size = new System.Drawing.Size(366, 186);
            this.assigned_subjects_grid.TabIndex = 1;
            this.assigned_subjects_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assigned_subjects_grid_CellContentClick);
            // 
            // assigned_subject_name
            // 
            this.assigned_subject_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assigned_subject_name.HeaderText = "Nombre";
            this.assigned_subject_name.Name = "assigned_subject_name";
            // 
            // professor_form_greeting
            // 
            this.professor_form_greeting.AutoSize = true;
            this.professor_form_greeting.Location = new System.Drawing.Point(356, 34);
            this.professor_form_greeting.Name = "professor_form_greeting";
            this.professor_form_greeting.Size = new System.Drawing.Size(35, 15);
            this.professor_form_greeting.TabIndex = 2;
            this.professor_form_greeting.Text = "Texto";
            // 
            // create_exam_datePicker
            // 
            this.create_exam_datePicker.Location = new System.Drawing.Point(48, 107);
            this.create_exam_datePicker.Name = "create_exam_datePicker";
            this.create_exam_datePicker.Size = new System.Drawing.Size(257, 23);
            this.create_exam_datePicker.TabIndex = 3;
            // 
            // create_exam_grid
            // 
            this.create_exam_grid.Controls.Add(this.create_exam_cancel);
            this.create_exam_grid.Controls.Add(this.create_exam_label);
            this.create_exam_grid.Controls.Add(this.create_exam_button);
            this.create_exam_grid.Controls.Add(this.create_exam_name);
            this.create_exam_grid.Controls.Add(this.label3);
            this.create_exam_grid.Controls.Add(this.label2);
            this.create_exam_grid.Controls.Add(this.create_exam_datePicker);
            this.create_exam_grid.Location = new System.Drawing.Point(50, 151);
            this.create_exam_grid.Name = "create_exam_grid";
            this.create_exam_grid.Size = new System.Drawing.Size(366, 192);
            this.create_exam_grid.TabIndex = 4;
            this.create_exam_grid.TabStop = false;
            this.create_exam_grid.Visible = false;
            // 
            // create_exam_cancel
            // 
            this.create_exam_cancel.Location = new System.Drawing.Point(202, 145);
            this.create_exam_cancel.Name = "create_exam_cancel";
            this.create_exam_cancel.Size = new System.Drawing.Size(75, 23);
            this.create_exam_cancel.TabIndex = 9;
            this.create_exam_cancel.Text = "Cancelar";
            this.create_exam_cancel.UseVisualStyleBackColor = true;
            this.create_exam_cancel.Click += new System.EventHandler(this.create_exam_cancel_Click);
            // 
            // create_exam_label
            // 
            this.create_exam_label.AutoSize = true;
            this.create_exam_label.Location = new System.Drawing.Point(17, 17);
            this.create_exam_label.Name = "create_exam_label";
            this.create_exam_label.Size = new System.Drawing.Size(47, 15);
            this.create_exam_label.TabIndex = 8;
            this.create_exam_label.Text = "Materia";
            // 
            // create_exam_button
            // 
            this.create_exam_button.Location = new System.Drawing.Point(98, 145);
            this.create_exam_button.Name = "create_exam_button";
            this.create_exam_button.Size = new System.Drawing.Size(75, 23);
            this.create_exam_button.TabIndex = 7;
            this.create_exam_button.Text = "Crear";
            this.create_exam_button.UseVisualStyleBackColor = true;
            this.create_exam_button.Click += new System.EventHandler(this.create_exam_button_Click);
            // 
            // create_exam_name
            // 
            this.create_exam_name.Location = new System.Drawing.Point(48, 54);
            this.create_exam_name.Name = "create_exam_name";
            this.create_exam_name.Size = new System.Drawing.Size(257, 23);
            this.create_exam_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clickea para crear un examen para esa materia";
            // 
            // change_calification_grid
            // 
            this.change_calification_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.change_calification_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.califications_grid_email,
            this.califications_grid_subject});
            this.change_calification_grid.Location = new System.Drawing.Point(460, 256);
            this.change_calification_grid.Name = "change_calification_grid";
            this.change_calification_grid.ReadOnly = true;
            this.change_calification_grid.RowTemplate.Height = 25;
            this.change_calification_grid.Size = new System.Drawing.Size(355, 126);
            this.change_calification_grid.TabIndex = 6;
            this.change_calification_grid.Visible = false;
            this.change_calification_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.change_calification_grid_CellContentClick);
            // 
            // califications_grid_email
            // 
            this.califications_grid_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.califications_grid_email.HeaderText = "Email de alumno";
            this.califications_grid_email.Name = "califications_grid_email";
            this.califications_grid_email.ReadOnly = true;
            // 
            // califications_grid_subject
            // 
            this.califications_grid_subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.califications_grid_subject.HeaderText = "Materia";
            this.califications_grid_subject.Name = "califications_grid_subject";
            this.califications_grid_subject.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cambiar nota a alumnos";
            // 
            // change_calification_cb
            // 
            this.change_calification_cb.FormattingEnabled = true;
            this.change_calification_cb.Location = new System.Drawing.Point(476, 121);
            this.change_calification_cb.Name = "change_calification_cb";
            this.change_calification_cb.Size = new System.Drawing.Size(137, 23);
            this.change_calification_cb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Materia";
            // 
            // change_calification_search
            // 
            this.change_calification_search.Location = new System.Drawing.Point(640, 122);
            this.change_calification_search.Name = "change_calification_search";
            this.change_calification_search.Size = new System.Drawing.Size(138, 23);
            this.change_calification_search.TabIndex = 10;
            this.change_calification_search.Text = "Buscar alumnos";
            this.change_calification_search.UseVisualStyleBackColor = true;
            this.change_calification_search.Click += new System.EventHandler(this.change_calification_search_Click);
            // 
            // change_calification_gb
            // 
            this.change_calification_gb.Controls.Add(this.change_calification_back);
            this.change_calification_gb.Controls.Add(this.change_calification_subject);
            this.change_calification_gb.Controls.Add(this.change_califications_exams_grid);
            this.change_calification_gb.Controls.Add(this.change_calification_student);
            this.change_calification_gb.Location = new System.Drawing.Point(454, 150);
            this.change_calification_gb.Name = "change_calification_gb";
            this.change_calification_gb.Size = new System.Drawing.Size(324, 178);
            this.change_calification_gb.TabIndex = 11;
            this.change_calification_gb.TabStop = false;
            this.change_calification_gb.Visible = false;
            // 
            // change_calification_back
            // 
            this.change_calification_back.Location = new System.Drawing.Point(218, 145);
            this.change_calification_back.Name = "change_calification_back";
            this.change_calification_back.Size = new System.Drawing.Size(75, 23);
            this.change_calification_back.TabIndex = 13;
            this.change_calification_back.Text = "Volver";
            this.change_calification_back.UseVisualStyleBackColor = true;
            this.change_calification_back.Click += new System.EventHandler(this.change_calification_back_Click);
            // 
            // change_calification_subject
            // 
            this.change_calification_subject.AutoSize = true;
            this.change_calification_subject.Location = new System.Drawing.Point(143, 19);
            this.change_calification_subject.Name = "change_calification_subject";
            this.change_calification_subject.Size = new System.Drawing.Size(47, 15);
            this.change_calification_subject.TabIndex = 3;
            this.change_calification_subject.Text = "Materia";
            // 
            // change_califications_exams_grid
            // 
            this.change_califications_exams_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.change_califications_exams_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_exams,
            this.student_califications});
            this.change_califications_exams_grid.Location = new System.Drawing.Point(12, 46);
            this.change_califications_exams_grid.Name = "change_califications_exams_grid";
            this.change_califications_exams_grid.ReadOnly = true;
            this.change_califications_exams_grid.RowTemplate.Height = 25;
            this.change_califications_exams_grid.Size = new System.Drawing.Size(290, 93);
            this.change_califications_exams_grid.TabIndex = 2;
            this.change_califications_exams_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.change_califications_exams_grid_CellContentClick);
            // 
            // student_exams
            // 
            this.student_exams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_exams.HeaderText = "Nombre de examen";
            this.student_exams.Name = "student_exams";
            this.student_exams.ReadOnly = true;
            // 
            // student_califications
            // 
            this.student_califications.HeaderText = "Nota";
            this.student_califications.Name = "student_califications";
            this.student_califications.ReadOnly = true;
            // 
            // change_calification_student
            // 
            this.change_calification_student.AutoSize = true;
            this.change_calification_student.Location = new System.Drawing.Point(6, 19);
            this.change_calification_student.Name = "change_calification_student";
            this.change_calification_student.Size = new System.Drawing.Size(62, 15);
            this.change_calification_student.TabIndex = 0;
            this.change_calification_student.Text = "Estudiante";
            // 
            // exam_changing_calification
            // 
            this.exam_changing_calification.Controls.Add(this.change_exam_cancel);
            this.exam_changing_calification.Controls.Add(this.exam_changing_califications_cb);
            this.exam_changing_calification.Controls.Add(this.change_exam_button);
            this.exam_changing_calification.Controls.Add(this.exam_changing_calification_name);
            this.exam_changing_calification.Location = new System.Drawing.Point(460, 334);
            this.exam_changing_calification.Name = "exam_changing_calification";
            this.exam_changing_calification.Size = new System.Drawing.Size(376, 100);
            this.exam_changing_calification.TabIndex = 12;
            this.exam_changing_calification.TabStop = false;
            this.exam_changing_calification.Visible = false;
            // 
            // change_exam_cancel
            // 
            this.change_exam_cancel.Location = new System.Drawing.Point(205, 66);
            this.change_exam_cancel.Name = "change_exam_cancel";
            this.change_exam_cancel.Size = new System.Drawing.Size(93, 23);
            this.change_exam_cancel.TabIndex = 4;
            this.change_exam_cancel.Text = "Cancelar";
            this.change_exam_cancel.UseVisualStyleBackColor = true;
            this.change_exam_cancel.Click += new System.EventHandler(this.change_exam_cancel_Click);
            // 
            // exam_changing_califications_cb
            // 
            this.exam_changing_califications_cb.FormattingEnabled = true;
            this.exam_changing_califications_cb.Location = new System.Drawing.Point(123, 37);
            this.exam_changing_califications_cb.Name = "exam_changing_califications_cb";
            this.exam_changing_califications_cb.Size = new System.Drawing.Size(121, 23);
            this.exam_changing_califications_cb.TabIndex = 3;
            // 
            // change_exam_button
            // 
            this.change_exam_button.Location = new System.Drawing.Point(70, 66);
            this.change_exam_button.Name = "change_exam_button";
            this.change_exam_button.Size = new System.Drawing.Size(118, 23);
            this.change_exam_button.TabIndex = 2;
            this.change_exam_button.Text = "Cambiar la nota";
            this.change_exam_button.UseVisualStyleBackColor = true;
            this.change_exam_button.Click += new System.EventHandler(this.change_exam_button_Click);
            // 
            // exam_changing_calification_name
            // 
            this.exam_changing_calification_name.AutoSize = true;
            this.exam_changing_calification_name.Location = new System.Drawing.Point(123, 19);
            this.exam_changing_calification_name.Name = "exam_changing_calification_name";
            this.exam_changing_calification_name.Size = new System.Drawing.Size(36, 15);
            this.exam_changing_calification_name.TabIndex = 0;
            this.exam_changing_calification_name.Text = "Exam";
            // 
            // professor_form_exit
            // 
            this.professor_form_exit.Location = new System.Drawing.Point(761, 12);
            this.professor_form_exit.Name = "professor_form_exit";
            this.professor_form_exit.Size = new System.Drawing.Size(75, 23);
            this.professor_form_exit.TabIndex = 13;
            this.professor_form_exit.Text = "Salir";
            this.professor_form_exit.UseVisualStyleBackColor = true;
            this.professor_form_exit.Click += new System.EventHandler(this.professor_form_exit_Click);
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 480);
            this.Controls.Add(this.professor_form_exit);
            this.Controls.Add(this.exam_changing_calification);
            this.Controls.Add(this.change_calification_gb);
            this.Controls.Add(this.change_calification_grid);
            this.Controls.Add(this.change_calification_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.change_calification_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.professor_form_greeting);
            this.Controls.Add(this.create_exam_grid);
            this.Controls.Add(this.assigned_subjects_grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfessorForm";
            this.Text = "Formulario de profesor";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assigned_subjects_grid)).EndInit();
            this.create_exam_grid.ResumeLayout(false);
            this.create_exam_grid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change_calification_grid)).EndInit();
            this.change_calification_gb.ResumeLayout(false);
            this.change_calification_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change_califications_exams_grid)).EndInit();
            this.exam_changing_calification.ResumeLayout(false);
            this.exam_changing_calification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label professor_form_greeting;
        private System.Windows.Forms.DataGridView assigned_subjects_grid;
        private System.Windows.Forms.DateTimePicker create_exam_datePicker;
        private System.Windows.Forms.GroupBox create_exam_grid;
        private System.Windows.Forms.Button create_exam_button;
        private System.Windows.Forms.TextBox create_exam_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label create_exam_label;
        private System.Windows.Forms.DataGridView change_calification_grid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox change_calification_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button change_calification_search;
        private System.Windows.Forms.Button create_exam_cancel;
        private System.Windows.Forms.GroupBox change_calification_gb;
        private System.Windows.Forms.Label change_calification_student;
        private System.Windows.Forms.DataGridView change_califications_exams_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn califications_grid_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn califications_grid_subject;
        private System.Windows.Forms.Label change_calification_subject;
        private System.Windows.Forms.GroupBox exam_changing_calification;
        private System.Windows.Forms.ComboBox exam_changing_califications_cb;
        private System.Windows.Forms.Button change_exam_button;
        private System.Windows.Forms.Label exam_changing_calification_name;
        private System.Windows.Forms.Button change_exam_cancel;
        private System.Windows.Forms.Button change_calification_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_exams;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_califications;
        private System.Windows.Forms.Button professor_form_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn assigned_subject_name;
    }
}