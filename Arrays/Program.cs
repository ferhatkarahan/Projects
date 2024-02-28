using System;
namespace Arrays
{
    class Program {

        static void Main(string[] args) {
            // string [] students=new string[3];
            // students[0]="ferhat";
            // students[1]="serhat";
            // students[2]="alican";
            // string[] students2={"ali","veli","hakkı","sinan"};
            // foreach (var student in students2)
            // {
            //     System.Console.WriteLine(student);
            // }
            int[] sayilar = { 10, -3, 5, 0, 33, -2, -60, 0, -20, -10 };
            System.Console.WriteLine("length "+sayilar.Length);

            int number1=new Random().Next(5);
            int number2=new Random().Next(5);

            int [,] regions=new int[number1,number2];
            // int [,] regions=new int[4,4];
           


            for (int i = 0; i < number1 ; i++)
            {
                
                for (int j = 0; j < number2; j++)
                {
                    regions[i,j]=new Random().Next(10);
                    System.Console.Write(regions[i,j]+"  ");
                    
                }
            System.Console.WriteLine();

                                
            }
            System.Console.WriteLine();
            System.Console.WriteLine("---------------- ffffffff-----------------------");
            System.Console.WriteLine();

            for (int i = 0; i < number1; i++)
            {
                var toplamSatir=0;
                
                for (int j = 0; j < number2; j++)
                {
                    
                    toplamSatir=toplamSatir+regions[i,j];
                }
                System.Console.WriteLine($"{i+1}. satır toplami: {toplamSatir}");
               
                
            }
            System.Console.WriteLine();
            System.Console.WriteLine("---------------- ffffffff-----------------------");
            System.Console.WriteLine();
            for (int j = 0; j < number2; j++)
            {
                
                var toplamSutun=0;
                for (int i = 0; i < number1; i++)
                {
                    toplamSutun=toplamSutun+regions[i,j];

                }
                    System.Console.WriteLine($"{j+1}. sütün toplami: {toplamSutun}");
                
               
                
            }

            
        
        }

    

   
    }
}
    
