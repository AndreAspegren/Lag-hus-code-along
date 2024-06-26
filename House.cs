﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lag_hus
{
    internal class House
    {
        public List<List<Room>> allFloors = new();

        public void buildHouse()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    $"Du har nå {allFloors.Count} etasjer på huset ditt? Trykk 1 for å lage flere, alt annet for å fullføre huset og vise det fram.");
                var input = Console.ReadLine();

                if (input == "1") buildFloor();
                else if (allFloors.Count > 0) displayHouse();
            }
        }

        private void buildFloor()
        {
            var thisFloor = new Floor();
            thisFloor.addRooms();
            allFloors.Add(thisFloor.floor);
        }

        private void displayHouse()
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
            Console.ReadKey(true);
        }
    }
}
