namespace Asky
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
        public string Mail { get; set; }

        #endregion

        public string ID { get; set; }
    }
}