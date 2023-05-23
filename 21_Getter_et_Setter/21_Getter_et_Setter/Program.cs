using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Getter_et_Setter
{
    internal class Program
    {
        static string ouverture = "OUVERTURE DU FENNTRE APRES LE CHARGEMENT";
        static string fermetureFenetre = "FERMETURE DU FENNTRE APRES LE CHARGEMENT";
        static int declancheur = 0;

        static void Main(string[] args)
        {
            menu mn = new menu(declancheur, ouverture);
            mn.menuPrincipale(fermetureFenetre, ouverture);
        }
    }
}
