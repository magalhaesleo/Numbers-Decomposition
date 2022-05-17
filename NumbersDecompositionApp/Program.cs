using System;
using System.Linq;

namespace NumbersDecompositionApp
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int value;

            while (true)
            {
                Console.Write("Digite um número: ");
                var line = Console.ReadLine();
                if (line == null || int.TryParse(line, out value) is false)
                {
                    Console.WriteLine("Valor inválido, tente novamente...");
                    continue;
                }

                break;
            }

            var decomposition = new DecompositionService();
            var divisors = decomposition.GetDivisorNumbers(value).ToList();
            var primeNumbers = decomposition.GetPrimeNumbers(divisors).ToList();

            Console.WriteLine("Número de Entrada: {0}", value);
            Console.WriteLine("Números divisores: {0}", string.Join(' ', divisors));
            Console.WriteLine("Dívisores Primos: {0}", string.Join(' ', primeNumbers));
        }
    }
}
