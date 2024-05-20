int lunghezza = 0;
bool check = false;
Console.WriteLine("Inserisci il valore di lunghezza");
while (check == false)
{
    check = int.TryParse(Console.ReadLine(), out lunghezza);
    if (check == false)
        Console.WriteLine("valore non valido");
}
for(int i=0;i<lunghezza;i++)
{
    for (int j=0; j < i+1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("\t");
}