string password = "Password2023";
Console.WriteLine("Inserisci la password");

for (string trys = "segnaposto"; trys != password;)
{
    trys = Console.ReadLine();
    if (trys != password)
        Console.WriteLine("Mi dispiace, la password è sbagliata! Riprova...");
}
Console.WriteLine("Complimenti! La password è corretta");
