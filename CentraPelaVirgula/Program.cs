using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir numeros
            Console.WriteLine("Introduza 4 numeros reais (um de cada vez)");
            string var1 = Console.ReadLine();
            string var2 = Console.ReadLine();
            string var3 = Console.ReadLine();
            string var4 = Console.ReadLine();
            //converter numeros
            
            //mostrar numeros
            Console.WriteLine($" {var1:F2} ");
        }
    }
}
