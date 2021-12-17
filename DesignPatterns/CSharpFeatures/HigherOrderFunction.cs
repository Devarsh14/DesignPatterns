using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.CSharpFeatures
{
    internal class HigherOrderFunction
    {

        public int name()
        {

            Func<string, int> selector = str => int.Parse(str);
            string no = "1";

            int alpha = no.Select(selector);

            return alpha;

        }
    }
}
