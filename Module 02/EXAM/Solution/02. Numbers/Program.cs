using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var evenNumbers = new List<int>();
            var oddNumbers = new List<int>();
            var sumOfDigitsIsFiveNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];

                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }

                int sum = 0;

                string numberToString = number.ToString();

                for (int j= 0; j < numberToString.Length; j++)
                {
                    int digit = int.Parse(numberToString[j].ToString());

                    sum += digit;
                }

                if (sum.ToString().EndsWith("5"))
                {
                    sumOfDigitsIsFiveNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(", ", evenNumbers));
            Console.WriteLine(string.Join(", ", oddNumbers));
            Console.WriteLine(string.Join(", ", sumOfDigitsIsFiveNumbers));
        }
    }
}
