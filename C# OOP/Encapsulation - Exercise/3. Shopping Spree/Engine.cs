using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P03.ShoppingSpree
{
    public class Engine
    {
        private List<Person> people;
        private List<Product> products;

        public Engine()
        {
            this.products = new List<Product>();
            this.people = new List<Person>();
        }

        public void Run()
        {
                AddPeople(people);
                AddProducts(products);



            while (true)
            {
                var currentCommand = Console.ReadLine();

                if (currentCommand == "END")
                {
                    break;
                }

                var currentCommandArgs = currentCommand.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string currentPersonToBuy = currentCommandArgs[0];
                string currentProductToBuy = currentCommandArgs[1];

                try
                {
                    Person person = people.First(p => p.Name == currentPersonToBuy);
                    Product product = products.First(p => p.Name == currentProductToBuy);

                    person.BuyProduct(product);

                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException ioe)
                {

                    Console.WriteLine(ioe.Message);
                }

            }

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }

        private static void AddProducts(List<Product> products)
        {
            var productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < productsInput.Length; i++)
            {
                var currentProductTokens = productsInput[i].Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = currentProductTokens[0];
                decimal cost = decimal.Parse(currentProductTokens[1]);

                Product product = new Product(name, cost);

                products.Add(product);
            }
        }

        private static void AddPeople(List<Person> people)
        {
            var peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < peopleInput.Length; i++)
            {
                string[] currentPeopleTokens = peopleInput[i].Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = currentPeopleTokens[0];
                decimal money = decimal.Parse(currentPeopleTokens[1]);

                Person person = new Person(name, money);

                people.Add(person);
            }
        }

    }
}
