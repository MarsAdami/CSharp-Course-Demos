using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DataBaseLogger();
            customerManager.Add();

        }
    }

    class CustomerManager
    {
        public void Add()
        {
            DataBaseLogger logger = new DataBaseLogger();
            logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }

    class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
