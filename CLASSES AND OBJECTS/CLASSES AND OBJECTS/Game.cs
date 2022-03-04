﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CLASSES_AND_OBJECTS
{
    public abstract class Game// abstract classes are meant to only be inherited from
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set;}

        public abstract void Play();// all classes inheriting this class must have this method
        public virtual void ListPlayers()//virtual method in abstract class means this method gets inherited but has the ability to over ride it
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
