namespace DesignPatterns.Algorithms.HacherRank
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TimeConversion
    {
        public string TimeConversions(string timeConversion)
        {
            DateTime dateTime = DateTime.ParseExact(timeConversion, "hh:mm:sstt",
                            System.Globalization.CultureInfo.InvariantCulture);

            string convertedString = dateTime.ToString("HH:mm:ss");
            return convertedString;
        }
    }
}
