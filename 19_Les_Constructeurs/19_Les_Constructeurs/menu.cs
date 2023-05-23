using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Les_Constructeurs
{
    internal class menu
    {
        public menu()
        {
            backgroundColor bc = new backgroundColor();
            menuPrincipame(bc);
        }

        public void menuPrincipame(backgroundColor bc)
        {
            bc.backColor();
            Console.WriteLine("\t\t==============================================================================================");
            Console.WriteLine("\t\t=============                           Menu Principale                           ============");
            Console.WriteLine("\t\t==============================================================================================");
            Console.WriteLine("\t\t=============                         1- Menu Adminstratife                       ============");
            Console.WriteLine("\t\t=============                         2- Menu Professeur                          ============");
            Console.WriteLine("\t\t=============                         3- Menu Etudiant                            ============");
            Console.WriteLine("\t\t=============                         4- Menu Generale                            ============");
            Console.WriteLine("\t\t==============================================================================================");
            bc.ReseCouleur();

        }
    }
}
