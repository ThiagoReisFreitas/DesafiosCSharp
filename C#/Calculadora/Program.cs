using System;

namespace Calcuradora
{
    class Program
    {
        static void Main(string[] args) // Programa principal
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Calculadora");
            Console.WriteLine();
            Console.WriteLine("Qual operação você quer fazer:\n 1 - Soma\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão\n 5 - Porcentagem\n 0 - Sair");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Selecione um valor");
            
            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 0 : System.Environment.Exit(0); break;
                case 1 : Soma(); break;
                case 2 : Subtracao(); break;
                case 3 : Multiplicacao(); break;
                case 4 : Divisao(); break;
                case 5 : Porcentagem(); break;
                default : Menu(); break;
            }
        }

        static void Soma() // metodo de soma/
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"A soma dos valores é {valor1 + valor2}");

            Console.ReadKey();
            Menu();
        }


        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"A subtração dos valores é {valor1 - valor2}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"A multiplicação dos valores é {valor1 * valor2}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine($"A divisão dos valores é {valor1 / valor2}");
            Console.ReadKey();
            Menu();
        }

        static void Porcentagem()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("A porcentagem do valor:");
            float valor2 = float.Parse(Console.ReadLine());

            float res = (valor1*valor2) / 100;

            Console.WriteLine($"{valor2}% de {valor1} é {res}");
            Console.ReadKey();

            Menu();
        }
    }
}