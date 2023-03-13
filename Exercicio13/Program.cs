namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pao, broa;
            double poupanca;


            Console.WriteLine("Digite a quantidade de pães vendidos. ");
            pao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de broas vendidos. ");
            broa = int.Parse(Console.ReadLine());

            double total = pao * 0.12 + broa * 1.50;
            poupanca = 10 * total / 100;

            Console.WriteLine("Total de pães vendidos: " + pao);
            Console.WriteLine("Total de broas vendidas: " + broa);
            Console.WriteLine("Total de vendas: " + total);
            Console.WriteLine("Total para guardar na poupança: " + poupanca);

        }
    }
}