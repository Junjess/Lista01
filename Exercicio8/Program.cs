namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;

            Console.Write("Informe o raio da lata de óleo: ");
            raio = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura da lata de óleo: ");
            altura = double.Parse(Console.ReadLine());

            volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume da lata de óleo é: {volume:F2} unidades de volume");

        }
    }
}