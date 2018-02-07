using System;
using System.Collections.Generic;

namespace RemovingElementAtASpecifiedPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Remove odd numbers
            for (int index = numbers.Count - 1; index >= 0; index--)
            {
                if (numbers[index] % 2 == 1)
                {
                    numbers.RemoveAt(index);
                }
            }

            numbers.ForEach(Console.WriteLine);
        }
    }
}
