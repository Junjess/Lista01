namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;

            Console.Write("Informe a temperatura em Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em Celsius é: {celsius:F2}");
        }
    }
}