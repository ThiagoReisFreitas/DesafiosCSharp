//using System; //porque o using não esta sendo usado
//using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuWhile();
        }

        static void MenuWhile()
        {
            Console.Clear();
            
            Console.WriteLine("S - Segundo\nM - Minuto\n0 - Sair");
            Console.WriteLine("Quanto tempo você quer contar?");
            string entrada = Console.ReadLine().ToLower();
            if (entrada == "0")
            {
                Console.WriteLine("Cronometro finalizado...");
                System.Environment.Exit(0);
            }
            char tipo = char.Parse(entrada.Substring(entrada.Length - 1, 1));
            int tempo = int.Parse(entrada.Substring(0, entrada.Length - 1));
            if (tipo == 'm')
            {
                tempo *= 60;
            }
            Console.WriteLine("Tipo da Contagem\n N - Normal\n R - Reversa");
            char modo = char.Parse(Console.ReadLine().ToLower());
            StartWhile(tempo, modo);

        }

        static void StartWhile(int tempoCorrido, char entrada)
        {
            int tempoAtual = 0;
            
            if (entrada == 'n')
            {
                while(tempoAtual != tempoCorrido)
                {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
                }
            }
            if (entrada == 'r')
            {
                
                while(tempoCorrido != tempoAtual)
                {
                    Console.Clear();
                    Console.WriteLine(tempoCorrido);
                    tempoCorrido--;
                    Thread.Sleep(1000);
                }
            }
            Console.Clear();
            Console.WriteLine("Cronometro finalizado...");
            Thread.Sleep(2500);
            MenuWhile();
        }
        //O mesmo codigo so que diferente
        static void MenuFor()
        {
            Console.Clear();
            Console.WriteLine("Cronometro\n S - Segundos\n M - Minutos\n 0 - Sair\nQuanto tempo você quer contar?");
            string entrada = Console.ReadLine().ToLower();
            if (entrada == "0")
            {
                Console.Clear();
                Console.WriteLine("Cronometro finalizado...");
                System.Environment.Exit(0);
            }
            char tipo = char.Parse(entrada.Substring(entrada.Length - 1, 1));
            int tempo = int.Parse(entrada.Substring(0, entrada.Length - 1));
            if (tipo == 'm')
            {
                tempo *= 60;
            }
            Console.WriteLine("Tipo da Contagem\n N - Normal\n R - Reversa");
            char modo = char.Parse(Console.ReadLine().ToLower());
            StartFor(tempo, modo);
        }
        static void StartFor(int tempo, char modo)
        {   
            if (modo == 'n')
            {
                for(var i = 1; i <= tempo; i++)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            }
            if (modo == 'r')
            {
                for(var i = tempo; i >= 1; i--)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            }
            
            MenuFor();
        }
        static void Teste()
        {
            int comeco = 10;
            int final = 0;
            while(comeco != final)
            {
                //Console.WriteLine(como)
            }
        }
    }
}