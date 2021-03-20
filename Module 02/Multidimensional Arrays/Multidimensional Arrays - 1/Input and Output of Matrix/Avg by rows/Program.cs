using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avg_by_rows
{
    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < rows; row++)
            {
                double avg = 0;
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"         {matrix[row, col]}");
                    avg += matrix[row, col];
                }
                Console.Write($"         {avg/cols}");
                Console.WriteLine();
            }
        }
    }
}
