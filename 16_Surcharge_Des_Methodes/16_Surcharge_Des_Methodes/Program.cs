using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Surcharge_Des_Methodes
{
    internal class Program
    {
        static int tailleTableau;
        static int[] tableauV ;
        static void Main(string[] args) {
            Console.Write("\t\t entrez un nombre a la cellule : ");
            tailleTableau = Convert.ToInt32(Console.ReadLine());
            tableauV = new int[tailleTableau];
            tableau(tailleTableau, tableauV);
            afficherValeurTableau(tableauV);
        }

        static int[] tableau(int tailleTableau, int[] tableauV)
        {
            if(tailleTableau != 0)
            {
                Console.WriteLine("\t\t Replissage du tableau ");
                for (int i =0; i < tailleTableau ; i++)
                {
                    Console.Write("\t\t Entrez un nombre a la cellule N°" + i+" : ");
                    tableauV[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return (tableauV);
        }

        static void afficherValeurTableau(int[] tableauV)
        {
            Array.Sort(tableauV);
            for(int i = 0; i < tailleTableau; i++)
            {
                if(i == 0)
                {
                    Console.Write("\t\t[" + tableauV[i] + ", ");
                }else if (tailleTableau == (i+1))
                {
                    Console.Write(tableauV[i] + "]\n");
                }
                else
                {
                    Console.Write(tableauV[i] + ", ");
                }
            }
        }
    }
}
