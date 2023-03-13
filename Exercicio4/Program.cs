namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmInicial, kmFinal, consumo, combustivelGasto, consumoPorKm;

            Console.Write("Informe a quilometragem inicial: ");
            kmInicial = double.Parse(Console.ReadLine());

            Console.Write("Informe a quilometragem final: ");
            kmFinal = double.Parse(Console.ReadLine());

            Console.Write("Informe o consumo de combustível (em litros): ");
            consumo = double.Parse(Console.ReadLine());

            combustivelGasto = kmFinal - kmInicial;
            consumoPorKm = consumo / combustivelGasto;

            Console.WriteLine($"O consumo por km foi de: {consumoPorKm:F2} litros/km");
        }
    }
}