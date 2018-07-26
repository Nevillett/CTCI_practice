using System;
using System.Collections.Generic;


namespace IsUnique
{   
     class Program
    {
        public bool IsUniqueChar(string str)
        {
            var hashset = new HashSet<char>();
            foreach( var c in str )
            {
                if (hashset.Contains(c)) 
                return false;
                hashset.Add(c);
            }
            return true;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string[] words = { "abcde", "hello", "apple", "kite", "padle"};

            foreach (var word in words)
            {
                Console.WriteLine( word + ":" + p.IsUniqueChar(word));
            }
            Console.WriteLine("Success!");
        }
    }
}
