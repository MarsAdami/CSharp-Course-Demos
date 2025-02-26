using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İntro();

            string sentence = "My name is Ayşegül";

            var result=sentence.Length;
            var result2=sentence.Clone();
            sentence = "My name is Serdar";

            bool result3=sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My");
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7= sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4);
            var result10=sentence.ToLower();
            var result11=sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2, 4);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
        }

        private static void İntro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0])

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
