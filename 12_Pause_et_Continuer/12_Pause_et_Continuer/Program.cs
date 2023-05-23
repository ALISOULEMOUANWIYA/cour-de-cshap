using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Pause_et_Continuer
{
    internal class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Dans le boucle for  break une fois le conteur arrive a 25");
            for(int i = 1; i <= 50; i++   ){
                if (i == 25) {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("Dans le boucle for  Continuer une fois arrive a 25 sauter le");
            for (int k = 1; k <= 50; k++)
            {
                if (k == 25)
                {
                    // sauter 25
                    continue;
                }
                Console.WriteLine(k);
            }

            int j = 0;
            Console.WriteLine("Dans le boucle while casser une fois arrive a 25");
            while (j < 50)
            {
                j++;
                if (j == 25)
                {
                    break;
                }
                Console.WriteLine(j);
            }

            int h = 0;
            Console.WriteLine("Dans le boucle while continuer une fois arrive a 25 sauter le");
            while (h < 50)
            {
                h++;
                if (h == 25)
                {
                    // sauter 25
                    continue;
                }
                Console.WriteLine(h);
            }
        }
    }
}
