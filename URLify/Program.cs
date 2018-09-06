using System;

namespace URLify
{
    class Program
    {
        int CountSpaces(char[] input)
        {
            var spaceCount = 0;
            foreach (var c in input)
            {
                if ( c == ' ')
                spaceCount++;
            }
            return spaceCount;
        }
        void ReplaceSpaces1(char[] input, int length)
        {
            var spaceCount = CountSpaces(input);
            var index = length + spaceCount * 2;
            
            for (int i = length - 1; i >= 0; i--)
            {
                if (input[i] == ' ')
                {
                    input[index - 1] = '0';
                    input[index - 2] = '2';
                    input[index - 3] = '%';
                    index = index - 3;
                } else {
                    input[index - 1] = input[i];
                    index--;
                }
            }          
        }

        void ReplaceSpaces2(char[] input, int length)
        {
            var space = new[] { '0', '2', '%' };
            var spaceCount = CountSpaces(input);
            var index = length + spaceCount * 2;

            void SetChar(params char[] chars)
            {
                foreach( var c in chars)
                {
                    //Console.Write(index);
                    //Console.WriteLine(c);
                    input[--index] = c;
                    //Console.WriteLine(index);
                }
            }
            for ( var indexSource = length - 1; indexSource >= 0; indexSource--)
            {
                if (input[indexSource] == ' ')
                    SetChar(space);
                else SetChar(input[indexSource]);
            }
        }

        static void Main(string[] args)
        {
            const string input = "abc d e f";
            var arr = new char[input.Length + 3 * 2 + 1 ];
            for ( var i = 0; i < input.Length; i++)
            {
                arr[i] = input[i];
            }
            //var arr = input.ToCharArray();
            Program p = new Program();
            //p.ReplaceSpaces1(arr, input.Length);
            p.ReplaceSpaces2(arr, input.Length);
            var haha = new string(arr);
            Console.WriteLine("input is : {0}, haha is : {1}",input, haha);
        }
    }
}
