﻿
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Player : Entity
{
    public int DistanceFromPlayer { get; set; }
    public Player(int xCord, int yCord)
    {
        CharacterChar = '@';
        CharacterColor = ConsoleColor.Magenta;

        CoordX = xCord;
        CoordY = yCord;

        HealthPoints = 25;
    }

    public void Update(LevelElement element, List<LevelElement> list)
    {
        if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
        {
            Delete();
            MoveOneStep("left", list);
        }
        else if (Console.ReadKey().Key == ConsoleKey.RightArrow)
        {
            Delete();
            MoveOneStep("right", list);
        }
        else if (Console.ReadKey().Key == ConsoleKey.DownArrow)
        {
            Delete();
            MoveOneStep("down", list);
        }
        else if (Console.ReadKey().Key == ConsoleKey.UpArrow)
        {
            Delete();
            MoveOneStep("up", list);
        }
        else if (Console.ReadKey().Key == ConsoleKey.End) Delete();
        
        Draw(element);
    }
}