using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stek = new Stack<int>();//deklariranje na stek
            stek.Push(1);//Vnesuvanje na elementi vo stek
            stek.Push(2);
            stek.Push(3);
            stek.Push(4);
            stek.Push(5);
            Console.WriteLine("Sodrzi " + stek.Count());//broe kolku elem ima vnatre
            Console.WriteLine("Struktura na stekot : ");
            foreach(int i in stek) Console.WriteLine(i);//Pecatenje na site elementi 
            Console.WriteLine("Vrvot na stekot e : " + stek.Peek());//Prviot element vo magacinot
            int vred =stek.Pop();//Brise ga vrvo na stekot
            if (vred == 5)//Proverka dali izbrisaniot vrv na stekot e deliv so 5
            {
                Console.WriteLine("Deliv");
            }
            else Console.WriteLine("Ne");
            if (stek.Contains(4))//proveruvanje na brojo 4 dali e vnatre vo stekot 
            {
                Console.WriteLine("Da ");
            }
            else
                Console.WriteLine("Ne");
            stek.Clear();//osloboduvanje na memorijata 
            Console.ReadKey();
        }
    }
}
