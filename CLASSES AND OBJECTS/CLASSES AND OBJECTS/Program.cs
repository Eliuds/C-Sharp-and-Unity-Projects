using CLASSES_AND_OBJECTS;
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


            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();
            //Game game = new TwentyOneGame();//Overloading Operators
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Anto";
            //game += player;
            //game -= player;





            // DaysOfTheWeek day = DaysOfTheWeek.Monday;
            //ConsoleColor color = ConsoleColor.Green;//make

            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);//enums have integers as underlying data type
            //Console.WriteLine(underlyingValue);

            Deck deck = new Deck();
            deck.Shuffle(3); // this will shuffle the deck 3 times

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        //public enum DaysOfTheWeek// enums limit the input from the user so you wont get errors
        //{
        //    Monday,
        //    Tuesday,
        //    Wednsday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}

       

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i ++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
