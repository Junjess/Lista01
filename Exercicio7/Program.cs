namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase, totalVendas, comissao, salarioTotal;

            Console.Write("Informe o salário base do vendedor: ");
            salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Informe o total de vendas: ");
            totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Informe o percentual de comissão (em %): ");
            comissao = double.Parse(Console.ReadLine());

            salarioTotal = salarioBase + (totalVendas * comissao / 100);

            Console.WriteLine($"O salário total do vendedor é: {salarioTotal:F2}");
        }
    }
}