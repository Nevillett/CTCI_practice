using System;

namespace Rotate_Matrix
{
    class Program
    {
        public static void rotateMatrix(int n, int[,] matrix)
        {
            for(var layer = 0; layer < n/2; layer++)
            {   
                var first = layer;
                var last = n - 1 - layer;
                for(var i = first; i < last; i++)
                {
                    var offset = i - first;
                    var top = matrix[first, i];// save top

                    //left -> top
                    matrix[first,i] = matrix[last - offset, first];
                    //bottom -> left
                    matrix[last - offset, first] = matrix[last, last - offset];
                    //right -> bottom
                    matrix[last, last - offset] = matrix[i, last];
                    //top -> right
                    matrix[i, last] = top; 
                }

            }
        }

        public static int[,] rotateMatrix2(int n , int[,] matrix)
        {
            int[,] result = new int[n,n];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    result[i,j] = matrix[n - j - 1, i];
                    //For a -90 degrees rotation: ret[i][j] = matrix[j][n - i - 1]
                }
            }
            return result;
        }

        static void displayMatrix(int n, int[,] matrix)
        {
            for (int t = 0; t < n; t++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" " + matrix[t, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = 4;
            int [,] matrix = {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };
            displayMatrix(n, matrix);
            //rotateMatrix(n, matrix);
            //displayMatrix(n,matrix);
            var x = rotateMatrix2(n, matrix);
            displayMatrix(n, x);
        }
    }
}
