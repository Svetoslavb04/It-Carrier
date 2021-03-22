using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_times
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine().ToLower().Split().ToList<string>();
            var dictionary = new Dictionary<string, int>();

            foreach (var word in line)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word,0);
                }
            }

            var bestList = new List<string>();

            foreach (var word in dictionary)
            {
                if (word.Value % 2 == 0)
                {
                    bestList.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", bestList));
        }
    }
}
