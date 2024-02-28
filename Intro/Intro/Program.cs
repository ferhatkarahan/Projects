using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager manager = new CourseManager(new CourseDal());
            List<Course> courses = manager.GetAll();
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine(courses[i].Name + " / " + courses[i].Price );
            }

            IndividualCustomer customer1  = new IndividualCustomer();
            customer1.Id = 1;
            customer1.NationalIdentity = "5544332211";
            customer1.FirstName = "kuzey";
            customer1.LastName = "güney";
            customer1.CustomerNumber = "1111";

            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.Id = 1;
            customer2.NationalIdentity = "55443322";
            customer2.FirstName = "kuzey";
            customer2.LastName = "doğu";
            customer2.CustomerNumber = "2222";

            CorporateCustomer customer3 = new CorporateCustomer();
            customer3.Id = 1;
            customer3.Name = "Alfa";
            customer3.CustomerNumber = "3333";
            customer3.TaxNumber = "554433";
            
            

            CorporateCustomer customer4 = new CorporateCustomer();
            customer4.Id = 1;
            customer4.Name = "Gama";
            customer4.CustomerNumber = "4444";
            customer4.TaxNumber = "5544";

            BaseCustomer[] customers = {customer1,customer2,customer3,customer4 };
            foreach (var item in customers)
            {
                Console.WriteLine(item.CustomerNumber);
            }

            Console.ReadLine();
        }
    }
}
