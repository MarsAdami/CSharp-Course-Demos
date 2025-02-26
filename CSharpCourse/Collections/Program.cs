using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();

            //List();

            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add("book","kitap");
            dictionary.Add("key", "anahtar");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["key"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("computer"));
            Console.WriteLine(dictionary.ContainsValue("kitap"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Serdar" });
            customers.Add(new Customer { Id = 2, FirstName = "Ayşegül" });



            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Zenb"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer(),
                new Customer()

            });

            Console.WriteLine(customers.Contains(customer1));
            //customers.Clear();

            var index = customers.IndexOf(customer1);
            Console.WriteLine("İndex:{0}", index);

            customers.Add(customer1);

            var index2 = customers.LastIndexOf(customer1);
            Console.WriteLine("index2 :{0}", index2);

            customers.Insert(0, customer1);
            customers.Remove(customer1);
            customers.RemoveAll(c => c.FirstName == "Zenb");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine("Count:{0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("Bursa");


            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
