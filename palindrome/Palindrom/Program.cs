using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi  string:");
            string prv=Console .ReadLine();
            char[] prvaarr=prv.ToCharArray();
            Array.Reverse(prvaarr);
            string p1=new string(prvaarr);
            if(p1 != prv)
            {
                Console.WriteLine("Ne palindrom");
            }
            else
            {
                Console.WriteLine("Palindrom");
            }
        }
    }
}
