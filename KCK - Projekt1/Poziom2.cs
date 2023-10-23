using KCK___Projekt1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Transactions;
using System.Diagnostics;

internal class Poziom2
{

    Postac postac = new Postac(60, 30);
    private ConsoleKeyInfo przycisk;
    char[] znakiPliku;

    private long czas;

    int czas_strzalka = 0;
    int Strzalka1X = 109;
    int Strzalka1Y = 24;
    int Strzalka2X = 109;
    int Strzalka2Y = 20;
    int Strzalka3X = 109;
    int Strzalka3Y = 16;
    int Strzalka4X = 109;
    int Strzalka4Y = 12;

    int Strzalka5X = 21;
    int Strzalka5Y = 22;
    int Strzalka6X = 21;
    int Strzalka6Y = 18;
    int Strzalka7X = 21;
    int Strzalka7Y = 14;
    int Strzalka8X = 21;
    int Strzalka8Y = 26;

    private Stopwatch stoper = new Stopwatch();

    public Poziom2(long czas)
    {
        Console.Clear();

        stoper.Start();

        this.czas = czas;

        string sciezkaDoPliku = "C:/Users/ostat/Desktop/KCKPoziom2.txt";

        string zawartoscPliku = File.ReadAllText(sciezkaDoPliku);

        znakiPliku = zawartoscPliku.ToCharArray();

        int pom = 0; //zmienna która liczy ilość wgranych znaków z plików

        foreach (char c in znakiPliku)
        {
            pom++;
            if ((pom >= 175 && pom <= 200) || (pom >= 285 && pom <= 302))
            {
                Console.ForegroundColor = ConsoleColor.Green; //Brama do drugiego poziomu jst koloru zielonego
            }
            Console.Write(c);
            Console.ResetColor();
        }

        Rysuj();

    }

