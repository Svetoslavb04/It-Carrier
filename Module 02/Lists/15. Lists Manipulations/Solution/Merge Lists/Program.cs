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
            List<string> newLists = new List<string>();

            for (int i = 0; i < lists.Count; i++)
            {
                List<string> list = lists[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
                lists.RemoveAt(i);
                i--;
                list.Reverse();
                for (int j = 0; j < list.Count; j++)
                {
                    newLists.Add(list[j]);
                }
            }

            newLists.Reverse();

            Console.WriteLine(string.Join(" ",newLists));
        }
    }
}
