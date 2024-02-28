using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities=new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName="ferhat"}, new Customer { FirstName = "serhat" });
            foreach (var customer in result2) 
            {
                Console.WriteLine(customer.FirstName);
            }
            
                
            Console.ReadLine();

        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items) 
        {
            return new List<T> ( items );
        }
    }
    class Product :IEntity
    {  

    }
    class Customer : IEntity
    {
        public string  FirstName { get; set; }
    }
    interface IEntity
    {
        
    }
    interface IProductDal : IRepository<Product>
    {
       
    }
    //interface ICustomerDal : IRepository<Customer>
    //{

    //}
    interface ICustomerDal : IRepository<Customer>
    {
        
    }
    //where T : struct    değer tipler için yazılır. where ifadesi kısıtlama işlemleri için kullanılır.
    interface IRepository<T> where T : class,IEntity,new() //referans type
    {
        List<T> GetAll();
        List<T> GetByName(string name);
        T GetById(int id);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
