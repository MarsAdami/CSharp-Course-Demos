using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DowhileLoop();
            //ForEachLoop();

            if (IsPrimeNumber(73))
            {
                Console.WriteLine("This is Prime Number");
            }
            else 
            {
                Console.WriteLine("This is not a Prime Number");
            }


        }
        private static bool IsPrimeNumber(int number)
        {
            bool result=true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DowhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {

                Console.WriteLine(number);
                number--;
            }
        }


        private static void ForLoop()
        {
            for (int i = 1; i <= 256; i++)
            {
                Console.WriteLine(i);

            }
        }
    }
}
