using System;

namespace SomaDosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numeroUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            int numeroDois = int.Parse(Console.ReadLine());

            int soma = numeroUm + numeroDois;

            Console.WriteLine("A soma dos valores é " + soma);

        }
    }
}