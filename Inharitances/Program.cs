using System;
namespace Inheritances
{
    class Program {

        static void Main(string[] args) {
            // Person[] persons=new Person[3]
            // {
            //     new Customer{FirstName="ferhat"},
            //     new Student{FirstName="serhat"},
            //     new Person{FirstName="ramazan"}
            // };
            // foreach (var person in persons)
            // {
            // System.Console.WriteLine(person.FirstName);
                
            // }

            Customer customer =new Customer();
            customer.NumberAdd();
            Student student=new Student();
            student.NumberAdd();
            
        
        }   
    }
    class Person
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
       
        public virtual void NumberAdd()
        {
            System.Console.WriteLine("Person Added");
        }
        
    }class Customer : Person
    {
        public override void NumberAdd()
        {
            System.Console.WriteLine("Customer Added");
            // base.NumberAdd();
        }
        public string Address { get; set; }
    }
    class Student : Person
    {
        public override void NumberAdd()
        {
            System.Console.WriteLine("Student Added");
            base.NumberAdd();
        }
        public string Department { get; set; }
    }
    public class AccessDemo1
    {
        public void AccessDemo(){
        System.Console.WriteLine("farklı projelerden classlara erişim sağlandı. ");

        }
    }
}
