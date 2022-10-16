int potega(int a, int b)
{
    if (b == 1)
        return a;
    int c = potega(a,b - 1);
        return a * c;
}
int a, b;
Console.WriteLine("podaj liczbę która chcesz podnieś do potęgi:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj potęgę:");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Oto twój wynik");
Console.WriteLine(potega(a, b));