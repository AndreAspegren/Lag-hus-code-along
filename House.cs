using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lag_hus
{
    internal class House
    {
        public List<List<Room>> allFloors;
        public int numberOfFloors;
        public void buildHouse()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    $"Du har nå {numberOfFloors} etasjer på huset ditt? Trykk 1 for å lage flere, alt annet for å fullføre huset og vise det fram.");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    var thisFloor = new Floor();
                    thisFloor.addRooms();
                    allFloors.Add(thisFloor.floor);
                    numberOfFloors++;
                }
                else if (allFloors.Count > 0)
                {
                    displayHouse();
                    break;
                }
            }
        }

        public void displayHouse()
        {
            for(var i = 0; i < allFloors.Count; i++)
            {
                foreach (var room in allFloors[i])
                {
                    Console.WriteLine($@"
Etasje nummer: {i + 1}
Romstørrelse: {room.squareMeter}
Romtype: {room.type}
Farge på veggene: {room.colorOnWalls}
");
                }
            }
        }
    }
}
