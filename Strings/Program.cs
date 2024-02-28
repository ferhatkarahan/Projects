using System;
namespace Strings
{
    class Program {

        static void Main(string[] args)
        {
            // Intro();
            string sentence="My name is Kuzey Güney. ";
            var result=sentence.Length;
            var result2=sentence.Clone();
            var result3=sentence;
            bool result4=sentence.EndsWith("y");
            bool result5=sentence.StartsWith("M");
            var result6= sentence.IndexOf("n");
            var result7= sentence.LastIndexOf("y");
            var result8=sentence.Insert(0,"Hello, ");
            var result9=sentence.Substring(3,6);
            var result10=sentence.ToLower();
            var result11=sentence.ToUpper();
            var result12=sentence.Replace(" ","-");
            var result13=sentence.Remove(7);
             string[] result14=sentence.Split(" ");
             var result15=sentence.Trim();
             char [] result16=sentence.ToCharArray();

            // sentence="My name is Doğu Batı";
            // System.Console.WriteLine(result4);
            // System.Console.WriteLine(result5);
            // System.Console.WriteLine(result6);
            // System.Console.WriteLine(result7);
            // System.Console.WriteLine(result8);
            // System.Console.WriteLine(result9);
            // System.Console.WriteLine(result10);
            
            // System.Console.WriteLine(result11);
            // System.Console.WriteLine(result12);
            // System.Console.WriteLine(result13);
            //  System.Console.WriteLine(result14[1]);
            //  System.Console.WriteLine(result15);
            foreach (var item in result16)
            {
                System.Console.WriteLine(item);
            }

            // System.Console.WriteLine(result);
            // System.Console.WriteLine(result2);
            // System.Console.WriteLine(result3);


        }

        private static void Intro()
        {
            string city = "Ankara";
            string city2 = "İstanbul";
            System.Console.WriteLine("{0} {1}", city, city2);

            foreach (var item in city)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
