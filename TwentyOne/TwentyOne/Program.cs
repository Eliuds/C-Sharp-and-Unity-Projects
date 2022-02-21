using System;
using System.Collections.Generic;
namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame();
            Game game = new Game();
            game.Players = new List<string>()  { "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine();



            //Deck deck = new Deck();
            //deck.Shuffles(3);

            //foreach(Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }
    }
}
