using System;

namespace HL7MessagePaser
{
    public static class Utils
    {
        /// <summary>
        /// Attempts to parse a string for a date.
        /// </summary>
        /// <param name="datetime">String representation of a datetime in the format of MMDDCCYYHHmmss.</param>
        /// <example>
        /// 01012015043000 == Jan 1, 2015 4:30:00
        /// </example>
        /// <returns>DateTime if the string can be parsed; NULL if not.</returns>
        public static DateTime? DateTimeFromNonStandardDateTimeFormat(string datetime, string incomingDateTimeFormat)
        {
            DateTime? returnValue = null;

            try
            {
                returnValue = DateTime.ParseExact(datetime, incomingDateTimeFormat, null);
            }
            catch
            {
                returnValue = null;
            }

            return returnValue;
        }
    }
}
