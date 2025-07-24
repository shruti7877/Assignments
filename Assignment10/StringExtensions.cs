using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    public static class StringExtensions
    {
        public static int CharCount(this string s)
        {
            return (s ?? "***").Length;
        }

        public static bool IsPalindrome(this string s)
        {
            s = (s ?? "***").ToLower().Replace(" ", "");
            return s == new string(s.Reverse().ToArray());
        }
        public static string ReverseSentence(this string s)
        {
            return new string((s ?? "***").Reverse().ToArray());
        }

        public static void CountDetails(this string s)
        {
            int vowels = 0, consonants = 0, digits = 0, special = 0;
            s = s ?? "***";
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                    digits++;
                else if ("aeiouAEIOU".Contains(c))
                    vowels++;
                else if (char.IsLetter(c))
                    consonants++;
                else
                    special++;
            }

            Console.WriteLine("Vowels: " + vowels + ", Consonants: " + consonants + ", Digits: " + digits + ", Specials: " + special);
        }
        public static string ToProperCase(this string s)
        {
            s = s ?? "***";

            return string.Join(" ",
                s.Split(' ')
                .Where(w => w != "")
                .Select(w => char.ToUpper(w[0]) + w.Substring(1).ToLower())
            );
        }

        public static string Combine(this string s1, string s2)
        {
            return (s1 ?? "***") + " " + (s2 ?? "***");
        }
        public static string RemoveExtraSpaces(this string s)
        {
            return string.Join(" ", (s ?? "***")
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        public static int WordCount(this string s)
        {
            return (s ?? "***").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool ContainsSubstring(this string s, string sub)
        {
            return (s ?? "***").Contains(sub ?? "***");
        }
        public static int CountOccurrences(this string s, string sub)
        {
            s = s ?? "***";
            sub = sub ?? "***";

            int count = 0, i = 0;

            while ((i = s.IndexOf(sub, i)) != -1)
            {
                count++;
                i += sub.Length;
            }

            return count;
        }

    }


}  
