using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class Card
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
