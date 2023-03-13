namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Informe o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine($"{a}, {b}, {c}");
                }
                else
                {
                    Console.WriteLine($"{a}, {c}, {b}");
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine($"{b}, {a}, {c}");
                }
                else
                {
                    Console.WriteLine($"{b}, {c}, {a}");
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine($"{c}, {a}, {b}");
                }
                else
                {
                    Console.WriteLine($"{c}, {b}, {a}");
                }
            }
        }
    }
}