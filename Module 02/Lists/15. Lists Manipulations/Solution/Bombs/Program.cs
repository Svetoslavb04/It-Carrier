using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombs
{
    public class Program
    {
        public static void Main()
        {
            List<int> bombs = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = line[0];
            int radius = line[1];

            int sum = 0;

            for (int i = 0; i < bombs.Count; i++)
            {
                if (bombs[i] == bomb)
                {
                    int n = 0;
                    ///left
                    if (i - radius < 0)
                    {
                        if (i - radius < 0)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                bombs.RemoveAt(j);
                                n++;
                            }
                        }
                    }
                    else
                    {   /// 1 4 4 2 8 9 1 /// 1 4 2 8 9 1 /// 1 4 8 9 1
                        for (int lt = 0; lt < radius; lt++)
                        {
                            bombs.RemoveAt(i - radius + lt);
                            i--;
                        }
                    }

                    ///right


                    if (i + radius >= bombs.Count)
                    {
                        i -= n;

                        for (int k = bombs.Count - 1; k > i; k--)
                        {
                            bombs.RemoveAt(k);
                        }
                    }
                    else
                    {                                 
                        for (int rt = 0; rt < radius; rt++)
                        {
                            bombs.RemoveAt(i + radius - rt);
                        }
                    }
                    bombs.Remove(bomb);
                    i--;
                }
            }

            Console.WriteLine(bombs.Sum());
        }
    }
}
