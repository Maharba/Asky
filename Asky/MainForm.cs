using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Asky.Properties;

namespace Asky
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Student student;
        private Professor professor;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();

            using (RegisterForm rf = new RegisterForm())
            {
                if (rf.ShowDialog(this) == DialogResult.OK)
                {
                    professor = rf.GetProfessorData();
                    student = rf.GetStudentData();
                    if (professor == null || student == null)
                    {
                        MessageBox.Show(Resources.MainForm_MainForm_Load_Error, 
                            Resources.MainForm_MainForm_Load_Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Restart();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
