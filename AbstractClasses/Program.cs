using System;
using Inheritances;
namespace Program
{
    class Program {

        static void Main(string[] args) {
            // Database database=new SqlDatabase();
            // database.Add();
            // database.Delete();

            // Database database1=new OracleDatabase();
            // database1.Add();
            // database1.Delete();
            AccessDemo1 accessDemos=new AccessDemo1();
            accessDemos.AccessDemo();
            
            
        
        }   
    }
    abstract class Database
    {
        public void Add()
        {
            System.Console.WriteLine("Abstract Class add Default.");

        }
        public abstract void Delete();
    }
    class SqlDatabase : Database
    {
       public override void Delete()
        {
            System.Console.WriteLine("Abstract Class delete Sgl Database");
        }
    }
    class OracleDatabase : Database
    {
        public override void Delete()
        {
            System.Console.WriteLine("Abstract Class delete Oracle Database");
            
        }
    }
}
