using System;
using System.Net.Mail;
using System.Security.Authentication;
using System.Text.RegularExpressions;
using Quiz.Base.Interfaces;

namespace Quiz.Base.Models
{
    public class Student : IPerson
    {
        #region Implementation of IPerson

        /// <summary>
        /// First name of a person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of a person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email of a person.
        /// </summary>
        public MailAddress Mail { get; set; }

        public DateTime Birthday { get; set; }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                
                int age = now.Year - Birthday.Year;
                if (Birthday > now.AddYears(-age)) 
                    age--;
                if (age > 120) 
                    throw new ApplicationException("What the hell?!... This person has lived more than 120 years!!.");
                return age;
            }
        }

        #endregion

        public string ID { get; set; }

        public string Career { get; set; }

        public int Period { get; set; }

        public string School { get; set; }
    }
}