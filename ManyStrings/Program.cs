using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Variaveis do tipo String
            string a = "\u2606";
            string b = "D:\\LP1\\Joao";
            string c = "Bye\\World \u269D";
            string d = "Hello World!";
            string e = "varios simbolos \u271E \u262d \u26A1";           
            Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
        }
    }
}
