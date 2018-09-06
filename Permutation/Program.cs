using System;
using System.Collections.Generic;

namespace Permutation
{
    class Program
    {
        public bool IsPermutation1(string original, string testOne)
        {
            if (original.Length != testOne.Length)
            {
                return false;
            } 
            var originalAsArray = original.ToCharArray();
            Array.Sort(originalAsArray);
            original = new string(originalAsArray);

            var testOneAsArray = testOne.ToCharArray();
            Array.Sort(testOneAsArray);
            testOne = new string(testOneAsArray);

            return original.Equals(testOne);
        }

        public bool IsPermutation2(string original, string testOne)
        {
            if (original.Length != testOne.Length)
            {
                return false;
            } 

            var letterCount =  new Dictionary<char , int>();

            foreach (var c in original)
            {
                if(letterCount.ContainsKey(c))
                    letterCount[c]++;
                else
                    letterCount[c] = 1;
            }

            foreach (var c in testOne)
            {
                if(letterCount.ContainsKey(c))
                {
                    letterCount[c]--;
                    if (letterCount[c] < 0)
                    {
                        return false;
                    }
                } else return false;
            }
 
            return true;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string[][] pairs = 
            {
                new string[]{"apple", "papel"},
                new string[]{"carrot", "tarroc"},
                new string[]{"hello", "llloh2"}
            };
            foreach (var pair in pairs)
            {
                var word1 = pair[0];
                var word2 = pair[1];
                var result = p.IsPermutation2(word1, word2);
                Console.WriteLine("{0}, {1}, {2}", word1, word2, result);
            }
        }
    }
}
