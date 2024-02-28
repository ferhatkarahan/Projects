using System;


namespace Exceptions
{
    class Program {

        static void Main(string[] args)
        {
            // ExceptionIntro();
            
            HandleException(()=>
            {
                Find();

            });

        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            
                
            }
            catch (RecordNotFoundExceptions exception)
            {
                System.Console.WriteLine(exception.Message);
                
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Ferhat", "Şirin", "Ceren" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundExceptions("Record Not Found");
            }
            else
            {
                System.Console.WriteLine("Record Found!. ");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Ferhat", "Şirin", "Ceren" };
                students[3] = "Ahmet";
                System.Console.WriteLine(students[0]);
            }
            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex.Message);
                // System.Console.WriteLine(ex.InnerException);
                System.Console.WriteLine("Diziye eklenen adet dizinin boyutunu aşmıştır.");
            }
        }
    }
}