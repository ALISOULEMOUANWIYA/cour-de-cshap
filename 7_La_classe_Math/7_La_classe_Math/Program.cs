using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_La_classe_Math
{
    internal class Program
    {
        static double longueur, largeur, hauteur, perimetre, demiPerimetre, poids, masse, temps, vitese, hautTI, longTir;
        static void Main(string[] args){
            Console.WriteLine("Calcule du Perimetre et demi-Perimetre d\' un rectangle");
            
            Console.Write("Entrez La longueur : ");
            longueur = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez La largeur : ");
            largeur = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            perimetre = (longueur + largeur) * 2;
            Console.WriteLine(" Perimetre = " + perimetre + " m");

            demiPerimetre = perimetre / 2;
            Console.WriteLine(" demi-Perimetre Perimetre = " + demiPerimetre + " m");

            Console.WriteLine("Consideron que cet rectangle a de la forme 3D avec une poid specific ");
            Console.WriteLine("Calculons son poids ");

            Console.Write("Entrez La Masse du rectangle a de la forme 3D : ");
            masse = Convert.ToDouble(Console.ReadLine());
            poids = masse * 10;
            Console.WriteLine("Le poois = "+ poids + " N");

            Console.WriteLine("Maintenant le cube est maintenant en chute libre ");
            Console.Write("Entrez la hauteur entre le sol le rectangle :  ");
            hauteur = Convert.ToDouble(Console.ReadLine());
            temps = Math.Sqrt((2 * hauteur) / 2);
            Console.WriteLine("Temps de chute T = " + temps + " s");

            Console.WriteLine("Le rectangle est lancee en trajectoire projectile projectile avec un angle de tire de 30 deg ");
            Console.Write("Entrez la vitesse tire pour calculer la hauteur de tire et la longueur de tire : ");
            vitese = Convert.ToDouble(Console.ReadLine());
            hautTI = (Math.Pow(vitese, 2)* Math.Pow(Math.Sin(30), 2))/20;
            longTir = (Math.Pow(vitese, 2)* Math.Sin(2*30))/10;
            Console.WriteLine("Hauteur de tire Ht = " + hautTI+ " m");
            Console.WriteLine("Longuer de tire Lt = " + longTir + " m");

        }
    }
}
