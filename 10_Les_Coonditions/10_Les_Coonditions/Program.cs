using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Les_Coonditions
{
    internal class Program
    {
        static string jour;
        static int heurJour;
        static void Main(string[] args)
        {

            Console.Write("Entrez un jour de la semaine : ");
            jour = Console.ReadLine().ToLower();
            Console.Write("Entrez L\'heur qu\'il est (en heur seulement 00h) : ");
            heurJour = Convert.ToInt32(Console.ReadLine());

            // chaine.equals(chaine);
            // methode equals() = egale 
            // cette methode ne prend pas de casse: (majiscule ou le miniscule)
            if (jour.Equals("lundi"))
            {
                if (heurJour >= 6 && heurJour <= 12)
                {
                    if (heurJour < 10)
                    {
                        Console.WriteLine("JAVA:)");
                    }
                    else
                    {
                        Console.WriteLine("C# :)");
                    }
                }
                else if (heurJour > 12 && heurJour <= 18)
                {
                    if (heurJour < 14)
                    {
                        Console.WriteLine("C++ :)");
                    }
                    else
                    {
                        Console.WriteLine("Python");
                    }
                }
                else
                {
                    if (heurJour >= 19 && heurJour <= 00)
                    {
                        if (heurJour < 22)
                        {
                            Console.WriteLine("JAVASCRIPTE :)");
                        }
                        else
                        {
                            Console.WriteLine("REVISION :)");
                        }
                    }
                }
            }
            else if (jour.Equals("mardi"))
            {
                if (heurJour >= 6 && heurJour <= 12)
                {
                    if (heurJour < 10)
                    {
                        Console.WriteLine("JAVA:)");
                    }
                    else
                    {
                        Console.WriteLine("C# :)");
                    }
                }
                else if (heurJour >= 12 && heurJour <= 18)
                {
                    if (heurJour < 14)
                    {
                        Console.WriteLine("C++ :)");
                    }
                    else
                    {
                        Console.WriteLine("Python");
                    }
                }
                else
                {
                    if (heurJour >= 19 && heurJour <= 00)
                    {
                        if (heurJour < 22)
                        {
                            Console.WriteLine("JAVASCRIPTE :)");
                        }
                        else
                        {
                            Console.WriteLine("REVISION :)");
                        }
                    }
                }
            }
            else
            {
                if (jour.Equals("mercredi"))
                {
                    if (heurJour >= 6 && heurJour <= 12)
                    {
                        if (heurJour < 10)
                        {
                            Console.WriteLine("JAVA:)");
                        }
                        else
                        {
                            Console.WriteLine("C# :)");
                        }
                    }
                    else if (heurJour >= 12 && heurJour <= 18)
                    {
                        if (heurJour < 14)
                        {
                            Console.WriteLine("C++ :)");
                        }
                        else
                        {
                            Console.WriteLine("Python");
                        }
                    }
                    else
                    {
                        if (heurJour >= 19 && heurJour <= 00)
                        {
                            if (heurJour < 22)
                            {
                                Console.WriteLine("JAVASCRIPTE :)");
                            }
                            else
                            {
                                Console.WriteLine("REVISION :)");
                            }
                        }
                    }
                }
                else if (jour.Equals("jeudi"))
                {
                    if (heurJour >= 6 && heurJour <= 12)
                    {
                        if (heurJour < 10)
                        {
                            Console.WriteLine("JAVA:)");
                        }
                        else
                        {
                            Console.WriteLine("C# :)");
                        }
                    }
                    else if (heurJour >= 12 && heurJour <= 18)
                    {
                        if (heurJour < 14)
                        {
                            Console.WriteLine("C++ :)");
                        }
                        else
                        {
                            Console.WriteLine("Python");
                        }
                    }
                    else
                    {
                        if (heurJour >= 19 && heurJour <= 00)
                        {
                            if (heurJour < 22)
                            {
                                Console.WriteLine("JAVASCRIPTE :)");
                            }
                            else
                            {
                                Console.WriteLine("REVISION :)");
                            }
                        }
                    }
                }
                else
                {
                    if (jour.Equals("vendredi"))
                    {
                        if (heurJour >= 6 && heurJour <= 12)
                        {
                            if (heurJour < 10)
                            {
                                Console.WriteLine("JAVA:)");
                            }
                            else
                            {
                                Console.WriteLine("C# :)");
                            }
                        }
                        else if (heurJour >= 12 && heurJour <= 18)
                        {
                            if (heurJour < 14)
                            {
                                Console.WriteLine("C++ :)");
                            }
                            else
                            {
                                Console.WriteLine("Python");
                            }
                        }
                        else
                        {
                            if (heurJour >= 19 && heurJour <= 00)
                            {
                                if (heurJour < 22)
                                {
                                    Console.WriteLine("JAVASCRIPTE :)");
                                }
                                else
                                {
                                    Console.WriteLine("REVISION :)");
                                }
                            }
                        }
                    }
                    else if (jour.Equals("samedi"))
                    {
                        if (heurJour >= 6 && heurJour <= 12)
                        {
                            if (heurJour < 10)
                            {
                                Console.WriteLine("SPORT");
                            }
                            else
                            {
                                Console.WriteLine("DIVERTISSEMENT :)");
                            }
                        }
                        else if (heurJour >= 12 && heurJour <= 18)
                        {
                            if (heurJour < 14)
                            {
                                Console.WriteLine(" UN PLAN N°1");
                            }
                            else
                            {
                                Console.WriteLine("PROMENADE");
                            }
                        }
                        else
                        {
                            if (heurJour >= 19 && heurJour <= 00)
                            {
                                if (heurJour < 22)
                                {
                                    Console.WriteLine("REVISION DU PLAN N°1 :)");
                                }
                                else
                                {
                                    Console.WriteLine("CONFIRMATION DU PLAN N°1 :)");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (heurJour >= 6 && heurJour <= 12)
                        {
                            if (heurJour < 10)
                            {
                                Console.WriteLine("SPORT");
                            }
                            else
                            {
                                Console.WriteLine("DIVERTISSEMENT :)");
                            }
                        }
                        else if (heurJour >= 12 && heurJour <= 18)
                        {
                            if (heurJour < 14)
                            {
                                Console.WriteLine(" UN PLAN N°2");
                            }
                            else
                            {
                                Console.WriteLine("PROMENADE");
                            }
                        }
                        else
                        {
                            if (heurJour >= 19 && heurJour <= 00)
                            {
                                if (heurJour < 22)
                                {
                                    Console.WriteLine("REVISION DU PLAN N°2 :)");
                                }
                                else
                                {
                                    Console.WriteLine("CONFIRMATION DU PLAN N°2 :)");
                                }
                            }
                        }
                    }
                }
            }
            Console.Write("Entrez un jour de la semaine : ");
            jour = Console.ReadLine().ToLower();
            Console.Write("Entrez L\'heur qu\'il est (en heur seulement 00h) : ");
            heurJour = Convert.ToInt32(Console.ReadLine());

            switch (jour)
            {
                case "lundi":
                    if (heurJour >= 6 && heurJour <= 12)
                    {
                        if (heurJour < 10)
                        {
                            Console.WriteLine("JAVA:)");
                        }
                        else
                        {
                            Console.WriteLine("C# :)");
                        }
                    }
                    else if (heurJour > 12 && heurJour <= 18)
                    {
                        if (heurJour < 14)
                        {
                            Console.WriteLine("C++ :)");
                        }
                        else
                        {
                            Console.WriteLine("Python");
                        }
                    }
                    else
                    {
                        if (heurJour >= 19 && heurJour <= 00)
                        {
                            if (heurJour < 22)
                            {
                                Console.WriteLine("JAVASCRIPTE :)");
                            }
                            else
                            {
                                Console.WriteLine("REVISION :)");
                            }
                        }
                    }
                    break;
                case "mardi":
                    if (heurJour >= 6 && heurJour <= 12)
                    {
                        if (heurJour < 10)
                        {
                            Console.WriteLine("JAVA:)");
                        }
                        else
                        {
                            Console.WriteLine("C# :)");
                        }
                    }
                    else if (heurJour > 12 && heurJour <= 18)
                    {
                        if (heurJour < 14)
                        {
                            Console.WriteLine("C++ :)");
                        }
                        else
                        {
                            Console.WriteLine("Python");
                        }
                    }
                    else
                    {
                        if (heurJour >= 19 && heurJour <= 00)
                        {
                            if (heurJour < 22)
                            {
                                Console.WriteLine("JAVASCRIPTE :)");
                            }
                            else
                            {
                                Console.WriteLine("REVISION :)");
                            }
                        }
                    }
                    break;
                case "mercredi":
                    if (heurJour >= 6 && heurJour <= 12)
                    {
                        if (heurJour < 10)
                        {
                            Console.WriteLine("JAVA:)");
                        }
                        else
                        {
                            Console.WriteLine("C# :)");
                        }
                    }
                    else if (heurJour > 12 && heurJour <= 18)
                    {
                        if (heurJour < 14)
                        {
                            Console.WriteLine("C++ :)");
                        }
                        else
                        {
                            Console.WriteLine("Python");
                        }
                    }
                    else
                    {
                        if (heurJour >= 19 && heurJour <= 00)
                        {
                            if (heurJour < 22)
                            {
                                Console.WriteLine("JAVASCRIPTE :)");
                            }
                            else
                            {
                                Console.WriteLine("REVISION :)");
                            }
                        }
                    }
                    break;
                case "jeudi":
                    if (heurJour >= 6 && heurJour <= 12)
                    {
                        if (heurJour < 10)
                        {
                            Console.WriteLine("JAVA:)");
                        }
                        else
                        {
                            Console.WriteLine("C# :)");
                        }
                    }
                    else if (heurJour > 12 && heurJour <= 18)
                    {
                        if (heurJour < 14)
                        {
                            Console.WriteLine("C++ :)");
                        }
                        else
                        {
                            Console.WriteLine("Python");
                        }
                    }
                    else
                    {
                        if (heurJour >= 19 && heurJour <= 00)
                        {
                            if (heurJour < 22)
                            {
                                Console.WriteLine("JAVASCRIPTE :)");
                            }
                            else
                            {
                                Console.WriteLine("REVISION :)");
                            }
                        }
                    }
                    break;
                case "vendredi":
                    if (heurJour >= 6 && heurJour <= 12)
                    {
                        if (heurJour < 10)
                        {
                            Console.WriteLine("JAVA:)");
                        }
                        else
                        {
                            Console.WriteLine("C# :)");
                        }
                    }
                    else if (heurJour > 12 && heurJour <= 18)
                    {
                        if (heurJour < 14)
                        {
                            Console.WriteLine("C++ :)");
                        }
                        else
                        {
                            Console.WriteLine("Python");
                        }
                    }
                    else
                    {
                        if (heurJour >= 19 && heurJour <= 00)
                        {
                            if (heurJour < 22)
                            {
                                Console.WriteLine("JAVASCRIPTE :)");
                            }
                            else
                            {
                                Console.WriteLine("REVISION :)");
                            }
                        }
                    }
                    break;
                case "samedi":
                    if (heurJour >= 6 && heurJour <= 12)
                    {
                        if (heurJour < 10)
                        {
                            Console.WriteLine("SPORT");
                        }
                        else
                        {
                            Console.WriteLine("DIVERTISSEMENT :)");
                        }
                    }
                    else if (heurJour >= 12 && heurJour <= 18)
                    {
                        if (heurJour < 14)
                        {
                            Console.WriteLine(" UN PLAN N°1");
                        }
                        else
                        {
                            Console.WriteLine("PROMENADE");
                        }
                    }
                    else
                    {
                        if (heurJour >= 19 && heurJour <= 00)
                        {
                            if (heurJour < 22)
                            {
                                Console.WriteLine("REVISION DU PLAN N°1 :)");
                            }
                            else
                            {
                                Console.WriteLine("CONFIRMATION DU PLAN N°1 :)");
                            }
                        }
                    }
                    break;
                case "dimanche":
                    if (heurJour >= 6 && heurJour <= 12)
                    {
                        if (heurJour < 10)
                        {
                            Console.WriteLine("SPORT");
                        }
                        else
                        {
                            Console.WriteLine("DIVERTISSEMENT :)");
                        }
                    }
                    else if (heurJour >= 12 && heurJour <= 18)
                    {
                        if (heurJour < 14)
                        {
                            Console.WriteLine(" UN PLAN N°2");
                        }
                        else
                        {
                            Console.WriteLine("PROMENADE");
                        }
                    }
                    else
                    {
                        if (heurJour >= 19 && heurJour <= 00)
                        {
                            if (heurJour < 22)
                            {
                                Console.WriteLine("REVISION DU PLAN N°2 :)");
                            }
                            else
                            {
                                Console.WriteLine("CONFIRMATION DU PLAN N°2 :)");
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine(" Vous avez saisi une chose non demander :(");
                    break;
            }
        }
        /*
        syntaxe N°1:
        -------
        if(condition){
            // instruction
        }
        if(condition){
            // instruction
        }
        .
        .
        .

        syntaxe N°2:
        -------
        if(condition){
            // instruction
        }else{
            // instruction
        }
        .
        .
        .

        syntaxe N°3:
        -------
        if(condition){
            // instruction
        }else if(condition){
            // instruction
        }else{
            // instruction
        }
        .
        .
        .
        syntaxe N°4:
        -----------
        switch(valeur){
            case valeur1:
                // instruction
            break;

            case valeur2:
                // instruction
            break;
            .
            .
            .
            case valeurN:
                // instruction
            break; 

            default:
                // instruction
            break;
        }
        tous choix du utilisation depend de chacun.
        Vous étes libre d'utilisez soit: le syntaxe N°1, ou N°2, Ou bien le N°3 :)
    */
    }
}
