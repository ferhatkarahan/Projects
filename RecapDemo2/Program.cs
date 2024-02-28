using System;
namespace RecapDemo2
{
    class Program {

        static void Main(string[] args) {
            CustomerManager customerManager=new CustomerManager();
            customerManager.Logger=new DatabaseLogger();
            customerManager.Add();
            
        
        }   
    }
    interface ILogger
    {
        void Log();
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add(){
            Logger.Log();
            System.Console.WriteLine("Added!. ");
        }
        
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Database logged");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("File logged");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Sms logged");
        }
    }

}