using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Asky
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private Student student;
        private Professor professor;

        public Student GetStudentData()
        {
            return student ?? new Student();
        }

        public Professor GetProfessorData()
        {
            return professor ?? new Professor();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtStudentMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errorProvider1.SetError(txtStudentMail, "Bad student email");
            }

            if (!Regex.IsMatch(txtProfessorMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errorProvider2.SetError(txtProfessorMail, "Bad professor email");
            }
            else
            {
                this.Close();
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            student = new Student()
                            {
                                FirstName = txtStudentFirstName.Text,
                                ID = txtStudentID.Text,
                                LastName = txtStudentLastName.Text,
                                Mail = txtStudentMail.Text
                            };
            professor = new Professor()
                            {
                                FirstName = txtProfessorFirstName.Text,
                                LastName = txtProfessorLastName.Text,
                                Mail = txtProfessorMail.Text,
                                Subject = txtProfessorSubject.Text
                            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
