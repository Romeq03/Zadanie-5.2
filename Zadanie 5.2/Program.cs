using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszy łańcuch tekstowy: ");
        string pierwszyLancuch = Console.ReadLine();

        Console.Write("Podaj drugi łańcuch tekstowy: ");
        string drugiLancuch = Console.ReadLine();

        string wynik = pierwszyLancuch + drugiLancuch;

        Console.WriteLine($"Wynik konkatenacji: {wynik}");

        Console.ReadLine();
    }
}
