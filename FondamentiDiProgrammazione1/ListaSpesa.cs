internal class Program
{
    private static void Main(string[] args)
    {
        string a;
        float b;
        Articolo[] shoppingList = new Articolo[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Inserisci un elemento nella lista della spesa: ");
            a = Console.ReadLine();
            shoppingList[i] = new Articolo(a);
        }
        Console.WriteLine();
        ShowList(shoppingList);
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            bool check = false;
            float price = 0;
            string test;
            Console.Write("Inserisci il prezzo di ciascun elemento nella lista della spesa: ");
            while(check == false || price < 0)
            {
                test = Console.ReadLine();
                check = float.TryParse(test, out price);
                if (check == false || price < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Inserisci un numero valido"); Console.ResetColor();
                }
            }
            shoppingList[i].Price = price;
        }
        TotalCount(shoppingList);
        FindItem(shoppingList);
    }
    public class Articolo
    {
        public string Name {  get; set; }
        public float Price { get; set; }
        public Articolo(string x, float y)
        {
            Name = x;
            Price = y;
        }
        public Articolo(string x)
        {
            Name = x;
        }
        public Articolo(float y)
        {
            Price = y;
        }
    }
    public static void ShowList(Articolo[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine($"{i} - {list[i].Name}");
        }
    }
    public static void TotalCount(Articolo[] list)
    {
        float sum = 0;
        for (int i = 0; i < list.Length; i++)
        {
            sum = sum + list[i].Price;
        }
        Console.WriteLine($"\nIl totale della spesa è {sum}$\n\n");
    }
    public static void FindItem(Articolo[] list) 
    {
        bool found = false;
        string item = "-";
        while (found == false)
        {
            Console.Write("Cerca un elemento nella lista\n");
            item = Console.ReadLine();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Name == item)
                {
                    Console.WriteLine($"\n{item} è presente nella tua lista al costo di {list[i].Price}$");
                    found = true;
                    break;
                }
            }
            if(found == false)
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.Write("\nElemento non presente. Inserisci un articolo valido per visualizzarne il prezzo\n\n"); Console.ResetColor();
            }

        }
    }
}