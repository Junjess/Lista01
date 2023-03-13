namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, salarioAumentado, salarioFinal;

            Console.Write("Informe o salário do funcionário: ");
            salario = double.Parse(Console.ReadLine());

            salarioAumentado = salario * 1.15;
            salarioFinal = salarioAumentado * 0.92;

            Console.WriteLine($"Salário inicial: R$ {salario:F2}");
            Console.WriteLine($"Salário com aumento de 15%: R$ {salarioAumentado:F2}");
            Console.WriteLine($"Salário final (descontando 8% de impostos): R$ {salarioFinal:F2}");

        }
    }
}