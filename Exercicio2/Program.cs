using System;

namespace Exercicio2
{
    class Program
    {
        private const string _sim = "SIM";

        static void Main(string[] args)
        {
            string continuar = string.Empty;
            decimal valor1;
            decimal valor2;

            try
            {
                do
                {
                    Console.WriteLine("Informe a operação matematica que deseja:");

                    char operacao = char.Parse(Console.ReadLine());

                    switch (operacao)
                    {
                        case '+':
                            Console.WriteLine("Informe o primeiro valor para a soma:");
                            valor1 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor para a soma:");
                            valor2 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("O resultado da soma é " + $"{valor1 + valor2 }");
                            break;

                        case '-':

                            Console.WriteLine("Informe o primeiro valor para a subtração:");
                            valor1 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor para a subtração:");
                            valor2 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("O resultado da soma é " + $"{valor1 - valor2 }");
                            break;

                        case '*':

                            Console.WriteLine("Informe o primeiro valor para a multiplicação:");
                            valor1 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor para a multiplicação:");
                            valor2 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("O resultado da multiplicação é " + $"{valor1 * valor2 }");
                            break;

                        case '/':

                            Console.WriteLine("Informe o primeiro valor para a divisão:");
                            valor1 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor para a divisão:");
                            valor2 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("O resultado da divisão é " + $"{valor1 / valor2 }");
                            break;

                        case '%':

                            Console.WriteLine("Informe o primeiro valor para ver o resto da divisão:");
                            valor1 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor para ver o resto da divisão:");
                            valor2 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("O resultado do resto da divisão é " + $"{valor1 % valor2 }");
                            break;
                    }

                    Console.WriteLine("Deseja continuar? (SIM/NAO)");
                    continuar = Console.ReadLine();
                } while (_sim.Equals(continuar.ToUpper()));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.ReadLine();
            }



        }
    }
}
