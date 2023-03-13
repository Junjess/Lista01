namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, volume;

            Console.WriteLine("Digite a largura do retângulo");
            a= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a largura do retângulo");
            b= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a largura do retângulo");
            c = int.Parse(Console.ReadLine());

            volume=a*b*c;
            Console.WriteLine(volume);
        }
    }
}