// Given astring, remove adjacent duplicate characters from string.
// Finally ,Theoutput string should not have any adjacent duplicates. See following examples.
// Input:  abccbcy
// Output: acy
// First "abccbcy" is reducedto "abbcy". 
// This outputstring "abbcy" again contains duplicates,  so it is further reduced to"acy".
// https://codereview.stackexchange.com/questions/133729/remove-adjacent-duplicate-characters

using System;
using System.Text;

namespace RemAdjacentDup
{
    class Program
    {
        public static string remDup(string str)
        {
            StringBuilder sb = new StringBuilder();
            if (str.Length > 0)
            {
                char prev = str[0];
                sb.Append(prev);
                for (int i = 0; i < str.Length; ++i)
                {
                    char current = str[i];
                    if (current != prev)
                    {
                        sb.Append(current);
                        prev = current;
                    }
                }
            }
            return sb.ToString();
        }
///
        public static string remAdjDup(string str)
        {
            char[] chars = str.ToCharArray();
            int len = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if ( len == 0 || chars[i] != chars[len - 1])
                {
                    chars[len++] = chars[i];
                } else
                {
                    len--;
                }
            }
            return new string(chars, 0, len);
        }

        public static string remAdjDup3(string str)
        {
            StringBuilder sb = new StringBuilder();

            for ( int i = 0; i < str.Length; i++)
            {
                char inputChar = str[i];
                int preIndex = sb.Length - 1;
                
                if (preIndex >= 0 && inputChar == sb[preIndex])
                    sb.Remove(preIndex, 1);
                else
                    sb.Append(inputChar);
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            string x = "aabccbydd";
            var result1 = remDup(x);
            var result2 = remAdjDup3(x);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
