Console.WriteLine("Escreva um numeros");
int numeroUm = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva outro numero");
int numeroDois = int.Parse(Console.ReadLine());

int soma = numeroUm + numeroDois;

if (soma%2 == 0)
{
    Console.WriteLine("É Par!");
}
else
{
    Console.WriteLine("É Impar");
}