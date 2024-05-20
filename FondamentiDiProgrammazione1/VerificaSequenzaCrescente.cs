bool check = false;
int n = 0;
Console.Write("Quanto è lungo il vettore?\n");
while (check == false)
{
    check = int.TryParse(Console.ReadLine(), out n);
    if (check == false)
        Console.WriteLine("valore non valido");
}
check = false;
int[] v = new int[n];
Console.WriteLine($"Inserisci {n} numeri interi");
for (int i = 0; i < n; i++)
{
    while (check == false)
    {
        check = int.TryParse(Console.ReadLine(), out v[i]);
        if (check == false)
            Console.WriteLine("valore non valido");
    }
    check = false;
}
if (findIncreasingSubsequence(v) == true)
    Console.WriteLine("La sequenza è strettamente ordinata");
else
    Console.WriteLine("La sequenza non è ordinata");

bool findIncreasingSubsequence(int []a)
{
    bool interruttore = true;
    for (int i = 0; i < n-1; i++)
    {
        if (a[i] > a[i+1])
            interruttore = false;
    }
    return interruttore;
}

