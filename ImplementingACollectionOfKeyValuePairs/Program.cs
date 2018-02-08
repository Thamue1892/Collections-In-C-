using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingACollectionOfKeyValuePairs
{
    class Program
    {
        private static void IterateThroughDictionary()
        {
            Dictionary<string, Element> elements = BuildDictionary();
            foreach (KeyValuePair<string, Element> kvp in elements)
            {
                Element thElement = kvp.Value;

                Console.WriteLine("key: " + kvp.Key);
                Console.WriteLine("value: " + thElement.Symbol + " " +
                                  thElement.Name + " " + thElement.AtomicNumber);
            }
        }

        private static Dictionary<string, Element> BuildDictionary()
        {
            var elements = new Dictionary<string, Element>();

            AddToDictionary(elements, "K", "Potassium", 19);
            AddToDictionary(elements, "Ca", "Calcium", 20);
            AddToDictionary(elements, "Sc", "Scandium", 21);
            AddToDictionary(elements, "Ti", "Titanium", 22);

            return elements;
        }

        private static void AddToDictionary(Dictionary<string, Element> elements, string symbol, string name,
            int atomicNumber)
        {
            Element thElement = new Element();
            thElement.Symbol = symbol;
            thElement.Name = name;
            thElement.AtomicNumber = atomicNumber;


            elements.Add(key: thElement.Symbol, value: thElement);
        }


        static void Main(string[] args)
        {

        }
    }
}

