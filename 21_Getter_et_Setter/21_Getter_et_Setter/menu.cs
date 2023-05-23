using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _21_Getter_et_Setter
{
    internal class menu
    {
        private int choix, fermer = 0;
        public string[] tableau;
        public menu(int declancheur,string ouvrir)
        {
            if (declancheur == 0) {
                declancheur = 1;
                fermeture(ouvrir);
            }
        }

        public void menuPrincipale(string fermer, string ouvrir)
        {
            int choix = 0;
            Administration adm = new Administration();
            do
            {
                Console.WriteLine("\t\t==============================================================================================");
                Console.WriteLine("\t\t=============                           Menu Principale                           ============");
                Console.WriteLine("\t\t==============================================================================================");
                Console.WriteLine("\t\t=============                         1- Menu Adminstratife                       ============");
                Console.WriteLine("\t\t=============                         2- Menu Professeur                          ============");
                Console.WriteLine("\t\t=============                         3- Menu Etudiant                            ============");
                Console.WriteLine("\t\t=============                         4- Menu Generale                            ============");
                Console.WriteLine("\t\t==============================================================================================");
                Console.WriteLine("\t\t=============                         5- QUITTER                                  ============");
                Console.WriteLine("\t\t==============================================================================================");
                Console.Write("\t\t=============                         choix : ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        adm.menuAdmin();
                        break;
                    case 2:
                        string valeur30 = "Professeur";
                        ProfesseurEtudiant pr0 = new ProfesseurEtudiant(fermer, ouvrir, valeur30, adm);
                        break;
                    case 3:
                        string valeur31 = "Etudiant";
                        ProfesseurEtudiant pr1 = new ProfesseurEtudiant(fermer, ouvrir, valeur31, adm);
                        break;
                    case 4:
                        break;
                    case 5:
                        fermeture(fermer);
                        Environment.Exit(0); // pour fermer la fenetre de manier general
                        break;
                    default:
                        break;
                }
            } while (choix != 5);

        }

        private void fermeture(string txt)
        {
            string tirrer = "";
            for (int i = 1; i<=100; i++)
            {
                for (int j =0; j < 1; j++)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n\n");
                    Console.WriteLine("\n\n\n\n\n\n\n\n");
                    Console.WriteLine("\t\t==============================================================================================================");
                    Console.WriteLine("\t\t                                             "+txt+"                         ");
                    Console.WriteLine("\t\t==============================================================================================================");
                    Console.WriteLine("\t\t                                                        " + i + "%       ");
                    tirrer += "=";
                    Console.WriteLine("\t            "+ tirrer + "");
                    Thread.Sleep(200);

                }

            }
            Console.Clear();
        }
        public int Fermer
        {
            get { return fermer; }
            set { fermer = value; }
        }
    }
}
