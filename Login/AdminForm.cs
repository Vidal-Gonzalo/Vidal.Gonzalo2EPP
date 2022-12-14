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
        string[] formats = { "JSON", "CSV" };

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
            for (int i = 0; i < Data.SubjectsInCourses.Count; i++)
            {
                export_students_subjects_cb.Items.Add(Data.SubjectsInCourses[i].Name);
            }
            for (int i = 0; i < formats.Length; i++)
            {
                export_students_format_cb.Items.Add(formats[i]);
            }

        }

        private delegate bool RegisterCallback(string name, short period, short correlativeId);

        private delegate bool AssignCallback(int userId, string subjectName, int status);

        private delegate bool AddStudent(string email, string password);
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

            Student? student = loggedAdmin.FindStudentByEmail(Data.Students, email);
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
                            student_subjects.Rows[i].Cells[0].Value = student.Email;
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
            bool r;

            Student? student = loggedAdmin.FindStudentByEmail(Data.Students, email);
            if (student is not null)
            {
                SubjectInCourse? subjectInCourse = loggedAdmin.FindSubjectByName(Data.SubjectsInCourses, subject, student);
                if (subjectInCourse is not null)
                {
                    if (MessageBox.Show("Desea cambiar el estado de la materia?", "Estado de materias", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (subjectInCourse.Status == 1)
                        {
                            student_subjects.Rows[index].Cells[2].Value = "Libre";
                            subjectInCourse.Status = 0;
                            r = Data.ChangeSubjectStatus(student.Id, subjectInCourse.Name, 0);
                        }
                        else
                        {
                            student_subjects.Rows[index].Cells[2].Value = "Regular";
                            subjectInCourse.Status = 1;
                            r = Data.ChangeSubjectStatus(student.Id, subjectInCourse.Name, 1);
                        }
                        if (r)
                        {
                            MessageBox.Show("El estado ha sido cambiado");
                            RefreshForm();
                        }
                        else
                        {
                            MessageBox.Show("Ha habido un error.");
                        }
                    }
                }
            }

        }

        private void subject_back_Click(object sender, EventArgs e)
        {
            student_subjects.Rows.Clear();
            student_subjects.Hide();
            students_names.Show();
            subject_back.Hide();
        }

        private void create_subject_button_Click(object sender, EventArgs e)
        {
            #region Create Subject Form Data
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
                RegisterCallback registerFunction = new RegisterCallback(Data.RegisterSubject);
                bool registered = loggedAdmin.RegisterSubject(registerFunction, Data.Subjects, name, subjectQuarter, newCorrelativeSubject);
                if (registered)
                {
                    MessageBox.Show("Materia registrada con exito");
                    Data.GetSubjects();
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
                Professor? professor = loggedAdmin.FindProfessorByEmail(email, Data.Professors);
                if (professor is not null)
                {
                    AssignCallback assignFunction = new AssignCallback(Data.AssignProfessorToSubject);
                    Subject? subject = loggedAdmin.FindSubjectById(subjectId,Data.Subjects);
                    if(subject is not null)
                    {
                        bool r = loggedAdmin.AssignProfessorToSubject(assignFunction, Data.SubjectsInCourses, professor.Id, subject.Name, 1);
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
                    Student? studentAux = loggedAdmin.FindStudentByEmail(Data.Students, email);
                    if (studentAux is not null)
                    {
                        Student student = studentAux;
                        bool areLessThanTwoSubjects = Data.CorrectNumberOfSubjects(3,Data.SubjectsInCourses, student.Email);
                        if (areLessThanTwoSubjects)
                        {
                            Data.EnrollSubjectToUser(student.Id, subject);
                            MessageBox.Show("Inscripción realizada con exito!");
                            Data.AssignUsersToSubjects();
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

        private void export_students_btn_Click(object sender, EventArgs e)
        {
            bool r = false;
            string? subjectAux = export_students_subjects_cb.SelectedItem.ToString();
            string? format = export_students_format_cb.SelectedItem.ToString();

            if(subjectAux is not null && format is not null)
            {
                SubjectInCourse? subjectInCourse = Data.FindSubjectInCourseByName(subjectAux);
                if(subjectInCourse is not null)
                {
                    List<Student> students = Data.GetStudentsFromSubject(subjectInCourse);
                    if(students.Count > 0)
                    {
                        if(format == "JSON")
                        {
                            r = loggedAdmin.SerializeToJson(students);
                        } else if(format == "CSV")
                        {
                            r = loggedAdmin.SerializeToCsv(students);
                        }
                    }
                }
            }
            if(r)
            {
                MessageBox.Show("Alumnos exportados correctamente");
            } else
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void import_students_btn_Click(object sender, EventArgs e)
        {
            AddStudent assignFunction = new AddStudent(Data.AddStudent);
            bool r = loggedAdmin.DeserializeFromJson(assignFunction, "students.json", Data.Students);

            if (r)
            {
                MessageBox.Show("Alumnos importados");
                Data.GetUsers();
                RefreshForm();
            }
            else
            {
                MessageBox.Show("Hubo un error en la importación de alumnos.");
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
