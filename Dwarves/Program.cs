using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwarves
{
    class Program
    {
        static void Main(string[] args)
        {
            var palindromes = new List<string>();
            var dwarves = new List<string> { "Gimli", "Fili", "Ilif", "Ilmig", "Mark" };
            var reversedDwarves = dwarves.Select(d => { d = new string(d.ToCharArray().Reverse().ToArray()).ToLower(); return d;}); 
            
            foreach(var dwarf in dwarves)
            {
                palindromes.AddRange(reversedDwarves.Where(r => r.ToLower() == dwarf.ToLower()).Select(r => dwarf + r));
            }

            foreach(var p in palindromes)
            {
                System.Console.WriteLine(p);
            }
        }
    }
}
