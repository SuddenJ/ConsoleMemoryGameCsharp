using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCardConsoleApp
{
    internal class Constants
    {

        public static string[] Cards()
        {
            string[] Const = new string[16]
            {
            " A "," B "," C "," D "," E "," F "," G "," H "," A "," B "," C "," D "," E "," F "," G "," H "
            };
            return Const;
        }



    // will update to cards later, just using single charictors for now
    // updating to cards means printing line by line of each card - fun but time consuming

    /*
    public static readonly string[] Const = new string[9] 
    {"-----\n| x |\n-----", "-----\n| A |\n-----", "-----\n| B |\n-----", "-----\n| C |\n-----", 
        "-----\n| D |\n-----", "-----\n| E |\n-----", "-----\n| F |\n-----", "-----\n| G |\n-----", 
        "-----\n| H |\n-----"};




    public static void Blank()
    {
        Console.WriteLine("-----\n| x |\n-----");
    }
    public static void A()
    {
        Console.WriteLine("-----\n| A |\n-----");
    }
    public static void B()
    {
        Console.WriteLine("-----\n| B |\n-----");
    }
    public static void C()
    {
        Console.WriteLine("-----\n| C |\n-----");
    }
    public static void D()
    {
        Console.WriteLine("-----\n| D |\n-----");
    }
    public static void E()
    {
        Console.WriteLine("-----\n| E |\n-----");
    }
    public static void F()
    {
        Console.WriteLine("-----\n| F |\n-----");
    }
    public static void G()
    {
        Console.WriteLine("-----\n| G |\n-----");
    }
    public static void H()
    {
        Console.WriteLine("-----\n| H |\n-----");
    }
    */
}

}
