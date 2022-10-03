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
    public partial class Form2 : Form
    {
        Admin loggedAdmin = new();

        public Form2(Admin admin)
        {
            InitializeComponent();
            loggedAdmin = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fa = new Form1();
            this.Hide();
            fa.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void createSubject_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.title_admin.Text = $"Hola {loggedAdmin.Email}!";
        }

        private void createUser_button_Click(object sender, EventArgs e)
        {
            //Refactorizar
            short newId = 0;
            string type = "";

            if (createUser_radioAdmin.Checked)
            {
                newId = loggedAdmin.GetNewAdminId(Data.Admins);
                type = "Admin";
            }
            else if (createUser_radioStudent.Checked)
            {
                newId = loggedAdmin.GetNewStudentId(Data.Students);
                type = "Student";
            }
            else if (createUser_radioProfessor.Checked)
            {
                newId = loggedAdmin.GetNewProfessorId(Data.Professors);
                type = "Professor";
            }     

            bool registered = loggedAdmin.RegisterUser(Data.Users, newId, createUser_email.Text, createUser_password.Text, type);
            if (registered)
            {
                MessageBox.Show("Usuario registrado");
                foreach(User user in Data.Users)
                {
                    Type userType = user.GetType();
                    MessageBox.Show($"Email: {user.Email} - Contraseña: {user.Password} - Tipo: {userType.Name}");
                }
            }
            else
            {
                MessageBox.Show("Hubo un error, vuelva a intentar.");
            }

        }
    }
}
