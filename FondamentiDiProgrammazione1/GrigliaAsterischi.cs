int lunghezza = 0;
int larghezza = 0;
bool check = false;
Console.WriteLine("Quante righe?");
while (check == false)
{
    check = int.TryParse(Console.ReadLine(), out lunghezza);
    if (check == false)
        Console.WriteLine("valore non valido");
}
Console.WriteLine("Quante colonne?");
check = false;
while (check == false)
{
    check = int.TryParse(Console.ReadLine(), out larghezza);
    if (check == false)
        Console.WriteLine("valore non valido");
}
for (int i = 0; i < lunghezza; i++)
{
    for (int j = 0; j < larghezza; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("\t");
}