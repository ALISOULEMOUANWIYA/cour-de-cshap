using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _21_Getter_et_Setter
{
    internal class Administration
    {
        static int taille = 0, i = 0;
        private string[] tableauDistributif = new string[taille];

        private Personne[] tableau = new Personne[5];
        
        private Hashtable openWith = new Hashtable();
        private Dictionary<string, ArrayList> dico = new Dictionary<string, ArrayList>();


        public string[] tableauClasse = { };
        public string[] tableauMatier = { };

        public string[] listeClasse = new string[4];
        public string[] listematier = new string[4];

        public Administration()
        {}

        public void menuAdmin()
        {
            int choix = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t==============================================================================================");
                Console.WriteLine("\t\t=============                           Menu Administration                       ============");
                Console.WriteLine("\t\t==============================================================================================");
                Console.WriteLine("\t\t=============                         1- Ajouter un Professeur                    ============");
                Console.WriteLine("\t\t=============                         2- Ajouter un Etudiant                      ============");
                Console.WriteLine("\t\t=============                         3- Supprimer un Professeur                  ============");
                Console.WriteLine("\t\t=============                         4- Supprimer un Etudiant                    ============");
                Console.WriteLine("\t\t=============                         5- Recherche un Professeur                  ============");
                Console.WriteLine("\t\t=============                         6- Recherche un Etudiant                    ============");
                Console.WriteLine("\t\t=============                         7- Afficher le corbeille                    ============");
                Console.WriteLine("\t\t==============================================================================================");
                Console.WriteLine("\t\t=============                         8- QUITTER                                  ============");
                Console.WriteLine("\t\t==============================================================================================");
                Console.Write("\t\t=============                         choix : ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        AjouterUnProfesseur();
                        break;
                    case 2:
                        //AjouterUnEtudiant();
                        break;
                    case 3:
                        //SupprimerUnProfesseur();
                        break;
                    case 4:
                        //SupprimerUnEtudiant();
                        break;
                    case 5:
                        //RechercheUnProfesseur();
                        break;
                    case 6:
                        //RechercheUnEtudiant();
                        break;
                    case 7:
                        //AfficherLecorbeille();
                        break;
                    case 8:
                        //Quitter();
                        break;
                    default:
                        Console.WriteLine("\t\t==============================================================================================");
                        Console.WriteLine("\t\t                                Valeur (" + choix + ") non prise en charge                        ");
                        Console.WriteLine("\t\t==============================================================================================");
                        break;
                }
            } while (choix != 8);
        }

        public void AjouterUnProfesseur()
        {
            ArrayList listePro = new ArrayList();
            Console.Clear();
            Console.WriteLine("\t\t==============================================================================================");
            Console.WriteLine("\t\t                                Saisie des donnes du professeur                               ");
            Console.WriteLine("\t\t==============================================================================================");
            Personne per = new Personne();
            Console.Write("\t\t                                Entrez Le Nom du proffesseur : ");
            listePro.Add(per.Nom = Console.ReadLine());
            Console.Write("\t\t                                Entrez Le Prenom du proffesseur : ");
            listePro.Add(per.Prenom = Console.ReadLine());
            Console.Write("\t\t                                Entrez L\'Age du proffesseur : ");
            listePro.Add(per.Age = Convert.ToInt32(Console.ReadLine()));
            Console.Write("\t\t                                Entrez La nationnalite du proffesseur : ");
            listePro.Add(per.Nationnalite = Console.ReadLine());

            dico.Add((per.Nom.Substring(1)), listePro);
        }

        public Dictionary<string, ArrayList> Dico
        {
            get { return dico; }
            set { dico = value; }
        }
    }
}

/*
 











 */
