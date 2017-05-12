using System.Linq;

namespace _99BottlesOfOOP
{
    public static class StringExtensions
    {
        public static string Capitalize(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            var first = s.First().ToString();
            var rest = new string(s.Skip(1).ToArray());

            return first.ToUpper() + rest;
        }
    }
}