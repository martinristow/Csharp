using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] broevi = new int[] { 0, 1, 2, 3, 5, 8, 13 };
            foreach (int i in broevi)
            {
                sum += i;
            }
            System.Console.WriteLine(sum);

        }
    }
}
