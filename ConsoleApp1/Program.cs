﻿using ConsoleApp1;

/* 
Spilbeskrivelse:
Dette program er et simpelt tekstbaseret eventyrspil, hvor spilleren
udforsker et hus og dets omgivelser gennem forskellige rum.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║ Velkommen til eventyrspillet!  ║");
        Console.WriteLine("╠════════════════════════════════╣");
        Console.WriteLine("║ Du skal udforske et hus og     ║");
        Console.WriteLine("║ dets omgivelser.               ║");
        Console.WriteLine("║ Brug kommandoer til at bevæge  ║");
        Console.WriteLine("║ dig og interagere med ting.    ║");
        Console.WriteLine("║                                ║");
        Console.WriteLine("║ Tryk på en tast for at starte. ║");
        Console.WriteLine("╚════════════════════════════════╝");

        Console.ReadKey();

        Game.rooms = Room.CreateAllRooms();                // Opret alle rum
        Player.CurrentRoom = Game.rooms["Rum1"];           // Start i Rum1
        Item.PopulateItems(Game.rooms);                    // Læg alle ting og våben i rummene

        Player.Move(); // Starter spillerens bevægelse

        Console.ReadKey();
    }
}

