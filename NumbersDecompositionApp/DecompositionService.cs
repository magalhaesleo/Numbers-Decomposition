using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersDecompositionApp
{
    public interface IDecompositionService
    {
        IEnumerable<int> GetDivisorNumbers(int number);
        IEnumerable<int> GetPrimeNumbers(IEnumerable<int> numbers);
        bool IsPrime(int number);
    }

    public class DecompositionService : IDecompositionService
    {
        public IEnumerable<int> GetDivisorNumbers(int number)
        {
            for (int divisor = 1; divisor <= number; divisor++)
            {
                if (number % divisor == 0)
                    yield return divisor;
            }
        }

        public IEnumerable<int> GetPrimeNumbers(IEnumerable<int> numbers)
        {
            return numbers.Where(IsPrime);
        }

        public bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            if (number % 2 == 0)
                return number == 2;

            int squareRoot = (int)Math.Sqrt(number);
            for (int divisor = 3; divisor <= squareRoot; divisor += 2)
            {
                if (number % divisor == 0)
                    return false;
            }
            return true;
        }
    }
}
