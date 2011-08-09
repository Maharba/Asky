using Quiz.Base.Collections;
using Quiz.Base.Interfaces;

namespace Quiz.Base
{
    public class Questionnaire : IQuestionnaire
    {
        public Questionnaire(QuestionCollection questions, string name = "None")
        {
            Name = name;
            Questions = questions;
        }

        public QuestionCollection Questions { get; private set; }
        public string Name { get; set; }
    }
}