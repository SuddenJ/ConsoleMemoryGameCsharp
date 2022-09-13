using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    //internal should work it limmits the class to the current assemberly
    internal class AppLogic
    {
        // the main memor dictionary
        public List<char> mainList = new List<char>();
        public List<char> inputList = new List<char>();
        public char newChar;

        public AppLogic()
        {
            //First run though
            newChar = CharGetter();
            mainList.Add(newChar);
        }

        public void ContinuedRun()
        {
            newChar = CharGetter();
            mainList.Add(newChar);
        }

        public void DicMaker (string input)
        {
            inputList.Clear();
            char[] chars = input.ToCharArray();
            foreach (char c in chars)
            {
                inputList.Add(c);
            }
        }

        public bool PassFailTest()
        {

            if (mainList.Count != inputList.Count)
                { return false; }
            for (int i = 0; i <= inputList.Count -1; i++)
            {
                if (mainList[i] != inputList[i])
                { return false; }
            }

            return true;
        }
        public static char CharGetter()
        {
            string charz = "abcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            int num = rand.Next(0, charz.Length);
            return charz[num];
        }


    }
}



