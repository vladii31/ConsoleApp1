using System;
namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(" Hur många kilometer vill du köra ?");
            int y = int.Parse(Console.ReadLine());
            int z = x * 500;
            int k = 300 + z + y;
            Console.WriteLine("Den totala suman blir " + k + "kr");
            Console.ReadKey();
        }
    }
}