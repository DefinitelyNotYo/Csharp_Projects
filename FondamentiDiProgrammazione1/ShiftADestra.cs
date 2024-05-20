using System.Linq.Expressions;
Console.Write("Inserisci la lunghezza della sequenza (N): ");
int n = 0;
bool check = false;
while(check == false)     //controllo che il numero passato per indicare la sequenza sia intero
{
    check = int.TryParse(Console.ReadLine(), out n);
    if (check == false)
        Console.WriteLine("Il valore non è valido");
}
check = false;
int[] v = new int[n];
for (int i = 0; i < v.Length; i++)    //inserimento di valori interi nell'array
{
    while (check == false)
    {
        Console.Write($"Inserisci il numero {i+1}: ");
        check = int.TryParse(Console.ReadLine(), out v[i]);
        if (check == false)
            Console.WriteLine("Il valore non è valido");
        
    }
    check = false;
}
Console.WriteLine();
Console.Write("Vettore originale: [");
for (int i = 0; i < v.Length - 1; i++)
    Console.Write($"{v[i]}, ");
Console.Write($"{v[v.Length - 1]}]");
int[] w = new int[v.Length];
for (int i = 0; i < 1; i++)   //inserimento dei nuovi primi elementi | ES. passo: 2, sequenza: 1'23' -> '23'1
    w[i] = v[v.Length - i - 1];
for (int i = 1; i < w.Length; i++)     //inserimento degli elementi restanti | ES. passo: 2, sequenza: '1'23 -> 23'1'
    w[i] = v[i - 1];
v = w;
Console.WriteLine();
Console.Write("Vettore dopo lo shift: [");
for (int i = 0; i < v.Length - 1; i++)
    Console.Write($"{v[i]}, ");
Console.Write($"{v[v.Length - 1]}]");
Console.WriteLine();



