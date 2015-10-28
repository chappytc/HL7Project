namespace HL7MessagePaser.Segments
{
    public class SegmentDelimiters
    {
        private char _fieldSeparator = '|';
        private char _componentSeparator = '^';
        private char _fieldRepeatSeparator = '~';
        private char _escapeCharacter = '\\';
        private char _subComponentSeparator = '&';

        public char FieldSeparator
        {
            get { return _fieldSeparator; }
            set { _fieldSeparator = value; }
        }

        public char ComponentSeparator
        {
            get { return _componentSeparator; }
            set { _componentSeparator = value; }
        }

        public char FieldRepeatSeparator
        {
            get { return _fieldRepeatSeparator; }
            set { _fieldRepeatSeparator = value; }
        }

        public char EscapeCharacter
        {
            get { return _escapeCharacter; }
            set { _escapeCharacter = value; }
        }

        public char SubComponentSeparator
        {
            get { return _subComponentSeparator; }
            set { _subComponentSeparator = value; }
        }
    }
}
