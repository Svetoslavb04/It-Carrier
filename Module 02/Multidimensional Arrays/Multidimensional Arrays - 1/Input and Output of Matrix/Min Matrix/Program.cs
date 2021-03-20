using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Matrix
{
    static class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows + 1, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            for (int i = 0; i < cols; i++)
            {
                List<int> numbers = new List<int>();

                for (int j = 0; j < rows; j++)
                {
                    numbers.Add(matrix[j,i]);
                }
                matrix[rows, i] = numbers.Min();
            }

            for (int row = 0; row < rows + 1; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"     {matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
