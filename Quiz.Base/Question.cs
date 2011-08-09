using System;
using Quiz.Base.Collections;
using Quiz.Base.Enums;

namespace Quiz.Base
{
    public class Question
    {
        private int _answer;

        public string Text { get; set; }
        public AnswerCollection Options { get; set; }
        public int Answer
        {
            get { return _answer; }
            set {
                if (value > Options.Count) throw new InvalidOperationException("Number of answer out of range of Options.");
                _answer = value;
            }
        }
        public TypeOptions Type { get; set; }
    }
}