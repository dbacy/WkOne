using System;
using System.Collections.Generic;
using System.Text;

namespace CardApp
{
    class Card
    {
        //card data
        string rank;
        string suit;
        int val;

        /// <summary>
        /// Gets or sets an interger value for the card. Different card games
        /// would assign different values.
        /// </summary>
        public int Value
        {
            get
            {
                return Val;
            }
            set
            {
                Val = value;
            }
        }

        public string Rank { get => rank; set => rank = value; }
        public string Suit { get => suit; set => suit = value; }
        public int Val { get => val; set => val = value; }

        /// <summary>
        /// Create a card object with the given card rand and suit.
        /// </summary>
        /// <param name="rank">A, K, Q, J, 10, 9, 8, 7, 6, 5, 4, 3, 2</param>
        /// <param name="suit">Use ASCII char for club, spade, heart, or diamond</param>
        public Card(string rank,string suit, int Value)
        {
            this.Rank = rank;
            this.Suit = suit;
            this.val = Value;

        }

        /// <summary>
        /// Display the card rank and suit.
        /// </summary>
        /// <returns>Race and suit as concatenated string</returns>
        public override string ToString()
        {
            return Rank + " " + Suit;
        }

    }
}
