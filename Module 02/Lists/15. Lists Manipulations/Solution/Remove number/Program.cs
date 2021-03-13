using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_number
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int removedNumbers = numbers[numbers.Count - 1];
            int n = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == removedNumbers)
                {
                    n++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                numbers.Remove(removedNumbers);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
