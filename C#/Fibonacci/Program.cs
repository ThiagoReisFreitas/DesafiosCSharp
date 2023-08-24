using System;
using NodaTime;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Clear();
            //SequenceWhile(3);
            //Console.WriteLine();
            SequenceFor(3);
        }

        static void SequenceFor(int quantidade)
        {
            Console.Clear();
            int v1 = 1;
            int v2 = 1;
            Console.Write($"{v1}, {v2}, ");
            for (var i = 3; i <= quantidade; i++)
            {
                int v3 = v1 + v2;
                v1 = v2 + v3;
                v2 = v1 + v3;    
                Console.Write($"{v3}, {v1}, {v2},");
            }
        }

        static void SequenceWhile(int quantidade)
        {
            int v1 = 1;
            int v2 = 1;
            Console.Write($"{v1}, {v2}, ");
            int valor = 3;
            while(valor <= quantidade)
            {
                int v3 = v1 + v2;
                v1 = v2 + v3;
                v2 = v1 + v3;
                Console.Write($"{v3}, {v1}, {v2},");
                valor++;
            }
        }
    }
}