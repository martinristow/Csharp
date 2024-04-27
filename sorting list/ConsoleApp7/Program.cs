using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Vnesi element vo listata "+ (i+1).ToString());
                lista.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            int broj = lista.Count;
            bool dali = lista.Contains(5);
            
            if(dali==true) 
            {
                int pozicija = lista.IndexOf(5);
                Console.WriteLine("Brojot e " + pozicija); 
            }
            else
            {
                Console.WriteLine("Brojot ne postoi!"); 
            }
            Console.WriteLine();
            lista.RemoveAt(9);
            lista.Reverse();
            Console.WriteLine("Prepravena lista : ");
            for(int i=0;i<9;i++)
            {
                Console.WriteLine(lista[i] +" ");

            }
            Console.WriteLine();
            lista.Sort();
            Console.WriteLine("Sortirana lista : ");
            for(int i=0;i<9;i++)
            {
                Console.WriteLine(lista[i]+" ");
            }
            lista.Insert(2, 100);
            lista.Insert(9, 10);
            int max = lista[0];
            for(int i=1;i<10;i++)
            {
                if (lista[i] > max)
                
                    max = lista[i];
                
               

            }
            Console.WriteLine("Najgolemiot e : " + max);

            Console.ReadKey();
           
           }
        
    }
}
