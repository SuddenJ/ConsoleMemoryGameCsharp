using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlipCardConsoleApp
{
    internal class GameControl
    {
        static GameControl()
        {
            CardLogic.cardLogic();
        }
        private static int _matchC;
        public static void Control()
        {
            while (_matchC < 8)
            {
                string input1 = "xx";
                string input2 = "xx";
                Console.Clear();
                Display.display();
                while (!IsValid(input1))
                {
                    Console.WriteLine("Enter the coordinates of the first selection, then click 'Enter'");
                    input1 = Console.ReadLine();
                }
                Console.Clear();
                CardLogic.ListSearch1(input1);
                Display.display();
                while (!IsValid(input2))
                {
                    Console.WriteLine("Enter the coordinates of the second selection, then click 'Enter'");
                    input2 = Console.ReadLine();
                }
                CardLogic.ListSearch2(input2);
                Console.Clear();
                Display.display();

                if (CardLogic.Card1 != CardLogic.Card2)
                {
                    Console.WriteLine("Not a match, try again");
                    int milliseconds = 2000;
                    Thread.Sleep(milliseconds);
                    CardLogic.ResetCard();
                }
                else
                {
                    Console.WriteLine("It's a Match!");
                    _matchC++;
                    int milliseconds2 = 2500;
                    Thread.Sleep(milliseconds2);
                }

            }
            Console.WriteLine("             ");
            Console.WriteLine("!!!You Won!!!");
            _matchC++;
            int milliseconds3 = 2500;
            Thread.Sleep(milliseconds3);



        }
        public static bool IsValid(string inputx)
        {
            char[] chars = inputx.ToCharArray();
            if (chars[0] != 'a' && chars[0] != 'b' && chars[0] != 'c' && chars[0] != 'd')
            {
                return false;
                Console.WriteLine("!!Invalid input!!");
                int milliseconds4 = 1500;
                Thread.Sleep(milliseconds4);
            }
            else if (chars[1] != '1' && chars[1] != '2' && chars[1] != '3' && chars[1] != '4')
            {
                return false;
                Console.WriteLine("!!Invalid input!!");
                int milliseconds5 = 1500;
                Thread.Sleep(milliseconds5);
            }
            return true;
        }
    }
}
