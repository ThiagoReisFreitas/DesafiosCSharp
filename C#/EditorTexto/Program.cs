using System;
using System.IO;

namespace EditorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Oque você quer fazer?\n 1 - Abrir um arquivo\n 2 - Criar um arquivo\n 0 - Sair");
            short opcao = short.Parse(Console.ReadLine());
            
            switch(opcao)
            {
                case 0 : System.Environment.Exit(0); break;
                case 1 : Abrir() ; break;
                case 2 : Editar() ; break;
                default : Menu() ; break; 
            }
        }
        
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();
            using(var file = new StreamReader(path))
            {
                string texto = file.ReadToEnd();
                Console.WriteLine(texto);
            }
            Console.ReadLine();
            Menu();
        }
        
        static void Editar() // Essa função sempre funcionou eu que sou desprovido de inteligencia
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)\n----------------------------------");
            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
                
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);
            Salvar(texto);

        }
        static void EditarDois()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo\n------------------------------------------------");         
            string texto = "";
            while (true)
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            Console.WriteLine(" Salvando texto...");
            Console.ReadLine();
            Salvar(texto);
        }
        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(texto);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Menu();
        }    
    }
}