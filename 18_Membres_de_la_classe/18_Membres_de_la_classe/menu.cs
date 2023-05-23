using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Membres_de_la_classe
{
    class menu
    {
        public void menuPrincipame()
        {
            backColor();
            Console.WriteLine("\t\t==============================================================================================");
            Console.WriteLine("\t\t=============                           Menu Principale                           ============");
            Console.WriteLine("\t\t==============================================================================================");
            Console.WriteLine("\t\t=============                         1- Menu Adminstratife                       ============");
            Console.WriteLine("\t\t=============                         2- Menu Professeur                          ============");
            Console.WriteLine("\t\t=============                         3- Menu Etudiant                            ============");
            Console.WriteLine("\t\t=============                         4- Menu Generale                            ============");
            Console.WriteLine("\t\t==============================================================================================");
            ReseCouleur();

        }
        public void backColor()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;// <-- This line is still white on blue.
        }
        public void ReseCouleur()
        {
            Type type = typeof(ConsoleColor);
            
            foreach (var name in Enum.GetNames(type))
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                Console.WriteLine(name);
            }
            Console.ResetColor();
        }
    }
}
