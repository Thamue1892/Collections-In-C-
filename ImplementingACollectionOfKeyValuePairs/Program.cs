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

        //private static Dictionary<string, Element> BuildDictionary()
        //{
        //    var elements = new Dictionary<string, Element>();

        //    AddToDictionary(elements, "K", "Potassium", 19);
        //    AddToDictionary(elements, "Ca", "Calcium", 20);
        //    AddToDictionary(elements, "Sc", "Scandium", 21);
        //    AddToDictionary(elements, "Ti", "Titanium", 22);

        //    return elements;
        //}

        private static Dictionary<string, Element> BuildDictionary()
        {
            return new Dictionary<string, Element>
            {
                {
                    "K",
                    new Element() {Symbol = "K", Name = "Potassium", AtomicNumber = 19}
                },
                {
                    "Ca",
                    new Element() {Symbol = "Ca", Name = "Calcium", AtomicNumber = 20}
                },
                {
                    "SC",
                    new Element() {Symbol = "SC", Name = "Scandium", AtomicNumber = 21}
                },
                {
                    "Ti",
                    new Element() {Symbol = "Ti", Name = "Titanium", AtomicNumber = 22}
                }
            };
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

        private static void FindInDictionary(string symbol)
        {
            Dictionary<string, Element> elements = BuildDictionary();
            if (elements.ContainsKey(symbol) == false)
            {
                Console.WriteLine(symbol + " not found");
            }
            else
            {
                Element thElement = elements[symbol];
                Console.WriteLine("found: " + thElement.Name);
            }
        }

        //Using the TryGetValue method to find an item
        private static void FindInDictionary2(string symbol)
        {
            Dictionary<string, Element> elements = BuildDictionary();
            Element thElement = null;
            if (elements.TryGetValue(symbol, out thElement) == false)
                Console.WriteLine(symbol + " not found");
            else
                Console.WriteLine("found: " + thElement.Name);
        }


        static void Main(string[] args)
        {

        }
    }
}

