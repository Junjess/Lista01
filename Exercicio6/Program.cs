namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.Write("Informe a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit:F2}");
        }
    }
}