using System;
using System.Diagnostics;

namespace VariousType
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Variaveis inteiras
            sbyte int_byte = 5;
            int inteiro = 10;
            ushort int_pequeno = 15;
            Console.WriteLine(int_byte + " " + inteiro + " " + int_pequeno);
            ///Variaveis char
            char coracao = '\u2661';
            char Seta_direita = '\u2192';
            Console.WriteLine(coracao + " " + Seta_direita);
            ///Variaveis reais
            float fl = 3.1415F;
            decimal De = 2.14M;
            Console.WriteLine(fl + " " + De);
            ///Variaveis boolean
            bool T = true;
            bool F = false;
            Console.WriteLine(T + " " + F);

        }
    }
}
