using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Les_Methode_avec_Parametre
{
    internal class Program
    {
        static int nombre = 0;
        static void Main(string[] args){
            Console.Write("\t\t Entrez un nombre entier postif : ");
            nombre = Convert.ToInt32(Console.ReadLine());
            if(nombre > 0)
            {
                afficher(nombre);
            }
            else
            {
                Console.WriteLine("\t\t Vous avez saisie un nombre entier Negatif");
            }
        }

        static void afficher(int nombre)
        {
            Console.Write("\t\t calcule du factorielle de "+nombre+" : ");
            Console.WriteLine(factorielle(nombre));
            ArgumentNomme(valeur3: "John", valeur1: "Liam", valeur2: "Liam");
            ArgumentNomme1("valeur2");
        }

        static int factorielle(int nombre)
        {
            int NombreFacto = 1;
            for (int i = 2; i <= nombre;  i++)
            {
                NombreFacto *= i;
            }
            return (NombreFacto);
        }

        // Arguments nommés
        static void ArgumentNomme(string valeur1, string valeur2, string valeur3)
        {
            Console.WriteLine("Le plus jeune enfant est : " + valeur1);
        }

        static void ArgumentNomme1(string valeur1 = "Liam", string valeur2 = "Jenny", string valeur3 = "John")
        {
            Console.WriteLine("Le plus jeune enfant est : " + valeur2);
        }
    }
}
