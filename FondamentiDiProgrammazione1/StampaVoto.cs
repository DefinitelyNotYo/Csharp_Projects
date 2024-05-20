int voto = -1;
bool check = false;
Console.WriteLine("Inserisci un voto da 0 a 100");
while (check == false || voto < 0 || voto > 100)
{
    check = int.TryParse(Console.ReadLine(), out voto); 
    /*la funzione int.TryParse prende 2 parametri: il primo contiene il valore su cui la funzione tenterà
    di effettuare la conversione, mentre il secondo è la variabile in cui verrà inserito il risultato della
    conversione (in caso di esito positivo). NB: La funzione restituisce un valore bool che è vero nel caso in
    cui la conversione sia avvenuta con successo e falso se invece non c'è riuscito.
    Questo serve per effettuare un controllo sul tipo di dato, in questo caso per essere sicuro che di fatto
    sia stato inserito un valore di tipo intero.*/
    if (check == false || voto < 0 || voto > 100)
    {
        Console.WriteLine("Valore non valido");
        continue;
    }
    else if (voto < 50) // voto inferiore a 50
    {
        Console.WriteLine("Insufficiente");
        break;
    }
    else if (voto < 70) //voto compreso fra 50 a 69
    {
        Console.WriteLine("Sufficiente");
        break;
    }
    else if (voto < 90) //voto compreso fra 70 a 89
    {
        Console.WriteLine("Buono");
        break;
    }    
    else if (voto <101)
    {
        Console.WriteLine("Eccellente");
        break;
    }
}
