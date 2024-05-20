using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Inserisci il nome del giocatore A: ");
        string gAname = Console.ReadLine();
        Console.Write("\nInserisci il punteggio del giocatore A: ");
        int gAscore=0;
        string score = Console.ReadLine();
        bool check = false;
        while (check == false)
        {
            check = int.TryParse(score, out gAscore);
            if (!check)
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.Write("\n\nIl punteggio deve essere un numero intero. Inserisci un numero intero: "); Console.ResetColor();
                score = Console.ReadLine();
            }
        }
        Console.Write("\n\nInserisci il nome del giocatore B: ");
        string gBname = Console.ReadLine();
        Console.Write("\nInserisci il punteggio del giocatore B: ");
        score = Console.ReadLine();
        int gBscore = 0;
        check = false;
        while (check == false)
        {
            check = int.TryParse(score, out gBscore);
            if (!check)
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.Write("\nIl punteggio deve essere un numero intero. Inserisci un numero intero: "); Console.ResetColor();
                score = Console.ReadLine();
            }
        }
        Giocatore A = new Giocatore(gAname, gAscore);
        Giocatore B = new Giocatore(gBname, gBscore);
        CompareScores(A, B);
        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\n\nPremi un tasto qualsiasi per terminare il programma"); Console.ResetColor();
        Console.ReadLine();
    }
    public class Giocatore
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Giocatore(string x, int y)
        {
            Name = x;
            Score = y;
        }
    }
    public static void CompareScores(Giocatore a, Giocatore b)
    {
        Console.Write($"\n\nLa differenza di punteggio tra {a.Name} e {b.Name} è {Math.Abs(a.Score - b.Score)}\nValutazione della partita: ");
        if (Math.Abs(a.Score - b.Score) < 10)
            Console.Write("Partita equilibrata");
        else if (Math.Abs(a.Score -b.Score) <= 20)
            Console.Write("Partita interessante");
        else
            Console.Write("Partita intensa");
    }
}

