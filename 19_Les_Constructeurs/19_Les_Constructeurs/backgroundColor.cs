using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Les_Constructeurs
{
    internal class backgroundColor
    {
        public void backColor()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;// <-- This line is still white on blue.
        }
        public void ReseCouleur()
        {
            /*Type type = typeof(ConsoleColor);

            foreach (var name in Enum.GetNames(type))
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                Console.WriteLine(name);
            }*/
            Console.ResetColor();
        }
    }
}
