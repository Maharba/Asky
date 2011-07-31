using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Asky
{
    public partial class QuizPresenter : UserControl
    {
        private readonly Quiz quiz;

        public QuizPresenter()
        {
            InitializeComponent();
            this.quiz = new Quiz();
        }

        public QuizPresenter(Quiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
        }

        public event EventHandler<Asky.EventArgs<byte, string>> QuestionChanged;

        public byte NumberQuestion { get; private set; }
                
        public string Question { get { return lblQuestion.Text; } }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<Question> Questions
        {
            get { return quiz.Questions; } 
            set
            {
                quiz.Questions = value;
                ShowQuestion(0);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        /// <summary>
        /// Go to the next question on Questions.
        /// </summary>
        public void NextQuestion()
        {
            if (NumberQuestion + 1 >= quiz.Questions.Count) return;
            ShowQuestion(++NumberQuestion);
            if (QuestionChanged != null)
                QuestionChanged(this, new EventArgs<byte, string>(NumberQuestion, quiz.Questions[NumberQuestion].Content));
        }

        /// <summary>
        /// Go to the previous question on Questions.
        /// </summary>
        public void PreviousQuestion()
        {
            if (NumberQuestion - 1 < 0) return;
            ShowQuestion(--NumberQuestion);
            if (QuestionChanged != null)
                QuestionChanged(this, new EventArgs<byte, string>(NumberQuestion, quiz.Questions[NumberQuestion].Content));
        }

        private void ShowQuestion(byte numberQuestion)
        {
            NumberQuestion = numberQuestion;
            // TODO: Optimizar para localización.
            gbQuestions.Text = string.Format("Pregunta {0}", numberQuestion + 1);
            lblQuestion.Text = quiz.Questions[numberQuestion].Content;

            switch (quiz.Questions[numberQuestion].Type)
            {
                case TypeQuestion.Single:
                    GenerateVisualOptions(typeof(RadioButton), numberQuestion);
                    break;
                case TypeQuestion.Multiple:
                    GenerateVisualOptions(typeof(CheckBox), numberQuestion);
                    break;
            }
        }

        private void GenerateVisualOptions(Type t, byte numberQuestion)
        {
            tableLayoutAnswersPanel.Controls.Clear();
            tableLayoutAnswersPanel.RowCount = quiz.Questions[numberQuestion].Options.Count;
            for (int i = 0; i < tableLayoutAnswersPanel.RowCount; i++)
            {
                tableLayoutAnswersPanel.RowStyles.Add(
                    new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,
                                                      (float)100 / quiz.Questions[numberQuestion].Options.Count));
                if (t.Name == "RadioButton")
                {
                    RadioButton rb = new RadioButton { Text = quiz.Questions[numberQuestion].Options[i].Content };
                    tableLayoutAnswersPanel.Controls.Add(rb);
                    tableLayoutAnswersPanel.SetRow(rb, i);
                }
                else if (t.Name == "CheckBox")
                {
                    CheckBox cbx = new CheckBox { Text = quiz.Questions[numberQuestion].Options[i].Content };
                    tableLayoutAnswersPanel.Controls.Add(cbx);
                    tableLayoutAnswersPanel.SetRow(cbx, i);
                }
            }
        }
    }
}
