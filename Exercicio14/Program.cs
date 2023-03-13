namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int idade, dias;
            int ano = 365;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            dias = idade * ano;

            Console.WriteLine(" " + nome + ", você já viveu " + dias + " dias.");
        }
    }
}