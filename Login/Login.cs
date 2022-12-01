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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(this.Width, this.Height);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            if (Data.Users.Count == 0)
            {
                Data.GetUsers();
            }
            if (Data.Subjects.Count == 0)
            {
                Data.GetSubjects();
            }
            Data.AssignUsersToSubjects();
            Data.GetExams();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            User? userAux = Data.CheckLogin(login_email.Text, login_password.Text);
            if (userAux is not null)
            {
                User loggedUser = userAux;
                switch (loggedUser.Role)
                {
                    case 1:
                        Admin admin = new Admin(loggedUser.Id, loggedUser.Email, loggedUser.Password, loggedUser.Role);
                        AdminForm fa = new(admin);
                        fa.Show();
                        break;
                    case 2:
                        Professor professor = new Professor(loggedUser.Id, loggedUser.Email, loggedUser.Password, loggedUser.Role);
                        ProfessorForm fp = new(professor);
                        fp.Show();
                        break;
                    case 3:
                        Student student = new Student(loggedUser.Id, loggedUser.Email, loggedUser.Password, loggedUser.Role);
                        StudentForm fs = new(student);
                        fs.Show();
                        break;
                    default:
                        MessageBox.Show("Hubo un error.");
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }


        }

        private void login_admin_Click(object sender, EventArgs e)
        {
            login_email.Text = "admin@gmail.com";
            login_password.Text = "admin123";
        }

        private void login_student_Click(object sender, EventArgs e)
        {
            login_email.Text = "gonzalo@gmail.com";
            login_password.Text = "gonza123";
        }

        private void login_professor_Click(object sender, EventArgs e)
        {
            login_email.Text = "mario@gmail.com";
            login_password.Text = "mario123";
        }
    }
}
