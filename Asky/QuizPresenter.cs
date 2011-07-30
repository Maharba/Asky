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

        public QuizPresenter(Quiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
        }

        public event EventHandler<Asky.EventArgs<byte, string>> QuestionChanged;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte NumberQuestion { get; private set; }
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Question { get { return lblQuestion.Text; } }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public List<Answer> Options { get { return quiz.Options; } }

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
            // TODO: CUIDADO!! BUG DETECTADO!! Verificar si el indice es válido en Options. Que devuelva int este método.
            ShowQuestion(++NumberQuestion);
            if (QuestionChanged != null)
                QuestionChanged(this, new EventArgs<byte, string>(NumberQuestion, quiz.Questions[NumberQuestion]));
        }

        /// <summary>
        /// Go to the previous question on Questions.
        /// </summary>
        public void PreviousQuestion()
        {
            // TODO: CUIDADO!! BUG DETECTADO!! Verificar si el indice es válido en Options. Que devuelva int este método.
            ShowQuestion(--NumberQuestion);
            if (QuestionChanged != null)
                QuestionChanged(this, new EventArgs<byte, string>(NumberQuestion, quiz.Questions[NumberQuestion]));
        }

        private void ShowQuestion(byte numberQuestion)
        {
            NumberQuestion = numberQuestion;
            // TODO: Optimizar para localización.
            gbQuestions.Text = string.Format("Pregunta {0}", quiz.Questions[numberQuestion]);
            lblQuestion.Text = quiz.Questions[numberQuestion];

            switch (quiz.Options[numberQuestion].Type)
            {
                case TypeAnswer.Single:
                    GenerateVisualOptions(typeof(RadioButton));
                    break;
                case TypeAnswer.Multiple:
                    GenerateVisualOptions(typeof(CheckBox));
                    break;
            }
        }

        private void GenerateVisualOptions(Type t)
        {
            tableLayoutAnswersPanel.RowCount = quiz.Options.Count;
            for (int i = 0; i < quiz.Options.Count; i++)
            {
                tableLayoutAnswersPanel.RowStyles.Add(
                    new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,
                                                      (float)100 / quiz.Options.Count));
                if (typeof(RadioButton) == t.GetType())
                {
                    RadioButton rb = new RadioButton {Text = quiz.Options[i].Content};
                    tableLayoutAnswersPanel.SetRow(rb, i);
                }
                else if (typeof(CheckBox) == t.GetType())
                {
                    CheckBox cbx = new CheckBox {Text = quiz.Options[i].Content};
                    tableLayoutAnswersPanel.SetRow(cbx, i);
                }
            }
        }
    }
}
