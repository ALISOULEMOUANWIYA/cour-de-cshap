using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _21_Getter_et_Setter
{
    internal class ProfesseurEtudiant
    {
        private string ouverture = "OUVERTURE DU FENNTRE APRES LE CHARGEMENT";
        private string fermetureFenetre = "FERMETURE DU FENNTRE APRES LE CHARGEMENT";
        private Dictionary<string, ArrayList> dicoP = new Dictionary<string, ArrayList>();
        public ProfesseurEtudiant(string valeur1, string valeur2, string valeur3, Administration adm)
        {
            menuProfesseur(valeur1, valeur2, valeur3, adm);
        }

        public void menuProfesseur(string valeur1, string valeur2, string valeur3, Administration adm)
        {
            int choix = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t==============================================================================================");
                Console.WriteLine("\t\t=============                           Menu "+valeur3+"                           ============");
                Console.WriteLine("\t\t==============================================================================================");
                Console.WriteLine("\t\t=============                         1- Afficher la listes des Professeur        ============");
                Console.WriteLine("\t\t=============                         2- Afficher la listes des Etudiant          ============");
                Console.WriteLine("\t\t=============                         3- Recherche un Professeur                  ============");
                Console.WriteLine("\t\t=============                         4- Recherche un Etudiant                    ============");
                Console.WriteLine("\t\t==============================================================================================");
                Console.WriteLine("\t\t=============                         5- QUITTER                                  ============");
                Console.WriteLine("\t\t==============================================================================================");
                Console.Write("\t\t=============                         choix : ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        AfficherListeProfesseur(adm);
                        break;
                    case 2:
                        //AfficherListeEtudiant();
                        break;
                    case 3:
                        //ProfesseurUnProfesseur();
                        break;
                    case 4:
                        //ProfesseurUnEtudiant();
                        break;
                    case 5:
                        menu mn = new menu(1, ouverture);
                        mn.menuPrincipale(fermetureFenetre, ouverture);
                        break;
                    default:
                        Console.WriteLine("\t\t==============================================================================================");
                        Console.WriteLine("\t\t                                Valeur (" + choix + ") non prise en charge                        ");
                        Console.WriteLine("\t\t==============================================================================================");
                        break;
                }
            } while (choix != 5);
        }

        private void AfficherListeProfesseur(Administration adm)
        {
            Console.WriteLine("\t\t==============================================================================================");
            Console.WriteLine("\t\t=============                           Liste des Professeur                      ============");
            Console.WriteLine("\t\t==============================================================================================");
            foreach (KeyValuePair<string, ArrayList> de in adm.Dico)
            {
                Console.WriteLine("Key = " + de.Key + " Value Length= " + de.Value.Count);
                for (int i = 0; i < de.Value.Count; i++)
                {
                    Console.WriteLine(de.Value[i]);
                }
            }
            Thread.Sleep(2000);
        }
    }
}
