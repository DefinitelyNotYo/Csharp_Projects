class Program
{
    static void Main()
    {
        // Esegui e stampa i risultati delle funzioni
        int numero = 5;

        Console.WriteLine($"Il doppio di {numero} è: {CalcolaDoppio(numero)}");

        int prodotto = CalcolaProdotto(3, 7);
        Console.WriteLine($"Il prodotto di 3 e 7 è: {prodotto}");

        int[] vettore = { 2, 4, 6, 8 };
        Console.WriteLine($"La somma degli elementi nel vettore è: {SommaElementiVettore(vettore)}");

        int maggiore = TrovaMassimo(15, 8);
        Console.WriteLine($"Il numero maggiore tra 15 e 8 è: {maggiore}");

        bool presente = VerificaPresenza(vettore, 6);
        Console.WriteLine($"Il numero 6 è presente nel vettore: {presente}");
    }

    static int CalcolaDoppio(int x)
    {
        return x * 2;
    }
    static int CalcolaProdotto(int x, int y)
    {
        return x * y;
    }
    static int SommaElementiVettore(int[] v)
    {
        int somma = 0;
        for (int i = 0; i < v.Length; i++)
            somma = somma + v[i];
        return somma;
    }
    static int TrovaMassimo(int x, int y)
    {
        if (x >= y)
            return x;
        else
            return y;
    }
    static bool VerificaPresenza(int[] v, int x)
    {
        bool trovato = false;
        for(int i = 0; i < v.Length; i++)
        {
            if (v[i] == x)
                trovato = true;
        }
        return trovato;

    }
}