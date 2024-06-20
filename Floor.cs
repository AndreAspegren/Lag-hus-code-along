using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lag_hus
{
    internal class Floor
    {
        public List<Room> floor = new();

        public void addRooms()
        {
            while (floor.Count < 5)
            {
                Console.Clear();
                Console.WriteLine($"Skriv ja for å legge til et rom? Du har satt {floor.Count} av 5 rom");
                if (Console.ReadLine() == "ja")
                {
                    var room = new Room();
                    room.setRoom();
                    if (!floor.Any(f => (f.type == "kjøkken" && type == "kjøkken") || (f.type == "bad" && type == "bad")))
                    {
                        floor.Add(new Room(room.squareMeter, room.type, room.colorOnWalls));
                        continue;
                    }
                    Console.WriteLine($"Etasjen kan bare ha 1 {room.type}. Prøv på nytt!");
                    Console.ReadKey(true);
                }
            }
        }
    }
}
