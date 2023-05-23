using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _5_Obtenir_une_entre_utilisateur
{
    internal class Program
    {
        static String nom, prenom, classe, ecole, niveau, matricule;
        static double moyenne;
        static int age, notes;
        static char sexe;
        static void Main(string[] args){
            Console.Write("Entrez Votre Nom : ");
            nom = Console.ReadLine();

            Console.Write("Entrez Votre Prenom : ");
            prenom = Console.ReadLine();

            Console.Write("Entrez Votre Age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entrez Votre Note eu : ");
            notes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entrez Votre genre (F/M) : ");
            sexe = (char) Console.ReadLine().IndexOf("F");

            Console.Write("Entrez Votre Ecole : ");
            ecole = Console.ReadLine();

            Console.Write("Entrez Votre Classe : ");
            classe = Console.ReadLine();

            Console.Write("Entrez Votre Niveau : ");
            niveau = Console.ReadLine();

            Console.WriteLine("Creation du Matricule Etudiant est fait");
            matricule = nom.Substring(1) + prenom.Substring(1) + classe.Substring(1) + ecole.Substring(1) + niveau;

            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine("Nom Etudiant : "+ nom);
            Console.WriteLine("prenom Etudiant : " + prenom);
            Console.WriteLine("age Etudiant : " + age);
            Console.WriteLine("sexe Etudiant : " + sexe);
            Console.WriteLine("classe Etudiant : " + classe);
            Console.WriteLine("ecole Etudiant : " + ecole);
            Console.WriteLine("niveau Etudiant : " + niveau);
            Console.WriteLine("notes Etudiant : " + notes);
            Console.WriteLine("matricule Etudiant : " + matricule);
            Console.WriteLine("moyenne Etudiant : " + notes);
        }
    }
}
