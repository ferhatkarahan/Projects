using System;
using System.Globalization;
namespace Loops
{
    class Program {

        static void Main(string[] args)
        {
            //int number=new Random().Next(2,10);
            int sayac = 0;

            for (int number = 1; number < 100; number++) 
            {
                if (IsPrimeNumber2(number))
                {
                    sayac++;
                    Console.WriteLine($"Asal Sayidir. {number}");
                }
                

            }
            Console.WriteLine($"Asal sayi adedi : {sayac}");

            //if (IsPrimeNumber2(number))
            //{
            //    System.Console.WriteLine("Asal Sayidir. "+number);
            //}else
            //{
            //    System.Console.WriteLine("Asal Sayi değildir. "+number);
            //}




            // IsPrimeNumber();
            // forLoop();
            // WhileLoop();

        }
         private static bool IsPrimeNumber2(int number)
        {
            bool result = true;
            if (number == 1)
            {
                result = false;
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        i = number;
                    }
                }
                
            }
            return result;


        }

        private static void IsPrimeNumber()
        {
            int sayac = 0;
            // System.Console.Write("Bir sayi giriniz : ");
            // int number=Convert.ToInt32(Console.ReadLine());
            for (int number = 1; number < 7920; number++)
            {

                bool result = true;
                if (number == 1)
                {
                    result = false;
                    System.Console.WriteLine($"Girilen sayi {number} sayisidir ve Asal sayi Değildir.");

                }
                else if (number == 2)
                {
                    System.Console.WriteLine($"Girilen sayi {number} sayisidir ve sayi Asal sayidir.");
                    sayac = sayac + 1;

                }
                // else if (number % (i+) ==0)
                // {
                //     System.Console.WriteLine($"Girilen sayi {number} sayisidir ve Asal sayi Değildir.");
                //     break;

                //}
                else
                {
                    for (int i = 2; i <= (number + 1) / 2; i++)
                    {
                        if (number % i == 0)
                        {
                            result = false;
                            i = number;
                        }
                    }
                    if (result)
                    {
                        sayac = sayac + 1;
                        System.Console.WriteLine(number);
                    }


                }

            }
            System.Console.WriteLine("toplam asal sayi adedi: " + sayac);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                System.Console.WriteLine(number);
                number--;

            }
        }

        private static void forLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                System.Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}