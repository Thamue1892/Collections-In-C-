using System;
using System.Collections.Generic;

namespace RemovingItemsInAList
{
    class Program
    {
        static void Main(string[] args)
        {
            var IDNumbers = new List<int> { 0123, 4567, 890 };
            IDNumbers.Remove(890);

            foreach (var idNumber in IDNumbers)
            {
                Console.WriteLine(idNumber);
            }
        }
    }
}
