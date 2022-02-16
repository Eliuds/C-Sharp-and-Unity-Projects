using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
   public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            Card cardOne = new Card();
            cardOne.Face = "Two";
            cardOne.Suit = "Hearts";
            Cards.Add(cardOne);
        }
        public List<Card> Cards { get; set; }
    }
}
