using System;
namespace Constructors
{
    class Program {

        static void Main(string[] args) {
            EmployeeManager employeeManager=new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();
            
        
        }   
    }
    interface ILogger
    {
        void Logger();
    }

    class DatabaseLogger : ILogger
    {
        public void Logger()
        {
            System.Console.WriteLine("Logged to Database! ");
        }
    }
    class FileLogger : ILogger
    {
        public void Logger()
        {
         System.Console.WriteLine("Logged to File! ");

        }
    }
    class SmsLogger : ILogger
    {
        public void Logger()
        {
            System.Console.WriteLine("Logged to Sms! ");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        
        public EmployeeManager(ILogger logger)
        {
            _logger=logger;
        }
        public void Add(){
            _logger.Logger();
            System.Console.WriteLine("Added! ");
        }
        
    }

}
