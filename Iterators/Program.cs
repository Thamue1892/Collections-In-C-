using System;
using System.Collections.Generic;

namespace Iterators
{
    class Program
    {
        private static void ListEvenNumbers()
        {
            foreach (int number in EvenSequence(5, 18))
            {
                Console.Write(number.ToString() + " ");
            }
            Console.WriteLine();
        }

        private static IEnumerable<int> EvenSequence(int firstNumber, int lastNumber)
        {
            for (var number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }

        static void Main(string[] args)
        {
            ListEvenNumbers();
        }
    }
}
