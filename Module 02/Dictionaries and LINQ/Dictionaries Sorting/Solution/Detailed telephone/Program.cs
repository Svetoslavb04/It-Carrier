using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detailed_telephone
{
    public class Program
    {
        public static void Main()
        {
            var telephone = new SortedDictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToList<string>();
                string command = input[0];

                if (command == "END")
                {
                    break;
                }
                if (command == "ListAll")
                {
                    foreach (var contact in telephone)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
                if (command == "A")
                {
                    string name = input[1];
                    string number = (input[2]);

                    if (telephone.ContainsKey(name))
                    {
                        telephone[name] = number;
                    }
                    else
                    {
                        telephone.Add(name, number);
                    }
                }
                if (command == "S")
                {
                    string name = input[1];

                    if (telephone.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {telephone[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
            }
        }
    }
}
