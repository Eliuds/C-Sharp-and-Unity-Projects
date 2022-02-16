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


            //deck.Cards = new List<Card>();// this is a long and annoying way to do this, this is where we would use a constructor.



            //Card cardOne = new Card();

            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);



            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();
        }
    }
}
