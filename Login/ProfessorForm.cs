using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{

    public partial class ProfessorForm : Form
    {

        Professor loggedProfessor = new();
        short[] califications = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public ProfessorForm(Professor professor)
        {
            InitializeComponent();
            loggedProfessor = professor;
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            List<Subject> subjectsAssigned = new List<Subject>();
            bool isSubjectAssigned = false;

            foreach (Subject subject in Data.Subjects)
            {
                if (loggedProfessor == subject)
                {
                    subjectsAssigned.Add(subject);
                    isSubjectAssigned = true;
                }
            }

            if (!isSubjectAssigned)
            {
                professor_form_greeting.Text = "No hay materias asignadas :(";
            }
            else
            {
                professor_form_greeting.Text = $"Hola {loggedProfessor.Email}!";
                for (int i = 0; i < subjectsAssigned.Count; i++)
                {
                    change_calification_cb.Items.Add(subjectsAssigned[i].Name);
                    assigned_subjects_grid.Rows.Add();
                    assigned_subjects_grid.Rows[i].Cells[0].Value = subjectsAssigned[i].Id;
                    assigned_subjects_grid.Rows[i].Cells[1].Value = subjectsAssigned[i].Name;
                }
            }
            for (int i = 0; i < califications.Length; i++)
            {
                exam_changing_califications_cb.Items.Add(califications[i]);
            }
            change_calification_cb.SelectedItem = null;
            change_calification_cb.SelectedText = "Selecciona una materia...";
            exam_changing_califications_cb.SelectedItem = null;
            exam_changing_califications_cb.SelectedText = "Selecciona un número...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void assigned_subjects_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            assigned_subjects_grid.Hide();
            create_exam_grid.Show();
            int index = int.Parse(e.RowIndex.ToString());
            string? subject = assigned_subjects_grid.Rows[index].Cells[1].Value.ToString();
            create_exam_label.Text = subject;

        }

        private void create_exam_button_Click(object sender, EventArgs e)
        {
            foreach (SubjectInCourse item in Data.SubjectsInCourses)
            {
                if (item.Name == create_exam_label.Text)
                {
                    if (create_exam_name.Text != "" && create_exam_datePicker.Text != "")
                    {
                        Exam exam = new(create_exam_name.Text, create_exam_datePicker.Text);
                        item.Exams.Add(exam);
                        MessageBox.Show("Examen creado");
                        create_exam_grid.Hide();
                        assigned_subjects_grid.Show();
                        RefreshForm();
                    } else
                    {
                        MessageBox.Show("Hubo un error");
                    }
                   
                }
            }
        }

        private void change_calification_search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.SubjectsInCourses.Count; i++)
            {
                if (change_calification_cb.SelectedItem is not null)
                {
                    if (Data.SubjectsInCourses[i].Name == change_calification_cb.SelectedItem.ToString())
                    {
                        if (Data.SubjectsInCourses.Count >= change_calification_grid.Rows.Count)
                        {
                            //Exception here
                            Student student = Data.SubjectsInCourses[i].Student;
                            change_calification_grid.Rows.Add();
                            change_calification_grid.Rows[i].Cells[0].Value = student.Email;
                            change_calification_grid.Rows[i].Cells[1].Value = change_calification_cb.SelectedItem.ToString();
                        }
                    }
                    change_calification_grid.Show();
                }

            }
        }

        private void create_exam_cancel_Click(object sender, EventArgs e)
        {
            create_exam_grid.Hide();
            assigned_subjects_grid.Show();
        }

        private void change_calification_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            change_calification_grid.Hide();
            change_calification_gb.Show();
            int index = int.Parse(e.RowIndex.ToString());
            string? email = change_calification_grid.Rows[index].Cells[0].Value.ToString();
            string? subject = change_calification_grid.Rows[index].Cells[1].Value.ToString();
            if (email is not null && subject is not null)
            {
                change_calification_student.Text = email;
                change_calification_subject.Text = subject;
                SubjectInCourse? subjectInCourseAux = Data.FindSubjectInCourseByName(subject);
                if (subjectInCourseAux is not null)
                {
                    SubjectInCourse subjectInCourse = subjectInCourseAux;
                    if (subjectInCourse.Exams.Count > 0)
                    {
                        for (int i = 0; i < subjectInCourse.Exams.Count; i++)
                        {
                            if (subjectInCourse.Exams.Count >= change_califications_exams_grid.Rows.Count)
                            {
                                change_califications_exams_grid.Rows.Add();
                                change_califications_exams_grid.Rows[i].Cells[0].Value = subjectInCourse.Exams[i].Name;
                                change_califications_exams_grid.Rows[i].Cells[1].Value = subjectInCourse.Exams[i].Calification;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay examenes.");
                    }
                }

            }

        }

        private void change_califications_exams_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = int.Parse(e.RowIndex.ToString());
            string? name = change_califications_exams_grid.Rows[index].Cells[0].Value.ToString();
            if (name is not null)
            {
                exam_changing_calification_name.Text = name;
                exam_changing_calification.Show();
            }

        }

        private void change_exam_button_Click(object sender, EventArgs e)
        {
            SubjectInCourse? subjectInCourseAux = Data.FindSubjectInCourseByName(change_calification_subject.Text);
            bool added = false;
            if (subjectInCourseAux is not null)
            {
                SubjectInCourse subjectInCourse = subjectInCourseAux;
                foreach (Exam exam in subjectInCourse.Exams)
                {
                    if (exam.Name == exam_changing_calification_name.Text)
                    {
                        string? selectedCalification = exam_changing_califications_cb.SelectedItem.ToString();
                        if (selectedCalification is not null && selectedCalification is not null)
                        {
                            int calification = int.Parse(selectedCalification);
                            exam.Calification = calification;
                            added = true;
                            exam_changing_calification.Hide();
                            RefreshForm();
                        }
                        else
                        {
                            MessageBox.Show("Ingresa un numero valido.");
                            break;
                        }
                    }
                }
                if (added)
                    MessageBox.Show("Calificación modificada con exito!");
                else
                    MessageBox.Show("Hubo un error :(");
            }
        }


        private void change_exam_cancel_Click(object sender, EventArgs e)
        {
            exam_changing_calification.Hide();
            change_calification_gb.Show();
        }

        private void change_calification_back_Click(object sender, EventArgs e)
        {
            change_calification_gb.Hide();
            change_calification_grid.Show();
        }
        private void RefreshForm()
        {
            Hide();
            ProfessorForm newForm = new(loggedProfessor);
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }

        private void professor_form_exit_Click(object sender, EventArgs e)
        {
            Login fa = new Login();
            this.Hide();
            fa.Show();
        }
    }
}
