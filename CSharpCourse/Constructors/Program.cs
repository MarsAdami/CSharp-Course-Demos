using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager();
            customermanager.List();
           
            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2,"Computer");

            EmployeeManager employeemanager = new EmployeeManager(new DataBaseLogger());
            employeemanager.Add();

            PersonManager personmanager = new PersonManager("Product");
            personmanager.Add();

            Teacher.Number = 10;

            Utilities.Validate();

            Manager.Dosomething();
            Manager manager = new Manager();
            manager.Dosomething2();

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {
            
        }

        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }

        public void Add() 
        {
            Console.WriteLine("Added");
        }
    }
    class Product
    {
        public Product()
        {
            
        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

      
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to DataBase");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
            
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity=entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
            
        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void Dosomething()
        {
            Console.WriteLine("Done");
        }

        public void Dosomething2()
        {
            Console.WriteLine("Done 2");
        }
    }

    
}
