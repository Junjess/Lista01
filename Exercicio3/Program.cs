namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double altura, raio, volume;
           double pi = 3.14;

            Console.WriteLine("Digite a altura do cilindro ");
            altura=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do raio ");
            raio = double.Parse(Console.ReadLine());

            volume = altura * pi*(raio * raio);
            Console.WriteLine(volume);

        }
    }
}