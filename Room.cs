using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lag_hus
{
    internal class Room
    {
        public string squareMeter { get; private set; }
        public string type { get; private set; }
        public string colorOnWalls { get; private set; }

        public Room(string squaremeter, string Type, string coloronwalls)
        {
            squareMeter = squaremeter;
            type = Type;
            colorOnWalls = coloronwalls;
        }

        public Room()
        {
        }

        public void setRoom()
        {
            Console.WriteLine("Hvor stort er det i m^2?");
            squareMeter = Console.ReadLine();

            Console.WriteLine("Hvilket type rom er det?");
            type = Console.ReadLine();

            Console.WriteLine("Hvilket farge er det på veggene?");
            colorOnWalls = Console.ReadLine();
        }
    }
}
