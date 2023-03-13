namespace Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número máximo para a sequência de Fibonacci: ");
            int maximo = int.Parse(Console.ReadLine());

            int anterior = 0;
            int atual = 1;
            Console.Write("Sequência de Fibonacci: ");

            while (atual <= maximo)
            {
                Console.Write(atual);
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
                if (atual <= maximo)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}