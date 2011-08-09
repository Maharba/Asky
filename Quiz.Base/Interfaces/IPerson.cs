using System;
using System.Net.Mail;

namespace Quiz.Base.Interfaces
{
    public interface IPerson
    {
        /// <summary>
        /// First name of a person.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Last name of a person.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Email of a person.
        /// </summary>
        MailAddress Mail { get; set; }

        DateTime Birthday { get; set; }

        int Age { get; }
    }
}