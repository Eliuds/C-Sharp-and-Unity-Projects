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
            //int number = 5;//a struc is a class that is a value type
            //Card card1 = new Card();
            //Card card2 = card1;// says whatever value is given to card 2 is gonna be card 1s value as well
            //card1.Face = Face.eight;
            //card2.Face = Face.king;// by changing the classes on card to struct now card one and 2 dont interfere they are different cards.

            //Console.WriteLine(card1.Face);

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

           // Deck deck = new Deck();

            // int count = deck.Cards.Count(x => x.Face == Face.ace);


            // List<Card> newList = deck.Cards.Where(x => x.Face == Face.king).ToList();

            //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            //int sum = numberList.Where(x => x > 20).Sum();

            //Console.WriteLine(sum);
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}
           

            //deck.Shuffle(3); // this will shuffle the deck 3 times

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
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
