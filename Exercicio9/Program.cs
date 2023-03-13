namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double nota, media, mediaTotal = 0;
            double totalNota;
            Console.WriteLine("Digite quantas notas são: ");
            int quantNotas = int.Parse(Console.ReadLine());

            for (i = 0; i < quantNotas; i++)
            {
                Console.WriteLine("Digite a nota: ");
                nota = double.Parse(Console.ReadLine());

                media = (1 / nota);
                mediaTotal = mediaTotal + media;
            }
            totalNota = quantNotas / mediaTotal;
            Console.WriteLine(totalNota);
        }
    }
}