using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture =
            CultureInfo.InvariantCulture;
            //pedir numeros
            Console.WriteLine("Introduza 4 numeros reais (um de cada vez)");
            string var1 = Console.ReadLine();
            string var2 = Console.ReadLine();
            string var3 = Console.ReadLine();
            string var4 = Console.ReadLine();
            //converter numeros
            float real1 = float.Parse(var1);
            float real2 = float.Parse(var2);
            float real3 = float.Parse(var3);
            float real4 = float.Parse(var4);
            //mostrar numeros
            Console.WriteLine(string.Format($" {real1,8:F2} "));
            Console.WriteLine(string.Format($" {real2,8:F2} "));
            Console.WriteLine(string.Format($" {real3,8:F2} "));
            Console.WriteLine(string.Format($" {real4,8:F2} "));
        }
    }
}
