using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlipCardConsoleApp;

internal static class CardLogic
{

    private static string[,] bgCard = new string[4, 4];
    public static string? Card1 { get; set;}
    public static string? Card2 { get; set;}
    public static int coordin1 {get; set;}
    public static int coordin2 { get; set;}
    public static int coordin3 { get; set;}
    public static int coordin4 { get; set;}


    public static void cardLogic()
    {
        string[] cards = Constants.Cards();
        var rnd = new Random();

        // Shuffle the array
        for (int i = 0; i < cards.Length; ++i)
        {
            int randomIndex = rnd.Next(cards.Length);
            string temp = cards[randomIndex];
            cards[randomIndex] = cards[i];
            cards[i] = temp;
        }
        int count = 0;

        for (int i = 0; i < bgCard.GetLength(0); i++)
        {
            for (int j = 0; j < bgCard.GetLength(1); j++)
            {
                bgCard[i, j] = cards[count];
                count++;
            }
        }



    }

    static Dictionary<char, int> inboundRow = new Dictionary<char, int>(4)
    {
        {'a',0},
        {'b',1},
        {'c',2},
        {'d',3}
    };
    static Dictionary<char, int> inboundCol = new Dictionary<char, int>(4)
    {
        {'1',0},
        {'2',1},
        {'3',2},
        {'4',3}
    };



    public static void ListSearch1(string inP)
    {
        char[] chars = inP.ToCharArray();

        coordin2 = inboundRow[chars[0]];
        coordin1 = inboundCol[chars[1]];

        Card1 = bgCard[coordin1, coordin2];
        Display.displayCard[coordin1, coordin2] = bgCard[coordin1, coordin2];

    }
    public static void ListSearch2(string inP)
    {
        char[] chars = inP.ToCharArray();

        coordin4 = inboundRow[chars[0]];
        coordin3 = inboundCol[chars[1]];

        Card2 = bgCard[coordin3, coordin4];
        Display.displayCard[coordin3, coordin4] = bgCard[coordin3, coordin4];

    }
    public static void ResetCard()
    {
        Display.displayCard[coordin1, coordin2] = " - ";
        Display.displayCard[coordin3, coordin4] = " - ";
    }
}






/* old code
* public CardLogic()
    {
        //To Randomise all 16 cards
        // !!!! needs implementing this is a temp not random
        for (var i = 0; i < 4; i++)
        {
            for (var j = 0; j < 4; j++)
            {
                Cards[i,j] = 0;
            }

        }
    }
* 
* 
*/
