using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.Helpers
{
    public static class StringExtension
    {
        public static string Chop(this string text, int numberofwords)
        {
           

            if (text == null || text.Length < numberofwords)
                return text;

            var word = text.Split(" ");

            if (word.Length <= numberofwords)
                return text;
            else
                return string.Join(" ", word.Take(numberofwords)) + "...";
        }
    }
}
