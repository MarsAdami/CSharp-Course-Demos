using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Hdd = new Product(50);
            Hdd.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "Telefon";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                Hdd.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();

        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Telefon about to finish!!!!!!");
        }
    }
}
