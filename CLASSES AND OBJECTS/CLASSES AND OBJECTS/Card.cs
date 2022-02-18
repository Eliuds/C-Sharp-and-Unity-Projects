using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
   public class Card// must be public in order to be used in another part of the program.
    {
        public Card()// default value if we dont assign any, called constructor.
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
