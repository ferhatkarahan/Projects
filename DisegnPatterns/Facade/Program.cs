using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager=new ProductManager(new Log4NetAdapter());
            productManager.Save();
            Console.ReadLine();
        }
    }
    class NLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged with NLogger , {0}",message);
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }
    class EfLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged with EfLogger , {0}", message);

        }
    }
    class ProductManager
    {
        private ILogger _logger;
        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Save()
        {
            _logger.Log("User Data ");
            Console.WriteLine("Saved! ");
        }

    }
    class Log4NetAdapter : ILogger
    {
        Log4Net _log4Net;
        public void Log(string message)
        {
            _log4Net=new Log4Net();
            _log4Net.LogMessage("Log4Net kullanıldı.");
        }
    }
    class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged with Log4Net , {0}", message);
        }
    }      

}
