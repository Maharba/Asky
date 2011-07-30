using System.Security.Authentication;
using System.Text.RegularExpressions;

namespace Asky
{
    public class Professor : IPerson
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

        private string mail;
        /// <summary>
        /// Email of a person.
        /// </summary>
        public string Mail
        {
            get { return mail; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                    mail = value;
                else
                    throw new InvalidCredentialException("Bad email");
            }
        }

        #endregion

        public string Subject { get; set; }
    }
}