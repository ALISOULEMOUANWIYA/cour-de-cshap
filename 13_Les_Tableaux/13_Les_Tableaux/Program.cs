using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Les_Tableaux
{
    internal class Program
    {
        static string[] voiture = { "Volvo", "BMW", "Ford", "Mazda" };
        static string[] personne;
        static int[] nombre = { 9, 10, 3, 1 };
        static void Main(string[] args){
            Console.WriteLine(voiture[0]+"\n");
            // parcourire le tableau voirute avec la boocle for
            for (int i = 0; i < voiture.Length; i++){
                Console.WriteLine(voiture[i]);
            }


            // parcourire le tableau voirute avec la boocle foreach
            Console.WriteLine("\n");
            foreach (string i in voiture)
            {
                Console.WriteLine(i);
            }

            //arranger les valeur du tableau par lettre
            Console.WriteLine("\n");
            Array.Sort(voiture);
            foreach (string i in voiture)
            {
                Console.WriteLine(i);
            }

            // Usage des methode integre dans un tableau int[]
            Console.WriteLine("\n");
                Console.WriteLine(nombre.Max()); // le maximume du tablau
                Console.WriteLine(nombre.Min()); // le minimume du tableau
                Console.WriteLine(nombre.Sum()); // la somme des nombre du tableau

            personne = new string[] {"Bobe", "jhon", "charl", "Eric", "Pepe"};
            Console.WriteLine("\n");
            Array.Sort(personne); // Arranger les valeur du tableau par lettre
            foreach (string i in personne)
            {
                Console.WriteLine(i);
            }
        }
    }
}
