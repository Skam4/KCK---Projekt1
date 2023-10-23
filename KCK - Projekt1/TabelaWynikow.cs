using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KCK___Projekt1
{
    internal class TabelaWynikow
    {
        string fileName = "C:\\Users\\ostat\\Desktop\\wyniki.txt";
        private ConsoleKeyInfo przycisk;
        char[] znakiPliku;

        public TabelaWynikow()
        {
            Console.Clear();

            string sciezkaDoPliku = "C:/Users/ostat/Desktop/TabelaWynikow.txt";

            string zawartoscPliku = File.ReadAllText(sciezkaDoPliku);

            znakiPliku = zawartoscPliku.ToCharArray();

            int pom = 0; //zmienna która liczy ilość wgranych znaków z plików

            foreach (char c in znakiPliku)
            {
                pom++;
                if (pom >= 0 && pom <= 250)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan; //Brama do drugiego poziomu jst koloru zielonego
                }
                Console.Write(c);
                Console.ResetColor();
            }

            Console.SetCursorPosition(44, 38);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Wciśnij ESC. aby wrócić do MENU.");
            Console.ResetColor();

            WyswietlRanking();
        }

        public void WyswietlRanking()
        {
            // Odczytaj wszystkie linie z pliku
            string[] wiersze = File.ReadAllLines(fileName);

            // Lista która przechowuje pary (nazwa, czas)
            List<(string, double)> wyniki = new List<(string, double)>();

            foreach (var wiersz in wiersze)
            {
                string[] czesci = wiersz.Split(' ');
                if (czesci.Length == 2)
                {
                    string nazwa = czesci[0];
                    if (double.TryParse(czesci[1], out double czas))
                    {
                        wyniki.Add((nazwa, czas));
                    }
                }
            }

            // Sortowanie wyników według czasu (rosnąco)
            wyniki.Sort((a, b) => a.Item2.CompareTo(b.Item2));

            int pom = 0;

            // Wyświetlanie rankingu
            for (int i = 0; i < wyniki.Count; i++)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                pom = i % 7;
                Console.SetCursorPosition(40, 9 + pom * 4);
                Console.Write("                                              ");
                Console.SetCursorPosition(40, 9 + pom * 4);
                Console.Write($"{i + 1}. {wyniki[i].Item1}                   {wyniki[i].Item2} sekund");
                Console.ResetColor();


                if ((i + 1) % 7 == 0)
                {

                    if (wyniki.Count > i + 1) //Narysuj strzałkę w prawo
                    {
                        Console.SetCursorPosition(100, 21);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("->");
                        Console.ResetColor();
                        Console.SetCursorPosition(0, 0);
                    }
                    if (i > 6) //Narysuj strzałkę w lewo
                    {
                        Console.SetCursorPosition(15, 21);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("<-");
                        Console.ResetColor();
                        Console.SetCursorPosition(0, 0);
                    }

                    for (; ; )
                    {
                        if (Console.KeyAvailable) //Sprawdza czy jest wciśnięty przycisk
                        {
                            przycisk = Console.ReadKey(true); //Przypisanie przycisku który klikneło się na klawiaturze

                            if (przycisk.Key == ConsoleKey.RightArrow)
                            {
                                Console.SetCursorPosition(100, 21);
                                Console.Write("  ");
                                Console.SetCursorPosition(15, 21);
                                Console.Write("  ");

                                if (wyniki.Count - i < 7) //Czyść nieużywane końcowe miejsca w tabeli
                                {
                                    for (int j = 0; j < 7; j++)
                                    {
                                        Console.SetCursorPosition(40, 9 + j * 4);
                                        Console.Write("                                              ");
                                    }
                                    Console.SetCursorPosition(0, 0);
                                }

                                break;
                            }
                            if (przycisk.Key == ConsoleKey.LeftArrow)
                            {
                                Console.SetCursorPosition(100, 21);
                                Console.Write("  ");
                                Console.SetCursorPosition(15, 21);
                                Console.Write("  ");
                                i = i - 7;
                                break;
                            }
                            if (Console.KeyAvailable) //Sprawdza czy jest wciśnięty przycisk
                            {
                                przycisk = Console.ReadKey(true); //Przypisanie przycisku który klikneło się na klawiaturze

                                if (przycisk.Key == ConsoleKey.Escape)
                                {
                                    Menu menu = new Menu();
                                }
                            }
                        }
                    }
                }
                if (i + 1 == wyniki.Count) //Jeżeli pętla jest na ostatnim wyniku
                {
                    Console.SetCursorPosition(0, 0);
                    if (i > 6) //Narysuj strzałkę w lewo
                    {
                        Console.SetCursorPosition(15, 21);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("<-");
                        Console.ResetColor();
                        Console.SetCursorPosition(0, 0);
                    }
                    for (; ; )
                    {
                        if (Console.KeyAvailable)
                        {
                            przycisk = Console.ReadKey(true);

                            if (przycisk.Key == ConsoleKey.LeftArrow)
                            {
                                Console.SetCursorPosition(100, 21);
                                Console.Write("  ");
                                Console.SetCursorPosition(15, 21);
                                Console.Write("  ");
                                i = i - 7;
                                break;
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
    }
}
