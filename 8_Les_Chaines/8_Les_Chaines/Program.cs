using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Les_Chaines
{
    internal class Program
    {
        static string nom, prenom, classe, matricule, valeur;
        static string concat = "";
        static Random aleatoir;
        static void Main(string[] args){
            aleatoir = new Random();
            Console.Write("Entrez votre Nom : ");
            nom = Console.ReadLine();

            Console.Write("Entrez votre Prenom : ");
            prenom = Console.ReadLine();

            Console.Write("Entrez votre Classe : ");
            classe = Console.ReadLine();

            // Concatenation: String.Concat(valeur1, valeur2, ..., valeurN), 
            // Recuperé une sous chaine: Substring(N)
            // Chaine d'acces Par positionnement: chaine[N] ou chaine.indexOf(Caractère)
            // Retourner une copie de la chaine convertie en majiscule
            // Retourner un nomber aleatoir: Random(N)
            // Retourner date et heur: DateTime
            concat = String.Concat(nom, prenom, classe);
            matricule = String.Concat(concat.Length, "-", nom[1].ToString().ToUpper(), prenom.Substring(1).ToUpper(), "-", classe.ToUpper(), "-", aleatoir.Next(0, 100), "-", DateTime.Today);

            // Interpolation de chaine
            valeur = $"Nom : {nom}; \nPrenom : {prenom}; \nClasse  : {classe}; \nMatricule : {matricule}";
            Console.WriteLine(valeur);
        }
    }
}
