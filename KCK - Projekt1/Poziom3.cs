using KCK___Projekt1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


internal class Poziom3
{

    Postac postac = new Postac(60, 30);
    private ConsoleKeyInfo przycisk;
    char[] znakiPliku;

    private long czas;

    int czasownik = 0;  

    private int EnemyX1 = 40;
    private int EnemyY1 = 7;

    private int EnemyX2 = 90;
    private int EnemyY2 = 7;

    private int EnemyX3 = 25;
    private int EnemyY3 = 9;

    private int EnemyX4 = 60;
    private int EnemyY4 = 9;

    private int EnemyX5 = 75;
    private int EnemyY5 = 8;

    private Stopwatch stoper = new Stopwatch();

    public Poziom3(long czas)
    {
        Console.Clear();

        this.czas = czas;

        stoper.Start();

        string sciezkaDoPliku = "KCKPoziom3.txt";

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
        this.czas = czas;
    }

    public void Rysuj()
    {

        Console.WriteLine("\n");
        Console.WriteLine("   ___          _              ____");
        Console.WriteLine("  / _ \\___ ___ (____  __ _    |_  /");
        Console.WriteLine(" / ___/ _ /_ // / _ \\/  ' \\  _/_ < ");
        Console.WriteLine("/_/   \\___/__/_/\\___/_/_/_/ /____/ ");
        Console.WriteLine("                                   ");

        Console.SetCursorPosition(35, 1);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("NIE DAJ SIĘ ZŁAPAĆ CZERWONYM PRZECIWNIKOM! UWAGA! ONI CIĘ GONIĄ!");
        Console.ResetColor();

        //Ustaw pozycję postaci i narysują postać
        Console.SetCursorPosition(postac.GetX(), postac.GetY());
        Console.Write("██");
        Console.SetCursorPosition(0, 0);

        //Ustaw pozycję pierwszego przeciwnika i narysują postać
        Console.SetCursorPosition(EnemyX1, EnemyY1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("██");
        Console.ResetColor();
        Console.SetCursorPosition(0, 0);

        //Ustaw pozycję drugiego przeciwnika i narysują postać
        Console.SetCursorPosition(EnemyX2, EnemyY2);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("██");
        Console.ResetColor();
        Console.SetCursorPosition(0, 0);

        //Ustaw pozycję trzeciego przeciwnika i narysują postać
        Console.SetCursorPosition(EnemyX3, EnemyY3);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("██");
        Console.ResetColor();
        Console.SetCursorPosition(0, 0);

        //Ustaw pozycję czwartego przeciwnika i narysują postać
        Console.SetCursorPosition(EnemyX4, EnemyY4);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("██");
        Console.ResetColor();
        Console.SetCursorPosition(0, 0);

        //Ustaw pozycję piątego przeciwnika i narysują postać
        Console.SetCursorPosition(EnemyX5, EnemyY5);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("██");
        Console.ResetColor();
        Console.SetCursorPosition(0, 0);

        for (; ; )
        {
            Thread.Sleep(1);

            czasownik++;
            if(czasownik >= 10000) { czasownik = 0; }

            //Przeciwnik pierwszy:
            if(czasownik % 10 == 0)
            {
                Console.SetCursorPosition(EnemyX1, EnemyY1);
                Console.Write("  ");

                if (postac.GetX() > EnemyX1)
                    EnemyX1++;
                if (postac.GetX() < EnemyX1)
                    EnemyX1--;
                if(postac.GetY() > EnemyY1)
                    EnemyY1++;
                if(postac.GetY()  < EnemyY1)
                    EnemyY1--;

                Console.SetCursorPosition(EnemyX1, EnemyY1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("██");
                Console.ResetColor();
                Console.SetCursorPosition(0, 0);
            }

            //Przeciwnik drugi:
            if (czasownik % 15 == 0)
            {
                Console.SetCursorPosition(EnemyX2, EnemyY2);
                Console.Write("  ");

                if (postac.GetX() > EnemyX2)
                    EnemyX2++;
                if (postac.GetX() < EnemyX2)
                    EnemyX2--;
                if (postac.GetY() > EnemyY2)
                    EnemyY2++;
                if (postac.GetY() < EnemyY2)
                    EnemyY2--;

                Console.SetCursorPosition(EnemyX2, EnemyY2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("██");
                Console.ResetColor();
                Console.SetCursorPosition(0, 0);
            }

            //Przeciwnik trzeci:
            if (czasownik % 25 == 0)
            {
                Console.SetCursorPosition(EnemyX3, EnemyY3);
                Console.Write("  ");

                if (postac.GetX() > EnemyX3)
                    EnemyX3++;
                if (postac.GetX() < EnemyX3)
                    EnemyX3--;
                if (postac.GetY() > EnemyY3)
                    EnemyY3++;
                if (postac.GetY() < EnemyY3)
                    EnemyY3--;

                Console.SetCursorPosition(EnemyX3, EnemyY3);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("██");
                Console.ResetColor();
                Console.SetCursorPosition(0, 0);
            }

            //Przeciwnik czwarty:
            if (czasownik % 20 == 0)
            {
                Console.SetCursorPosition(EnemyX4, EnemyY4);
                Console.Write("  ");

                if (postac.GetX() > EnemyX4)
                    EnemyX4++;
                if (postac.GetX() < EnemyX4)
                    EnemyX4--;
                if (postac.GetY() > EnemyY4)
                    EnemyY4++;
                if (postac.GetY() < EnemyY4)
                    EnemyY4--;

                Console.SetCursorPosition(EnemyX4, EnemyY4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("██");
                Console.ResetColor();
                Console.SetCursorPosition(0, 0);
            }

            //Przeciwnik czwarty:
            if (czasownik % 25 == 0)
            {
                Console.SetCursorPosition(EnemyX5, EnemyY5);
                Console.Write("  ");

                if (postac.GetX() > EnemyX5)
                    EnemyX5++;
                if (postac.GetX() < EnemyX5)
                    EnemyX5--;
                if (postac.GetY() > EnemyY5)
                    EnemyY5++;
                if (postac.GetY() < EnemyY5)
                    EnemyY5--;

                Console.SetCursorPosition(EnemyX5, EnemyY5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("██");
                Console.ResetColor();
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
            Console.SetCursorPosition(0, 0);

            //Jeżeli postać jest na kordynatach bramy do poziomu numer 2
            if (postac.GetX() >= 64 && postac.GetX() <= 66 && postac.GetY() >= 3 && postac.GetY() <= 4)
            {
                this.czas += stoper.ElapsedMilliseconds;
                stoper.Stop();
                Wyniki wynik = new Wyniki(czas); //Przenieś do Wyników
            }

            if (CzyTrafiony())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(54, 15);
                Console.WriteLine("Dopadł cie"); //Komunikat o śmierci gracza
                Console.SetCursorPosition(50, 16);

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
                            Poziom3 poziom = new Poziom3(czas);
                        }
                    }
                }

            }
        }
    }

    public bool CzyTrafiony()
    {
        if ((EnemyX1 == postac.GetX() && EnemyY1 == postac.GetY()) || (EnemyX2 == postac.GetX() && EnemyY2 == postac.GetY()) || (EnemyX3 == postac.GetX() && EnemyY3 == postac.GetY()) || (EnemyX4 == postac.GetX() && EnemyY4 == postac.GetY()) || (EnemyX5 == postac.GetX() && EnemyY5 == postac.GetY()))
        {
            return true;
        }
        if ((EnemyX1+1 == postac.GetX() && EnemyY1 == postac.GetY()) || (EnemyX2+1 == postac.GetX() && EnemyY2 == postac.GetY()) || (EnemyX3+1 == postac.GetX() && EnemyY3 == postac.GetY()) || (EnemyX4+1 == postac.GetX() && EnemyY4 == postac.GetY()) || (EnemyX5+1 == postac.GetX() && EnemyY5 == postac.GetY()))
        {
            return true;
        }
        return false;
    }
}


