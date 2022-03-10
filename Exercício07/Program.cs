using System;

namespace Exercício07
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o seu nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a sua idade:");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 0 && idade <= 19)
                {
                    Console.WriteLine("Você é jovem!");
                }
                else if (idade >= 20 && idade <= 59)
                {
                    Console.WriteLine("Você é adulto!");
                }
                else if (idade >= 60)
                {
                    Console.WriteLine("Você é idoso!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro: { e.Message}");
            }
        }
    }
}
