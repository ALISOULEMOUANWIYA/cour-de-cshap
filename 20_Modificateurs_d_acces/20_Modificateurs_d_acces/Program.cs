using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Modificateurs_d_acces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valeur = 0;
            menu mn = new menu();

            mn.choix = Convert.ToInt32(Console.ReadLine());
            mn.clearColor();
            for (int i = mn.tableau.Length; i > 0; i--)
            {
                valeur = i;
                if (mn.choix.Equals(valeur--))
                {
                    Console.Clear();
                    mn.backgroundcolors();
                    Console.WriteLine("\t\t==============================================================================================");
                    Console.WriteLine("\t\t                                  "+ mn.tableau[valeur]+"                                     ");
                    Console.WriteLine("\t\t==============================================================================================");
                   
                }
            }
            mn.clearColor();
        }
    }
}
