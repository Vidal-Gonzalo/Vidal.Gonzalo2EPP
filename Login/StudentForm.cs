using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class StudentForm : Form
    {
        Student loggedStudent = new();
        public StudentForm(Student student)
        {
            InitializeComponent();
            Student? studentAux = Data.FindStudentByEmail(student.Email);
            if (studentAux is not null)
            {
                loggedStudent = studentAux;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            student_greeting.Text = $"Hola {loggedStudent.Email}!";
            if (register_subject_cb.Items.Count == 0)
            {
                for (int i = 0; i < Data.Subjects.Count; i++)
                {
                    register_subject_cb.Items.Add(Data.Subjects[i].Name);
                }
            }
            List<SubjectInCourse>? subjectsFromStudent = Data.GetSubjectsFromStudent(loggedStudent);
            if (subjectsFromStudent is not null)
            {
                for (int i = 0; i < subjectsFromStudent.Count; i++)
                {
                    if (subjectsFromStudent.Count >= subjects_list.Rows.Count)
                    {
                        subjects_list.Rows.Add();
                        subjects_list.Rows[i].Cells[0].Value = subjectsFromStudent[i].Name;
                        List<Exam>? examList = Data.GetStudentExamsBySubject(loggedStudent, subjectsFromStudent[i].Name);
                        if(examList is not null)
                        {
                            var lista = examList.Select(x => x.Calification.ToString()).ToList();
                            var finalString = string.Join(",", lista);
                            subjects_list.Rows[i].Cells[1].Value = finalString;
                        }
                       
                    }
                }
            }

        }


        private void student_form_exit_Click(object sender, EventArgs e)
        {
            Login fa = new Login();
            this.Hide();
            fa.Show();
        }

        private void register_subject_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void register_subject_button_Click(object sender, EventArgs e)
        {
            try
            {
                string? subjectAux = register_subject_cb.SelectedItem.ToString();
                if (subjectAux is not null)
                {
                    string subject = subjectAux;
                    bool isRegistered = Data.CheckIfSubjectContainsStudent(subject, loggedStudent.Email);
                    if (!isRegistered)
                    {
                        Data.EnrollSubjectToUser(loggedStudent.Id, subject);
                        MessageBox.Show("Inscripción realizada con exito!");
                        Data.AssignUsersToSubjects();
                        RefreshForm();
                    }
                    else
                    {
                        MessageBox.Show("Ya éstás inscripto en esa materia!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RefreshForm()
        {
            Hide();
            StudentForm newForm = new(loggedStudent);
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }
    }
}
