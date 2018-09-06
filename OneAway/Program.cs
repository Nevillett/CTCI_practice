using System;

namespace OneAway
{
    class Program
    {
        public bool OneEditReplace(string str1, string str2)
        {
            bool foundDifference = false;
            for ( int i = 0; i < str1.Length; i++ )
            {
                if (str1[i] != str2[i])
                {
                    if ( foundDifference )
                    {
                        return false;
                    }
                    foundDifference = true;
                }
            }
            return true;
        }
        public bool OneEditInsert(string str1, string str2)
        {
            int index1 = 0;
            int index2 = 0;
            while(index1 < str1.Length && index2 < str2.Length)
            {
                if (str1[index1] != str2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }else
                {   
                    index1++;
                    index2++;
                }
            }
            return true;
        }

        public bool OneEditAway(string first, string second)
        {
            if (first.Length == second.Length)
            {
                return OneEditReplace(first, second);
            }
            else if (first.Length + 1 == second.Length)
            {
                return OneEditInsert(first, second);
            }
            else if (first.Length - 1 == second.Length)
            {
                return OneEditInsert(second, first);
            }
            return false;
        }
///not entirely understand
        public bool OneEditAway2(string first, string second)
        {
            if (Math.Abs(first.Length - second.Length) > 1)
            return false;

            string s1 = first.Length < second.Length ? first : second;
            string s2 = first.Length < second.Length ? second : first;

            int index1 = 0;
            int index2 = 0;
            bool foundDifference = false;
            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (foundDifference) return false;
                    foundDifference = true;
                    if (s1.Length == s2.Length)
                    index1++;
                } else {
                    index1++;
                }
                index2++;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string a = "bpbie";
            string b = "apple";
            string c = "aple";
            Program p = new Program();
            var x = p.OneEditAway(a, b);
            var y = p.OneEditAway(c ,b);
            var z = p.OneEditAway2(b,c);
            Console.WriteLine("test replace is " + x);
            Console.WriteLine("test insert is " + y);
            System.Console.WriteLine(z);
        }
    }
}
