using System;

class Program
{
    static void Main()
    {
        Console.SetWindowSize(120, 40); // Ustaw rozmiar konsoli na 80 kolumn x 40 wierszy
        Console.SetBufferSize(120, 40); // Ustaw rozmiar bufora konsoli

        Menu class1 = new Menu();



        //Console.ReadKey();
    }
}


/*
 * for (; ; )
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

            string Numerek = Console.ReadLine();

            if(Numerek == "1")
            {
                Gra gra = new Gra();
            }

            if (Numerek == "2")
            {
                Opcje gra = new Opcje();
            }

            if (Numerek == "3")
            {
                break;
            }
            Console.Clear();

        }*/



//if ((postac.GetX() == 64 && postac.GetY() == 4) || (postac.GetX() == 65 && postac.GetY() == 4) || (postac.GetX() == 66 && postac.GetY() == 4) || (postac.GetX() == 64 && postac.GetY() == 3) || (postac.GetX() == 65 && postac.GetY() == 3) || (postac.GetX() == 66 && postac.GetY() == 3))
//{
//   Poziom2 poziom2 = new Poziom2();
//}