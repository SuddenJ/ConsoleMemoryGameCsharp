using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class Controler
    {
        AppLogic appLogic = new AppLogic();
        string input = "";

        public Controler()
        {
            bool continued = true;
            HashSet<string> nGame = new HashSet<string>();
            nGame.Add("N");
            nGame.Add("n");
            nGame.Add("Q");
            nGame.Add("q");
            string control = string.Empty;

            while (!nGame.Contains(control))
            {
                Console.WriteLine("N = New Game");
                Console.WriteLine("Q = Quit");
                control = Console.ReadLine();
            }
            if (control == "n" || control == "N")
            {
                while(continued)
                {
                    Console.WriteLine($"Remeber this new Charictor: {appLogic.newChar}");
                    Console.WriteLine("click 'ENTER' to continue");
                    Console.ReadLine();
                    Console.Clear();

                    //Set input to "" for next time below
                    while (input == "")
                    {
                        MainInput();
                    }

                    appLogic.DicMaker(input);
                    continued = appLogic.PassFailTest();
                    if (continued)
                    {
                        input = "";
                        appLogic.ContinuedRun();
                    }
                }
                if(!continued)
                {
                    StringBuilder builderM = new StringBuilder();
                    foreach (char x in appLogic.mainList)
                    {
                        // Append each int to the StringBuilder overload.
                        builderM.Append(x).Append("");
                    }


                    Console.WriteLine("Good Try");
                    Console.WriteLine($"The correct answer was {builderM}");
                    Console.WriteLine($"But you answered {input}");
                }


            }

        }
        
        private void MainInput()
        {
            Console.WriteLine("Type the answer and press 'Enter'");
            input = Console.ReadLine();
        }



    }
}



//char newChar = AppLogic.CharGetter();
//List<char> ts = appLogic.mainList;
