using System;

namespace Exercício_04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escreva sua data de nascimento:");
                DateTime data = DateTime.Parse(Console.ReadLine());

                int idade = DateTime.Today.Year - data.Year;

                if (DateTime.Today.DayOfYear < data.DayOfYear)
                {
                    idade = idade - 1;

                    Console.WriteLine($"Você tem {idade} anos!");
                } else if (DateTime.Today.Year == data.DayOfYear) {
                    Console.WriteLine("Você tem 0 anos!");
                }
                else
                {

                    Console.WriteLine($"Você tem {DateTime.Today.Year - data.Year} anos!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Tente novamente!");
            }
        }
    }
}
