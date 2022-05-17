using System;
using System.Linq;

namespace NumbersDecompositionApp
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int inputValue;

            while (true)
            {
                Console.Write("Digite um número: ");
                var line = Console.ReadLine();
                if (line == null || int.TryParse(line, out inputValue) is false)
                {
                    Console.WriteLine("Valor inválido, tente novamente...");
                    continue;
                }

                break;
            }

            var decomposition = new DecompositionService();
            var divisors = decomposition.GetDivisorNumbers(inputValue).ToList();
            var primeDivisors = decomposition.GetPrimeNumbers(divisors).ToList();

            Console.WriteLine("Número de Entrada: {0}", inputValue);
            Console.WriteLine("Números divisores: {0}", string.Join(' ', divisors));
            Console.WriteLine("Dívisores Primos: {0}", string.Join(' ', primeDivisors));
        }
    }
}
