using System;
using System.Collections.Generic;
using System.Text;

namespace CLASSES_AND_OBJECTS
{
   public  class TwentyOneGame : Game
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 playes:");
            base.ListPlayers();
        }
    }
}
