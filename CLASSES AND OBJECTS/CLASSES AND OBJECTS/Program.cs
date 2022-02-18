using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne// namespace must be the same between class and this.
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck); // this will shuffle the deck
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            //deck.Cards = new List<Card>();// this is a long and annoying way to do this, this is where we would use a constructor.



            //Card cardOne = new Card();

            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);



            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)// method to shuffle deck
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
