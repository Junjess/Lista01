using System;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Digite o número desejado: ");
            n1=int.Parse(Console.ReadLine());

            if(n1%1==0&&n1%n1==0)
            {
                Console.WriteLine("Número é primo");
            }
            else
            {
                Console.WriteLine("Número não é primo");
            }
        }
    }
}