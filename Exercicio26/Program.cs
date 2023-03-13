namespace Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor para A: ");
            int a = int.Parse(Console.ReadLine());

            int resultado = 1;
            Console.Write($"{a}! = ");

            for (int i = a; i > 1; i--)
            {
                resultado *= i;
                Console.Write($"{i} x ");
            }

            Console.WriteLine($"1 = {resultado}");
        }
    }
}