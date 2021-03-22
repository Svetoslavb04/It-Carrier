using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_numbers
{
    public class Program
    {
        public static void Main()
        {
            var sortedDic = new SortedDictionary<double, int>();

            var line = Console.ReadLine().Split().ToArray();

            foreach (var item in line)
            {
                if (sortedDic.ContainsKey(double.Parse(item)))
                {
                    sortedDic[double.Parse(item)]++;
                }
                else
                {
                    sortedDic.Add(double.Parse(item), 1);
                }
            }

            foreach (var item in sortedDic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
