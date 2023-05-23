using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Modificateurs_d_acces
{
    internal class menu
    {
        public int choix;
        public string[] tableau;
        public menu()
        {
            background bc = new background();
            menuPrincipame(bc);
            tableau = new string[] { "1- Menu Adminstratife", "2- Menu Professeur", "3- Menu Etudiant", "4- Menu Generale"};
        }

        public void menuPrincipame(background bc)
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
            Console.Write("\t\t=============                         choix : ");
        }
        public void backgroundcolors()
        {
            background bc = new background();
            bc.backColor();
        }
        public void clearColor()
        {
            background bc = new background();
            bc.ResetCouleur();
        }
    }
}
