namespace Login
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.createSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónDeProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.title_admin = new System.Windows.Forms.Label();
            this.createUser_button = new System.Windows.Forms.Button();
            this.createUser_email = new System.Windows.Forms.TextBox();
            this.createUser_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createUser_radioAdmin = new System.Windows.Forms.RadioButton();
            this.createUser_radioStudent = new System.Windows.Forms.RadioButton();
            this.createUser_radioProfessor = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSubject,
            this.asignaciónDeProfesoresToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(41)))));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripDropDownButton1.Text = "Materias";
            // 
            // createSubject
            // 
            this.createSubject.Name = "createSubject";
            this.createSubject.Size = new System.Drawing.Size(207, 22);
            this.createSubject.Text = "Crear materia";
            this.createSubject.Click += new System.EventHandler(this.createSubject_Click);
            // 
            // asignaciónDeProfesoresToolStripMenuItem
            // 
            this.asignaciónDeProfesoresToolStripMenuItem.Name = "asignaciónDeProfesoresToolStripMenuItem";
            this.asignaciónDeProfesoresToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.asignaciónDeProfesoresToolStripMenuItem.Text = "Asignación de profesores";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(41)))));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(65, 22);
            this.toolStripDropDownButton2.Text = "Usuarios";
            // 
            // title_admin
            // 
            this.title_admin.AutoSize = true;
            this.title_admin.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_admin.Location = new System.Drawing.Point(235, 75);
            this.title_admin.Name = "title_admin";
            this.title_admin.Size = new System.Drawing.Size(82, 42);
            this.title_admin.TabIndex = 2;
            this.title_admin.Text = "Hola";
            // 
            // createUser_button
            // 
            this.createUser_button.Location = new System.Drawing.Point(235, 283);
            this.createUser_button.Name = "createUser_button";
            this.createUser_button.Size = new System.Drawing.Size(75, 23);
            this.createUser_button.TabIndex = 3;
            this.createUser_button.Text = "Crear";
            this.createUser_button.UseVisualStyleBackColor = true;
            this.createUser_button.Click += new System.EventHandler(this.createUser_button_Click);
            // 
            // createUser_email
            // 
            this.createUser_email.Location = new System.Drawing.Point(170, 153);
            this.createUser_email.Name = "createUser_email";
            this.createUser_email.Size = new System.Drawing.Size(222, 23);
            this.createUser_email.TabIndex = 4;
            // 
            // createUser_password
            // 
            this.createUser_password.Location = new System.Drawing.Point(170, 205);
            this.createUser_password.Name = "createUser_password";
            this.createUser_password.PasswordChar = '*';
            this.createUser_password.Size = new System.Drawing.Size(222, 23);
            this.createUser_password.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // createUser_radioAdmin
            // 
            this.createUser_radioAdmin.AutoSize = true;
            this.createUser_radioAdmin.Location = new System.Drawing.Point(170, 234);
            this.createUser_radioAdmin.Name = "createUser_radioAdmin";
            this.createUser_radioAdmin.Size = new System.Drawing.Size(61, 19);
            this.createUser_radioAdmin.TabIndex = 8;
            this.createUser_radioAdmin.TabStop = true;
            this.createUser_radioAdmin.Text = "Admin";
            this.createUser_radioAdmin.UseVisualStyleBackColor = true;
            // 
            // createUser_radioStudent
            // 
            this.createUser_radioStudent.AutoSize = true;
            this.createUser_radioStudent.Location = new System.Drawing.Point(237, 234);
            this.createUser_radioStudent.Name = "createUser_radioStudent";
            this.createUser_radioStudent.Size = new System.Drawing.Size(80, 19);
            this.createUser_radioStudent.TabIndex = 9;
            this.createUser_radioStudent.TabStop = true;
            this.createUser_radioStudent.Text = "Estudiante";
            this.createUser_radioStudent.UseVisualStyleBackColor = true;
            // 
            // createUser_radioProfessor
            // 
            this.createUser_radioProfessor.AutoSize = true;
            this.createUser_radioProfessor.Location = new System.Drawing.Point(323, 234);
            this.createUser_radioProfessor.Name = "createUser_radioProfessor";
            this.createUser_radioProfessor.Size = new System.Drawing.Size(69, 19);
            this.createUser_radioProfessor.TabIndex = 10;
            this.createUser_radioProfessor.TabStop = true;
            this.createUser_radioProfessor.Text = "Profesor";
            this.createUser_radioProfessor.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.createUser_radioProfessor);
            this.Controls.Add(this.createUser_radioStudent);
            this.Controls.Add(this.createUser_radioAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUser_password);
            this.Controls.Add(this.createUser_email);
            this.Controls.Add(this.createUser_button);
            this.Controls.Add(this.title_admin);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem createSubject;
        private System.Windows.Forms.ToolStripMenuItem asignaciónDeProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.Label title_admin;
        private System.Windows.Forms.Button createUser_button;
        private System.Windows.Forms.TextBox createUser_email;
        private System.Windows.Forms.TextBox createUser_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton createUser_radioAdmin;
        private System.Windows.Forms.RadioButton createUser_radioStudent;
        private System.Windows.Forms.RadioButton createUser_radioProfessor;
    }
}