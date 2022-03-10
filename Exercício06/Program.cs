using System;
using System.Linq;

namespace Exercício06
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = string.Empty;
            const string vogais = "AEIOUÁÀÄÉÈËÍÌÏÓÒÖÚÙÜaeiouáàäéèëíìïóòöúùü";
            const string consoantes = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";

            try
            {
                Console.WriteLine("Digite o seu nome:");
                frase = Console.ReadLine();


                int contador = frase.Count(x => vogais.Contains(x));
                int contador2 = frase.Count(x => consoantes.Contains(x));

                Console.WriteLine($"O seu nome contém {contador} vogais e {contador2} consoantes.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }
    }
}
