using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Classe_et_Objets
{
    internal class personne
    {
        string prenom = "Ibra";
        static void Main(string[] args)
        {
            // objet1 creer 
            personne A = new personne();
            Console.WriteLine(A.prenom);

            // objet2 creer 
            eleve B = new eleve();
            Console.WriteLine(B.nom);

            // objet3 creer 
            eleve C = new eleve();
            C.nom = "Issa";
            Console.WriteLine(C.nom);
        }
    }


}

