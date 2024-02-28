using System;
namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, ferhat!");
            // value Types
            short number1=32333;
            int number2=1112155545;
            long number3=3548956555555555555;
            byte number4=255;
            bool condition=false;
            char character='F';
            // var number5=10;
          
            //Referance Types
            string name="ferhat";
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine($"Number2 is {number2}"+" "+number2);
            Console.WriteLine("Number3 is : "+number3);
            Console.WriteLine("Number4 is {0}",number4);
            Console.WriteLine(condition);
            Console.WriteLine(character);
            Console.WriteLine(name);
            System.Console.WriteLine(Days.Saturday);



            // Console.ReadLine();
        }
        enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }
    }
}
