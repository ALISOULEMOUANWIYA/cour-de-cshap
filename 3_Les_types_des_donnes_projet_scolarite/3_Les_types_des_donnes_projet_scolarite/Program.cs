using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Les_types_des_donnes_projet_scolarite
{
    internal class Program
    {
        // declaration des variable dans la classe main
        static int nombreEntier;
        static double nombreDecimale;
        static float nombreFlotant;
        static long nombreLong;
        static char caracter;
        static String chaine;
        static bool boolean;
        static void Main(string[] args){
            //initiation des varibale
            nombreEntier = 2;
            nombreDecimale = 34e3D;
            nombreFlotant = 98e2F;
            nombreLong = 263L;
            caracter = 'Z';
            chaine = "Ali Soule";
            boolean = true;

            // affichage des resultats
            Console.WriteLine("nombre Entier : "+ nombreEntier);
            Console.WriteLine("nombre Decimale : " + nombreDecimale);
            Console.WriteLine("nombre Flotant : " + nombreFlotant);
            Console.WriteLine("nombre Long : " + nombreLong);
            Console.WriteLine("caracter : " + caracter);
            Console.WriteLine("chaine : " + chaine);
            Console.WriteLine("boolean : " + boolean);
        }
    }
}
