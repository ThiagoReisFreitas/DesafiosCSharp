using System;
using System.Text;

namespace AprendendoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
           Construtor();
        }
        static void AprendendoGuid()
        {
             var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("8a60d29d-3474-4fe9-bfec-48ffacae0dc3");
            //Console.WriteLine(id.ToString().Substring(0, 8));
            id = new Guid();
            Console.WriteLine(id);
        }

        static void InterpolacaoDeStrings()
        {
            var price = 10.2;
            //var texto = string.Format("O preço do produto é {0}", price);
            var texto = $@"O preço do produto é 
            {price} apenas na promoção";
            Console.WriteLine(texto);
        }

        static void ComparandoStrings()
        {
            var texto = "Este texto é um teste";
            //Console.WriteLine(texto.CompareTo("Testando"));
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
        } 

        static void StartEndWith()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("---------------------------");

            Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.EndsWith("teste"));

        }

        static void MetodoEquals()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
        }

        static void Indice()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s"));
        }

        static void MetodosAdcionais()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.Insert(5, "AQUI "));
            Console.WriteLine(texto.Remove(5, 5));
            Console.WriteLine(texto.Length);
        }

        static void ManipulandoStrings()
        {
            var texto = "   Este texto é um teste  ";
            Console.WriteLine(texto.Replace("Este", "Isto"));
            
            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);

            var resultado = texto.Substring(5, 5);
            Console.WriteLine(resultado);

            //Limpa os espaços desnecessarios no começo e no final da string
            Console.WriteLine(texto.Trim());
        }

        static void Construtor()
        {
            var texto = new StringBuilder();
            texto.Append("Este texto é um texte");
            texto.Append("Do teste de texto");
            texto.Append("Testando o texto do teste");

            texto.ToString();
            Console.WriteLine(texto);
        }
    }
}