using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Les_Booleans
{
    internal class Program
    {
        static int zero = 0, un = 1;
        static int NombreA , NombreB;
        static void Main(string[] args){
            Console.Write("Entrez un nombre A entier : ");
            NombreA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entrez un nombre B entier : ");
            NombreB = Convert.ToInt32(Console.ReadLine());

            // vrai = true
            // faut = false
                Console.WriteLine("Comparaison Est ce que  A  >  B (?) : "+ (NombreA  >  NombreB));
                Console.WriteLine("Comparaison Est ce que  A >=  B (?) : "+ (NombreA >=  NombreB));
                Console.WriteLine("Comparaison Est ce que  A  <  B (?) : "+ (NombreA  <  NombreB));
                Console.WriteLine("Comparaison Est ce que  A <=  B (?) : "+ (NombreA <=  NombreB));
                Console.WriteLine("Comparaison Est ce que  A ==  B (?) : "+ (NombreA ==  NombreB));
                Console.WriteLine("Comparaison Est ce que  A !=  B (?) : "+ (NombreA !=  NombreB));

            // conVertire un nombre bite( 0 ou 1 ) en Boolean
                Console.WriteLine(zero+" a pour valeur Boolean : " + Convert.ToBoolean(zero));
                Console.WriteLine(un+" a pour valeur Boolean : " + Convert.ToBoolean(un));


        }
    }
}
