using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Les_Methodes
{
    internal class Program
    {
        static void Main(string[] args){
            menu();
        }

        static void menu()
        {
            Console.Write("\t\t==================================================================================\n");
            Console.Write("\t\t===================                    Menu                  =====================\n");
            Console.Write("\t\t==================================================================================\n");
            Console.Write("\t\t===================           1 - Afficher les Etudiant      =====================\n");
            Console.Write("\t\t===================           2 - Ajouter un Etudiant        =====================\n");
            Console.Write("\t\t===================           3 - Supprimer un Etudiant      =====================\n");
            Console.Write("\t\t===================           4 - Afficher en corbeille      =====================\n");
            Console.Write("\t\t===================           4 - Modiffier un Etudiant      =====================\n");
            Console.Write("\t\t===================           4 - Chercher un Etudiant       =====================\n");
        }
    }
}
