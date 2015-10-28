using System;
using HL7MessagePaser.Enums;

namespace HL7MessagePaser.Segments
{
    public abstract class Segment
    {
        internal SegmentTypes _segmentType = SegmentTypes.Unknown;
        internal string _segment = String.Empty;
        internal SegmentDelimiters _delimiters;

        public SegmentDelimiters Delimiters
        {
            get { return _delimiters; }
            set { _delimiters = value; }
        }

        public SegmentTypes SegmentType
        {
            get { return _segmentType; }
            set { _segmentType = value; }
        }

        protected Segment(string segment)
        {
            _delimiters = new SegmentDelimiters();
            _segment = segment;
        }

        public string GetField(int fieldIndex)
        {
            return GetItemFromDelimitedString(_segment, fieldIndex, _delimiters.FieldSeparator);
        }

        public string GetComponent(string s, int fieldIndex)
        {
            return GetItemFromDelimitedString(s, fieldIndex, _delimiters.ComponentSeparator);
        }

        private string GetItemFromDelimitedString(string s, int fieldIndex, char delimiter)
        {
            string returnVal = string.Empty;

            if (!string.IsNullOrEmpty(s))
            {
                string[] fields = s.Split(delimiter);

                if (fields.Length > fieldIndex)
                    returnVal = fields[fieldIndex];
            }

            return returnVal;
        }
    }
}
