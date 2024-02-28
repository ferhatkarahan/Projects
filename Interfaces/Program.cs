using System;
namespace Interfaces
{
    class Program {

        static void Main(string[] args)
        {
            // Demo();
            // InterfacesIntro();
            ICustomerDal[] customerDals=new ICustomerDal[3]{new SqlCustomerDal(),new OracleCustomerDal(),new MysqlCustomerDal()};
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer() { Id = 1, FirstName = "Kuzey", LastName = "Güney", Address = "istanbul" };
            Student student = new Student() { Id = 2, FirstName = "Doğu", LastName = "Güney", Department = "Yazılım" };
            personManager.Add(customer);
            personManager.Add(student);

            System.Console.WriteLine(customer.Address);
        }

        interface IPerson
        {
             int Id { get; set; }
             string  FirstName { get; set; }
             string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string  Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
            
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                System.Console.WriteLine("Added ! "+person.FirstName);
            }
        }
    
    }
}
