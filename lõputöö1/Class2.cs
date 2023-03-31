using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimedeSkipSortFilter
{
    internal class Class2
    {
        public void NimedeSkipSortFilter()
        {
            List<string> names = new List<string> { "Andre", "Karol", "Bob", "Marek", "Jane", "Heli", "Marje", "Mark" };

            var result = names

                .SkipWhile(name => name.StartsWith("A")) 
                // jätab algusest kõik elemendid, mis algavad "A" tähemärgiga

                .OrderByDescending(name => name.Length) 
                // järjestab pikkuse järgi kahanevas järjekorras

                .Where(name => name.Contains("a")) 
                // jätab alles ainult elemendid, mis sisaldavad "a" tähemärki

                .ToList();

            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
