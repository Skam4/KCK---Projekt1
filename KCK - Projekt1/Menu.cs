﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Menu
{
    private ConsoleKeyInfo przycisk;

    public Menu()
    {
        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("\n");

        //Zmienne dotyczące MENU
        int LogoLenght = 65; //Długość loga gry
        int LogoPlace = (120 - LogoLenght) / 2; //Ilość spacji do środka konsoli
        int JedenLenght = 14; //Długość Pierwszej opcji w menu
        int JedenPlace = (120 - JedenLenght) / 2;
        int DwaLenght = 8; //Długość opcji numer 2 w menu
        int DwaPlace = (120 - DwaLenght) / 2; //obliczamy miejsce w poziomie według długości liter
        int TrzyLenght = 11;
        int TrzyPlace = (120 - TrzyLenght) / 2;

        for (; ; )
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.Write(new string(' ', LogoPlace)); Console.WriteLine("  ______                                                      ");
            Console.Write(new string(' ', LogoPlace)); Console.WriteLine(" |  ____|                                                     ");
            Console.Write(new string(' ', LogoPlace)); Console.WriteLine(" | |__   ___  ___ __ _ _ __   ___   _ __ ___   ___  _ __ ___  ");
            Console.Write(new string(' ', LogoPlace)); Console.WriteLine(" |  __| / __|/ __/ _` | '_ \\ / _ \\ | '__/ _ \\ / _ \\| '_ ` _ \\ ");
            Console.Write(new string(' ', LogoPlace)); Console.WriteLine(" | |____\\__ \\ (_| (_| | |_) |  __/ | | | (_) | (_) | | | | | |");
            Console.Write(new string(' ', LogoPlace)); Console.WriteLine(" |______|___/\\___\\__,_| .__/ \\___| |_|  \\___/ \\___/|_| |_| |_|");
            Console.Write(new string(' ', LogoPlace)); Console.WriteLine("                      | |                                     ");
            Console.Write(new string(' ', LogoPlace)); Console.WriteLine("                      |_|                                     ");

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(new string(' ', JedenPlace) + "1. Rozpocznij gre");

            Console.WriteLine("\n");
            Console.WriteLine(new string(' ', DwaPlace) + "2. Opcje");

            Console.WriteLine("\n");
            Console.WriteLine(new string(' ', TrzyPlace) + "3. Wyjdz z gry");

            Thread.Sleep(300);
            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.Write(new string(' ', LogoPlace + 1)); Console.WriteLine("   ______                                                      ");
            Console.Write(new string(' ', LogoPlace + 1)); Console.WriteLine("  |  ____|                                                     ");
            Console.Write(new string(' ', LogoPlace + 1)); Console.WriteLine("  | |__   ___  ___ __ _ _ __   ___   _ __ ___   ___  _ __ ___  ");
            Console.Write(new string(' ', LogoPlace + 1)); Console.WriteLine("  |  __| / __|/ __/ _` | '_ \\ / _ \\ | '__/ _ \\ / _ \\| '_ ` _ \"");
            Console.Write(new string(' ', LogoPlace + 1)); Console.WriteLine("  | |____\\__ \\ (_| (_| | |_) |  __/ | | | (_) | (_) | | | | | |");
            Console.Write(new string(' ', LogoPlace + 1)); Console.WriteLine("  |______|___/\\___\\__,_| .__/ \\___| |_|  \\___/ \\___/|_| |_| |_|");
            Console.Write(new string(' ', LogoPlace + 1)); Console.WriteLine("                       | |                                     ");
            Console.Write(new string(' ', LogoPlace + 1)); Console.WriteLine("                       |_|                                     ");

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(new string(' ', JedenPlace) + "1. Rozpocznij gre");

            Console.WriteLine("\n");
            Console.WriteLine(new string(' ', DwaPlace) + "2. Opcje");

            Console.WriteLine("\n");
            Console.WriteLine(new string(' ', TrzyPlace) + "3. Wyjdz z gry");

            Thread.Sleep(300);
            Console.Clear();

            if (Console.KeyAvailable) //Sprawdza czy jest wciśnięty przycisk
            {
                przycisk = Console.ReadKey(true);

                if(przycisk.Key == ConsoleKey.D1) //Jeżeli wciśniemy 1 to idź do poziomu 1
                {
                    Poziom1 poziom = new Poziom1(); 
                }
                if (przycisk.Key == ConsoleKey.D2) //Jeżeli wciśniemy 2 to idź do opcji
                {
                    Opcje opcje = new Opcje();
                }
                if (przycisk.Key == ConsoleKey.D3) //Jeżeli wciśniemy 3 to wyjdź z gry
                {
                    Poziom1 poziom = new Poziom1();
                }

            }

        }
    }
}

