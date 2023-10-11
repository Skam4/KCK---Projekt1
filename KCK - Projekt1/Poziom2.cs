﻿using KCK___Projekt1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.IO;


internal class Poziom2
{

    Postac postac = new Postac(60, 30);
    private ConsoleKeyInfo przycisk;
    char[] znakiPliku;
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

    public Poziom2()
    {
        Console.Clear();

        Console.WriteLine("\n");
        Console.WriteLine("\n");

        string sciezkaDoPliku = "C:/Users/ostat/Desktop/KCKPoziom2.txt";

        string zawartoscPliku = File.ReadAllText(sciezkaDoPliku);

        znakiPliku = zawartoscPliku.ToCharArray();

        foreach (char c in znakiPliku)
        {
            Console.Write(c);
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
            Console.WriteLine("                                   ");

        //Ustaw pozycję postaci i narysują postać
        Console.SetCursorPosition(postac.GetX(), postac.GetY());
            Console.Write("██");
            Console.SetCursorPosition(0, 0);

            for (; ; )
            {
                Thread.Sleep(1);
                czas_strzalka++;
                if(czas_strzalka >= 10000) { czas_strzalka = 0; }

                if (czas_strzalka % 1 == 0)
                {
                    Console.SetCursorPosition(Strzalka1X + 1, Strzalka1Y);
                    Console.Write(" ");

                    Strzalka1X--;

                    if (Strzalka1X == 20)
                    {
                        Console.SetCursorPosition(Strzalka1X+1, Strzalka1Y);
                        Console.Write(" ");
                        Strzalka1X = 109;
                    }

                    Console.SetCursorPosition(Strzalka1X, Strzalka1Y); //Ustaw pozycję kursora na nową pozycję strzałki
                    Console.ForegroundColor = ConsoleColor.Red; //Ustaw kolor czerowny
                    Console.Write("<-"); //Narysuj strzłkę
                    Console.ResetColor(); //Zresetuj ustawiony wcześniej kolor
                    
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

            }

            if (Console.KeyAvailable) //Sprawdza czy jest wciśnięty przycisk
                {
                    przycisk = Console.ReadKey(true); //Przypisanie przycisku który klikneło się na klawiaturze

                    Console.SetCursorPosition(postac.GetX(), postac.GetY());
                    Console.Write("  ");

                    if (przycisk.Key == ConsoleKey.UpArrow || przycisk.Key == ConsoleKey.W) //Jeżeli naciśnięta strzałka w górę lub "w"
                    {
                        if (postac.GetY() >= 6) //Górna granica mapy
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
            if (postac.GetX() >= 64 && postac.GetX() <= 66 && postac.GetY() >= 5 && postac.GetY() <= 6)
                {
                    Poziom3 poziom3 = new Poziom3(); //Przenieś do poziomu trzeciego
                }

            //Jeżeli postać znajdzie się na terytorium Strzałka1 to zakończ grę
            if (CzyTrafiony())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(40, 15);
                Console.WriteLine("Dedles"); //Komunikat o śmierci gracza
                Console.SetCursorPosition(40, 16);
                Console.WriteLine("*Wcisnij ESC aby wrocic do menu*");
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
        if ((Strzalka1X == postac.GetX() && Strzalka1Y == postac.GetY()) || ((Strzalka2X == postac.GetX() && Strzalka2Y == postac.GetY())) || (Strzalka3X == postac.GetX() && Strzalka3Y == postac.GetY()) || (Strzalka4X == postac.GetX() && Strzalka4Y == postac.GetY()) || (Strzalka5X+1 == postac.GetX() && Strzalka5Y == postac.GetY()) || ((Strzalka6X+1 == postac.GetX() && Strzalka6Y == postac.GetY())) || (Strzalka7X+1 == postac.GetX() && Strzalka7Y == postac.GetY()) || (Strzalka8X+1 == postac.GetX() && Strzalka8Y == postac.GetY()))
        {
            return true;
        }
        return false;
    }
}

