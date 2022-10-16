void bin(int liczba)
{
    if (liczba > 0)
    {
        bin(liczba / 2);
        Console.Write(liczba % 2);
    }
}
{
    int liczba;

    Console.WriteLine("Podaj liczbę:");
    liczba = int.Parse(Console.ReadLine());
    Console.WriteLine("Postać binarna liczby " + liczba + " to:");
    bin(liczba);
}