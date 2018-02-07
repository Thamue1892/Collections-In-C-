using System;
using System.Collections.Generic;

namespace CollectionsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamsList = new List<string> {"Manchester United", "Liverpool", "Arsenal", "Chelsea"};

            foreach (var team in teamsList)
            {
                Console.WriteLine(team);
            }
        }
    }
}
