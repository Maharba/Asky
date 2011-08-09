using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Asky.Properties;
using Quiz.Base.Collections;

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
        private Quiz quiz;

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            // this.Hide();
            
            quizDocument1 = QuizDocument

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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                quiz = Quiz.ParseFromFile(openFileDialog1.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            quizPresenter1.NextQuestion();
        }
    }
}
