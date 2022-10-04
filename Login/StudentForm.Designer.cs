namespace Login
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.student_form_exit = new System.Windows.Forms.Button();
            this.student_greeting = new System.Windows.Forms.Label();
            this.register_in_subject_title = new System.Windows.Forms.Label();
            this.register_subject_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register_subject_button = new System.Windows.Forms.Button();
            this.subjects_list = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.student_subjects_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_subject_calification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_list)).BeginInit();
            this.SuspendLayout();
            // 
            // student_form_exit
            // 
            this.student_form_exit.Location = new System.Drawing.Point(660, 12);
            this.student_form_exit.Name = "student_form_exit";
            this.student_form_exit.Size = new System.Drawing.Size(75, 23);
            this.student_form_exit.TabIndex = 0;
            this.student_form_exit.Text = "Salir";
            this.student_form_exit.UseVisualStyleBackColor = true;
            this.student_form_exit.Click += new System.EventHandler(this.student_form_exit_Click);
            // 
            // student_greeting
            // 
            this.student_greeting.AutoSize = true;
            this.student_greeting.Location = new System.Drawing.Point(358, 41);
            this.student_greeting.Name = "student_greeting";
            this.student_greeting.Size = new System.Drawing.Size(32, 15);
            this.student_greeting.TabIndex = 1;
            this.student_greeting.Text = "Hola";
            // 
            // register_in_subject_title
            // 
            this.register_in_subject_title.AutoSize = true;
            this.register_in_subject_title.Location = new System.Drawing.Point(57, 94);
            this.register_in_subject_title.Name = "register_in_subject_title";
            this.register_in_subject_title.Size = new System.Drawing.Size(135, 15);
            this.register_in_subject_title.TabIndex = 2;
            this.register_in_subject_title.Text = "Inscribirse a una materia";
            // 
            // register_subject_cb
            // 
            this.register_subject_cb.FormattingEnabled = true;
            this.register_subject_cb.Location = new System.Drawing.Point(57, 156);
            this.register_subject_cb.Name = "register_subject_cb";
            this.register_subject_cb.Size = new System.Drawing.Size(135, 23);
            this.register_subject_cb.TabIndex = 3;
            this.register_subject_cb.SelectedIndexChanged += new System.EventHandler(this.register_subject_cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Materia";
            // 
            // register_subject_button
            // 
            this.register_subject_button.Location = new System.Drawing.Point(57, 200);
            this.register_subject_button.Name = "register_subject_button";
            this.register_subject_button.Size = new System.Drawing.Size(75, 23);
            this.register_subject_button.TabIndex = 5;
            this.register_subject_button.Text = "Inscribirse";
            this.register_subject_button.UseVisualStyleBackColor = true;
            this.register_subject_button.Click += new System.EventHandler(this.register_subject_button_Click);
            // 
            // subjects_list
            // 
            this.subjects_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjects_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_subjects_name,
            this.student_subject_calification});
            this.subjects_list.Location = new System.Drawing.Point(326, 127);
            this.subjects_list.Name = "subjects_list";
            this.subjects_list.RowTemplate.Height = 25;
            this.subjects_list.Size = new System.Drawing.Size(344, 150);
            this.subjects_list.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tus materias";
            // 
            // student_subjects_name
            // 
            this.student_subjects_name.HeaderText = "Nombre";
            this.student_subjects_name.Name = "student_subjects_name";
            // 
            // student_subject_calification
            // 
            this.student_subject_calification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_subject_calification.HeaderText = "Calificaciones";
            this.student_subject_calification.Name = "student_subject_calification";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjects_list);
            this.Controls.Add(this.register_subject_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_subject_cb);
            this.Controls.Add(this.register_in_subject_title);
            this.Controls.Add(this.student_greeting);
            this.Controls.Add(this.student_form_exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentForm";
            this.Text = "Formulario de estudiante";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjects_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button student_form_exit;
        private System.Windows.Forms.Label student_greeting;
        private System.Windows.Forms.Label register_in_subject_title;
        private System.Windows.Forms.ComboBox register_subject_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register_subject_button;
        private System.Windows.Forms.DataGridView subjects_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_subjects_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_subject_calification;
    }
}