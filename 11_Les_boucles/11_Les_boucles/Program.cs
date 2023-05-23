using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Les_boucles
{
    internal class Program
    {
        static int nombre = 1, nombre2 = 1, choix;
        static void Main(string[] args){
            Console.WriteLine("++++++++++++++++++ testeur des boucle+++++++++++++");
            while(nombre != 0){
                nombre += 1; // incrementation de nombre = nombre + 1
                Console.WriteLine("Nombre = " + nombre);
                if (nombre % 5 == 0){
                    Console.WriteLine("Voulez-vous continuer ? (1 = continuer et 0 = rompre");
                    choix = Convert.ToInt32(Console.ReadLine());
                    if(choix == 0){
                        nombre = 0;
                    }
                }
                else{
                    Console.Clear();
                    Console.WriteLine("-------------------Boucle while(condition)-------------------");
                }
            }

           
            do
            {
                nombre += 1; // incrementation de nombre = nombre + 1
                Console.WriteLine("Nombre = " + nombre);
                if (nombre % 25 == 0)
                {
                    Console.WriteLine("Voulez-vous continuer ? (1 = continuer et 0 = rompre");
                    choix = Convert.ToInt32(Console.ReadLine());
                    if (choix == 0)
                    {
                        nombre = 0;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("-------------------Boucle do{ }while(condition)-------------------");
                }
            } while (nombre != 0);


            for (int i = 0; i < nombre2; i++) {
                nombre2 += 1; // incrementation de nombre = nombre + 1
                Console.WriteLine("Nombre = " + nombre2);
                if (nombre2 % 25 == 0)
                {
                    Console.WriteLine("Voulez-vous continuer ? (1 = continuer et 0 = rompre");
                    choix = Convert.ToInt32(Console.ReadLine());
                    if (choix == 0)
                    {
                        nombre2 = 0;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("-------------------Boucle for Loop-------------------");
                }
            }
            // Les tableau serons bien expliquer au 13ems chapitres
            string[] cartier = { "Cigarali", "Caltexe", "Mangani", "Hadoudja", "Djomani" };
            foreach (string i in cartier)
            {
                Console.WriteLine(i);
            }
        }
    }
}
