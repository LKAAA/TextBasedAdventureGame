using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    class Room
    {

        public int north, east, south, west;

        public string name;
        public string description;

        public Room(int n, int e, int s, int w)
        {
            north = n;
            south = s;
            west = w;
            east = e;
        }

        public override string ToString()
        {
            return ("You are here: " + name + "\n What you see: \n" + description); 
        }

    }
}
