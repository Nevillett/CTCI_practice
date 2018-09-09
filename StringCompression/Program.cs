using System;
using System.Text;

namespace StringCompression
{
    class Program
    {
        // using string concatenation; string.Concact()
        public static string compressFirst(string str)
        {
            string compressedString = "";
            int countConsective = 0;
            for (int i = 0; i < str.Length ; i++)
            {
                countConsective++;

                if (i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    compressedString +="" + str[i] + countConsective;               
                    //System.Console.WriteLine(compressedString);
                    countConsective = 0;
                }
            }
            return compressedString.Length < str.Length ? compressedString : str;
        }
        //using stringbuilder
        public static string compressSecond(string str)
        {
            StringBuilder sb = new StringBuilder();
            int countConsective = 0;
            for (int i = 0; i < str.Length; i++)
            {
                countConsective++;

                if( i + 1 == str.Length || str[i] != str[i + 1])
                {
                    sb.Append(str[i]);
                    sb.Append(countConsective);
                    countConsective = 0;
                }
            }
            return sb.Length < str.Length ? sb.ToString() : str;
        }

        static void Main(string[] args)
        {
            string str1 = "aabcccccaaa";
            string str2 = "aaabbcc";
            var result1 = compressFirst(str1);
            var result2 = compressSecond(str2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
