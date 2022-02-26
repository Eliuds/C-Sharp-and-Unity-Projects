using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
   public class Card// must be public in order to be used in another part of the program.
    {
        //public Card()// default value if we dont assign any, called constructor.
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    public enum Suit// in enum the content is given an order kind of like indexes starting at 0, but we can assign any value we want to it.
    {
        Clubs,//0
        Diamonds,//1
        Heart,//2
        Spades//3
    }

    public enum Face
    {
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        jack,
        queen,
        king,
        ace
    }
}
