using KCK___Projekt1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.IO;


internal class Poziom5
{

    Postac postac = new Postac(60, 30);
    private ConsoleKeyInfo przycisk;
    char[] znakiPliku;

    public Poziom5()
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
        Console.WriteLine("   ___          _              ____");
        Console.WriteLine("  / _ \\___ ___ (____  __ _    / __/");
        Console.WriteLine(" / ___/ _ /_ // / _ \\/  ' \\  /__ \\ ");
        Console.WriteLine("/_/   \\___/__/_/\\___/_/_/_/ /____/ ");
        Console.WriteLine("                                   ");

        //Ustaw pozycję postaci i narysują postać
        Console.SetCursorPosition(postac.GetX(), postac.GetY());
        Console.Write("██");
        Console.SetCursorPosition(0, 0);

        for (; ; )
        {
            Thread.Sleep(1);

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
        }
    }
}


