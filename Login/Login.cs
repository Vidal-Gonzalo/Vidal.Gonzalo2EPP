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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(this.Width, this.Height);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            User loggedUser = Data.CheckLogin(login_email.Text, login_password.Text);

            if (loggedUser is not null)
            {
                Type userType = loggedUser.GetType();
                Hide();
                switch (userType.Name)
                {
                    case "Admin":
                        Admin fa = new((ClassLibrary.Admin)loggedUser);
                        fa.Show();
                        break;
                    case "Student":
                        Form3 fs = new("Student");
                        fs.Show();
                        break;
                    case "Professor":
                        Form4 fp = new("Professor");
                        fp.Show();
                        break;
                    default:
                        break;
                }
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
