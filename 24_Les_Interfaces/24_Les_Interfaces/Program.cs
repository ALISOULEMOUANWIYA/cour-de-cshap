using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Les_Interfaces
{
   internal class Program
    {
        static string[] languageComorien = { "Comorien", "Senegalais", "Anglais", "Francais" };
        static void Main(string[] args)
        {
            Nationalite();
        }

        static void Nationalite()
        {
            char choix;
            int valeur;
            do
            {
                Console.WriteLine("\t\t\t----------------------------------------------------------------");
                Console.WriteLine("\t\t\t-----------------         Menu Nationalite    ------------------");
                Console.WriteLine("\t\t\t----------------------------------------------------------------");
                Console.WriteLine("\t\t\t-----------------         1- Comorien         ------------------");
                Console.WriteLine("\t\t\t-----------------         2- Senegalais       ------------------");
                Console.WriteLine("\t\t\t-----------------         3- Anglais          ------------------");
                Console.WriteLine("\t\t\t-----------------         4- Francais         ------------------");
                Console.WriteLine("\t\t\t----------------------------------------------------------------");
                Console.WriteLine("\t\t\t-----------------         5- Quitter          ------------------");
                Console.WriteLine("\t\t\t----------------------------------------------------------------");
                Console.Write("\t\t\t-----------------      fait votre choix : ");
                choix = Convert.ToChar((Console.ReadLine()).Substring(0, 1));
                switch (choix)
                {
                    case '1':
                        Console.Clear();
                        contry cm = new Comorien();
                        do
                        {
                            Console.WriteLine("\t\t\t----------------------------------------------------------------");
                            Console.WriteLine("\t\t\t-------          Vous etez comorien de quelle ILE ?         ----");
                            Console.WriteLine("\t\t\t----------------------------------------------------------------");
                            Console.WriteLine("\t\t\t-----------------         1- Anjouanais        ------------------");
                            Console.WriteLine("\t\t\t-----------------         2- Mohelinne        ------------------");
                            Console.WriteLine("\t\t\t-----------------         3- Ngazidja         ------------------");
                            Console.WriteLine("\t\t\t----------------------------------------------------------------");
                            Console.Write("\t\t\t-----------------      fait votre choix : ");
                            valeur = Convert.ToInt16(Console.ReadLine().Substring(0, 1));
                            switch (valeur)
                            {
                                case 1:
                                    Console.Clear();
                                    cm.residancePersonne("Anjouanais");
                                    valeur = 3;
                                    break;
                                case 2:
                                    Console.Clear();
                                    cm.residancePersonne("Mohelien");
                                    valeur = 3;
                                    break;
                                case 3:
                                    Console.Clear();
                                    cm.residancePersonne("Chi-Ngazidja");
                                    valeur = 3;
                                    break;
                            }
                        } while (valeur != 3);
                        break;
                    case '2':
                        Console.Clear();
                        contry sn = new Senegalais();
                        do
                        {
                            Console.WriteLine("\t\t\t----------------------------------------------------------------");
                            Console.WriteLine("\t\t\t-------   Vous etez Senegalais, vous parlez quelle langue ? ----");
                            Console.WriteLine("\t\t\t----------------------------------------------------------------");
                            Console.WriteLine("\t\t\t-----------------         1- Wolof            ------------------");
                            Console.WriteLine("\t\t\t-----------------         2- Bambara          ------------------");
                            Console.WriteLine("\t\t\t-----------------         3- peule            ------------------");
                            Console.WriteLine("\t\t\t----------------------------------------------------------------");
                            Console.Write("\t\t\t-----------------      fait votre choix : ");
                            valeur = Convert.ToInt16(Console.ReadLine().Substring(0, 1));
                            switch (valeur)
                            {
                                case 1:
                                    Console.Clear();
                                    sn.residancePersonne("Wolof");
                                    valeur = 3;
                                    break;
                                case 2:
                                    Console.Clear();
                                    sn.residancePersonne("Bambara");
                                    valeur = 3;
                                    break;
                                case 3:
                                    Console.Clear();
                                    sn.residancePersonne("peule");
                                    valeur = 3;
                                    break;
                            }
                        } while (valeur != 3);
                        break;
                    case '3':
                        Console.Clear();
                        contry An = new Anglais();
                        An.residancePersonne("Anglais");
                        break;
                    case '4':
                        Console.Clear();
                        contry fr = new Francais();
                        fr.residancePersonne("Français");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\t\t\t----------------------------------------------------------------");
                        Console.WriteLine("\t\t\t---------------  Valeur non prise en charege  ------------------");
                        Console.WriteLine("\t\t\t----------------------------------------------------------------");
                        break;
                }
            } while (choix != '5');
        }
    }

    interface contry
    {
        void residancePersonne(String valeur);
    }

    class Comorien : contry
    {
        private string[] languageComorien = { "Anjouanais", "Mohelien", "Chi-Ngazidja" };
        private int cmpt = 0;
        public  void residancePersonne(String valeur)
        {
            foreach (string tb in LanguageComorien)
            {
                if (String.Compare(valeur, tb, true) == 0)
                {
                    Console.WriteLine("\t\t\t----------------------------------------------------------------");
                    Console.WriteLine("\t\t\t    Vous etes Comorienne et vous parlez (" + valeur + ")");
                    Console.WriteLine("\t\t\t----------------------------------------------------------------");
                }
                else
                {
                    cmpt++;
                }
            }
            if (cmpt == 3)
            {
                Console.WriteLine("\t\t\t----------------------------------------------------------------");
                Console.WriteLine("\t\t\t----  [ Desolé Valeur non prise en charge dans le system ] -----");
                Console.WriteLine("\t\t\t----------------------------------------------------------------");
            }
        }

        public String[] LanguageComorien
        {
            get { return languageComorien; }
            set { languageComorien = value; }
        }
    }

    class Senegalais : contry
    {
        private string[] languageSenegalaise = { "Wolof", "Bambara", "peule" };
        private int cmpt = 0;
        public void residancePersonne(String valeur)
        {

            foreach (string tb in LanguageSenegalaise)
            {
                if (String.Compare(valeur, tb, true) == 0)
                {
                    Console.WriteLine("\t\t\t----------------------------------------------------------------");
                    Console.WriteLine("\t\t\t    Vous etes Senegalais et vous parlez (" + valeur + ")");
                    Console.WriteLine("\t\t\t----------------------------------------------------------------");
                }
                else
                {
                    cmpt++;
                }
            }
            if (cmpt == 3)
            {
                Console.WriteLine("\t\t\t----------------------------------------------------------------");
                Console.WriteLine("\t\t\t----  [ Desolé Valeur non prise en charge dans le system ] -----");
                Console.WriteLine("\t\t\t----------------------------------------------------------------");
            }
        }

        public String[] LanguageSenegalaise
        {
            get { return languageSenegalaise; }
            set { languageSenegalaise = value; }
        }
    }

    class Anglais : contry
    {
        public void residancePersonne(String valeur)
        {
            Console.WriteLine("\t\t\t----------------------------------------------------------------");
            Console.WriteLine("\t\t\t-----     Vous etes " + valeur + " et vous parlez  " + valeur + "      -----");
            Console.WriteLine("\t\t\t----------------------------------------------------------------");
        }
    }

    class Francais : contry
    {
        public void residancePersonne(String valeur)
        {
            Console.WriteLine("\t\t\t----------------------------------------------------------------");
            Console.WriteLine("\t\t\t-----     Vous etes " + valeur + " et vous parlez  " + valeur + "      -----");
            Console.WriteLine("\t\t\t----------------------------------------------------------------");
        }
    }
}

