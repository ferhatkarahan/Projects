using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisegnPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customerManager=CustomerManager.GetCustomerManager();
            customerManager.Save();


        }
    }
}
