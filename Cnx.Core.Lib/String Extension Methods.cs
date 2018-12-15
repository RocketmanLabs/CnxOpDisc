using System;
using System.Text;

namespace Cnx.Core.Lib
{
    public static class String_Extension_Methods
    {
        /// <summary>
        /// Returns first string that has content.
        /// FullString.OrFirstContent(first, second, third) returns FullString
        /// EmptyString.OrFirstContent(full, empty1) returns full
        /// EmptyString.OrFirstContent(empty1, full, empty2) returns full
        /// EmptyString.OrFirstContent(empty1, empty3, empty2, empty4) returns ""
        /// </summary>
        static public string OrFirstContent(this string s, params string[] candidates)
        {
            if (String.IsNullOrEmpty(s)) {
                foreach (var possible in candidates) {
                    if (!String.IsNullOrEmpty(possible)) {
                        return possible;
                    }
                }
                return "";
            }
            return s;
        }

        /// <summary>
        /// Concatenates strings into a space-delimited list.
        /// </summary>
        static public string Space(this string s, params string[] sibs) => (s + " " + String.Join(" ", sibs)).TrimEnd();
    }
}
