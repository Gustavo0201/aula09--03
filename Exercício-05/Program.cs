using System;

namespace Exercício_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = string.Empty;
            int valor2;
            float valor3;
            float valor4;
            float valorFinal;
            try
            {
                do
                {
                    Console.WriteLine("=================================");
                    Console.WriteLine("Escolha a operação matemática:");
                    Console.WriteLine("1 - Soma");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    Console.WriteLine("5 - Resto de Divisão");
                    Console.WriteLine("=================================");

                    valor2 = int.Parse(Console.ReadLine());

                    switch (valor2)
                    {
                        case 1:
                            Console.WriteLine("Digite o primeiro valor:");
                            valor3 = float.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o segundo valor:");
                            valor4 = float.Parse(Console.ReadLine());

                            valorFinal = valor3 + valor4;
                            Console.WriteLine($"Resultado: {valorFinal}");
                            Console.WriteLine("=========================");

                            break;
                        case 2:
                            Console.WriteLine("Digite o primeiro valor:");
                            valor3 = float.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o segundo valor:");
                            valor4 = float.Parse(Console.ReadLine());

                            valorFinal = valor3 - valor4;

                            Console.WriteLine($"Resultado: {valorFinal}");
                            Console.WriteLine("=========================");
                            break;
                        case 3:
                            Console.WriteLine("Digite o primeiro valor:");
                            valor3 = float.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o segundo valor:");
                            valor4 = float.Parse(Console.ReadLine());

                            valorFinal = valor3 * valor4;

                            Console.WriteLine($"Resultado: {valorFinal}");
                            Console.WriteLine("=========================");
                            break;
                        case 4:
                            Console.WriteLine("Digite o primeiro valor:");
                            valor3 = float.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o segundo valor:");
                            valor4 = float.Parse(Console.ReadLine());

                            valorFinal = valor3 / valor4;

                            Console.WriteLine($"Resultado: {valorFinal}");
                            Console.WriteLine("=========================");
                            break;
                        case 5:
                            Console.WriteLine("Digite o primeiro valor:");
                            valor3 = float.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o segundo valor:");
                            valor4 = float.Parse(Console.ReadLine());

                            valorFinal = valor3 % valor4;

                            Console.WriteLine($"Resultado: {valorFinal}");
                            Console.WriteLine("=========================");

                            break;
                    }

                    Console.WriteLine("Digite 1 para escolher outra operação ou qualquer tecla para sair");
                    valor = (Console.ReadLine());
                } while (valor == "1");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
