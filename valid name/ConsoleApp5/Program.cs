using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Vnesete recenica: ");
            string recenica = Console.ReadLine();
            if ((recenica[recenica.Length - 1] == '.') && (recenica.Length != 0))
            {
                if (recenica.StartsWith("Ana"))
                    Console.WriteLine("Validno Ime");
                else if (recenica.StartsWith("Anastasija"))
                    Console.WriteLine("Validno Ime");
                else
                    Console.WriteLine("Nevaliden vnes");
            }
            else
                Console.WriteLine("Greska");
            Console.ReadKey();
        }
    }
}

