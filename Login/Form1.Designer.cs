namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_email = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_admin = new System.Windows.Forms.Button();
            this.login_student = new System.Windows.Forms.Button();
            this.login_professor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_label
            // 
            resources.ApplyResources(this.login_label, "login_label");
            this.login_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.login_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(41)))));
            this.login_label.Name = "login_label";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // login_email
            // 
            resources.ApplyResources(this.login_email, "login_email");
            this.login_email.Name = "login_email";
            // 
            // login_password
            // 
            resources.ApplyResources(this.login_password, "login_password");
            this.login_password.Name = "login_password";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(41)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.login_btn, "login_btn");
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Name = "login_btn";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_admin
            // 
            resources.ApplyResources(this.login_admin, "login_admin");
            this.login_admin.BackColor = System.Drawing.Color.Black;
            this.login_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_admin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login_admin.FlatAppearance.BorderSize = 0;
            this.login_admin.ForeColor = System.Drawing.Color.White;
            this.login_admin.Name = "login_admin";
            this.login_admin.UseVisualStyleBackColor = false;
            this.login_admin.Click += new System.EventHandler(this.login_admin_Click);
            // 
            // login_student
            // 
            resources.ApplyResources(this.login_student, "login_student");
            this.login_student.BackColor = System.Drawing.Color.Black;
            this.login_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_student.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login_student.FlatAppearance.BorderSize = 0;
            this.login_student.ForeColor = System.Drawing.Color.White;
            this.login_student.Name = "login_student";
            this.login_student.UseVisualStyleBackColor = false;
            this.login_student.Click += new System.EventHandler(this.login_student_Click);
            // 
            // login_professor
            // 
            resources.ApplyResources(this.login_professor, "login_professor");
            this.login_professor.BackColor = System.Drawing.Color.Black;
            this.login_professor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_professor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login_professor.FlatAppearance.BorderSize = 0;
            this.login_professor.ForeColor = System.Drawing.Color.White;
            this.login_professor.Name = "login_professor";
            this.login_professor.UseVisualStyleBackColor = false;
            this.login_professor.Click += new System.EventHandler(this.login_professor_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.label3.Name = "label3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Login.Properties.Resources.doodad;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_professor);
            this.Controls.Add(this.login_student);
            this.Controls.Add(this.login_admin);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_email;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button login_admin;
        private System.Windows.Forms.Button login_student;
        private System.Windows.Forms.Button login_professor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
