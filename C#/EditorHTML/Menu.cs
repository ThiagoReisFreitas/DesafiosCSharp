using System;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            
            DesenhaTela();
            OpcaoEscrita();

            var opcao = short.Parse(Console.ReadLine());

            ManipulacaoMenu(opcao);
        }
        public static void DesenhaTela()
        {
            Linha("+", 30, "-");

            for (int linha = 0; linha <= 10; linha++)
            {
                Linha("|", 30, " ");
            }
            
            Linha("+", 30, "-");

        }
        public static void Linha(string divisao, int valor, string modelo)
        {
            Console.Write(divisao);
            for(int i = 0; i <= valor; i++)
            {
                Console.Write(modelo);
            }
            Console.Write(divisao);
            Console.Write("\n");
        }
        public static void OpcaoEscrita()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("==========================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");
        }

        public static void ManipulacaoMenu(short opcao)
        {
            switch(opcao)
            {
                case 0 : Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); Environment.Exit(0); break;
                case 1 : Editor.Show(); break;
                case 2 : ; break;
                default:Console.Clear(); Show(); break;
            }
            
        }
    }
}