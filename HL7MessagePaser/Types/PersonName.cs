namespace HL7MessagePaser.Types
{
    public class PersonName
    {
        public PersonName()
        {
            this.FamilyName = "";
            this.GivenName = "";
            this.MiddleNameOrInitial = "";
            this.Suffix = "";
            this.Prefix = "";
            this.Degree = "";
        }

        /// <summary>
        ///  Family Name (Last Name)
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// Given Name (First Name)
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// Middle Name (or Initial)
        /// </summary>
        public string MiddleNameOrInitial { get; set; }

        /// <summary>
        /// Suffix
        /// </summary>
        /// <example>
        /// jr, sr
        /// </example>
        public string Suffix { get; set; }

        /// <summary>
        /// Prefix
        /// </summary>
        /// <example>
        /// Mr, Mrs, Dr
        /// </example> 
        public string Prefix { get; set; }

        /// <summary>
        /// Degree ()
        /// </summary>
        /// <example>
        /// MD, PHD
        /// </example>
        public string Degree { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            PersonName x = (PersonName) obj;

            return (this.FamilyName == x.FamilyName) &&
                   (this.GivenName == x.GivenName) &&
                   (this.MiddleNameOrInitial == x.MiddleNameOrInitial) &&
                   (this.Suffix == x.Suffix) &&
                   (this.Prefix == x.Prefix) &&
                   (this.Degree == x.Degree);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
