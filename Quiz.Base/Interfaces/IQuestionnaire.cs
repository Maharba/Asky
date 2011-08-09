using Quiz.Base.Collections;

namespace Quiz.Base.Interfaces
{
    public interface IQuestionnaire
    {
        QuestionCollection Questions { get; }
    }
}