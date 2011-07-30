namespace Asky
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
        string Mail { get; set; }
    }
}