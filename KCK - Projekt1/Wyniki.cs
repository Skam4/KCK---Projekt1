﻿using System;
using System.IO;
using System.Text;

namespace KCK___Projekt1
{
    internal class Wyniki
    {
        private long czas;
        private ConsoleKeyInfo przycisk;
        char[] znakiPliku;
        double czasWynik;

        public Wyniki(long czas)
        {
            this.czas = czas;
            czasWynik = czas;
            czasWynik = czasWynik / 1000;

            Console.Clear();

            string sciezkaDoPliku = "KCKWyniki.txt";

            string zawartoscPliku = File.ReadAllText(sciezkaDoPliku);

            znakiPliku = zawartoscPliku.ToCharArray();

            int pom = 0; //zmienna która liczy ilość wgranych znaków z plików

            foreach (char c in znakiPliku)
            {
                pom++;
                Console.Write(c);
                Console.ResetColor();
            }

            Console.SetCursorPosition(49, 14);
            Console.Write("TWÓJ CZAS: ");
            Console.Write(czasWynik);
            Console.Write(" sekund.");

            Console.SetCursorPosition(28, 16);
            Console.Write("Jeżeli chcesz zapisać swój wynik, kliknij 1 i wpisz swóją nazwę.");
            Console.SetCursorPosition(30, 17);
            Console.Write("Jeżeli nie chcesz zapisać wyniku kliknij 0 i wróć do menu.");

            Console.SetCursorPosition(28, 19);
            Console.Write("  1. Wpisz swoją nazwę");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(67, 19);
            Console.Write("ESC. Wróc do menu");
            Console.ResetColor();

            Console.SetCursorPosition(0, 0);

            for(; ; )
            {
                if (Console.KeyAvailable) //Sprawdza czy jest wciśnięty przycisk
                {
                    przycisk = Console.ReadKey(true); //Przypisanie przycisku który klikneło się na klawiaturze

                    if (przycisk.Key == ConsoleKey.D1)
                    {
                        string nazwa = "";
                        Console.SetCursorPosition(30, 22);
                        Console.Write("Wpisz swoją nazwę i kliknij ENTER: ");
                        for (; ; )
                        {
                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                break; // Zakończ pętlę po naciśnięciu Enter.
                            }
                            else if (keyInfo.Key == ConsoleKey.Backspace && nazwa.Length > 0)
                            {
                                // Jeśli użytkownik naciśnie Backspace i nazwa nie jest pusta, usuń ostatni znak.
                                nazwa = nazwa.Substring(0, nazwa.Length - 1);
                            }
                            else if (nazwa.Length < 15)
                            {
                                // Jeśli długość nazwy jest mniejsza niż 15 znaków, dodaj kolejny znak.
                                nazwa += keyInfo.KeyChar;
                            }

                            // Wypisz aktualną zawartość nazwy.
                            Console.SetCursorPosition(65, 22);
                            Console.Write(new string(' ', 20)); // Wyczyść poprzednią zawartość
                            Console.SetCursorPosition(66, 22);
                            Console.Write(nazwa);
                        }

                        string fileName = "wyniki.txt";

                        using (StreamWriter wyniki = new StreamWriter(fileName, true))
                        {
                            wyniki.WriteLine($"{nazwa} {czasWynik}");
                        }

                        TabelaWynikow tabela = new TabelaWynikow();
                    }


                    if (przycisk.Key == ConsoleKey.Escape)
                    {
                        Menu menu = new Menu();
                    }
                }
            }
        }
    }
}
