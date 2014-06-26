using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;

namespace CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck=new Deck();
            newDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Card newCard = newDeck.GetCard(i);
                Console.WriteLine(newCard.ToString());
                if (i!=51)
                {
                    Console.WriteLine(", ");

                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
