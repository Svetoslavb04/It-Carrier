using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_extremes
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int max = int.MinValue;
            int min = int.MaxValue;

            List<int> extremes = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == max || numbers[i] == min)
                {
                    extremes.Add(numbers[i]);
                }
            }

            extremes.Sort();

            Console.WriteLine(string.Join(" ", extremes));
        }
    }
}
