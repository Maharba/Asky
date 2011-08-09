using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Asky;
using Quiz.Base;
using Quiz.Base.Collections;
using Quiz.Base.Enums;
using Quiz.Components;

namespace Quiz.Controls
{
    public partial class QuizPresenter : UserControl
    {
        private readonly QuizDocument _quiz;

        public QuizPresenter()
        {
            InitializeComponent();
            this._quiz = new QuizDocument();
        }

        public QuizPresenter(QuizDocument quiz)
        {
            InitializeComponent();
            this._quiz = quiz;
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public QuizDocument Quiz { get; set; }

        public event EventHandler<EventArgs<byte, string>> QuestionChanged;

        public byte NumberQuestion { get; private set; }
                
        public string Question { get { return lblQuestion.Text; } }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public QuestionCollection Questions
        {
            get { return _quiz.Questions; } 
            set
            {
                _quiz.Questions = value;
                ShowQuestion(0);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        /// <summary>
        /// Go to the next question on Questions.
        /// </summary>
        public void NextQuestion()
        {
            if (NumberQuestion + 1 >= _quiz.Questions.Count) return;
            ShowQuestion(++NumberQuestion);
            if (QuestionChanged != null)
                QuestionChanged(this, new EventArgs<byte, string>(NumberQuestion, _quiz.Questions[NumberQuestion].Text));
        }

        /// <summary>
        /// Go to the previous question on Questions.
        /// </summary>
        public void PreviousQuestion()
        {
            if (NumberQuestion - 1 < 0) return;
            ShowQuestion(--NumberQuestion);
            if (QuestionChanged != null)
                QuestionChanged(this, new EventArgs<byte, string>(NumberQuestion, _quiz.Questions[NumberQuestion].Text));
        }

        private void ShowQuestion(byte numberQuestion)
        {
            NumberQuestion = numberQuestion;
            // TODO: Optimizar para localización.
            gbQuestions.Text = string.Format("Pregunta {0}", numberQuestion + 1);
            lblQuestion.Text = _quiz.Questions[numberQuestion].Text;

            switch (_quiz.Questions[numberQuestion].Type)
            {
                case TypeOptions.Single:
                    GenerateVisualOptions(typeof(RadioButton), numberQuestion);
                    break;
                case TypeOptions.Multiple:
                    GenerateVisualOptions(typeof(CheckBox), numberQuestion);
                    break;
            }
        }

        private void GenerateVisualOptions(Type t, byte numberQuestion)
        {
            tableLayoutAnswersPanel.Controls.Clear();
            tableLayoutAnswersPanel.RowCount = _quiz.Questions[numberQuestion].Options.Count;
            for (int i = 0; i < tableLayoutAnswersPanel.RowCount; i++)
            {
                tableLayoutAnswersPanel.RowStyles.Add(
                    new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,
                                                      (float)100 / _quiz.Questions[numberQuestion].Options.Count));
                if (t.Name == "RadioButton")
                {
                    RadioButton rb = new RadioButton { Text = _quiz.Questions[numberQuestion].Options[i].Text };
                    tableLayoutAnswersPanel.Controls.Add(rb);
                    tableLayoutAnswersPanel.SetRow(rb, i);
                }
                else if (t.Name == "CheckBox")
                {
                    CheckBox cbx = new CheckBox { Text = _quiz.Questions[numberQuestion].Options[i].Text };
                    tableLayoutAnswersPanel.Controls.Add(cbx);
                    tableLayoutAnswersPanel.SetRow(cbx, i);
                }
            }
        }
    }
}
