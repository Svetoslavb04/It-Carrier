using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_reversed_numbers
{
    public class Program
    {
        public static void Main()
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<int> reversedNumbers = new List<int>();

            foreach (var number in numbers)
            {
                string reversedNumber = Reverse(number);
                reversedNumbers.Add(int.Parse(reversedNumber));
            }

            int sum = 0;

            foreach (var number in reversedNumbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
