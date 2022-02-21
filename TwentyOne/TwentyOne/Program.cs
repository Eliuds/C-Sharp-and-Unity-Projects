using System;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();

            Deck deck = new Deck();
            deck.Shuffles(3);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
