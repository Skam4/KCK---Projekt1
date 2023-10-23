using System;
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

            string sciezkaDoPliku = "C:/Users/ostat/Desktop/KCKWyniki.txt";

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
                        Console.SetCursorPosition(30, 22);
                        Console.Write("Wpisz swoją nazwę i kliknij ENTER: ");
                        string nazwa = Console.ReadLine();    //TRZEBA ZROBIĆ ZAKRES WPISYWANIA NAZWY!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1

                        string fileName = "C:\\Users\\ostat\\Desktop\\wyniki.txt";

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
