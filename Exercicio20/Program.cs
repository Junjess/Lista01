﻿namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}