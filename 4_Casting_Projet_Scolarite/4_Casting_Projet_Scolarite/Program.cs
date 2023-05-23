using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Casting_Projet_Scolarite
{
    internal class Program
    {
        // Declaration des carible de la classe main
        static int nombreEntier;
        static double nombreDecimale;
        static float nombreFlotant;
        static long nombreLong;
        static String chaine;
        static char character;
        static bool boolean;
        static void Main(string[] args){
            // initialisation des donne
            nombreEntier = 23;
            nombreDecimale = 23.9;
            nombreFlotant = 12.0F;
            nombreLong = 19;
            chaine = "ALI SOULE";
            character = 'z';
            boolean = true;

            //afficheage N°1 des resultat
            Console.WriteLine("nombre Entier : "+ nombreEntier);
            Console.WriteLine("nombre Decimale : "+ nombreDecimale);
            Console.WriteLine("nombre Flotant : "+ nombreFlotant);
            Console.WriteLine("nombre Long : "+ nombreLong);
            Console.WriteLine("chaine : "+ chaine);
            Console.WriteLine("character : "+ character);
            Console.WriteLine("boolean : "+ boolean);

            // Casting N°1 des donne
            nombreEntier = 23;
            nombreLong = 19;
            nombreDecimale = nombreEntier;
            nombreFlotant = nombreLong;
            chaine = "ALI SOULE";
            character = 'z';
            boolean = true;

            //afficheage N°2 des resultat
            Console.WriteLine("nombre Entier : " + nombreEntier);
            Console.WriteLine("nombre Decimale : " + nombreDecimale);
            Console.WriteLine("nombre Flotant : " + nombreFlotant);
            Console.WriteLine("nombre Long : " + nombreLong);
            Console.WriteLine("chaine : " + chaine);
            Console.WriteLine("character : " + character);
            Console.WriteLine("boolean : " + boolean);

            // Casting N°2 des donne
            nombreDecimale = 23.9;
            nombreEntier = (int)nombreDecimale;
            nombreFlotant = 12.0F;
            nombreLong = (long) nombreFlotant;
            chaine = "ALI SOULE";
            character = 'z';
            boolean = true;

            //afficheage N°3 des resultat
            Console.WriteLine("nombre Entier : " + nombreEntier);
            Console.WriteLine("nombre Decimale : " + nombreDecimale);
            Console.WriteLine("nombre Flotant : " + nombreFlotant);
            Console.WriteLine("nombre Long : " + nombreLong);
            Console.WriteLine("chaine : " + chaine);
            Console.WriteLine("character : " + character);
            Console.WriteLine("boolean : " + boolean);

            // Casting N°3 des donne
            nombreEntier = 0;
            nombreDecimale = 23.9;
            nombreFlotant = 12.0F;
            nombreLong = 19;
            chaine = "ALI SOULE";
            character = 'z';
            boolean = true;

            //afficheage N°4 des resultat
            Console.WriteLine("nombre Entier : " + Convert.ToInt32(nombreDecimale));
            Console.WriteLine("nombre Decimale : " + Convert.ToDouble(nombreFlotant));
            Console.WriteLine("nombre Flotant : " + nombreFlotant); // pas possible pour le moment
            Console.WriteLine("nombre Long : " + Convert.ToInt64(nombreFlotant));
            Console.WriteLine("chaine : " + Convert.ToString(boolean)); 
            Console.WriteLine("character : " + character); // pas possible pour le moment
            Console.WriteLine("boolean : " + Convert.ToBoolean(nombreEntier));
        }
    }
}
