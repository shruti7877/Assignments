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
            if (s == null) s = "***";
            return s.Length;
        }

        public static bool IsPalindrome(this string s)
        {
            if (s == null) s = "***";
            s = s.ToLower().Replace(" ", ""); 
            string reversed = new string(s.Reverse().ToArray()); 
            return s == reversed; // 
        }
        public static string ReverseSentence(this string s)
        {
            if (s == null) s = "***";
            return new string(s.Reverse().ToArray());
        }

        public static void CountDetails(this string s)
        {
            if (s == null) s = "***";

            int vowels = 0, consonants = 0, digits = 0, special = 0;

            foreach (char c in s)
            {
                if (char.IsDigit(c)) digits++;
                else if ("aeiouAEIOU".Contains(c)) vowels++;
                else if (char.IsLetter(c)) consonants++;
                else special++;
            }

            Console.WriteLine("Vowels: " + vowels + ", Consonants: " + consonants + ", Digits: " + digits + ", Specials: " + special);
        }
        public static string ToProperCase(this string s)
        {
            if (s == null) s = "***";

            var words = s.Split(' ');
            string result = "";

            foreach (string word in words)
            {
                if (word != "")
                {
                    result += char.ToUpper(word[0]) + word.Substring(1).ToLower() + " ";
                }
            }
            return result.Trim(); 
        }

        public static string Combine(this string s1, string s2)
        {
            if (s1 == null) s1 = "***";
            if (s2 == null) s2 = "***";

            return s1 + " " + s2;
        }
        public static string RemoveExtraSpaces(this string s)
        {
            if (s == null) s = "***";

            string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words);
        }
        public static int WordCount(this string s)
        {
            if (s == null) s = "***";

            return s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool ContainsSubstring(this string s, string sub)
        {
            if (s == null) s = "***";
            if (sub == null) sub = "***";

            return s.Contains(sub);
        }

        public static int CountOccurrences(this string s, string sub)
        {
            if (s == null) s = "***";
            if (sub == null) sub = "***";

            int count = 0;
            int i = 0;

            while ((i = s.IndexOf(sub, i)) != -1)
            {
                count++;
                i += sub.Length;
            }

            return count;
        }

    }


}  
