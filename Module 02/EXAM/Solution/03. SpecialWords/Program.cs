using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SpecialWords
{
    public class Program
    {
        public static void Main()
        {
            int wordsNumber = int.Parse(Console.ReadLine());

            var startsEndsWithLetter = new List<string>();
            var moreThanTwoA = new List<string>();
            var nonSpecialWords = new List<string>();

            for (int i = 0; i < wordsNumber; i++)
            {
                string word = Console.ReadLine();

                bool isSpecial = false;

                string firstLetter = word[0].ToString();
                string lastLetter = word[word.Length - 1].ToString(); 

                
                if (firstLetter == lastLetter)
                {
                    startsEndsWithLetter.Add(word);
                    isSpecial = true;
                }

                int numberOfA = 0;

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == 'a')
                    {
                        numberOfA++;
                    }
                }

                if (numberOfA >= 2)
                {
                    moreThanTwoA.Add(word);
                    isSpecial = true;
                }

                if (isSpecial == false)
                {
                    nonSpecialWords.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", startsEndsWithLetter));
            Console.WriteLine(string.Join(", ", moreThanTwoA));
            Console.WriteLine(string.Join(", ", nonSpecialWords));
        }
    }
}
