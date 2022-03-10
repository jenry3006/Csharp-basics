using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe o ano que voce nasceu:");
                DateTime ano = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Sua idade é: " + $"{DateTime.Today.Year - ano.Year}");
            }
            catch (Exception ex)
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
