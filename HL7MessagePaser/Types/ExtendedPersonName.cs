namespace HL7MessagePaser.Types
{
    public class ExtendedPersonName : PersonName
    {
        public ExtendedPersonName()
        {
            NameRepresentationCode = "";
            NameTypeCode = "";
        }

        /// <summary>
        /// Name type code
        /// </summary>
        /// <example>
        /// A = Alias Name; L = Legal Name; D = Display Name; M = Maiden Name; C = Adopted Name
        /// </example>
        public string NameTypeCode { get; set; }

        /// <summary>
        /// Name representation
        /// </summary>
        /// <example>
        /// I = Ideographic; A = Alphabetic; P = Phonetic
        /// </example>
        public string NameRepresentationCode { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            ExtendedPersonName x = (ExtendedPersonName)obj;

            return base.Equals(obj) &&
                   (this.NameTypeCode == x.NameTypeCode) &&
                   (this.NameRepresentationCode == x.NameRepresentationCode);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
