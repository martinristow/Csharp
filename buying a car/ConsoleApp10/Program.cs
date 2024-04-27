//MARTIN RISTOV - 102620 //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godini=0,broj,proverka;
            string ime, prezime, grad, adresa;
            string avtomobil;
            float sostojba = 0,suma;
            Console.WriteLine("Dali ste sigurni deka sakate da ja koristete nasata aplikacija ? ( 1-DA ^ 0-NE )");
            proverka=int.Parse(Console.ReadLine());
            if(proverka==1 )
            {
                Console.WriteLine("Uspesno se povrzavte!");
                Console.WriteLine();
                Console.WriteLine("Vnesete gi vasite podatoci (Ime,Prezime,Godini,Grad,Adresa) !");
                Console.WriteLine("Ime: ");
                ime = Console.ReadLine();
                Console.WriteLine("Prezime: ");
                prezime = Console.ReadLine();
                Console.WriteLine("Godini: ");
                godini = int.Parse(Console.ReadLine());
                Console.WriteLine("Grad: ");
                grad = Console.ReadLine();
                Console.WriteLine("Adresa: ");
                adresa = Console.ReadLine();
                while(true)
                {
                    Console.WriteLine(" \n ");
                    Console.WriteLine("Pocetna sostojba vi e : " + sostojba);
                    Console.WriteLine() ;
                    Console.WriteLine("Dokolku sakate da vnesete pari izberete nekoja od ponudenite opcii !");
                    Console.WriteLine("0-150000 , 1-200000 , 2-300000 , 3-5000 , 4-izlez ");
                    broj= int.Parse(Console.ReadLine());
                    switch(broj)
                    {
                        case 0: sostojba = 150000;
                            break;
                        case 1:sostojba= 200000; 
                            break;
                        case 2:sostojba = 300000;
                            break;
                        case 3:sostojba = 5000;
                            break;
                        default: Console.WriteLine("Izlegovte");break;
                    }
                    break;
                }
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine("Vnesete go "+i+"-ot avtomobil :");
                    avtomobil=Console.ReadLine();
                    Console.WriteLine("Dali sakate da gi kupite ? (0-NE , 1-DA)");
                    int kont= int.Parse(Console.ReadLine());
                    if (kont == 1)
                    {
                        if (sostojba > 9999)
                        {
                             
                            Console.WriteLine("Uspesno go kupivte avtomobilot: " + avtomobil);
                        }
                        else Console.WriteLine("Nedovolno sretstva");
                        
                             }
                    else
                    {
                        Console.WriteLine("Odbivte da gi kupite");
                    }
                }
                suma = sostojba - 100000;
                Console.WriteLine();
                Console.WriteLine("VLASNIK : \n");
                Console.WriteLine("Ime: " + ime);
                Console.WriteLine("Prezime: " + prezime);
                Console.WriteLine("Godini: " + godini);
                Console.WriteLine("Grad: " + grad);
                Console.WriteLine("Adresa: " + adresa);
                Console.WriteLine();
                Console.WriteLine("\n"+ "Preostanati sredstva : "+suma);
                
                goto finish;
            finish: Console.WriteLine("\n KRAJ");
            }
            else 
            { 
                Console.WriteLine("Izbravte da izlezete ! "); 
            }

            Console.ReadKey();
        }
    }
}
