using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
   public class Deck
    {
        public Deck()// constructor a method thats called as soon as a object is created
        {
            Cards = new List<Card>();//instanciate its property which here would be Cards as an empty list of cards
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };//Then creates 2 more list and gives them values.
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Sevem",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            foreach(string face in Faces) // for each face it will loop 4 times cause there is 4 suits.
            {
                foreach (string suit in Suits)//during each loop we creat a card and assign the value of suit and then we assign the face. Then we add that new card to the cards list. the first list the ones thats empty.
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
