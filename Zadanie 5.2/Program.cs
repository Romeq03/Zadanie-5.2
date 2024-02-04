using System;

class Program
{
    static void Main()
    {
        // Wprowadzenie pierwszego łańcucha tekstowego
        Console.Write("Podaj pierwszy łańcuch tekstowy: ");
        string pierwszyLancuch = Console.ReadLine();

        // Wprowadzenie drugiego łańcucha tekstowego
        Console.Write("Podaj drugi łańcuch tekstowy: ");
        string drugiLancuch = Console.ReadLine();

        // Konkatenacja łańcuchów
        string wynik = pierwszyLancuch + drugiLancuch;

        // Wyświetlenie wyniku
        Console.WriteLine($"Wynik konkatenacji: {wynik}");

        // Zatrzymanie programu do momentu naciśnięcia klawisza Enter
        Console.ReadLine();
    }
}
