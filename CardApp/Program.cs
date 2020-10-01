using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Card myCard = new Card("Q", "♠", 12);
            Console.WriteLine(myCard.Suit);
            string[] ranks = { "1", "2", "3", "4", "5", "6", "7", "8", "9",
                "J", "Q", "K", "A" };
            string[] suits = { "♥", "♦", "♣", "♠" };

            List<Card> deck = new List<Card>();
            for (int r = 0; r < ranks.Length; r++)
            {
                for (int s = 0; s < suits.Length; s++)
                {
                    Card card = new Card(ranks[r], suits[s], r + 1);
                    deck.Add(card);
                }
            }
            Console.WriteLine();


        }
    }
}
