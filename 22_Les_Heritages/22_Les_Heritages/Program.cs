using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Les_Heritages
{
    internal class Program
    {
        static String cheveau;
        static void Main(string[] args)
        {
            voitur v = new voitur();
            v.honk();

            Console.WriteLine(v.brand +" "+v.modelName);

            Console.Write("Entrez le type de cheveau : ");
            cheveau = Console.ReadLine();
            couleur c = new couleur(cheveau);
            Console.WriteLine(c.Cheveau+" "+c.Tableau[0]);
            cheveau = Console.ReadLine();
        }
    }

    sealed class couleur
    {
        private string[]  tableau = {"rouge", "noir", "bleu"};
        public couleur(string cheveau)
        {
            this.Cheveau = cheveau;
        }

        public string[] Tableau
        {
            get { return tableau; }
            set{ tableau = value; }
        }

        public string Cheveau
        {
            get; set;
        }
    }

    class vehicule
    {
        public string brand = "ford"; // Vehicule domaine
        public void honk()
        {
            Console.WriteLine("Garage, Garage");
        }
    }

    class voitur : vehicule
    {
        public string modelName = "Mustang";
    }
}
