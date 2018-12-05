using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_5.RadixSort.DiazUriasJorgeDavid
{
    class Program
    {
        static void Main(string[] args)
        {
            Radix Rdx = new Radix();
            foreach (var item in Rdx.NumerosRandom())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}