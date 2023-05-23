using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Getter_et_Setter
{
    internal class background
    {
        public void backColor()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;// <-- This line is still white on blue.
        }
        public void ResetCouleur()
        {
            Console.ResetColor();
        }
    }
}
