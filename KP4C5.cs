static int fibo(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return fibo(n - 2) + fibo(n - 1);
    }
}
int k;
Console.WriteLine("Ktory wyraz wypisac? ");
k = int.Parse(Console.ReadLine());
Console.WriteLine(fibo(k));
Console.ReadKey();