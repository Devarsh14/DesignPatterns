using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CSharpFeatures
{
    public class StringInterpolation
    {
        // String interpoloation is better method than escape character and also bettr than idea of string composite formatting. 

        /// <summary>
        ///  Provides example for the interpolated string in c#.
        /// </summary>
        /// <returns>string</returns>
        public string interpolatedString()
        {

            string name = "Devarsh";
            var date = DateTime.Now;

            // String interpolation example.
            string namedate = $"{name} {date}";

            return namedate;
        }
    }
}
