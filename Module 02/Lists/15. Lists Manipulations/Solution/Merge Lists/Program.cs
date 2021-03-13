using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Lists
{
    public class Program
    {
        public static void Main()
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();

            for (int i = 0; i < lists.Count; i++)
            {
                List<string> list = lists[i].Split(' ').ToList();
                lists.RemoveAt(i);

                for (int j = 0; j < list.Count; j++)
                {
                    lists.Add(list[j]);
                }
            }

            Console.WriteLine(string.Join(" ",lists));
        }
    }
}
