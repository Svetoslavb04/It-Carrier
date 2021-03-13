using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_series_of_equal_numbers
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int currSeriesStartIndex = -1;
            int currSeriesLength = 1;

            int bestSeriesStartIndex = -1;
            int bestSeriesLength = 1;

            List<int> bestSeries = new List<int>();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    currSeriesStartIndex = i - currSeriesLength;
                    currSeriesLength++;
                }
                else
                {
                    if (currSeriesLength > bestSeriesLength)
                    {
                        bestSeriesStartIndex = currSeriesStartIndex;
                        bestSeriesLength = currSeriesLength;

                        bestSeries.Clear();

                        MakeSeries(bestSeriesStartIndex, currSeriesStartIndex, bestSeriesLength, currSeriesLength, bestSeries, numbers);
                    }

                    currSeriesStartIndex = -1;
                    currSeriesLength = 1;
                }
                if (i == numbers.Count - 1 && bestSeries.Count == 0)
                {
                    bestSeriesStartIndex = currSeriesStartIndex;
                    bestSeriesLength = currSeriesLength;

                    bestSeries.Clear();

                    MakeSeries(bestSeriesStartIndex, currSeriesStartIndex, bestSeriesLength, currSeriesLength, bestSeries, numbers);
                }
            }

            Console.WriteLine(string.Join(" ", bestSeries));
        }

        public static void MakeSeries(int bestSeriesStartIndex, int currSeriesStartIndex, int bestSeriesLength, int currSeriesLength, List<int> bestSeries, List<int> numbers)
        {
            for (int j = bestSeriesStartIndex; j < bestSeriesStartIndex + bestSeriesLength; j++)
            {
                bestSeries.Add(numbers[j]);
            }
        }
    }
}
