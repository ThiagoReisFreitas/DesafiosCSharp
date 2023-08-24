using System;
using System.IO;
using System.Text.RegularExpressions;

namespace EditorHTML
{
    public static class Leitor
    {
        public static void Show(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo de Leitura\n---------------");
            Replace(texto);
            //Abrir();
        }

        public static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo? ");
            var path = Console.ReadLine();
            using(var file = new StreamReader(path))
            {
                string texto = file.ReadToEnd();
                Console.WriteLine(texto);
            }
            Console.ReadLine();
            Menu.Show();
        }

        public static void Replace(string texto)
        {
            //tentar revolver usando Indexof 
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var palavras = texto.Split(' ');

            for(var i = 0; i < palavras.Length; i++)
            {
                if(strong.IsMatch(palavras[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        palavras[i].Substring(
                            palavras[i].IndexOf('>') + 1,
                            (
                                (palavras[i].LastIndexOf('<') - 1) - palavras[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(palavras[i]);
                    Console.Write(" ");
                }
            }
        }


    }
}