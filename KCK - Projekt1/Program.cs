using System;
using System.Text;
using System.IO;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.SetWindowSize(125, 45); // Ustaw rozmiar konsoli na 120 kolumn x 45 wierszy
        Console.SetBufferSize(125, 45); // Ustaw rozmiar bufora konsoli

        Menu class1 = new Menu();

    }
}
