using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            ///ex 6 
                double xx = 1.23456;
                int ii = 19;
                Console.WriteLine($"{xx:F2} " + " | " + $"{xx:P1}" + " | " + $"{ii:X}" + " | " + $"{ii:C}");


            ///Variaveis do tipo String
            string a = "\u2606";
            string b = "D:\\LP1\\Joao";
            string c = "Bye\\World \u269D";
            string d = "Hello World!";
            string e = "simbolos \u271E \u262d \u26A1";           
            Console.WriteLine(a + " | " + b + " | " + c + " | " + d +
             " | " + e);

            ///Mais variaveis do tipo String
            string f = "Hello " + 2 + " Times";
            string g = "ele disse" + d;
            string h = "look " + "at " + "me";
            string i = "um simbolo " + a + " muitos mais " + e;
            f += " Bye 12 times";
            string j = $"{a} mais {e} é igual a {a+e}";
            string k = $"uma pasta {b}";
            Console.WriteLine(f + " | " + g + " | " + h + " | " + i +
             " | " + j + " | " + k);


        }
    }
}
