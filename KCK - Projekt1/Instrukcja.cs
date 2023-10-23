﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCK___Projekt1
{
    internal class Instrukcja
    {

        Postac postac = new Postac(79, 13);
        private ConsoleKeyInfo przycisk;

        public Instrukcja()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("                     _  _      ____  _____  ____  _     _  __ ____     _  ____ ");
            Console.WriteLine("                    / \\/ \\  /|/ ___\\/__ __\\/  __\\/ \\ /\\/ |/ //   _\\   / |/  _ \\");
            Console.WriteLine("                    | || |\\ |||    \\  / \\  |  \\/|| | |||   / |  /     | || / \\|");
            Console.WriteLine("                    | || | \\||\\___ |  | |  |    /| \\_/||   \\ |  \\_ /\\_| || |-||");
            Console.WriteLine("                    \\_/\\_/  \\|\\____/  \\_/  \\_/\\_\\\\____/\\_|\\_\\\\____/\\____/\\_/ \\|");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     W grze poruszasz się za pomocą strzałek albo za pomocą 'wsad': ");

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("     Wejdź się do zielonego portalu, aby dostać się do następnego poziomu: ");

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.Write("     Unikaj wszytkiego co jest czerwone, w innym przypadku zginiesz: ");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" -->       ██");
            Console.ResetColor();

            Console.SetCursorPosition(75, 10);
            Console.Write("╔═════════╗");
            Console.SetCursorPosition(75, 13);
            Console.Write("║         ║");
            Console.SetCursorPosition(75, 12);
            Console.Write("║         ║");
            Console.SetCursorPosition(75, 11);
            Console.Write("║         ║");
            Console.SetCursorPosition(75, 14);
            Console.Write("║         ║");
            Console.SetCursorPosition(75, 15);
            Console.Write("║         ║");
            Console.SetCursorPosition(75, 16);
            Console.Write("╚═════════╝");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(78, 19);
            Console.WriteLine("╔╗");
            Console.SetCursorPosition(78, 20);
            Console.WriteLine("╚╝");
            Console.WriteLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(47, 31);
            Console.WriteLine("Wciśnij ESC aby wrócić do MENU");
            Console.ResetColor();

            //Ustaw pozycję postaci i narysują postać
            Console.SetCursorPosition(postac.GetX(), postac.GetY());
            Console.Write("██");
            Console.SetCursorPosition(0, 0);

            for (; ; )
            {

                if (Console.KeyAvailable) //Sprawdza czy jest wciśnięty przycisk
                {
                    przycisk = Console.ReadKey(true); //Przypisanie przycisku który klikneło się na klawiaturze

                    Console.SetCursorPosition(postac.GetX(), postac.GetY());
                    Console.Write("  ");

                    if (przycisk.Key == ConsoleKey.UpArrow || przycisk.Key == ConsoleKey.W) //Jeżeli naciśnięta strzałka w górę lub "w"
                    {
                        if (postac.GetY() >= 12) //Górna granica mapy
                        {
                            postac = new Postac(postac.GetX(), postac.GetY() - 1); //Przzesuń postać w górę
                        }
                    }
                    if (przycisk.Key == ConsoleKey.DownArrow || przycisk.Key == ConsoleKey.S) //Jeżeli naciśnięta strzałka w dół lub "s"
                    {
                        if (postac.GetY() <= 14) //Dolna granica mapy
                        {
                            postac = new Postac(postac.GetX(), postac.GetY() + 1); //Przesuń postać w dół
                        }
                    }

                    if (przycisk.Key == ConsoleKey.LeftArrow || przycisk.Key == ConsoleKey.A) //Jeżeli naciśnięta strzałka w lewo lub "a"
                    {
                        if (postac.GetX() >= 77) //Lewa granica mapy
                        {
                            postac = new Postac(postac.GetX() - 1, postac.GetY()); //Przesuń postać w lewo
                        }
                    }

                    if (przycisk.Key == ConsoleKey.RightArrow || przycisk.Key == ConsoleKey.D) //Jeżeli naciśnięta strzałka w prawo lub "d"
                    {
                        if (postac.GetX() <= 82) //Prawa granica mapy
                        {
                            postac = new Postac(postac.GetX() + 1, postac.GetY()); //Przesuń postać w prawo
                        }
                    }

                    if(przycisk.Key == ConsoleKey.Escape)
                    {
                        Menu menu = new Menu();
                    }


                    //Ustaw pozycję postaci i narysują postać
                    Console.SetCursorPosition(postac.GetX(), postac.GetY());
                    Console.Write("██");
                    Console.SetCursorPosition(0, 0);
                }
                
            }
        }
    }
}
