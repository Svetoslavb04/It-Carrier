using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_sum
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            int k = numbers.Count / 4;

            var firstNumbers = numbers.Take(k).Reverse().ToList();
            numbers.RemoveRange(0, k);
            numbers.Reverse();
            var secondNumbers = numbers.Take(k).ToList();
            numbers.RemoveRange(0, k);
            numbers.Reverse();

            var finalNumber = new List<int>();

            for (int i = 0; i < firstNumbers.Count; i++)
            {
                finalNumber.Add(firstNumbers[i]);
            }

            for (int i = 0; i < firstNumbers.Count; i++)
            {
                finalNumber.Add(secondNumbers[i]);
            }

            var summedNumbers = new List<int>();

            for (int i = 0; i < finalNumber.Count; i++)
            {
                summedNumbers.Add(finalNumber[i] + numbers[i]);
            }

            Console.WriteLine(string.Join(" ", summedNumbers));
        }
    }
}
