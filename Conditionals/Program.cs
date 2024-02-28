namespace Conditionals;

class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine("bir sayi giriniz ");
        //int number=Convert.ToInt32(Console.ReadLine());
        //System.Console.WriteLine(number<100 ? "girdiğiniz sayi 100 den küçüktür": "girdiğiniz sayi 100 den büyüktür");


        Console.WriteLine("Bir sayi giriniz : ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number<100 ? "girdiğiniz sayı 100den kücüktür ":" Girdiğiniz sayi 100 den büyüktür. ");
        // if (number<100)
        // {

        //     System.Console.WriteLine("girdiğiniz sayi 100 den küçüktür ");

        // }else
        // {
        //     System.Console.WriteLine("girdiğiniz sayi 100 den büyüktür");
        // }
    }
}
