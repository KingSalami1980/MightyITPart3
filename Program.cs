using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Part3
{
    public static class StringExtender
    {

        public static string Truncate(this string source, int length)
        {
            //If source is null, return null.
            if (source.Length > length)
            {
                source = source.Substring(0, length);
            }
            return source;
        }
    }

}
