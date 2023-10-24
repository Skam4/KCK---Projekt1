﻿

namespace KCK___Projekt1
{
    internal class TabelaWynikow
    {
        string fileName = "wyniki.txt";
        private ConsoleKeyInfo przycisk;
        char[] znakiPliku;

        public TabelaWynikow()
        {
            Console.Clear();

            string sciezkaDoPliku = "TabelaWynikow.txt";

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

            Console.SetCursorPosition(43, 38);
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
                Console.Write($"{i + 1}. {wyniki[i].Item1}            {wyniki[i].Item2} sekund");
                Console.ResetColor();
                Console.SetCursorPosition(0, 0);


                if ((i + 1) % 7 == 0)
                {

                    if (wyniki.Count > i + 1) //Narysuj strzałkę w prawo
                    {
                        Console.SetCursorPosition(94, 17);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Naciśnij strzałkę w prawo,");
                        Console.SetCursorPosition(92, 18);
                        Console.Write("aby sprawdzić reszte rankingu");
                        Console.ResetColor();
                        Console.SetCursorPosition(0, 0);
                    }
                    if (i > 6) //Narysuj strzałkę w lewo
                    {
                        Console.SetCursorPosition(3, 17);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Naciśnij strzałkę w lewo,");
                        Console.SetCursorPosition(7, 18);
                        Console.Write(" aby wrócić");
                        Console.ResetColor();
                        Console.SetCursorPosition(0, 0);
                    }
                    if((i + 1 == wyniki.Count()) || ((wyniki.Count() % 7 == 0) && (wyniki.Count() - i <= 6)))
                    {
                        Console.SetCursorPosition(93, 17);
                        Console.Write("                            ");
                        Console.SetCursorPosition(92, 18);
                        Console.Write("                                ");
                        Console.SetCursorPosition(0, 0);
                    }
                    if(i == 6)
                    {
                        Console.SetCursorPosition(3, 17);
                        Console.Write("                          ");
                        Console.SetCursorPosition(7, 18);
                        Console.Write("            ");
                        Console.SetCursorPosition(0, 0);
                    }

                    for (; ; )
                    {
                        if (Console.KeyAvailable) //Sprawdza czy jest wciśnięty przycisk
                        {
                            przycisk = Console.ReadKey(true); //Przypisanie przycisku który klikneło się na klawiaturze

                            if (przycisk.Key == ConsoleKey.RightArrow && wyniki.Count() != i + 1)
                            {
                                //Rysowanie strzałki podczas kliknięcia
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.SetCursorPosition(111, 19);
                                Console.Write("_");
                                Console.SetCursorPosition(107, 20);
                                Console.Write("____"); Console.Write("\\ "); Console.Write("\\ ");
                                Console.SetCursorPosition(106, 21);
                                Console.Write("|____ ) )");
                                Console.SetCursorPosition(111, 22);
                                Console.Write("/_/");
                                Console.ResetColor();
                                Console.SetCursorPosition(0, 0);

                                if (wyniki.Count - i < 7) //Czyść nieużywane końcowe miejsca w tabeli
                                {
                                    for (int j = 0; j < 7; j++)
                                    {
                                        Console.SetCursorPosition(40, 9 + j * 4);
                                        Console.Write("                                              ");
                                    }
                                    Console.SetCursorPosition(0, 0);
                                }
                                Thread.Sleep(100);

                                //Odrysowanie strzałki podczas kliknięcia
                                Console.SetCursorPosition(111, 19);
                                Console.Write("_");
                                Console.SetCursorPosition(107, 20);
                                Console.Write("____"); Console.Write("\\ "); Console.Write("\\ ");
                                Console.SetCursorPosition(106, 21);
                                Console.Write("|____ ) )");
                                Console.SetCursorPosition(111, 22);
                                Console.Write("/_/");
                                Console.SetCursorPosition(0, 0);
                                break;
                            }
                            if (przycisk.Key == ConsoleKey.LeftArrow)
                            {
                                if(i > 6) //Jeżeli jesteśmy nie na pierwszej stronie tabeli
                                {
                                    //Rysowanie strzałki podczas kliknięcia
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.SetCursorPosition(7, 19);
                                    Console.Write("_");
                                    Console.SetCursorPosition(6, 20);
                                    Console.Write("/ /"); Console.Write("____");
                                    Console.SetCursorPosition(5, 21);
                                    Console.Write("( ( ____|");
                                    Console.SetCursorPosition(6, 22);
                                    Console.Write("\\_\\");
                                    Console.ResetColor();
                                    Console.SetCursorPosition(0, 0);
                                    Thread.Sleep(100);

                                    i = i - 14;

                                    Console.SetCursorPosition(7, 19);
                                    Console.Write("_");
                                    Console.SetCursorPosition(6, 20);
                                    Console.Write("/ /"); Console.Write("____");
                                    Console.SetCursorPosition(5, 21);
                                    Console.Write("( ( ____|");
                                    Console.SetCursorPosition(6, 22);
                                    Console.Write("\\_\\");
                                    Console.SetCursorPosition(0, 0);

                                    break;
                                }
                            }

                            if (przycisk.Key == ConsoleKey.Escape)
                            {
                                Menu menu = new Menu();
                            }

                        }
                    }
                }
                if (i + 1 == wyniki.Count) //Jeżeli pętla jest na ostatnim wyniku
                {

                    Console.SetCursorPosition(93, 17);
                    Console.Write("                            ");
                    Console.SetCursorPosition(92, 18);
                    Console.Write("                                ");
                    Console.SetCursorPosition(0, 0);

                    if (i + 1 >= 7)
                    {
                        Console.SetCursorPosition(3, 17);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Naciśnij strzałkę w lewo,");
                        Console.SetCursorPosition(7, 18);
                        Console.Write(" aby wrócić");
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
                                //Rysowanie strzałki podczas kliknięcia
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.SetCursorPosition(7, 19);
                                Console.Write("_");
                                Console.SetCursorPosition(6, 20);
                                Console.Write("/ /"); Console.Write("____");
                                Console.SetCursorPosition(5, 21);
                                Console.Write("( ( ____|");
                                Console.SetCursorPosition(6, 22);
                                Console.Write("\\_\\");
                                Console.ResetColor();
                                Console.SetCursorPosition(0, 0);
                                Thread.Sleep(100);

                                int pom2 = wyniki.Count % 7;
                                i = i - pom2;
                                i = i - 7;

                                Console.SetCursorPosition(7, 19);
                                Console.Write("_");
                                Console.SetCursorPosition(6, 20);
                                Console.Write("/ /"); Console.Write("____");
                                Console.SetCursorPosition(5, 21);
                                Console.Write("( ( ____|");
                                Console.SetCursorPosition(6, 22);
                                Console.Write("\\_\\");
                                Console.SetCursorPosition(0, 0);

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
