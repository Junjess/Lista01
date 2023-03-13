namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume, raio;
            double pi = 3.14;

            Console.WriteLine("Digite o valor do raio");
            raio=double.Parse(Console.ReadLine());

            volume = (4 / 3) * pi * (raio * raio * raio);
            Console.WriteLine(volume);

        }
    }
}