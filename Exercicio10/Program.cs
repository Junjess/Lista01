namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, peso1, peso2, media;

            Console.Write("Informe a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o peso da primeira nota: ");
            peso1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Informe o peso da segunda nota: ");
            peso2 = double.Parse(Console.ReadLine());

            media = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine($"A média ponderada das notas é: {media:F2}");
        }
    }
}