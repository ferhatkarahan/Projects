using System;
using System.Collections;
namespace Collections
{
    class Program {

        static void Main(string[] args)
        {
            // ArrayList();
            List<string> cities =new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add("izmir");
            foreach (var city in cities)
            {
                System.Console.WriteLine(city);
            }
            List<Customer> customers =new List<Customer>()
            {
                new Customer{Id=1,FirstName="ferhat"},
                new Customer{Id=2,FirstName="derin"}
            };
             List<Customer> customers2 =new List<Customer>()
            {
                new Customer{Id=4,FirstName="serhat"},
                new Customer{Id=5,FirstName="sude"}
            };
                
            customers.Add(new Customer{Id=3,FirstName="şirin"});
         

            
            
            customers.AddRange(customers2);
            // customers.Clear();
            customers.Remove(customers2[0]);
            customers.Insert(0,customers2[0]);
            System.Console.WriteLine(customers.Contains(customers2[0]));


               foreach (var Customer in customers)
            {
                System.Console.WriteLine(Customer.FirstName);
            }
            var count =customers.Count;
            System.Console.WriteLine(count);

        }

        private static void ArrayList()
        {
            // string [] cities=new string[2]{"Ankara","İstanbul"};
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add('A');
            cities.Add(1);

            foreach (var city in cities)
            {
                System.Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
    }
}
