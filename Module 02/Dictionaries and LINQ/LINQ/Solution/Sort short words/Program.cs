using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_short_words
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .ToList()
                .Distinct()
                .OrderBy(x => x);

            Console.WriteLine(string.Join(", ", text));
        }
    }
}
