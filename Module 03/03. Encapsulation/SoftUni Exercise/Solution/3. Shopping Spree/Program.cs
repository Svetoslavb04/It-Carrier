using System;
using System.Collections.Generic;
using System.Linq;

namespace _ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            try
            {
                var people = new Dictionary<string, Person>();
                var products = new Dictionary<string, Product>();

                string[] peopleInfo = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);


                    for (int i = 0; i < peopleInfo.Length; i++)
                    {
                        string[] currentPersonInfo = peopleInfo[i].Split('=');
                        string name = currentPersonInfo[0];
                        double money = double.Parse(currentPersonInfo[1]);
                        Person person = new Person(name, money);
                        people[name] = person;
                    }

                    string[] productsInfo = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < productsInfo.Length; i++)
                    {
                        string[] currentProductInfo = productsInfo[i].Split('=');
                        string name = currentProductInfo[0];
                        double cost = double.Parse(currentProductInfo[1]);
                        Product product = new Product(name, cost);
                        products[name] = product;
                    }

                    while (true)
                {
                    var line = Console.ReadLine().Split();

                    if (line[0] == "END")
                    {
                        break;
                    }

                    var person = people[line[0]];
                    var product = products[line[1]];

                    if (person != null && product != null)
                    {
                        if (person.Money < product.Cost)
                        {
                            Console.WriteLine($"{person.Name} can't afford {product.Name}");
                        }
                        else
                        {
                            person.AddProduct(product);
                            Console.WriteLine($"{person.Name} bought {product.Name}");
                        }
                    }
                }

                foreach (var person in people)
                {
                    if (person.Value.BagOfProduct.Count == 0)
                    {
                        Console.WriteLine($"{person.Key} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Key} - {string.Join(", ", person.Value.BagOfProduct.Select(p => p.Name))}");
                    }
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
