using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Getter_et_Setter
{
    internal class Personne
    {
        static string nom, prenom, nationnalite;
        static int age;
        public Personne()
        { }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Nationnalite
        {
            get { return nationnalite; }
            set { nationnalite = value; }
        }
    }
}