    public void Rysuj()
    {
        Console.WriteLine("\n");
        Console.WriteLine("   ___          _              ___ ");
        Console.WriteLine("  / _ \\___ ___ (____  __ _    |_  |");
        Console.WriteLine(" / ___/ _ /_ // / _ \\/  ' \\  / __/ ");
        Console.WriteLine("/_/   \\___/__/_/\\___/_/_/_/ /____/ ");

        Console.SetCursorPosition(40, 1);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("UWAŻAJ NA CZERWONE STRZAŁKI! NIE DAJ SIĘ USTRZELIĆ!");
        Console.ResetColor();

        //Ustaw pozycję postaci i narysują postać
        Console.SetCursorPosition(postac.GetX(), postac.GetY());
        Console.Write("██");
        Console.SetCursorPosition(0, 10);

        for (; ; )
        {
            Thread.Sleep(1);
            czas_strzalka++;
            if (czas_strzalka >= 10000) { czas_strzalka = 0; }

            if (czas_strzalka % 1 == 0)
            {
                Console.SetCursorPosition(Strzalka1X + 1, Strzalka1Y);
                Console.Write(" ");

                Strzalka1X--;

                if (Strzalka1X == 20)
                {
                    Console.SetCursorPosition(Strzalka1X + 1, Strzalka1Y);
                    Console.Write(" ");
                    Strzalka1X = 109;
                }

                Console.SetCursorPosition(Strzalka1X, Strzalka1Y); //Ustaw pozycję kursora na nową pozycję strzałki
                Console.ForegroundColor = ConsoleColor.Red; //Ustaw kolor czerowny
                Console.Write("<-"); //Narysuj strzłkę
                Console.ResetColor(); //Zresetuj ustawiony wcześniej kolor
                Console.SetCursorPosition(0, 0);

            }
            if (czas_strzalka % 2 == 0)
            {
                Console.SetCursorPosition(Strzalka2X + 1, Strzalka2Y);
                Console.Write(" ");

                Strzalka2X--;

                if (Strzalka2X == 20)
                {
                    Console.SetCursorPosition(Strzalka2X + 1, Strzalka2Y);
                    Console.Write(" ");
                    Strzalka2X = 109;
                }

                Console.SetCursorPosition(Strzalka2X, Strzalka2Y); //Ustaw pozycję kursora na nową pozycję strzałki
                Console.ForegroundColor = ConsoleColor.Red; //Ustaw kolor czerowny
                Console.Write("<-"); //Narysuj strzłkę
                Console.ResetColor(); //Zresetuj ustawiony wcześniej kolor
                Console.SetCursorPosition(0, 0);
            }
            if (czas_strzalka % 3 == 0)
            {
                Console.SetCursorPosition(Strzalka3X + 1, Strzalka3Y);
                Console.Write(" ");

                Strzalka3X--;

                if (Strzalka3X == 20)
                {
                    Console.SetCursorPosition(Strzalka3X + 1, Strzalka3Y);
                    Console.Write(" ");
                    Strzalka3X = 109;
                }

                Console.SetCursorPosition(Strzalka3X, Strzalka3Y); //Ustaw pozycję kursora na nową pozycję strzałki
                Console.ForegroundColor = ConsoleColor.Red; //Ustaw kolor czerowny
                Console.Write("<-"); //Narysuj strzłkę
                Console.ResetColor(); //Zresetuj ustawiony wcześniej kolor
                Console.SetCursorPosition(0, 0);
            }
            if (czas_strzalka % 5 == 0)
            {
                Console.SetCursorPosition(Strzalka4X + 1, Strzalka4Y);
                Console.Write(" ");

                Strzalka4X--;

                if (Strzalka4X == 20)
                {
                    Console.SetCursorPosition(Strzalka4X + 1, Strzalka4Y);
                    Console.Write(" ");
                    Strzalka4X = 109;
                }

                Console.SetCursorPosition(Strzalka4X, Strzalka4Y); //Ustaw pozycję kursora na nową pozycję strzałki
                Console.ForegroundColor = ConsoleColor.Red; //Ustaw kolor czerowny
                Console.Write("<-"); //Narysuj strzłkę
                Console.ResetColor(); //Zresetuj ustawiony wcześniej kolor
                Console.SetCursorPosition(0, 0);
            }

            if (czas_strzalka % 4 == 0)
            {
                Console.SetCursorPosition(Strzalka5X - 1, Strzalka5Y);
                Console.Write(" ");

                Strzalka5X++;

                if (Strzalka5X == 109)
                {
                    Console.SetCursorPosition(Strzalka5X - 1, Strzalka5Y);
                    Console.Write("  ");
                    Strzalka5X = 21;
                }

                Console.SetCursorPosition(Strzalka5X, Strzalka5Y); //Ustaw pozycję kursora na nową pozycję strzałki
                Console.ForegroundColor = ConsoleColor.Red; //Ustaw kolor czerowny
                Console.Write("->"); //Narysuj strzłkę
                Console.ResetColor(); //Zresetuj ustawiony wcześniej kolor
                Console.SetCursorPosition(0, 0);
            }
            if (czas_strzalka % 2 == 0)
            {
                Console.SetCursorPosition(Strzalka6X - 1, Strzalka6Y);
                Console.Write(" ");

                Strzalka6X++;

                if (Strzalka6X == 109)
                {
                    Console.SetCursorPosition(Strzalka6X - 1, Strzalka6Y);
                    Console.Write("  ");
                    Strzalka6X = 21;
                }

                Console.SetCursorPosition(Strzalka6X, Strzalka6Y); //Ustaw pozycję kursora na nową pozycję strzałki
                Console.ForegroundColor = ConsoleColor.Red; //Ustaw kolor czerowny
                Console.Write("->"); //Narysuj strzłkę
                Console.ResetColor(); //Zresetuj ustawiony wcześniej kolor
                Console.SetCursorPosition(0, 0);
            }
            if (czas_strzalka % 3 == 0)
            {
                Console.SetCursorPosition(Strzalka7X - 1, Strzalka7Y);
                Console.Write(" ");

                Strzalka7X++;

                if (Strzalka7X == 109)
                {
                    Console.SetCursorPosition(Strzalka7X - 1, Strzalka7Y);
                    Console.Write("  ");
                    Strzalka7X = 21;
                }

                Console.SetCursorPosition(Strzalka7X, Strzalka7Y); //Ustaw pozycję kursora na nową pozycję strzałki
                Console.ForegroundColor = ConsoleColor.Red; //Ustaw kolor czerowny
                Console.Write("->"); //Narysuj strzłkę
                Console.ResetColor(); //Zresetuj ustawiony wcześniej kolor
                Console.SetCursorPosition(0, 0);
            }
            if (czas_strzalka % 5 == 0)
            {
                Console.SetCursorPosition(Strzalka8X - 1, Strzalka8Y);
                Console.Write(" ");

                Strzalka8X++;

                if (Strzalka8X == 109)
                {
                    Console.SetCursorPosition(Strzalka8X - 1, Strzalka8Y);
                    Console.Write("  ");
                    Strzalka8X = 21;
                }

                Console.SetCursorPosition(Strzalka8X, Strzalka8Y); //Ustaw pozycję kursora na nową pozycję strzałki
                Console.ForegroundColor = ConsoleColor.Red; //Ustaw kolor czerowny
                Console.Write("->"); //Narysuj strzłkę
                Console.ResetColor(); //Zresetuj ustawiony wcześniej kolor
                Console.SetCursorPosition(0, 0);
            }

            if (Console.KeyAvailable) //Sprawdza czy jest wciśnięty przycisk
            {
                przycisk = Console.ReadKey(true); //Przypisanie przycisku który klikneło się na klawiaturze

                Console.SetCursorPosition(postac.GetX(), postac.GetY());
                Console.Write("  ");

                if (przycisk.Key == ConsoleKey.UpArrow || przycisk.Key == ConsoleKey.W) //Jeżeli naciśnięta strzałka w górę lub "w"
                {
                    if (postac.GetY() >= 4) //Górna granica mapy
                    {
                        postac = new Postac(postac.GetX(), postac.GetY() - 1); //Przzesuń postać w górę
                    }
                }
                if (przycisk.Key == ConsoleKey.DownArrow || przycisk.Key == ConsoleKey.S) //Jeżeli naciśnięta strzałka w dół lub "s"
                {
                    if (postac.GetY() <= 31) //Dolna granica mapy
                    {
                        postac = new Postac(postac.GetX(), postac.GetY() + 1); //Przesuń postać w dół
                    }
                }
                if (przycisk.Key == ConsoleKey.LeftArrow || przycisk.Key == ConsoleKey.A) //Jeżeli naciśnięta strzałka w lewo lub "a"
                {
                    if (postac.GetX() >= 21) //Lewa granica mapy
                    {
                        postac = new Postac(postac.GetX() - 1, postac.GetY()); //Przesuń postać w lewo
                    }
                }
                if (przycisk.Key == ConsoleKey.RightArrow || przycisk.Key == ConsoleKey.D) //Jeżeli naciśnięta strzałka w prawo lub "d"
                {
                    if (postac.GetX() <= 109) //Prawa granica mapy
                    {
                        postac = new Postac(postac.GetX() + 1, postac.GetY()); //Przesuń postać w prawo
                    }
                }

            }
            //Ustaw pozycję postaci i narysują postać
            Console.SetCursorPosition(postac.GetX(), postac.GetY());
            Console.Write("██");
            Console.SetCursorPosition(0, 10);

            //Jeżeli postać jest na kordynatach bramy do poziomu numer 2
            if (postac.GetX() >= 64 && postac.GetX() <= 66 && postac.GetY() >= 3 && postac.GetY() <= 4)
            {
                this.czas += stoper.ElapsedMilliseconds;
                stoper.Stop();
                Poziom3 poziom3 = new Poziom3(czas); //Przenieś do poziomu trzeciego
            }

            //Jeżeli postać znajdzie się na terytorium Strzałka to zakończ grę
            if (CzyTrafiony())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(54, 15);
                Console.WriteLine("Zostałeś trafiony"); //Komunikat o śmierci gracza
                Console.SetCursorPosition(50, 16);
                Console.WriteLine("*Wcisnij ESC aby kontynuować*");

                this.czas += stoper.ElapsedMilliseconds;
                stoper.Stop();

                int liczCzas = 0; //zmienna pomocnicza, do migania wiadomości

                for (; ; )
                {
                    liczCzas++;
                    if (liczCzas % 13000 == 0)
                    {
                        Console.SetCursorPosition(50, 16);
                        Console.WriteLine("                             ");
                    }
                    if (liczCzas % 15000 == 0)
                    {
                        Console.SetCursorPosition(50, 16);
                        Console.WriteLine("*Wcisnij ESC aby kontynuować*");
                        liczCzas = 0;
                    }

                    if (Console.KeyAvailable)
                    {
                        przycisk = Console.ReadKey(true);

                        if (przycisk.Key == ConsoleKey.Escape)
                        {
                            Console.ResetColor();
                            Poziom2 poziom = new Poziom2(czas);
                        }
                    }
                }

            }
        }
    }

    public bool CzyTrafiony()
    {
        if ((Strzalka1X == postac.GetX() && Strzalka1Y == postac.GetY()) || ((Strzalka2X == postac.GetX() && Strzalka2Y == postac.GetY())) || (Strzalka3X == postac.GetX() && Strzalka3Y == postac.GetY()) || (Strzalka4X == postac.GetX() && Strzalka4Y == postac.GetY()) || (Strzalka5X + 1 == postac.GetX() && Strzalka5Y == postac.GetY()) || ((Strzalka6X + 1 == postac.GetX() && Strzalka6Y == postac.GetY())) || (Strzalka7X + 1 == postac.GetX() && Strzalka7Y == postac.GetY()) || (Strzalka8X + 1 == postac.GetX() && Strzalka8Y == postac.GetY()))
        {
            return true;
        }
        return false;
    }
}


