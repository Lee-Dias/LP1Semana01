using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero inteiro");
            string str = Console.ReadLine();
            int i = int.Parse(str);
            Console.WriteLine("Insira um numero real");
            str = Console.ReadLine();
            float f = float.Parse(str);
        }
    }
}
