using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LesVariable_Projet_Scolarite
{
    internal class Program
    {
        static string nom, prenom, classe;
        static double notes;
        static void Main(string[] args){
            nom = "Ali Soule ";
            prenom = "Mouanwiya ";
            classe = "GL L3 ";
            notes = 18;
            Console.WriteLine(nom + prenom + "de la classe "+ classe + "a eu la note de "+ notes);
        }
    }
}
