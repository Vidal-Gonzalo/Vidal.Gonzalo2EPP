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
            List<SubjectInCourse> subjectsAssigned = Data.GetProfessorSubjects(loggedProfessor);


            if (subjectsAssigned.Count == 0)
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
                    assigned_subjects_grid.Rows[i].Cells[0].Value = subjectsAssigned[i].Name;
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
            string? subject = assigned_subjects_grid.Rows[index].Cells[0].Value.ToString();
            create_exam_label.Text = subject;
        }

        private void create_exam_button_Click(object sender, EventArgs e)
        {
            List<SubjectInCourse> subjectsAssigned = Data.GetProfessorSubjects(loggedProfessor);

            foreach (SubjectInCourse item in subjectsAssigned)
            {
                if (item.Name == create_exam_label.Text)
                {
                    if (create_exam_name.Text != "" && create_exam_datePicker.Text != "")
                    {
                        bool r = false;
                        DateTime date = Convert.ToDateTime(create_exam_datePicker.Text);
                        foreach (Student student in item.Students)
                        {
                            r = Data.AssignExams(item.Name, date, student.Id, create_exam_name.Text);
                            r = true;
                            if (!r)
                            {
                                MessageBox.Show($"Hubo un error con la asignación de: {student.Email}.");
                                break;
                            }
                        }
                        if (r)
                        {
                            MessageBox.Show("Examen creado!");
                            Data.GetExams();
                        }
                        create_exam_grid.Hide();
                        assigned_subjects_grid.Show();
                        RefreshForm();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error");
                    }
                    break;
                }
            }
        }

        private void change_calification_search_Click(object sender, EventArgs e)
        {
            change_calification_grid.Rows.Clear();
            for (int i = 0; i < Data.SubjectsInCourses.Count; i++)
            {
                if (change_calification_cb.SelectedItem is not null)
                {
                    if (Data.SubjectsInCourses[i].Name == change_calification_cb.SelectedItem.ToString())
                    {
                        if (Data.SubjectsInCourses.Count >= change_calification_grid.Rows.Count)
                        {
                            for (int j = 0; j < Data.SubjectsInCourses[i].Students.Count; j++)
                            {
                                change_calification_grid.Rows.Add();
                                change_calification_grid.Rows[j].Cells[0].Value = Data.SubjectsInCourses[i].Students[j].Email;
                                change_calification_grid.Rows[j].Cells[1].Value = change_calification_cb.SelectedItem.ToString();
                            }
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
            List<Exam> exams = new List<Exam>();

            if (email is not null && subject is not null)
            {
                change_calification_student.Text = email;
                change_calification_subject.Text = subject;

                Student? studentAux = Data.FindStudentByEmail(email);
                if (studentAux is not null)
                {
                    Student student = studentAux;
                    if (student.Exams.Count > 0)
                    {
                        foreach (Exam exam in student.Exams)
                        {
                            if (exam.Subject == subject)
                            {
                                exams.Add(exam);
                            }
                        }
                    }
                }

                change_califications_exams_grid.Rows.Clear();

                if (exams.Count >= change_califications_exams_grid.Rows.Count)
                {
                    for (int i = 0; i < exams.Count; i++)
                    {
                        change_califications_exams_grid.Rows.Add();
                        change_califications_exams_grid.Rows[i].Cells[0].Value = exams[i].Name;
                        change_califications_exams_grid.Rows[i].Cells[1].Value = exams[i].Calification;

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
            Student? studentAux = Data.FindStudentByEmail(change_calification_student.Text);
            bool added = false;
            if (studentAux is not null)
            {
                Student student = studentAux;
                //Esto esta mal. Actualiza todas las calificaciones. 
                //También hay que verificar en la función de muestra de examenes que no se vuelvan a cargar.
                foreach (Exam exam in student.Exams)
                {
                    if (exam.Name == exam_changing_calification_name.Text && exam.UserId == student.Id)
                    {
                        string? selectedCalification = exam_changing_califications_cb.SelectedItem.ToString();
                        if (selectedCalification is not null)
                        {
                            int calification = int.Parse(selectedCalification);
                            added = Data.ChangeCalification(calification, student.Id, exam.Name);
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
                {
                    student.Exams.Clear();
                    Data.GetExams();
                    MessageBox.Show("Calificación modificada con exito!");
                }
                else
                {
                    MessageBox.Show("Hubo un error :(");
                }


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
