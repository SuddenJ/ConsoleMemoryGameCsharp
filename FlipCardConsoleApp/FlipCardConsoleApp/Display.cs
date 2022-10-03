using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCardConsoleApp
{
    
    internal static class Display
    {
        //setting the display variables dv
        public static string dv11 = "1";
        public static string dv12 = "2";
        public static string dv13 = "3";
        public static string dv14 = "4";
        public static string dv15 = "5";
        public static string dv16 = "6";
        public static string dv21 = "A";
        public static string dv22 = " - ";
        public static string dv23 = " - ";
        public static string dv24 = " - ";
        public static string dv25 = " - ";
        public static string dv26 = " - ";
        public static string dv31 = "B";
        public static string dv32 = " - ";
        public static string dv33 = " - ";
        public static string dv34 = " - ";
        public static string dv35 = " - ";
        public static string dv36 = " - ";
        public static string dv41 = "C";
        public static string dv42 = " - ";
        public static string dv43 = " - ";
        public static string dv44 = " - ";
        public static string dv45 = " - ";
        public static string dv46 = " - ";
        public static string dv51 = "D";
        public static string dv52 = " - ";
        public static string dv53 = " - ";
        public static string dv54 = " - ";
        public static string dv55 = " - ";
        public static string dv56 = " - ";


        public static string[,] displayCard = new string[4, 4]
        {
        {dv22,dv23,dv24,dv25},
        {dv32,dv33,dv34,dv35},
        {dv42,dv43,dv44,dv45},
        {dv52,dv53,dv54,dv55}
        };

        public static string[] keyColumn = new string[4] { "1","2","3","4" }; 

        public static void display()
        {
            Console.WriteLine("  a  b  c  d");
            for (int i = 0; i < displayCard.GetLength(0); i++)
            {
                StringBuilder sb = new StringBuilder(displayCard.GetLength(0));

                sb.Append(keyColumn[i]);
                for (int j = 0; j < displayCard.GetLength(1); j++)
                {
                    sb.Append(displayCard[i, j]);
                }
                Console.WriteLine(sb.ToString());
            }
            
        }
    }
    
}
