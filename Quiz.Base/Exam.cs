using System;
using System.Timers;
using Quiz.Base.Collections;
using Quiz.Base.Interfaces;
using Quiz.Base.Models;

namespace Quiz.Base
{
    public class Exam : IQuestionnaire
    {
        private readonly Timer _timer;

        public event EventHandler TimeOut;

        public Exam(QuestionCollection questions, Student student, Professor professor, TimeSpan duration)
        {
            _timer = new Timer(1000);
            Questions = questions;
            Student = student;
            Professor = professor;
            Duration = duration;
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (e.SignalTime.Ticks == Duration.Ticks)
            {
                _timer.Stop();
                if (TimeOut != null)
                {
                    TimeOut(this, EventArgs.Empty);
                }
            }
        }
        
        public QuestionCollection Questions { get; set; }
        public Student Student { get; set; }
        public Professor Professor { get; set; }
        public string Subject { get; set; }
        public byte Unit { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }

        public void Start()
        {
            _timer.Start();
        }
    }
}