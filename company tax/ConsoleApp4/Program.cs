using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi ime na kompanijata : ");
            string Kompanija = Console.ReadLine();
            Console.Write("Vnesi promet : ");
            double Promet = double.Parse(Console.ReadLine());
            double danok = 0;
            switch(Kompanija)
            {
                case "EkoTrejd": danok = 0.1 * Promet;
                    break;
                case "EkoKompani": danok = 0.2 * Promet;
                    break;
                case "EkoMartin": danok = 0.7 * Promet;
                    break;
                case "EkoFilip":danok = 0.4 * Promet;
                    break;
                default:  Console.WriteLine("Vnesete postoecka kompanija");
                    break;

            }
            Console.WriteLine("Danokot za kompanijata " + Kompanija + " iznesuva : " + danok.ToString()+ " den.");
            Console.ReadKey();
        }
    }
}
