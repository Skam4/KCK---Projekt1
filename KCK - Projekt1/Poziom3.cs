﻿using KCK___Projekt1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.IO;


internal class Poziom3
{

    Postac postac = new Postac(60, 30);
    private ConsoleKeyInfo przycisk;
    char[] znakiPliku;

    int czasownik = 0;  

    private int EnemyX1 = 40;
    private int EnemyY1 = 7;

    private int EnemyX2 = 90;
    private int EnemyY2 = 7;

    private int EnemyX3 = 25;
    private int EnemyY3 = 9;

    private int EnemyX4 = 60;
    private int EnemyY4 = 9;

    public Poziom3()
    {
        Console.Clear();

        string sciezkaDoPliku = "C:/Users/ostat/Desktop/KCKPoziom3.txt";

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
        Console.WriteLine("   ___          _              ____");
        Console.WriteLine("  / _ \\___ ___ (____  __ _    |_  /");
        Console.WriteLine(" / ___/ _ /_ // / _ \\/  ' \\  _/_ < ");
        Console.WriteLine("/_/   \\___/__/_/\\___/_/_/_/ /____/ ");
        Console.WriteLine("                                   ");

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

        for (; ; )
        {
            Thread.Sleep(1);

            czasownik++;
            if(czasownik >= 10000) { czasownik = 0; }

            //Przeciwnik pierwszy:
            if(czasownik % 30 == 0)
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
            if (czasownik % 40 == 0)
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
            if (czasownik % 35 == 0)
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
            if (czasownik % 45 == 0)
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
                Poziom4 poziom4 = new Poziom4(); //Przenieś do poziomu trzeciego
            }

            if (CzyTrafiony())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(40, 15);
                Console.WriteLine("Dopadł cie"); //Komunikat o śmierci gracza
                Console.SetCursorPosition(40, 16);
                Console.WriteLine("*Wciśnij ESC aby wrócić do menu*");
                Console.ResetColor();
                for (; ; )
                {
                    if (Console.KeyAvailable)
                    {
                        przycisk = Console.ReadKey(true);

                        if (przycisk.Key == ConsoleKey.Escape)
                        {
                            Menu menu = new Menu();
                        }
                    }
                }

            }
        }
    }

    public bool CzyTrafiony()
    {
        if ((EnemyX1 == postac.GetX() && EnemyY1 == postac.GetY()) || (EnemyX2 == postac.GetX() && EnemyY2 == postac.GetY()) || (EnemyX3 == postac.GetX() && EnemyY3 == postac.GetY()) || (EnemyX4 == postac.GetX() && EnemyY4 == postac.GetY()))
        {
            return true;
        }
        return false;
    }
}


