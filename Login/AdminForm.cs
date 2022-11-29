using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AdminForm : Form
    {
        Admin loggedAdmin = new();

        public AdminForm(Admin admin)
        {
            InitializeComponent();
            loggedAdmin = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login fa = new Login();
            this.Hide();
            fa.Show();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.title_admin.Text = $"Hola {loggedAdmin.Email}!";

            for (int i = 0; i < Data.Students.Count; i++)
            {
                register_subject_cb_student.Items.Add(Data.Students[i].Email);
                students_names.Rows.Add();
                students_names.Rows[i].Cells[0].Value = Data.Students[i].Email;
            }
            for (int i = 0; i < Data.Subjects.Count; i++)
            {
                register_subject_cb_subject.Items.Add(Data.Subjects[i].Name);
                create_subject_correlative.Items.Add(Data.Subjects[i].Id);
                to_assign_subject.Items.Add(Data.Subjects[i].Id);
                subjects_view.Rows.Add();
                subjects_view.Rows[i].Cells[0].Value = Data.Subjects[i].Id;
                subjects_view.Rows[i].Cells[1].Value = Data.Subjects[i].Name;
            }
            for (int i = 0; i < Data.Professors.Count; i++)
            {
                to_assign_professor.Items.Add(Data.Professors[i].Email);
            }


        }

        private void createUser_button_Click(object sender, EventArgs e)
        {
            //Refactorizar
            int type = 0;

            if (createUser_radioAdmin.Checked)
            {
                type = 1;
            }
            else if (createUser_radioStudent.Checked)
            {
                type = 3;
            }
            else if (createUser_radioProfessor.Checked)
            {
                type = 2;
            }

            bool registered = Data.RegisterUser(createUser_email.Text, createUser_password.Text, type);
            if (registered)
            {
                MessageBox.Show("Usuario registrado");
                Data.GetUsers();
                RefreshForm();
            }
            else
            {
                MessageBox.Show("Hubo un error, vuelva a intentar.");
            }

        }

        private void students_names_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            students_names.Hide();
            int index = int.Parse(e.RowIndex.ToString());
            string? email = students_names.Rows[index].Cells[0].Value.ToString();

            Student? student = Data.FindStudentByEmail(email);
            if (student is not null)
            {
                List<SubjectInCourse>? subjectsFromStudent = Data.GetSubjectsFromStudent(student);
                if (subjectsFromStudent is not null)
                {
                    for (int i = 0; i < subjectsFromStudent.Count; i++)
                    {
                        if (student_subjects.Rows.Count <= Data.SubjectsInCourses.Count)
                        {
                            student_subjects.Rows.Add();
                            student_subjects.Rows[i].Cells[0].Value = subjectsFromStudent[i].Student.Email;
                            student_subjects.Rows[i].Cells[1].Value = subjectsFromStudent[i].Name;
                            if (subjectsFromStudent[i].Status == 1)
                            {
                                student_subjects.Rows[i].Cells[2].Value = "Regular";
                            }
                            else
                            {
                                student_subjects.Rows[i].Cells[2].Value = "Libre";
                            }
                        }

                    }
                }

                student_subjects.Show();
                subject_back.Visible = true;
            }
        }

        private void student_subjects_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = int.Parse(e.RowIndex.ToString());
            string? email = student_subjects.Rows[index].Cells[0].Value.ToString();
            string? subject = student_subjects.Rows[index].Cells[1].Value.ToString();

            //Faltaría hacer la consulta SQL para editar el estado de la materia

            Student? student = Data.FindStudentByEmail(email);
            if (student is not null)
            {
                SubjectInCourse? subjectInCourse = Data.FindSubjectByName(student, subject);
                if (subjectInCourse is not null)
                {
                    if (MessageBox.Show("Desea cambiar el estado de la materia?", "Estado de materias", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        MessageBox.Show(subjectInCourse.Status.ToString());
                        if (subjectInCourse.Status == 1)
                        {
                            student_subjects.Rows[index].Cells[2].Value = "Libre";
                            subjectInCourse.Status = 0;
                        }
                        else
                        {
                            student_subjects.Rows[index].Cells[2].Value = "Regular";
                            subjectInCourse.Status = 1;
                        }
                        MessageBox.Show("El estado ha sido cambiado");
                    }
                }
            }

        }

        private void subject_back_Click(object sender, EventArgs e)
        {
            student_subjects.Hide();
            students_names.Show();
            subject_back.Hide();
        }

        private void create_subject_button_Click(object sender, EventArgs e)
        {
            #region Create Subject Form Data
            short newId = loggedAdmin.GetNewSubjectId(Data.Subjects);
            string name = create_subject_name.Text;
            short subjectQuarter;
            if (create_subject_firstQuarter.Checked)
                subjectQuarter = 1;
            else
                subjectQuarter = 2;
            string? subjectAux = create_subject_correlative.SelectedItem.ToString();
            #endregion

            if (subjectAux is not null)
            {
                short newCorrelativeSubject = short.Parse(subjectAux);
                bool registered = loggedAdmin.RegisterSubject(Data.Subjects, newId, name, subjectQuarter, newCorrelativeSubject);
                if (registered)
                {
                    MessageBox.Show("Materia registrada con exito");
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("Ha habido un error.");
            }
        }

        private void to_assign_assign_Click(object sender, EventArgs e)
        {
            string? emailAux = to_assign_professor.SelectedItem.ToString();
            string? subjectIdAux = to_assign_subject.SelectedItem.ToString();
            if (emailAux is not null && subjectIdAux is not null)
            {
                string email = emailAux;
                short subjectId = short.Parse(subjectIdAux);
                Professor? professor = Data.FindProfessorByEmail(email);
                if (professor is not null)
                {
                    bool r = Data.AssignProfessorToSubject(subjectId, professor);
                    if (r)
                    {
                        MessageBox.Show("Profesor asignado a materia con exito");
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un error");
                    }
                }

            }
        }

        private void register_subject_button_Click(object sender, EventArgs e)
        {
            string? emailAux = register_subject_cb_student.SelectedItem.ToString();
            string? subjectAux = register_subject_cb_subject.SelectedItem.ToString();
            if (emailAux is not null && subjectAux is not null)
            {
                string email = emailAux;
                string subject = subjectAux;
                bool isRegistered = Data.CheckIfSubjectContainsStudent(subject, email);
                if (!isRegistered)
                {
                    Student? studentAux = Data.FindStudentByEmail(email);
                    if (studentAux is not null)
                    {
                        Student student = studentAux;
                        bool areLessThanTwoSubjects = Data.CorrectNumberOfSubjects(2, student);
                        if (areLessThanTwoSubjects)
                        {
                            SubjectInCourse subjectInCourse = new(1, subject, student);
                            Data.SubjectsInCourses.Add(subjectInCourse);
                            MessageBox.Show("Inscripción realizada con exito!");
                            RefreshForm();
                        }
                        else
                        {
                            MessageBox.Show("El alumno alcanzó el tope de materias para inscribirse.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Ese usuario ya está inscripto en la materia!");
                }
            }
        }

        private void RefreshForm()
        {
            Hide();
            AdminForm newForm = new(loggedAdmin);
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }

    }
}
