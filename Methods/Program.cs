

namespace Methods;

class Program
{
        
    static void Main(string[] args)
    {
        
        // System.Console.Write("bir sayi giriniz : ");
        // var sayi1=Convert.ToInt32(Console.ReadLine());

        // System.Console.Write("bir sayi giriniz : ");
        // var sayi2=Convert.ToInt32(Console.ReadLine());
        // Toplam(sayi1,sayi2);
        // int number1=30;
        // int number2=40;
        // Toplam();
        System.Console.WriteLine(Add( 1,2,3,4,5,6,7));
        // System.Console.WriteLine(number1);
        

       

        
    }
    static void Toplam()
    {
        System.Console.Write("bir sayi giriniz : ");
        var sayi1=Convert.ToInt32(Console.ReadLine());

        System.Console.Write("bir sayi giriniz : ");
        var sayi2=Convert.ToInt32(Console.ReadLine());
        var result=sayi1+sayi2;
        
        System.Console.WriteLine(result);    

        
    }
    static int Add( params int[] numbers)
    {
        // number1=40;
        int size =numbers.Length;
        bool IsTrue=numbers.Contains(0);
        Console.WriteLine(size +"  "+IsTrue);
        return numbers.Sum();

    }
}
