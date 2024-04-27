using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> mojalista = new List<int>();
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Vnesi elementi "+(i+1).ToString());
                mojalista.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
           int broj = mojalista.Count;
            bool dali = mojalista.Contains(5);
            if (dali == true)
            {
                int pozicija = mojalista.IndexOf(5);
            }
            else
            {
                Console.WriteLine("Ne e pronajden!");
            }
            mojalista.RemoveAt(9);
            mojalista.Reverse();
            for(int i=0;i<9;i++)
            {
                Console.WriteLine(mojalista[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sortirana lista ");
            mojalista.Sort();
            for(int i=0;i<9;i++)
            {
                Console.WriteLine(mojalista[i] + " ");
            }
            mojalista.Insert(2, 10);
            mojalista.Insert(9, 500);
            int max = mojalista[0];
            for(int i=0;i<10;i++)
            {
                if (mojalista[i] > max) { max = mojalista[i];}
            }
            Console.WriteLine("Max elem e " + max);
            Console.ReadKey();
        }

        }
    }

