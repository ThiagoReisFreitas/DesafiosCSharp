using System;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("===========");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
                
            } while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Console.WriteLine("DDeseja salvar o arquivo?\n S - Sim\n N - Não");
            var confirma = Console.ReadLine().ToUpper();

            switch(confirma)
            {
                case "S": Salvar(file); break;
                case "N": Console.BackgroundColor = ConsoleColor.Black; Menu.Show(); break;
            }

            //Salvar(file);
        }

        public static void Salvar(StringBuilder arq)
        {
            Console.Clear();
            Console.WriteLine("QQual caminho para salvar o arquivo? ");
            var path = Console.ReadLine();
            using(var file = new StreamWriter(path))
            {
                file.Write(arq);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso");
            Console.ReadLine();
            Leitor.Show(arq.ToString());
            
            Menu.Show();
        }
    }
}