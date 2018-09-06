using System;

namespace MatrixPrint
{
    class Program
    {
        static void Display (string str)
        {
            int len = str.Length;
            char[,] matrix = new char[len ,len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    matrix[i ,j] = 'x';
                }
            }
            int m = len / 2;
            for (int i = 0; i < len; i++)
            {
                matrix[m ,i] = str[i];
                matrix[i ,m] = str[i];
            }

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(matrix[i ,j] + " ");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            string x = "PICTURE";
            Display(x);
            string test = "haha\0test";
            System.Console.WriteLine(test);
        }
    }
}
