namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento;

            Console.WriteLine("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine());

            double area = largura * comprimento;
            Console.WriteLine(area);

        }
    }
}